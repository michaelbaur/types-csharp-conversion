import ts from 'typescript'
import { reservedNames } from './reservedNames'
import { excludedMembers, excludedTypes } from './excludes'

type Context = {
  sourceFile: ts.SourceFile
  containingType?: string
  elementName?: string
  typeList?: boolean
  returnValue?: boolean
}

type Namespace = 'Worker' | 'Lib' | 'DOM' | 'Decorators'

const seenTypeNames = new Set<string>()

export function getHeader(namespace: Namespace): string[] {
  if (namespace === 'Lib') {
    return [
      'using yWorks.Blunter.Annotations;',
      `namespace ECMAScript.${namespace};`,
    ]
  }

  return [
    'using ECMAScript.Lib;',
    'using yWorks.Blunter.Annotations;',
    'using Void = ECMAScript.Lib.Void;\n',
    `namespace ECMAScript.${namespace};`,
  ]
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

function getTypeName(type: ts.TypeNode, context: Context): string | null {
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
    case ts.SyntaxKind.ObjectKeyword:
      return 'object'
    case ts.SyntaxKind.UndefinedKeyword:
      return context.returnValue || context.typeList ? 'Undefined' : 'null'
    case ts.SyntaxKind.NullKeyword:
      return context.typeList ? null : context.returnValue ? 'Null' : 'null'
    case ts.SyntaxKind.VoidKeyword:
      return context.typeList ? 'Void' : 'void'
    case ts.SyntaxKind.ThisType:
      return context.containingType!
    case ts.SyntaxKind.SymbolKeyword:
      return 'Symbol'
  }

  if (ts.isLiteralTypeNode(type)) {
    if (ts.isStringLiteral(type.literal)) {
      return `string /* ${type.getText(context!.sourceFile)} */`
    } else if (
      ts.isNumericLiteral(type.literal) ||
      ts.isPrefixUnaryExpression(type.literal)
    ) {
      return `int /* ${type.getText(context!.sourceFile)} */`
    } else if (
      type.literal.kind === ts.SyntaxKind.TrueKeyword ||
      type.literal.kind === ts.SyntaxKind.FalseKeyword
    ) {
      return `bool /* ${type.getText(context!.sourceFile)} */`
    } else if (
      type.literal.kind === ts.SyntaxKind.NullKeyword ||
      type.literal.kind === ts.SyntaxKind.UndefinedKeyword
    ) {
      return context.returnValue ? 'Null' : null
    }
    throw new Error(
      `Unsupported literal type: ${type.getText(context!.sourceFile)}`,
    )
  }
  if (ts.isTypeReferenceNode(type)) {
    if (ts.isQualifiedName(type.typeName)) {
      return `object /* ${type.typeName.getText(context.sourceFile)} */`
    }
    const typeName = (type.typeName as ts.Identifier).text
    if (!Array.isArray(type.typeArguments) || type.typeArguments.length === 0) {
      return typeName
    }
    const typeList = type.typeArguments!.map((type) =>
      getTypeName(type, createContext(context, type, true)),
    )
    return `${typeName}<${typeList.join(', ')}>`
  }
  if (ts.isArrayTypeNode(type)) {
    return getTypeName(type.elementType, context) + '[]'
  }
  if (ts.isFunctionTypeNode(type)) {
    return getFunctionType(type, context)
  }
  if (ts.isUnionTypeNode(type)) {
    const typeList = type
      .types!.map((type) =>
        getTypeName(type, createContext(context, type, true)),
      )
      .filter((name) => name != null)
    // Currently, null and undefined are the only types we filter out.
    // So, if the lengths are different, we know it's because of one of them
    const containsNull = type.types!.length !== typeList.length

    const typeListPart =
      typeList.length === 1 ? `${typeList[0]}` : `Union<${typeList.join(', ')}>`
    return typeListPart + (containsNull ? '?' : '')
  }
  if (ts.isTypeLiteralNode(type)) {
    // type literals can contain multiple lines and comments, so we don't
    // include the plain text
    return `object /* some type literal */`
  }

  const text = type.getText(context!.sourceFile).replaceAll('\n', '; ')
  return `object /* ${text} */`
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
      getTypeName(p.type!, createContext(context, p.name)),
    )
    return 'Action<' + typeList.join(', ') + '>'
  }

  const typeList = [...parameters, type.type].map((t) =>
    ts.isParameter(t)
      ? getTypeName(t.type!, createContext(context, t.name))
      : getTypeName(t, context),
  )
  return 'Func<' + typeList.join(', ') + '>'
}

function getSafeName(
  member:
    | ts.PropertySignature
    | ts.MethodSignature
    | ts.Identifier
    | ts.ComputedPropertyName,
): string {
  if (ts.isComputedPropertyName(member)) {
    return member.getText()
  }

  const name = ts.isIdentifier(member)
    ? member.text
    : (member.name as ts.StringLiteral).text
  if (name == null) {
    // TODO Find the actual name
    return `NotDetected`
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

function createContext(context: Context, node: ts.Node, typeList = false) {
  return {
    ...context,
    elementName: node.getFullText(context.sourceFile),
    typeList,
  }
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
            getTypeName(type, createContext(context, type)),
          )
          .join(', ')}>`
  })
  return `: ${typeNames.join(', ')} `
}

function getMemberExcluded(containingType: string | undefined, name: string) {
  return name === 'NotDetected' ||
    excludedMembers.has(`${containingType}.${name}`)
    ? '// Member excluded: '
    : ''
}

function getMembers(node: ts.InterfaceDeclaration, context: Context): string[] {
  return node.members.map((member) => {
    if (ts.isPropertySignature(member)) {
      const name = getSafeName(member)
      const type = getTypeName(member.type!, {
        ...context,
        elementName: name,
        returnValue: true,
      })
      const readonly = isReadonly(member.modifiers)
      const accessors = 'get;' + (!readonly ? ' set;' : '')
      const memberExcluded = getMemberExcluded(context.containingType, name)
      return `${memberExcluded}public new ${type} ${name} { ${accessors} }`
    }
    if (ts.isMethodSignature(member)) {
      const name = getMethodName(member)
      const typeParameters = getTypeParameters(member)
      const type = getTypeName(member.type!, {
        ...context,
        elementName: name,
        returnValue: true,
      })
      const parameters = getParameterList(member.parameters, context)
      const memberExcluded = getMemberExcluded(context.containingType, name)
      return `${memberExcluded}public new ${type} ${name}${typeParameters}(${parameters});`
    }
    return `// TODO: Unsupported member: ${member.getText(context.sourceFile)}`
  })
}

function getStubAttribute(name: string) {
  if (seenTypeNames.has(name)) {
    return ''
  }
  seenTypeNames.add(name)
  return '[Stub]\n'
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
      const stubAttribute = getStubAttribute(name)
      const typeParameters = getTypeParameters(node)
      context.containingType = `${name}${typeParameters}`
      const baseTypes = getBaseTypes(node, context)
      const members = getMembers(node, context)

      if (excludedTypes.has(name)) {
        fileContent.push(
          `${stubAttribute}public partial interface ${name}${typeParameters} ${baseTypes} {\n  // Content excluded\n}`,
        )
        return
      }

      const typeContent =
        members.length === 0 ? '' : `\n  ${members.join('\n  ')}\n`
      fileContent.push(
        `${stubAttribute}public partial interface ${name}${typeParameters} ${baseTypes} {${typeContent}}`,
      )
      delete context.containingType
    }

    if (ts.isTypeAliasDeclaration(node)) {
      // TODO String unions should be string
      // TODO Some aliases have type parameters
      const name = node.name.escapedText.toString()
      const stubAttribute = getStubAttribute(name)
      fileContent.push(
        `${stubAttribute}public abstract partial class ${name} { }`,
      )
    }
  })

  return fileContent
}
