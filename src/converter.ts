import * as fs from 'node:fs'
import * as path from 'node:path'
import ts, { Identifier } from 'typescript'

export const preamble = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

`

const reservedMemberNames: Record<string, boolean> = {
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
}

function getBaseTypes(node: ts.InterfaceDeclaration) {
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

function getTypeName(type: ts.TypeNode) {
  switch (type.kind) {
    case ts.SyntaxKind.StringKeyword:
      return 'string'
    case ts.SyntaxKind.NumberKeyword:
      return 'double'
    case ts.SyntaxKind.BooleanKeyword:
      return 'bool'
    default:
      // TODO support more specific types, start with non-union types
      // TODO Support generics
      // TODO support for Nullable, CanBeUndefined (| null, | undefined)
      return 'object'
  }
}

function getMemberName(member: ts.PropertySignature | ts.MethodSignature) {
  const name = (member.name as ts.StringLiteral).text
  return !reservedMemberNames[name]
    ? name
    : ts.isPropertySignature(member)
    ? `${name}Property`
    : `${name}Method`
}

function isReadonly(modifiers: ts.NodeArray<ts.Modifier> | undefined): boolean {
  return modifiers?.some(m => ts.isReadonlyKeywordOrPlusOrMinusToken(m)) ?? false
}

function getParameterList(
  parameterDeclaration: ts.NodeArray<ts.ParameterDeclaration>,
) {
  return parameterDeclaration
    .map((para, index) => `${getTypeName(para.type!)} ${(para.name as Identifier).text}`) //`${} ${para.name}`)
    .join(', ')
}

function getMembers(node: ts.InterfaceDeclaration): string[] {
  return node.members.map((member) => {
    if (ts.isPropertySignature(member)) {
      // TODO support modifier, especially readonly
      const name = getMemberName(member)
      const type = getTypeName(member.type!)
      const readonly = isReadonly(member.modifiers)
      const accessors = 'get;' + (!readonly ? ' set;' : '')
      return `public new ${type} ${name} { ${accessors} }`
    }
    if (ts.isMethodSignature(member)) {
      const ms = member as ts.MethodSignature
      const name = getMemberName(member)
      const type = getTypeName(member.type!)
      const parameters = getParameterList(ms.parameters)
      return `public new ${type} ${name}(${parameters});`
 
    }
    return `// TODO: Unsupported member: ${member.name}`
  })
}

export function getTypes(sourceFile: ts.SourceFile): string[] {
  const interfaces: string[] = [
    sourceFile.fileName.includes('lib.dom') ? 'public interface Error { }' : '',
  ]

  ts.forEachChild(sourceFile, (node) => {
    if (ts.isInterfaceDeclaration(node)) {
      const name = node.name.text
      // TODO Support generics
      const baseTypes = getBaseTypes(node)
      const members = getMembers(node)
      const typeContent =
        members.length === 0 ? '' : `\n  ${members.join('\n  ')}\n`

      interfaces.push(`public partial interface ${name} ${baseTypes} {${typeContent}}`)
    }
  })

  return interfaces
}
