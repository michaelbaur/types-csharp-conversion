/**
 * These members cause problems and are therefore excluded.
 * Typically, this is because they are ambiguous overloads.
 * If such a member is actually necessary in yFiles code, implement it in LibCustom.
 */
export const excludedMembers: Set<string> = new Set([
  'SubtleCrypto.generateKey',
  'SubtleCrypto.importKey',
  'Document.createElement',
  'Document.createElementNS',
  'Document.createEvent',
  'Document.getElementsByTagName',
  'Document.getElementsByTagNameNS',
  'Element.closest',
  'Element.getElementsByTagName',
  'Element.getElementsByTagNameNS',
  'HTMLCanvasElement.getContext',
  'ObjectConstructor.keys',
  'ObjectConstructor.freeze',
  'OffscreenCanvas.getContext',
  'ParentNode.querySelector',
  'ParentNode.querySelectorAll',
  'WebGLRenderingContextBase.getExtension',
  'WindowOrWorkerGlobalScope.clearInterval',
  'WindowOrWorkerGlobalScope.clearTimeout',
  'DateConstructor.UTC',
  'BigIntToLocaleStringOptions.minimumIntegerDigits',
  'BigIntToLocaleStringOptions.minimumFractionDigits',
  'BigIntToLocaleStringOptions.maximumFractionDigits',
  'BigIntToLocaleStringOptions.minimumSignificantDigits',
  'BigIntToLocaleStringOptions.maximumSignificantDigits',
])

export const excludedTypes: Set<string> = new Set([
  'AggregateErrorConstructor',
])
