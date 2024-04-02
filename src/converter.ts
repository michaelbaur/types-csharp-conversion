import ts from 'typescript'
import { reservedNames } from './reservedNames'

type Context = {
  sourceFile: ts.SourceFile
  containingType?: string
  elementName?: string
}

type Namespace = 'Worker' | 'Lib' | 'DOM' | 'Decorators'

export function getHeader(namespace: Namespace): string[] {
  return [`namespace ECMAScript.${namespace};`]
}

export function getNamespace(filename: string): Namespace {
  return filename.includes('webworker')
    ? 'Worker'
    : // : filename.includes('dom')
      // ? 'DOM'
      // : filename.includes('decorators')
      // ? 'Decorators'
      'Lib'
}

function getTypeName(type: ts.TypeNode, context: Context): string {
  switch (type.kind) {
    case ts.SyntaxKind.StringKeyword:
      return 'string'
    case ts.SyntaxKind.NumberKeyword:
      // try to guess better types in certain places
      return context.elementName?.match(/length|size|count|offset|index/i)
        ? 'int'
        : 'double'
    case ts.SyntaxKind.BooleanKeyword:
      return 'bool'
    case ts.SyntaxKind.AnyKeyword:
    case ts.SyntaxKind.UnknownKeyword:
      return 'object'
    case ts.SyntaxKind.VoidKeyword:
      return 'void'
    case ts.SyntaxKind.ThisType:
      return context!.containingType!
    case ts.SyntaxKind.SymbolKeyword:
      return 'Symbol'
  }

  if (ts.isTypeReferenceNode(type)) {
    const typeName = (type.typeName as ts.Identifier).text
    if (!Array.isArray(type.typeArguments) || type.typeArguments.length === 0) {
      return typeName
    }
    const typeList = type
      .typeArguments!.map((type) =>
        getTypeName(type, createContext(type, context)),
      )
      .map((name) => (name === 'void' ? 'Void' : name))
    return `${typeName}<${typeList.join(', ')}>`
  }
  if (ts.isArrayTypeNode(type)) {
    return getTypeName(type.elementType, context) + '[]'
  }
  if (ts.isFunctionTypeNode(type)) {
    return getFunctionType(type, context)
  }
  if (ts.isTypeLiteralNode(type)) {
    // type literals can contain multiple lines and comments, so we don't
    // include the plain text
    return `object /* some type literal */`
  }

  // TODO support more specific types, start with non-union types
  // TODO Support generics
  // TODO support for Nullable, CanBeUndefined (| null, | undefined)
  return `object /* ${type.getText(context!.sourceFile)} */`
}

function getFunctionType(type: ts.FunctionTypeNode, context: Context): string {
  const returnType = getTypeName(type.type, context)
  const returnsVoid = returnType === 'void'
  // skip these parameters - they don't actually exist
  const parameters = [...type.parameters]
  if (
    parameters.length &&
    context &&
    parameters[0].name.getFullText(context.sourceFile) === 'this'
  ) {
    parameters.splice(0, 1)
  }

  if (returnsVoid) {
    if (parameters.length == 0) {
      return 'Action'
    }
    const typeList = parameters.map((p) =>
      getTypeName(p.type!, createContext(p.name, context)),
    )
    return 'Action<' + typeList.join(', ') + '>'
  }

  const typeList = [...parameters, type.type].map((t) =>
    ts.isParameter(t)
      ? getTypeName(t.type!, createContext(t.name, context))
      : getTypeName(t, context),
  )
  return 'Func<' + typeList.join(', ') + '>'
}

function getSafeName(
  member: ts.PropertySignature | ts.MethodSignature | ts.Identifier,
): string {
  const name = ts.isIdentifier(member)
    ? member.text
    : (member.name as ts.StringLiteral).text
  if (name == null) {
    // TODO Don't return an empty name
    return ''
  }
  if (name.startsWith('$')) {
    return name
      .replace('$', 'dollar')
      .replace('+', 'Plus')
      .replace('&', 'Amp')
      .replace('`', 'BackTick')
      .replace("'", 'Apo')
  }

  return reservedNames.has(name)
    ? `@${name}`
    : name.match(/(^\d+$)/)
    ? `number${name}`
    : name.replaceAll('-', '_')
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

function createContext(node: ts.Node, context: Context) {
  return { ...context, elementName: node.getFullText(context.sourceFile) }
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

function getBaseTypes(node: ts.InterfaceDeclaration, context: Context): string {
  if (!node.heritageClauses) {
    return ''
  }

  const typeNames = node.heritageClauses[0].types.map((type) => {
    const typeName = (type.expression as ts.Identifier).text
    return !Array.isArray(type.typeArguments) || type.typeArguments.length === 0
      ? typeName
      : `${typeName}<${type
          .typeArguments!.map((type) =>
            getTypeName(type, createContext(type, context)),
          )
          .join(', ')}>`
  })
  return `: ${typeNames.join(', ')} `
}

function getMembers(node: ts.InterfaceDeclaration, context: Context): string[] {
  return node.members.map((member) => {
    if (ts.isPropertySignature(member)) {
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

export function getFileContent(filename: string): string[] {
  const program = ts.createProgram([filename], { allowJs: true })
  const sourceFile = program.getSourceFile(filename)!

  const context: Context = { sourceFile }

  // TODO Parse types into usings

  const fileContent: string[] = []

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
      const baseTypes = getBaseTypes(node, context)
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
      fileContent.push(
        `public abstract partial class ${node.name.escapedText} { }`,
      )
    }
  })

  return fileContent
}
