import ts, {
  forEachChild,
  Identifier,
  InterfaceDeclaration,
  isArrayTypeNode,
  isIdentifier,
  isInterfaceDeclaration,
  isMethodSignature,
  isPropertySignature,
  isReadonlyKeywordOrPlusOrMinusToken,
  isTypeReferenceNode,
  MethodSignature,
  Modifier,
  NodeArray,
  ParameterDeclaration,
  PropertySignature,
  SourceFile,
  StringLiteral,
  SyntaxKind,
  TypeNode,
} from 'typescript'

export const preamble = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

`

type Context = {
  sourceFile: SourceFile
}

const reservedNames: Record<string, boolean> = {
  as: true,
  base: true,
  checked: true,
  default: true,
  event: true,
  float: true,
  is: true,
  object: true,
  operator: true,
  public: true,
  switch: true,
  this: true,
}

function getTypeName(type: TypeNode, context: Context): string {
  switch (type.kind) {
    case SyntaxKind.StringKeyword:
      return 'string'
    case SyntaxKind.NumberKeyword:
      return 'double'
    case SyntaxKind.BooleanKeyword:
      return 'bool'
    case SyntaxKind.AnyKeyword:
      return 'object'
    case SyntaxKind.VoidKeyword:
      return 'void'
    case SyntaxKind.SymbolKeyword:
      return 'Symbol'
  }

  if (isTypeReferenceNode(type)) {
    return (type.typeName as Identifier).text
  }
  if (isArrayTypeNode(type)) {
    return getTypeName(type.elementType, context) + '[]'
  }

  // TODO support more specific types, start with non-union types
  // TODO Support generics
  // TODO support for Nullable, CanBeUndefined (| null, | undefined)
  return `object /* ${type.getText(context.sourceFile)} */`
}

function getSafeName(
  member: PropertySignature | MethodSignature | Identifier,
): string {
  const name = isIdentifier(member)
    ? member.text
    : (member.name as StringLiteral).text
  // TODO Improve writing of reserved member names
  return !reservedNames[name]
    ? name
    : isIdentifier(member)
      ? `${name}Parameter`
      : isPropertySignature(member)
        ? `${name}Property`
        : `${name}Method`
}

function isReadonly(modifiers: NodeArray<Modifier> | undefined): boolean {
  return modifiers?.some((m) => isReadonlyKeywordOrPlusOrMinusToken(m)) ?? false
}

function getParameterList(
  parameterDeclaration: NodeArray<ParameterDeclaration>,
  context: Context,
) {
  return parameterDeclaration
    .map(
      (para) =>
        `${getTypeName(para.type!, context)} ${getSafeName(
          para.name as Identifier,
        )}`,
    )
    .join(', ')
}

function getBaseTypes(node: InterfaceDeclaration): string {
  if (!node.heritageClauses) {
    return ''
  }

  const typeNames = node.heritageClauses[0].types.map(
    // TODO Support generics
    // TODO Call getTypeName
    (value) => (value.expression as Identifier).text,
  )
  return `: ${typeNames.join(', ')} `
}

function getMembers(node: InterfaceDeclaration, context: Context): string[] {
  return node.members.map((member) => {
    if (isPropertySignature(member)) {
      // TODO support modifier, especially readonly
      const name = getSafeName(member)
      const type = getTypeName(member.type!, context)
      const readonly = isReadonly(member.modifiers)
      const accessors = 'get;' + (!readonly ? ' set;' : '')
      return `public new ${type} ${name} { ${accessors} }`
    }
    if (isMethodSignature(member)) {
      const ms = member as MethodSignature
      const name = getSafeName(member)
      const type = getTypeName(member.type!, context)
      const parameters = getParameterList(ms.parameters, context)
      return `public new ${type} ${name}(${parameters});`
    }
    return `// TODO: Unsupported member: ${member.getText(context.sourceFile)}`
  })
}

export function getFileContent(sourceFile: SourceFile): string[] {
  const context = { sourceFile }
  const interfaces: string[] = []

  for (const match of sourceFile.text.matchAll(
    /\/\/\/\s*<reference\s+lib="(?<libName>.*)"\s*\/>/g,
  )) {
    interfaces.push(`// Referenced lib: ${match.groups!.libName}`)
  }

  forEachChild(sourceFile, (node) => {
    if (isInterfaceDeclaration(node)) {
      const name = node.name.text
      // TODO Support generics
      const baseTypes = getBaseTypes(node)
      const members = getMembers(node, context)
      const typeContent =
        members.length === 0 ? '' : `\n  ${members.join('\n  ')}\n`

      interfaces.push(
        `public partial interface ${name} ${baseTypes} {${typeContent}}`,
      )
    }
  })

  return interfaces
}
