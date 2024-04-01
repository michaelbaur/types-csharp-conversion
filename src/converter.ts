import ts from 'typescript'

const disableWarnings = `// ReSharper disable InconsistentNaming, RedundantExtendsListEntry, TypeParameterCanBeVariant
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using ECMAScript.Decorators;
using ECMAScript.DOM;
using ECMAScript.Lib;
`

type Context = {
  sourceFile: ts.SourceFile
  containingType?: string
  elementName?: string
}

const reservedNames: Set<string> = new Set([
  'abstract',
  'as',
  'base',
  'bool',
  'break',
  'byte',
  'case',
  'catch',
  'char',
  'checked',
  'class',
  'const',
  'continue',
  'decimal',
  'default',
  'delegate',
  'do',
  'double',
  'else',
  'enum',
  'event',
  'explicit',
  'extern',
  'false',
  'finally',
  'fixed',
  'float',
  'for',
  'foreach',
  'goto',
  'if',
  'implicit',
  'in',
  'int',
  'interface',
  'internal',
  'is',
  'lock',
  'long',
  'namespace',
  'new',
  'null',
  'object',
  'operator',
  'out',
  'override',
  'params',
  'private',
  'protected',
  'public',
  'readonly',
  'ref',
  'return',
  'sbyte',
  'sealed',
  'short',
  'sizeof',
  'stackalloc',
  'static',
  'string',
  'struct',
  'switch',
  'this',
  'throw',
  'true',
  'try',
  'typeof',
  'uint',
  'ulong',
  'unchecked',
  'unsafe',
  'ushort',
  'using',
  'virtual',
  'void',
  'volatile',
  'while',
])

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
    // TODO support readonly
    const typeName = (type.typeName as ts.Identifier).text
    return !Array.isArray(type.typeArguments) || type.typeArguments.length === 0
      ? typeName
      : `${typeName}<${type
          .typeArguments!.map((type) =>
            getTypeName(type, {
              ...context,
              elementName: type.getFullText(context.sourceFile),
            }),
          )
          .join(', ')}>`
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
  return !reservedNames.has(name) ? name : `@${name}`
}

/**
 * Does method-specific stuff and delegates to {@link getSafeName} for shared features.
 */
function getMethodName(member: ts.MethodSignature): string {
  if (
    ts.isComputedPropertyName(member.name) &&
    ts.isPropertyAccessExpression(member.name.expression)
  ) {
    const pae = member.name.expression
    if (
      ts.isIdentifier(pae.expression) &&
      pae.expression.escapedText == 'Symbol' &&
      pae.name.escapedText === 'iterator'
    ) {
      return 'symbolIterator'
    }
  }
  return getSafeName(member)
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

function getTypeParameters(
  node: ts.NamedDeclaration & {
    typeParameters?: ts.NodeArray<ts.TypeParameterDeclaration>
  },
): string {
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
      const name = getMethodName(member)
      const typeParameters = getTypeParameters(member)
      const type = getTypeName(member.type!, { ...context, elementName: name })
      const parameters = getParameterList(member.parameters, context)
      return `public new ${type} ${name}${typeParameters}(${parameters});`
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

  const fileContent: string[] = [
    disableWarnings,
    `namespace ECMAScript.${namespace};`,
  ]

  for (const match of sourceFile.text.matchAll(
    /\/\/\/\s*<reference\s+lib="(?<libName>.*)"\s*\/>/g,
  )) {
    fileContent.push(`// Referenced lib: ${match.groups!.libName}`)
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

      fileContent.push(
        `public partial interface ${name}${typeParameters} ${baseTypes} {${typeContent}}`,
      )
      delete context.containingType
    }

    if (ts.isTypeAliasDeclaration(node)) {
      // TODO String unions should be string
      // TODO Some aliases have type parameters
      fileContent.push(`public abstract partial class ${node.name.escapedText} { }`)
    }
  })

  return fileContent
}
