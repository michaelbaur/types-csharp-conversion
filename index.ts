import * as fs from 'node:fs'
import * as path from 'node:path'
import ts from 'typescript'

const preamble = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
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
    (value) => (value.expression as ts.Identifier).text,
  )
  return `: ${typeNames.join(', ')} `
}

function getTypeString(type: ts.TypeNode) {
  switch (type.kind) {
    case ts.SyntaxKind.StringKeyword:
      return 'string'
    case ts.SyntaxKind.NumberKeyword:
      return 'double'
    case ts.SyntaxKind.BooleanKeyword:
      return 'bool'
    default:
      // TODO better types
      return 'object'
  }
}

function getMemberName(member: ts.PropertySignature) {
  const name = (member.name as ts.StringLiteral).text
  return reservedMemberNames[name] ? `${name}Property` : name
}

function getMembers(node: ts.InterfaceDeclaration): string {
  const memberStrings: string[] = []
  for (const member of node.members) {
    if (ts.isPropertySignature(member)) {
      // TODO support modifier, especially readonly
      const name = getMemberName(member)
      const type = getTypeString(member.type!)
      const prop = `public new ${type} ${name} { get; set; }`
      memberStrings.push(prop)
    }
    // TODO support methods
  }

  return memberStrings.length === 0 ? '' : `\n  ${memberStrings.join('\n  ')}\n`
}

/**
 * Prints out particular nodes from a source file
 *
 * @param filename a path to a file
 */
function extract(filename: string): void {
  // Create a Program to represent the project, then pull out the
  // source file to parse its AST.
  const program = ts.createProgram([filename], { allowJs: true })
  const sourceFile = program.getSourceFile(filename)!

  // Loop through the root AST nodes of the file
  const interfaces: string[] = ['public interface Error { }']
  ts.forEachChild(sourceFile, (node) => {
    if (ts.isInterfaceDeclaration(node)) {
      const name = node.name.text
      const baseTypes = getBaseTypes(node)
      const members = getMembers(node)

      interfaces.push(`public interface ${name} ${baseTypes} {${members}}`)
    }
  })

  console.log(interfaces.join('\n\n'))

  const pagination = 500
  for (let i = 0; i * pagination < interfaces.length; i++) {
    const targetFile = path.join(
      'C:\\Users\\baur\\Documents\\yFilesNET\\wpf-4.0\\lib\\yfiles-dotnet\\src\\viewer\\Stubs',
      `${path.basename(filename, `.d.ts`)}-${i}.cs`,
    )
    fs.writeFileSync(
      targetFile,
      preamble +
        interfaces.slice(i * pagination, (i + 1) * pagination).join('\n\n'),
    )
  }
}

// Run the extract function with the script's arguments
extract(process.argv[2])
