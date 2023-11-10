import ts from 'typescript'

const disableWarnings = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry, TypeParameterCanBeVariant
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
`

type Context = {
  sourceFile: ts.SourceFile
  containingType?: string
  elementName?: string
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
  static: true,
  private: true,
  this: true,
}

function getTypeName(type: ts.TypeNode, context: Context): string {
  switch (type.kind) {
    case ts.SyntaxKind.StringKeyword:
      return 'string'
    case ts.SyntaxKind.NumberKeyword:
      // try to guess better types in certain places
      if (
        context.elementName &&
        context.elementName.match(/length|size|count|offset|index/i)
      ) {
        return 'int'
      }
      return 'double'
    case ts.SyntaxKind.BooleanKeyword:
      return 'bool'
    case ts.SyntaxKind.AnyKeyword:
    case ts.SyntaxKind.UnknownKeyword:
      return 'object'
    case ts.SyntaxKind.VoidKeyword:
      return 'void'
    case ts.SyntaxKind.ThisType:
      return context.containingType!
    case ts.SyntaxKind.SymbolKeyword:
      return 'Symbol'
  }

  if (ts.isTypeReferenceNode(type)) {
    return (type.typeName as ts.Identifier).text
  }
  if (ts.isArrayTypeNode(type)) {
    return getTypeName(type.elementType, context) + '[]'
  }
  if (ts.isFunctionTypeNode(type)) {
    return getFunctionType(type, context)
  }

  // TODO support more specific types, start with non-union types
  // TODO Support generics
  // TODO support for Nullable, CanBeUndefined (| null, | undefined)
  return `object /* ${type.getText(context.sourceFile)} */`
}

function getFunctionType(type: ts.FunctionTypeNode, context: Context): string {
  const returnType = getTypeName(type.type, context)
  const returnsVoid = returnType === 'void'
  // skip this parameters - they don't actually exist
  const parameters = [...type.parameters]
  if (
    parameters.length &&
    parameters[0].name.getFullText(context.sourceFile) === 'this'
  ) {
    parameters.splice(0, 1)
  }
  if (returnsVoid) {
    return (
      'Action<' +
      parameters
        .map((p) =>
          getTypeName(p.type!, {
            ...context,
            elementName: p.name.getFullText(context.sourceFile),
          }),
        )
        .join(', ') +
      '>'
    )
  } else {
    return (
      'Func<' +
      [...parameters, type.type]
        .map((t) =>
          ts.isParameter(t)
            ? getTypeName(t.type!, {
                ...context,
                elementName: t.name.getFullText(context.sourceFile),
              })
            : getTypeName(t, context),
        )
        .join(', ') +
      '>'
    )
  }
}

function getSafeName(
  member: ts.PropertySignature | ts.MethodSignature | ts.Identifier,
): string {
  const name = ts.isIdentifier(member)
    ? member.text
    : (member.name as ts.StringLiteral).text
  // TODO Improve writing of reserved member names
  return !reservedNames[name]
    ? name
    : ts.isIdentifier(member)
    ? `${name}Parameter`
    : ts.isPropertySignature(member)
    ? `${name}Property`
    : `${name}Method`
}

function isReadonly(modifiers: ts.NodeArray<ts.Modifier> | undefined): boolean {
  return (
    modifiers?.some((m) => ts.isReadonlyKeywordOrPlusOrMinusToken(m)) ?? false
  )
}

function getParameterList(
  parameterDeclaration: ts.NodeArray<ts.ParameterDeclaration>,
  context: Context,
) {
  return parameterDeclaration
    .map(
      (para) =>
        `${getTypeName(para.type!, context)} ${getSafeName(
          para.name as ts.Identifier,
        )}`,
    )
    .join(', ')
}

function getTypeParameters(node: ts.InterfaceDeclaration): string {
  if (!node.typeParameters?.length) {
    return ''
  }
  const parameters = node.typeParameters.map((parameter) => parameter.name.text)
  return `<${parameters.join(', ')}>`
}

function getBaseTypes(node: ts.InterfaceDeclaration): string {
  if (!node.heritageClauses) {
    return ''
  }

  const typeNames = node.heritageClauses[0].types.map(
    // TODO Support generics
    // TODO Call getTypeName
    (value) => (value.expression as ts.Identifier).text,
  )
  return `: ${typeNames.join(', ')} `
}

function getMembers(node: ts.InterfaceDeclaration, context: Context): string[] {
  return node.members.map((member) => {
    if (ts.isPropertySignature(member)) {
      // TODO support modifier, especially readonly
      const name = getSafeName(member)
      const type = getTypeName(member.type!, {
        ...context,
        elementName: name,
      })
      const readonly = isReadonly(member.modifiers)
      const accessors = 'get;' + (!readonly ? ' set;' : '')
      return `public new ${type} ${name} { ${accessors} }`
    }
    if (ts.isMethodSignature(member)) {
      const ms = member as ts.MethodSignature
      const name = getSafeName(member)
      const type = getTypeName(member.type!, { ...context, elementName: name })
      const parameters = getParameterList(ms.parameters, context)
      return `public new ${type} ${name}(${parameters});`
    }
    return `// TODO: Unsupported member: ${member.getText(context.sourceFile)}`
  })
}

export function getNamespace(filename: string) {
  return filename.includes('dom')
    ? 'DOM'
    : filename.includes('webworker')
    ? 'Worker'
    : filename.includes('decorators')
    ? 'Decorators'
    : 'Lib'
}

export function getFileContent(filename: string): string[] {
  const program = ts.createProgram([filename], { allowJs: true })
  const sourceFile = program.getSourceFile(filename)!

  const context: Context = { sourceFile }
  const namespace = getNamespace(filename)

  // TODO Parse types into usings

  const interfaces: string[] = [
    disableWarnings,
    `namespace ECMAScript.${namespace};`,
  ]

  for (const match of sourceFile.text.matchAll(
    /\/\/\/\s*<reference\s+lib="(?<libName>.*)"\s*\/>/g,
  )) {
    interfaces.push(`// Referenced lib: ${match.groups!.libName}`)
  }

  ts.forEachChild(sourceFile, (node) => {
    if (ts.isInterfaceDeclaration(node)) {
      const name = node.name.text
      // TODO Support generics
      const typeParameters = getTypeParameters(node)
      context.containingType = `${name}${typeParameters}`
      const baseTypes = getBaseTypes(node)
      const members = getMembers(node, context)
      const typeContent =
        members.length === 0 ? '' : `\n  ${members.join('\n  ')}\n`

      interfaces.push(
        `public partial interface ${name}${typeParameters} ${baseTypes} {${typeContent}}`,
      )
      delete context.containingType
    }
  })

  return interfaces
}
