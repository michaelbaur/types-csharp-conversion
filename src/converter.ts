import * as fs from 'node:fs'
import * as path from 'node:path'
import ts, { Identifier } from 'typescript'

export const preamble = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

`

type Context = {
  sourceFile: ts.SourceFile
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

function getTypeName(type: ts.TypeNode, context: Context): string {
  switch (type.kind) {
    case ts.SyntaxKind.StringKeyword:
      return 'string'
    case ts.SyntaxKind.NumberKeyword:
      return 'double'
    case ts.SyntaxKind.BooleanKeyword:
      return 'bool'
    case ts.SyntaxKind.AnyKeyword:
      return 'object'
    case ts.SyntaxKind.VoidKeyword:
      return 'void'
    case ts.SyntaxKind.SymbolKeyword:
      return 'Symbol'
  }

  if (ts.isTypeReferenceNode(type)) {
    return (type.typeName as ts.Identifier).text
  }
  if (ts.isArrayTypeNode(type)) {
    return getTypeName(type.elementType, context) + '[]'
  }

  // TODO support more specific types, start with non-union types
  // TODO Support generics
  // TODO support for Nullable, CanBeUndefined (| null, | undefined)
  return `object /* ${type.getText(context.sourceFile)} */`
}

function getSafeName(
  member: ts.PropertySignature | ts.MethodSignature | ts.Identifier,
  context: Context,
): string {
  const name = ts.isIdentifier(member)
    ? member.text
    : (member.name as ts.StringLiteral).text
  // TODO Improve writting of reserved member names
  return !reservedNames[name]
    ? name
    : ts.isIdentifier(member)
    ? `${name}Parameter`
    : ts.isPropertySignature(member)
    ? `${name}Property`
    : `${name}Method`
}

function isReadonly(
  modifiers: ts.NodeArray<ts.Modifier> | undefined,
  context: Context,
): boolean {
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
      (para, index) =>
        `${getTypeName(para.type!, context)} ${getSafeName(
          para.name as Identifier,
          context,
        )}`,
    ) //`${} ${para.name}`)
    .join(', ')
}

function getBaseTypes(node: ts.InterfaceDeclaration, context: Context): string {
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
      const name = getSafeName(member, context)
      const type = getTypeName(member.type!, context)
      const readonly = isReadonly(member.modifiers, context)
      const accessors = 'get;' + (!readonly ? ' set;' : '')
      return `public new ${type} ${name} { ${accessors} }`
    }
    if (ts.isMethodSignature(member)) {
      const ms = member as ts.MethodSignature
      const name = getSafeName(member, context)
      const type = getTypeName(member.type!, context)
      const parameters = getParameterList(ms.parameters, context)
      return `public new ${type} ${name}(${parameters});`
    }
    return `// TODO: Unsupported member: ${member.getText(context.sourceFile)}`
  })
}

export function getFileContent(sourceFile: ts.SourceFile): string[] {
  const context = { sourceFile }
  const interfaces: string[] = []

  for (const match of sourceFile.text.matchAll(
    /\/\/\/\s*<reference\s+lib="(?<libName>.*)"\s*\/>/g,
  )) {
    interfaces.push(`// TODO: Referenced lib: ${match.groups!.libName}`)
  }

  if (sourceFile.fileName.includes('lib.dom')) {
    interfaces.push('public interface Error { }')
  }

  ts.forEachChild(sourceFile, (node) => {
    if (ts.isInterfaceDeclaration(node)) {
      const name = node.name.text
      // TODO Support generics
      const baseTypes = getBaseTypes(node, context)
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
