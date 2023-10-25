// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial interface EXT_color_buffer_float  {}

public partial interface EXT_color_buffer_half_float  {
  public new object RGBA16F_EXT { get; }
  public new object RGB16F_EXT { get; }
  public new object FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT { get; }
  public new object UNSIGNED_NORMALIZED_EXT { get; }
}

public partial interface EXT_float_blend  {}

public partial interface EXT_frag_depth  {}

public partial interface EXT_sRGB  {
  public new object SRGB_EXT { get; }
  public new object SRGB_ALPHA_EXT { get; }
  public new object SRGB8_ALPHA8_EXT { get; }
  public new object FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT { get; }
}

public partial interface EXT_shader_texture_lod  {}

public partial interface EXT_texture_compression_bptc  {
  public new object COMPRESSED_RGBA_BPTC_UNORM_EXT { get; }
  public new object COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT { get; }
  public new object COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT { get; }
  public new object COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT { get; }
}

public partial interface EXT_texture_compression_rgtc  {
  public new object COMPRESSED_RED_RGTC1_EXT { get; }
  public new object COMPRESSED_SIGNED_RED_RGTC1_EXT { get; }
  public new object COMPRESSED_RED_GREEN_RGTC2_EXT { get; }
  public new object COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT { get; }
}

public partial interface EXT_texture_filter_anisotropic  {
  public new object TEXTURE_MAX_ANISOTROPY_EXT { get; }
  public new object MAX_TEXTURE_MAX_ANISOTROPY_EXT { get; }
}

public partial interface EXT_texture_norm16  {
  public new object R16_EXT { get; }
  public new object RG16_EXT { get; }
  public new object RGB16_EXT { get; }
  public new object RGBA16_EXT { get; }
  public new object R16_SNORM_EXT { get; }
  public new object RG16_SNORM_EXT { get; }
  public new object RGB16_SNORM_EXT { get; }
  public new object RGBA16_SNORM_EXT { get; }
}

public partial interface ElementEventMap  {
  public new object fullscreenchange { get; set; }
  public new object fullscreenerror { get; set; }
}

public partial interface Element : Node, ARIAMixin, Animatable, ChildNode, InnerHTML, NonDocumentTypeChildNode, ParentNode, Slottable  {
  public new object attributes { get; }
  public new object classList { get; }
  public new string className { get; set; }
  public new double clientHeight { get; }
  public new double clientLeft { get; }
  public new double clientTop { get; }
  public new double clientWidth { get; }
  public new string id { get; set; }
  public new string localName { get; }
  public new object namespaceURI { get; }
  public new object onfullscreenchange { get; set; }
  public new object onfullscreenerror { get; set; }
  public new string outerHTML { get; set; }
  public new object ownerDocument { get; }
  public new object part { get; }
  public new object prefix { get; }
  public new double scrollHeight { get; }
  public new double scrollLeft { get; set; }
  public new double scrollTop { get; set; }
  public new double scrollWidth { get; }
  public new object shadowRoot { get; }
  public new string slot { get; set; }
  public new string tagName { get; }
  public new object attachShadow(object init);
  public new bool checkVisibility(object options);
  public new object closest(object selector);
  public new object closest(object selector);
  public new object closest(object selector);
  public new object closest(string selectors);
  public new object computedStyleMap();
  public new object getAttribute(string qualifiedName);
  public new object getAttributeNS(object namespace, string localName);
  public new object getAttributeNames();
  public new object getAttributeNode(string qualifiedName);
  public new object getAttributeNodeNS(object namespace, string localName);
  public new object getBoundingClientRect();
  public new object getClientRects();
  public new object getElementsByClassName(string classNames);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(string qualifiedName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespace, string localName);
  public new bool hasAttribute(string qualifiedName);
  public new bool hasAttributeNS(object namespace, string localName);
  public new bool hasAttributes();
  public new bool hasPointerCapture(double pointerId);
  public new object insertAdjacentElement(object where, object element);
  public new object insertAdjacentHTML(object position, string text);
  public new object insertAdjacentText(object where, string data);
  public new bool matches(string selectors);
  public new object releasePointerCapture(double pointerId);
  public new object removeAttribute(string qualifiedName);
  public new object removeAttributeNS(object namespace, string localName);
  public new object removeAttributeNode(object attr);
  public new object requestFullscreen(object options);
  public new object requestPointerLock();
  public new object scroll(object options);
  public new object scroll(double x, double y);
  public new object scrollBy(object options);
  public new object scrollBy(double x, double y);
  public new object scrollIntoView(object arg);
  public new object scrollTo(object options);
  public new object scrollTo(double x, double y);
  public new object setAttribute(string qualifiedName, string value);
  public new object setAttributeNS(object namespace, string qualifiedName, string value);
  public new object setAttributeNode(object attr);
  public new object setAttributeNodeNS(object attr);
  public new object setPointerCapture(double pointerId);
  public new bool toggleAttribute(string qualifiedName, bool force);
  public new bool webkitMatchesSelector(string selectors);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ElementCSSInlineStyle  {
  public new object attributeStyleMap { get; }
  public new object style { get; }
}

public partial interface ElementContentEditable  {
  public new string contentEditable { get; set; }
  public new string enterKeyHint { get; set; }
  public new string inputMode { get; set; }
  public new bool isContentEditable { get; }
}

public partial interface ElementInternals : ARIAMixin  {
  public new object form { get; }
  public new object labels { get; }
  public new object shadowRoot { get; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object setFormValue(object value, object state);
  public new object setValidity(object flags, string message, object anchor);
}

public partial interface EncodedVideoChunk  {
  public new double byteLength { get; }
  public new object duration { get; }
  public new double timestamp { get; }
  public new object type { get; }
  public new object copyTo(object destination);
}

public partial interface ErrorEvent : Event  {
  public new double colno { get; }
  public new object error { get; }
  public new string filename { get; }
  public new double lineno { get; }
  public new string message { get; }
}

public partial interface Event  {
  public new bool bubbles { get; }
  public new bool cancelBubble { get; set; }
  public new bool cancelable { get; }
  public new bool composed { get; }
  public new object currentTarget { get; }
  public new bool defaultPrevented { get; }
  public new double eventPhase { get; }
  public new bool isTrusted { get; }
  public new bool returnValue { get; set; }
  public new object srcElement { get; }
  public new object target { get; }
  public new object timeStamp { get; }
  public new string type { get; }
  public new object composedPath();
  public new object initEvent(string type, bool bubbles, bool cancelable);
  public new object preventDefault();
  public new object stopImmediatePropagation();
  public new object stopPropagation();
  public new object NONE { get; }
  public new object CAPTURING_PHASE { get; }
  public new object AT_TARGET { get; }
  public new object BUBBLING_PHASE { get; }
}

public partial interface EventCounts  {
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface EventListener  {
  // TODO: Unsupported member: undefined
}

public partial interface EventListenerObject  {
  public new object handleEvent(object object);
}

public partial interface EventSourceEventMap  {
  public new object error { get; set; }
  public new object message { get; set; }
  public new object open { get; set; }
}

public partial interface EventSource : EventTarget  {
  public new object onerror { get; set; }
  public new object onmessage { get; set; }
  public new object onopen { get; set; }
  public new double readyState { get; }
  public new string url { get; }
  public new bool withCredentials { get; }
  public new object close();
  public new object CONNECTING { get; }
  public new object OPEN { get; }
  public new object CLOSED { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface EventTarget  {
  public new object addEventListener(string type, object callback, object options);
  public new bool dispatchEvent(object event);
  public new object removeEventListener(string type, object callback, object options);
}

public partial interface External  {
  public new object AddSearchProvider();
  public new object IsSearchProviderInstalled();
}

public partial interface File : Blob  {
  public new double lastModified { get; }
  public new string name { get; }
  public new string webkitRelativePath { get; }
}

public partial interface FileList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface FileReaderEventMap  {
  public new object abort { get; set; }
  public new object error { get; set; }
  public new object load { get; set; }
  public new object loadend { get; set; }
  public new object loadstart { get; set; }
  public new object progress { get; set; }
}

public partial interface FileReader : EventTarget  {
  public new object error { get; }
  public new object onabort { get; set; }
  public new object onerror { get; set; }
  public new object onload { get; set; }
  public new object onloadend { get; set; }
  public new object onloadstart { get; set; }
  public new object onprogress { get; set; }
  public new object readyState { get; }
  public new object result { get; }
  public new object abort();
  public new object readAsArrayBuffer(object blob);
  public new object readAsBinaryString(object blob);
  public new object readAsDataURL(object blob);
  public new object readAsText(object blob, string encoding);
  public new object EMPTY { get; }
  public new object LOADING { get; }
  public new object DONE { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface FileSystem  {
  public new string name { get; }
  public new object root { get; }
}

public partial interface FileSystemDirectoryEntry : FileSystemEntry  {
  public new object createReader();
  public new object getDirectory(object path, object options, object successCallback, object errorCallback);
  public new object getFile(object path, object options, object successCallback, object errorCallback);
}

public partial interface FileSystemDirectoryHandle : FileSystemHandle  {
  public new object kind { get; }
  public new object getDirectoryHandle(string name, object options);
  public new object getFileHandle(string name, object options);
  public new object removeEntry(string name, object options);
  public new object resolve(object possibleDescendant);
}

public partial interface FileSystemDirectoryReader  {
  public new object readEntries(object successCallback, object errorCallback);
}

public partial interface FileSystemEntry  {
  public new object filesystem { get; }
  public new string fullPath { get; }
  public new bool isDirectory { get; }
  public new bool isFile { get; }
  public new string name { get; }
  public new object getParent(object successCallback, object errorCallback);
}

public partial interface FileSystemFileEntry : FileSystemEntry  {
  public new object file(object successCallback, object errorCallback);
}

public partial interface FileSystemFileHandle : FileSystemHandle  {
  public new object kind { get; }
  public new object createWritable(object options);
  public new object getFile();
}

public partial interface FileSystemHandle  {
  public new object kind { get; }
  public new string name { get; }
  public new object isSameEntry(object other);
}

public partial interface FileSystemWritableFileStream : WritableStream  {
  public new object seek(double position);
  public new object truncate(double size);
  public new object write(object data);
}

public partial interface FocusEvent : UIEvent  {
  public new object relatedTarget { get; }
}

public partial interface FontFace  {
  public new string ascentOverride { get; set; }
  public new string descentOverride { get; set; }
  public new object display { get; set; }
  public new string family { get; set; }
  public new string featureSettings { get; set; }
  public new string lineGapOverride { get; set; }
  public new object loaded { get; }
  public new object status { get; }
  public new string stretch { get; set; }
  public new string style { get; set; }
  public new string unicodeRange { get; set; }
  public new string variant { get; set; }
  public new string weight { get; set; }
  public new object load();
}

public partial interface FontFaceSetEventMap  {
  public new object loading { get; set; }
  public new object loadingdone { get; set; }
  public new object loadingerror { get; set; }
}

public partial interface FontFaceSet : EventTarget  {
  public new object onloading { get; set; }
  public new object onloadingdone { get; set; }
  public new object onloadingerror { get; set; }
  public new object ready { get; }
  public new object status { get; }
  public new bool check(string font, string text);
  public new object load(string font, string text);
  public new object forEach(object callbackfn, object thisArg);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface FontFaceSetLoadEvent : Event  {
  public new object fontfaces { get; }
}

public partial interface FontFaceSource  {
  public new object fonts { get; }
}

public partial interface FormData  {
  public new object append(string name, object value);
  public new object append(string name, string value);
  public new object append(string name, object blobValue, string filename);
  public new object delete(string name);
  public new object get(string name);
  public new object getAll(string name);
  public new bool has(string name);
  public new object set(string name, object value);
  public new object set(string name, string value);
  public new object set(string name, object blobValue, string filename);
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface FormDataEvent : Event  {
  public new object formData { get; }
}

public partial interface GainNode : AudioNode  {
  public new object gain { get; }
}

public partial interface Gamepad  {
  public new object axes { get; }
  public new object buttons { get; }
  public new bool connected { get; }
  public new object hapticActuators { get; }
  public new string id { get; }
  public new double index { get; }
  public new object mapping { get; }
  public new object timestamp { get; }
  public new object vibrationActuator { get; }
}

public partial interface GamepadButton  {
  public new bool pressed { get; }
  public new bool touched { get; }
  public new double value { get; }
}

public partial interface GamepadEvent : Event  {
  public new object gamepad { get; }
}

public partial interface GamepadHapticActuator  {
  public new object type { get; }
  public new object playEffect(object type, object params);
  public new object reset();
}

public partial interface GenericTransformStream  {
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface Geolocation  {
  public new object clearWatch(double watchId);
  public new object getCurrentPosition(object successCallback, object errorCallback, object options);
  public new double watchPosition(object successCallback, object errorCallback, object options);
}

public partial interface GeolocationCoordinates  {
  public new double accuracy { get; }
  public new object altitude { get; }
  public new object altitudeAccuracy { get; }
  public new object heading { get; }
  public new double latitude { get; }
  public new double longitude { get; }
  public new object speed { get; }
}

public partial interface GeolocationPosition  {
  public new object coords { get; }
  public new object timestamp { get; }
}

public partial interface GeolocationPositionError  {
  public new double code { get; }
  public new string message { get; }
  public new object PERMISSION_DENIED { get; }
  public new object POSITION_UNAVAILABLE { get; }
  public new object TIMEOUT { get; }
}

public partial interface GlobalEventHandlersEventMap  {
  public new object abort { get; set; }
  public new object animationcancel { get; set; }
  public new object animationend { get; set; }
  public new object animationiteration { get; set; }
  public new object animationstart { get; set; }
  public new object auxclick { get; set; }
  public new object beforeinput { get; set; }
  public new object blur { get; set; }
  public new object cancel { get; set; }
  public new object canplay { get; set; }
  public new object canplaythrough { get; set; }
  public new object change { get; set; }
  public new object click { get; set; }
  public new object close { get; set; }
  public new object compositionend { get; set; }
  public new object compositionstart { get; set; }
  public new object compositionupdate { get; set; }
  public new object contextmenu { get; set; }
  public new object copy { get; set; }
  public new object cuechange { get; set; }
  public new object cut { get; set; }
  public new object dblclick { get; set; }
  public new object drag { get; set; }
  public new object dragend { get; set; }
  public new object dragenter { get; set; }
  public new object dragleave { get; set; }
  public new object dragover { get; set; }
  public new object dragstart { get; set; }
  public new object drop { get; set; }
  public new object durationchange { get; set; }
  public new object emptied { get; set; }
  public new object ended { get; set; }
  public new object error { get; set; }
  public new object focus { get; set; }
  public new object focusin { get; set; }
  public new object focusout { get; set; }
  public new object formdata { get; set; }
  public new object gotpointercapture { get; set; }
  public new object input { get; set; }
  public new object invalid { get; set; }
  public new object keydown { get; set; }
  public new object keypress { get; set; }
  public new object keyup { get; set; }
  public new object load { get; set; }
  public new object loadeddata { get; set; }
  public new object loadedmetadata { get; set; }
  public new object loadstart { get; set; }
  public new object lostpointercapture { get; set; }
  public new object mousedown { get; set; }
  public new object mouseenter { get; set; }
  public new object mouseleave { get; set; }
  public new object mousemove { get; set; }
  public new object mouseout { get; set; }
  public new object mouseover { get; set; }
  public new object mouseup { get; set; }
  public new object paste { get; set; }
  public new object pause { get; set; }
  public new object play { get; set; }
  public new object playing { get; set; }
  public new object pointercancel { get; set; }
  public new object pointerdown { get; set; }
  public new object pointerenter { get; set; }
  public new object pointerleave { get; set; }
  public new object pointermove { get; set; }
  public new object pointerout { get; set; }
  public new object pointerover { get; set; }
  public new object pointerup { get; set; }
  public new object progress { get; set; }
  public new object ratechange { get; set; }
  public new object reset { get; set; }
  public new object resize { get; set; }
  public new object scroll { get; set; }
  public new object scrollend { get; set; }
  public new object securitypolicyviolation { get; set; }
  public new object seeked { get; set; }
  public new object seeking { get; set; }
  public new object select { get; set; }
  public new object selectionchange { get; set; }
  public new object selectstart { get; set; }
  public new object slotchange { get; set; }
  public new object stalled { get; set; }
  public new object submit { get; set; }
  public new object suspend { get; set; }
  public new object timeupdate { get; set; }
  public new object toggle { get; set; }
  public new object touchcancel { get; set; }
  public new object touchend { get; set; }
  public new object touchmove { get; set; }
  public new object touchstart { get; set; }
  public new object transitioncancel { get; set; }
  public new object transitionend { get; set; }
  public new object transitionrun { get; set; }
  public new object transitionstart { get; set; }
  public new object volumechange { get; set; }
  public new object waiting { get; set; }
  public new object webkitanimationend { get; set; }
  public new object webkitanimationiteration { get; set; }
  public new object webkitanimationstart { get; set; }
  public new object webkittransitionend { get; set; }
  public new object wheel { get; set; }
}

public partial interface GlobalEventHandlers  {
  public new object onabort { get; set; }
  public new object onanimationcancel { get; set; }
  public new object onanimationend { get; set; }
  public new object onanimationiteration { get; set; }
  public new object onanimationstart { get; set; }
  public new object onauxclick { get; set; }
  public new object onbeforeinput { get; set; }
  public new object onblur { get; set; }
  public new object oncancel { get; set; }
  public new object oncanplay { get; set; }
  public new object oncanplaythrough { get; set; }
  public new object onchange { get; set; }
  public new object onclick { get; set; }
  public new object onclose { get; set; }
  public new object oncontextmenu { get; set; }
  public new object oncopy { get; set; }
  public new object oncuechange { get; set; }
  public new object oncut { get; set; }
  public new object ondblclick { get; set; }
  public new object ondrag { get; set; }
  public new object ondragend { get; set; }
  public new object ondragenter { get; set; }
  public new object ondragleave { get; set; }
  public new object ondragover { get; set; }
  public new object ondragstart { get; set; }
  public new object ondrop { get; set; }
  public new object ondurationchange { get; set; }
  public new object onemptied { get; set; }
  public new object onended { get; set; }
  public new object onerror { get; set; }
  public new object onfocus { get; set; }
  public new object onformdata { get; set; }
  public new object ongotpointercapture { get; set; }
  public new object oninput { get; set; }
  public new object oninvalid { get; set; }
  public new object onkeydown { get; set; }
  public new object onkeypress { get; set; }
  public new object onkeyup { get; set; }
  public new object onload { get; set; }
  public new object onloadeddata { get; set; }
  public new object onloadedmetadata { get; set; }
  public new object onloadstart { get; set; }
  public new object onlostpointercapture { get; set; }
  public new object onmousedown { get; set; }
  public new object onmouseenter { get; set; }
  public new object onmouseleave { get; set; }
  public new object onmousemove { get; set; }
  public new object onmouseout { get; set; }
  public new object onmouseover { get; set; }
  public new object onmouseup { get; set; }
  public new object onpaste { get; set; }
  public new object onpause { get; set; }
  public new object onplay { get; set; }
  public new object onplaying { get; set; }
  public new object onpointercancel { get; set; }
  public new object onpointerdown { get; set; }
  public new object onpointerenter { get; set; }
  public new object onpointerleave { get; set; }
  public new object onpointermove { get; set; }
  public new object onpointerout { get; set; }
  public new object onpointerover { get; set; }
  public new object onpointerup { get; set; }
  public new object onprogress { get; set; }
  public new object onratechange { get; set; }
  public new object onreset { get; set; }
  public new object onresize { get; set; }
  public new object onscroll { get; set; }
  public new object onscrollend { get; set; }
  public new object onsecuritypolicyviolation { get; set; }
  public new object onseeked { get; set; }
  public new object onseeking { get; set; }
  public new object onselect { get; set; }
  public new object onselectionchange { get; set; }
  public new object onselectstart { get; set; }
  public new object onslotchange { get; set; }
  public new object onstalled { get; set; }
  public new object onsubmit { get; set; }
  public new object onsuspend { get; set; }
  public new object ontimeupdate { get; set; }
  public new object ontoggle { get; set; }
  public new object ontouchcancel { get; set; }
  public new object ontouchend { get; set; }
  public new object ontouchmove { get; set; }
  public new object ontouchstart { get; set; }
  public new object ontransitioncancel { get; set; }
  public new object ontransitionend { get; set; }
  public new object ontransitionrun { get; set; }
  public new object ontransitionstart { get; set; }
  public new object onvolumechange { get; set; }
  public new object onwaiting { get; set; }
  public new object onwebkitanimationend { get; set; }
  public new object onwebkitanimationiteration { get; set; }
  public new object onwebkitanimationstart { get; set; }
  public new object onwebkittransitionend { get; set; }
  public new object onwheel { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLAllCollection  {
  public new double length { get; }
  public new object item(string nameOrIndex);
  public new object namedItem(string name);
  // TODO: Unsupported member: undefined
}

public partial interface HTMLAnchorElement : HTMLElement, HTMLHyperlinkElementUtils  {
  public new string charset { get; set; }
  public new string coords { get; set; }
  public new string download { get; set; }
  public new string hreflang { get; set; }
  public new string name { get; set; }
  public new string ping { get; set; }
  public new string referrerPolicy { get; set; }
  public new string rel { get; set; }
  public new object relList { get; }
  public new string rev { get; set; }
  public new string shape { get; set; }
  public new string target { get; set; }
  public new string text { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLAreaElement : HTMLElement, HTMLHyperlinkElementUtils  {
  public new string alt { get; set; }
  public new string coords { get; set; }
  public new string download { get; set; }
  public new bool noHref { get; set; }
  public new string ping { get; set; }
  public new string referrerPolicy { get; set; }
  public new string rel { get; set; }
  public new object relList { get; }
  public new string shape { get; set; }
  public new string target { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLAudioElement : HTMLMediaElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLBRElement : HTMLElement  {
  public new string clear { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLBaseElement : HTMLElement  {
  public new string href { get; set; }
  public new string target { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLBodyElementEventMap : HTMLElementEventMap, WindowEventHandlersEventMap  {}

public partial interface HTMLBodyElement : HTMLElement, WindowEventHandlers  {
  public new string aLink { get; set; }
  public new string background { get; set; }
  public new string bgColor { get; set; }
  public new string link { get; set; }
  public new string text { get; set; }
  public new string vLink { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLButtonElement : HTMLElement, PopoverInvokerElement  {
  public new bool disabled { get; set; }
  public new object form { get; }
  public new string formAction { get; set; }
  public new string formEnctype { get; set; }
  public new string formMethod { get; set; }
  public new bool formNoValidate { get; set; }
  public new string formTarget { get; set; }
  public new object labels { get; }
  public new string name { get; set; }
  public new object type { get; set; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new string value { get; set; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object setCustomValidity(string error);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLCanvasElement : HTMLElement  {
  public new double height { get; set; }
  public new double width { get; set; }
  public new object captureStream(double frameRequestRate);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(string contextId, object options);
  public new object toBlob(object callback, string type, object quality);
  public new string toDataURL(string type, object quality);
  public new object transferControlToOffscreen();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLCollectionBase  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface HTMLCollection : HTMLCollectionBase  {
  public new object namedItem(string name);
}

public partial interface HTMLCollectionOf : HTMLCollectionBase  {
  public new object item(double index);
  public new object namedItem(string name);
  // TODO: Unsupported member: undefined
}

public partial interface HTMLDListElement : HTMLElement  {
  public new bool compact { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDataElement : HTMLElement  {
  public new string value { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDataListElement : HTMLElement  {
  public new object options { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDetailsElement : HTMLElement  {
  public new bool open { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDialogElement : HTMLElement  {
  public new bool open { get; set; }
  public new string returnValue { get; set; }
  public new object close(string returnValue);
  public new object show();
  public new object showModal();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDirectoryElement : HTMLElement  {
  public new bool compact { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDivElement : HTMLElement  {
  public new string align { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLDocument : Document  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLElementEventMap : ElementEventMap, GlobalEventHandlersEventMap  {}

public partial interface HTMLElement : Element, ElementCSSInlineStyle, ElementContentEditable, GlobalEventHandlers, HTMLOrSVGElement  {
  public new string accessKey { get; set; }
  public new string accessKeyLabel { get; }
  public new string autocapitalize { get; set; }
  public new string dir { get; set; }
  public new bool draggable { get; set; }
  public new bool hidden { get; set; }
  public new bool inert { get; set; }
  public new string innerText { get; set; }
  public new string lang { get; set; }
  public new double offsetHeight { get; }
  public new double offsetLeft { get; }
  public new object offsetParent { get; }
  public new double offsetTop { get; }
  public new double offsetWidth { get; }
  public new string outerText { get; set; }
  public new object popover { get; set; }
  public new bool spellcheck { get; set; }
  public new string title { get; set; }
  public new bool translate { get; set; }
  public new object attachInternals();
  public new object click();
  public new object hidePopover();
  public new object showPopover();
  public new object togglePopover(bool force);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLEmbedElement : HTMLElement  {
  public new string align { get; set; }
  public new string height { get; set; }
  public new string name { get; set; }
  public new string src { get; set; }
  public new string type { get; set; }
  public new string width { get; set; }
  public new object getSVGDocument();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLFieldSetElement : HTMLElement  {
  public new bool disabled { get; set; }
  public new object elements { get; }
  public new object form { get; }
  public new string name { get; set; }
  public new string type { get; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object setCustomValidity(string error);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLFontElement : HTMLElement  {
  public new string color { get; set; }
  public new string face { get; set; }
  public new string size { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLFormControlsCollection : HTMLCollectionBase  {
  public new object namedItem(string name);
}

public partial interface HTMLFormElement : HTMLElement  {
  public new string acceptCharset { get; set; }
  public new string action { get; set; }
  public new object autocomplete { get; set; }
  public new object elements { get; }
  public new string encoding { get; set; }
  public new string enctype { get; set; }
  public new double length { get; }
  public new string method { get; set; }
  public new string name { get; set; }
  public new bool noValidate { get; set; }
  public new string rel { get; set; }
  public new object relList { get; }
  public new string target { get; set; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object requestSubmit(object submitter);
  public new object reset();
  public new object submit();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  // TODO: Unsupported member: undefined
  // TODO: Unsupported member: undefined
}

public partial interface HTMLFrameElement : HTMLElement  {
  public new object contentDocument { get; }
  public new object contentWindow { get; }
  public new string frameBorder { get; set; }
  public new string longDesc { get; set; }
  public new string marginHeight { get; set; }
  public new string marginWidth { get; set; }
  public new string name { get; set; }
  public new bool noResize { get; set; }
  public new string scrolling { get; set; }
  public new string src { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLFrameSetElementEventMap : HTMLElementEventMap, WindowEventHandlersEventMap  {}

public partial interface HTMLFrameSetElement : HTMLElement, WindowEventHandlers  {
  public new string cols { get; set; }
  public new string rows { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLHRElement : HTMLElement  {
  public new string align { get; set; }
  public new string color { get; set; }
  public new bool noShade { get; set; }
  public new string size { get; set; }
  public new string width { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLHeadElement : HTMLElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLHeadingElement : HTMLElement  {
  public new string align { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLHtmlElement : HTMLElement  {
  public new string version { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLHyperlinkElementUtils  {
  public new string hash { get; set; }
  public new string host { get; set; }
  public new string hostname { get; set; }
  public new string href { get; set; }
  public new string toStringMethod();
  public new string origin { get; }
  public new string password { get; set; }
  public new string pathname { get; set; }
  public new string port { get; set; }
  public new string protocol { get; set; }
  public new string search { get; set; }
  public new string username { get; set; }
}

public partial interface HTMLIFrameElement : HTMLElement  {
  public new string align { get; set; }
  public new string allow { get; set; }
  public new bool allowFullscreen { get; set; }
  public new object contentDocument { get; }
  public new object contentWindow { get; }
  public new string frameBorder { get; set; }
  public new string height { get; set; }
  public new string loading { get; set; }
  public new string longDesc { get; set; }
  public new string marginHeight { get; set; }
  public new string marginWidth { get; set; }
  public new string name { get; set; }
  public new object referrerPolicy { get; set; }
  public new object sandbox { get; }
  public new string scrolling { get; set; }
  public new string src { get; set; }
  public new string srcdoc { get; set; }
  public new string width { get; set; }
  public new object getSVGDocument();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLImageElement : HTMLElement  {
  public new string align { get; set; }
  public new string alt { get; set; }
  public new string border { get; set; }
  public new bool complete { get; }
  public new object crossOrigin { get; set; }
  public new string currentSrc { get; }
  public new object decoding { get; set; }
  public new double height { get; set; }
  public new double hspace { get; set; }
  public new bool isMap { get; set; }
  public new object loading { get; set; }
  public new string longDesc { get; set; }
  public new string lowsrc { get; set; }
  public new string name { get; set; }
  public new double naturalHeight { get; }
  public new double naturalWidth { get; }
  public new string referrerPolicy { get; set; }
  public new string sizes { get; set; }
  public new string src { get; set; }
  public new string srcset { get; set; }
  public new string useMap { get; set; }
  public new double vspace { get; set; }
  public new double width { get; set; }
  public new double x { get; }
  public new double y { get; }
  public new object decode();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLInputElement : HTMLElement, PopoverInvokerElement  {
  public new string accept { get; set; }
  public new string align { get; set; }
  public new string alt { get; set; }
  public new object autocomplete { get; set; }
  public new string capture { get; set; }
  public new bool checkedProperty { get; set; }
  public new bool defaultChecked { get; set; }
  public new string defaultValue { get; set; }
  public new string dirName { get; set; }
  public new bool disabled { get; set; }
  public new object files { get; set; }
  public new object form { get; }
  public new string formAction { get; set; }
  public new string formEnctype { get; set; }
  public new string formMethod { get; set; }
  public new bool formNoValidate { get; set; }
  public new string formTarget { get; set; }
  public new double height { get; set; }
  public new bool indeterminate { get; set; }
  public new object labels { get; }
  public new object list { get; }
  public new string max { get; set; }
  public new double maxLength { get; set; }
  public new string min { get; set; }
  public new double minLength { get; set; }
  public new bool multiple { get; set; }
  public new string name { get; set; }
  public new string pattern { get; set; }
  public new string placeholder { get; set; }
  public new bool readOnly { get; set; }
  public new bool required { get; set; }
  public new object selectionDirection { get; set; }
  public new object selectionEnd { get; set; }
  public new object selectionStart { get; set; }
  public new double size { get; set; }
  public new string src { get; set; }
  public new string step { get; set; }
  public new string type { get; set; }
  public new string useMap { get; set; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new string value { get; set; }
  public new object valueAsDate { get; set; }
  public new double valueAsNumber { get; set; }
  public new object webkitEntries { get; }
  public new bool webkitdirectory { get; set; }
  public new double width { get; set; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object select();
  public new object setCustomValidity(string error);
  public new object setRangeText(string replacement);
  public new object setRangeText(string replacement, double start, double end, object selectionMode);
  public new object setSelectionRange(object start, object end, object direction);
  public new object showPicker();
  public new object stepDown(double n);
  public new object stepUp(double n);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLLIElement : HTMLElement  {
  public new string type { get; set; }
  public new double value { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLLabelElement : HTMLElement  {
  public new object control { get; }
  public new object form { get; }
  public new string htmlFor { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLLegendElement : HTMLElement  {
  public new string align { get; set; }
  public new object form { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLLinkElement : HTMLElement, LinkStyle  {
  public new string asProperty { get; set; }
  public new string charset { get; set; }
  public new object crossOrigin { get; set; }
  public new bool disabled { get; set; }
  public new string href { get; set; }
  public new string hreflang { get; set; }
  public new string imageSizes { get; set; }
  public new string imageSrcset { get; set; }
  public new string integrity { get; set; }
  public new string media { get; set; }
  public new string referrerPolicy { get; set; }
  public new string rel { get; set; }
  public new object relList { get; }
  public new string rev { get; set; }
  public new object sizes { get; }
  public new string target { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMapElement : HTMLElement  {
  public new object areas { get; }
  public new string name { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMarqueeElement : HTMLElement  {
  public new string behavior { get; set; }
  public new string bgColor { get; set; }
  public new string direction { get; set; }
  public new string height { get; set; }
  public new double hspace { get; set; }
  public new double loop { get; set; }
  public new double scrollAmount { get; set; }
  public new double scrollDelay { get; set; }
  public new bool trueSpeed { get; set; }
  public new double vspace { get; set; }
  public new string width { get; set; }
  public new object start();
  public new object stop();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMediaElementEventMap : HTMLElementEventMap  {
  public new object encrypted { get; set; }
  public new object waitingforkey { get; set; }
}

public partial interface HTMLMediaElement : HTMLElement  {
  public new bool autoplay { get; set; }
  public new object buffered { get; }
  public new bool controls { get; set; }
  public new object crossOrigin { get; set; }
  public new string currentSrc { get; }
  public new double currentTime { get; set; }
  public new bool defaultMuted { get; set; }
  public new double defaultPlaybackRate { get; set; }
  public new bool disableRemotePlayback { get; set; }
  public new double duration { get; }
  public new bool ended { get; }
  public new object error { get; }
  public new bool loop { get; set; }
  public new object mediaKeys { get; }
  public new bool muted { get; set; }
  public new double networkState { get; }
  public new object onencrypted { get; set; }
  public new object onwaitingforkey { get; set; }
  public new bool paused { get; }
  public new double playbackRate { get; set; }
  public new object played { get; }
  public new object preload { get; set; }
  public new bool preservesPitch { get; set; }
  public new double readyState { get; }
  public new object remote { get; }
  public new object seekable { get; }
  public new bool seeking { get; }
  public new string src { get; set; }
  public new object srcObject { get; set; }
  public new object textTracks { get; }
  public new double volume { get; set; }
  public new object addTextTrack(object kind, string label, string language);
  public new object canPlayType(string type);
  public new object fastSeek(double time);
  public new object load();
  public new object pause();
  public new object play();
  public new object setMediaKeys(object mediaKeys);
  public new object NETWORK_EMPTY { get; }
  public new object NETWORK_IDLE { get; }
  public new object NETWORK_LOADING { get; }
  public new object NETWORK_NO_SOURCE { get; }
  public new object HAVE_NOTHING { get; }
  public new object HAVE_METADATA { get; }
  public new object HAVE_CURRENT_DATA { get; }
  public new object HAVE_FUTURE_DATA { get; }
  public new object HAVE_ENOUGH_DATA { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMenuElement : HTMLElement  {
  public new bool compact { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMetaElement : HTMLElement  {
  public new string content { get; set; }
  public new string httpEquiv { get; set; }
  public new string media { get; set; }
  public new string name { get; set; }
  public new string scheme { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLMeterElement : HTMLElement  {
  public new double high { get; set; }
  public new object labels { get; }
  public new double low { get; set; }
  public new double max { get; set; }
  public new double min { get; set; }
  public new double optimum { get; set; }
  public new double value { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLModElement : HTMLElement  {
  public new string cite { get; set; }
  public new string dateTime { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLOListElement : HTMLElement  {
  public new bool compact { get; set; }
  public new bool reversed { get; set; }
  public new double start { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLObjectElement : HTMLElement  {
  public new string align { get; set; }
  public new string archive { get; set; }
  public new string border { get; set; }
  public new string code { get; set; }
  public new string codeBase { get; set; }
  public new string codeType { get; set; }
  public new object contentDocument { get; }
  public new object contentWindow { get; }
  public new string data { get; set; }
  public new bool declare { get; set; }
  public new object form { get; }
  public new string height { get; set; }
  public new double hspace { get; set; }
  public new string name { get; set; }
  public new string standby { get; set; }
  public new string type { get; set; }
  public new string useMap { get; set; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new double vspace { get; set; }
  public new string width { get; set; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new object getSVGDocument();
  public new bool reportValidity();
  public new object setCustomValidity(string error);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLOptGroupElement : HTMLElement  {
  public new bool disabled { get; set; }
  public new string label { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLOptionElement : HTMLElement  {
  public new bool defaultSelected { get; set; }
  public new bool disabled { get; set; }
  public new object form { get; }
  public new double index { get; }
  public new string label { get; set; }
  public new bool selected { get; set; }
  public new string text { get; set; }
  public new string value { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLOptionsCollection : HTMLCollectionOf  {
  public new double length { get; set; }
  public new double selectedIndex { get; set; }
  public new object add(object element, object before);
  public new object remove(double index);
}

public partial interface HTMLOrSVGElement  {
  public new bool autofocus { get; set; }
  public new object dataset { get; }
  public new string nonce { get; set; }
  public new double tabIndex { get; set; }
  public new object blur();
  public new object focus(object options);
}

public partial interface HTMLOutputElement : HTMLElement  {
  public new string defaultValue { get; set; }
  public new object form { get; }
  public new object htmlFor { get; }
  public new object labels { get; }
  public new string name { get; set; }
  public new string type { get; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new string value { get; set; }
  public new bool willValidate { get; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object setCustomValidity(string error);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLParagraphElement : HTMLElement  {
  public new string align { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLParamElement : HTMLElement  {
  public new string name { get; set; }
  public new string type { get; set; }
  public new string value { get; set; }
  public new string valueType { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLPictureElement : HTMLElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLPreElement : HTMLElement  {
  public new double width { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLProgressElement : HTMLElement  {
  public new object labels { get; }
  public new double max { get; set; }
  public new double position { get; }
  public new double value { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLQuoteElement : HTMLElement  {
  public new string cite { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLScriptElement : HTMLElement  {
  public new bool async { get; set; }
  public new string charset { get; set; }
  public new object crossOrigin { get; set; }
  public new bool defer { get; set; }
  public new string eventProperty { get; set; }
  public new string htmlFor { get; set; }
  public new string integrity { get; set; }
  public new bool noModule { get; set; }
  public new string referrerPolicy { get; set; }
  public new string src { get; set; }
  public new string text { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLSelectElement : HTMLElement  {
  public new object autocomplete { get; set; }
  public new bool disabled { get; set; }
  public new object form { get; }
  public new object labels { get; }
  public new double length { get; set; }
  public new bool multiple { get; set; }
  public new string name { get; set; }
  public new object options { get; }
  public new bool required { get; set; }
  public new double selectedIndex { get; set; }
  public new object selectedOptions { get; }
  public new double size { get; set; }
  public new string type { get; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new string value { get; set; }
  public new bool willValidate { get; }
  public new object add(object element, object before);
  public new bool checkValidity();
  public new object item(double index);
  public new object namedItem(string name);
  public new object remove();
  public new object remove(double index);
  public new bool reportValidity();
  public new object setCustomValidity(string error);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  // TODO: Unsupported member: undefined
}

public partial interface HTMLSlotElement : HTMLElement  {
  public new string name { get; set; }
  public new object assign(object nodes);
  public new object assignedElements(object options);
  public new object assignedNodes(object options);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLSourceElement : HTMLElement  {
  public new double height { get; set; }
  public new string media { get; set; }
  public new string sizes { get; set; }
  public new string src { get; set; }
  public new string srcset { get; set; }
  public new string type { get; set; }
  public new double width { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLSpanElement : HTMLElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLStyleElement : HTMLElement, LinkStyle  {
  public new bool disabled { get; set; }
  public new string media { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableCaptionElement : HTMLElement  {
  public new string align { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableCellElement : HTMLElement  {
  public new string abbr { get; set; }
  public new string align { get; set; }
  public new string axis { get; set; }
  public new string bgColor { get; set; }
  public new double cellIndex { get; }
  public new string ch { get; set; }
  public new string chOff { get; set; }
  public new double colSpan { get; set; }
  public new string headers { get; set; }
  public new string height { get; set; }
  public new bool noWrap { get; set; }
  public new double rowSpan { get; set; }
  public new string scope { get; set; }
  public new string vAlign { get; set; }
  public new string width { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableColElement : HTMLElement  {
  public new string align { get; set; }
  public new string ch { get; set; }
  public new string chOff { get; set; }
  public new double span { get; set; }
  public new string vAlign { get; set; }
  public new string width { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableDataCellElement : HTMLTableCellElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableElement : HTMLElement  {
  public new string align { get; set; }
  public new string bgColor { get; set; }
  public new string border { get; set; }
  public new object caption { get; set; }
  public new string cellPadding { get; set; }
  public new string cellSpacing { get; set; }
  public new string frame { get; set; }
  public new object rows { get; }
  public new string rules { get; set; }
  public new string summary { get; set; }
  public new object tBodies { get; }
  public new object tFoot { get; set; }
  public new object tHead { get; set; }
  public new string width { get; set; }
  public new object createCaption();
  public new object createTBody();
  public new object createTFoot();
  public new object createTHead();
  public new object deleteCaption();
  public new object deleteRow(double index);
  public new object deleteTFoot();
  public new object deleteTHead();
  public new object insertRow(double index);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableHeaderCellElement : HTMLTableCellElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableRowElement : HTMLElement  {
  public new string align { get; set; }
  public new string bgColor { get; set; }
  public new object cells { get; }
  public new string ch { get; set; }
  public new string chOff { get; set; }
  public new double rowIndex { get; }
  public new double sectionRowIndex { get; }
  public new string vAlign { get; set; }
  public new object deleteCell(double index);
  public new object insertCell(double index);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTableSectionElement : HTMLElement  {
  public new string align { get; set; }
  public new string ch { get; set; }
  public new string chOff { get; set; }
  public new object rows { get; }
  public new string vAlign { get; set; }
  public new object deleteRow(double index);
  public new object insertRow(double index);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTemplateElement : HTMLElement  {
  public new object content { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTextAreaElement : HTMLElement  {
  public new object autocomplete { get; set; }
  public new double cols { get; set; }
  public new string defaultValue { get; set; }
  public new string dirName { get; set; }
  public new bool disabled { get; set; }
  public new object form { get; }
  public new object labels { get; }
  public new double maxLength { get; set; }
  public new double minLength { get; set; }
  public new string name { get; set; }
  public new string placeholder { get; set; }
  public new bool readOnly { get; set; }
  public new bool required { get; set; }
  public new double rows { get; set; }
  public new object selectionDirection { get; set; }
  public new double selectionEnd { get; set; }
  public new double selectionStart { get; set; }
  public new double textLength { get; }
  public new string type { get; }
  public new string validationMessage { get; }
  public new object validity { get; }
  public new string value { get; set; }
  public new bool willValidate { get; }
  public new string wrap { get; set; }
  public new bool checkValidity();
  public new bool reportValidity();
  public new object select();
  public new object setCustomValidity(string error);
  public new object setRangeText(string replacement);
  public new object setRangeText(string replacement, double start, double end, object selectionMode);
  public new object setSelectionRange(object start, object end, object direction);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTimeElement : HTMLElement  {
  public new string dateTime { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTitleElement : HTMLElement  {
  public new string text { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLTrackElement : HTMLElement  {
  public new bool defaultProperty { get; set; }
  public new string kind { get; set; }
  public new string label { get; set; }
  public new double readyState { get; }
  public new string src { get; set; }
  public new string srclang { get; set; }
  public new object track { get; }
  public new object NONE { get; }
  public new object LOADING { get; }
  public new object LOADED { get; }
  public new object ERROR { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLUListElement : HTMLElement  {
  public new bool compact { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLUnknownElement : HTMLElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HTMLVideoElementEventMap : HTMLMediaElementEventMap  {
  public new object enterpictureinpicture { get; set; }
  public new object leavepictureinpicture { get; set; }
}

public partial interface HTMLVideoElement : HTMLMediaElement  {
  public new bool disablePictureInPicture { get; set; }
  public new double height { get; set; }
  public new object onenterpictureinpicture { get; set; }
  public new object onleavepictureinpicture { get; set; }
  public new bool playsInline { get; set; }
  public new string poster { get; set; }
  public new double videoHeight { get; }
  public new double videoWidth { get; }
  public new double width { get; set; }
  public new object cancelVideoFrameCallback(double handle);
  public new object getVideoPlaybackQuality();
  public new object requestPictureInPicture();
  public new double requestVideoFrameCallback(object callback);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface HashChangeEvent : Event  {
  public new string newURL { get; }
  public new string oldURL { get; }
}

public partial interface Headers  {
  public new object append(string name, string value);
  public new object delete(string name);
  public new object get(string name);
  public new object getSetCookie();
  public new bool has(string name);
  public new object set(string name, string value);
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface History  {
  public new double length { get; }
  public new object scrollRestoration { get; set; }
  public new object state { get; }
  public new object back();
  public new object forward();
  public new object go(double delta);
  public new object pushState(object data, string unused, object url);
  public new object replaceState(object data, string unused, object url);
}

public partial interface IDBCursor  {
  public new object direction { get; }
  public new object key { get; }
  public new object primaryKey { get; }
  public new object request { get; }
  public new object source { get; }
  public new object advance(double count);
  public new object continue(object key);
  public new object continuePrimaryKey(object key, object primaryKey);
  public new object delete();
  public new object update(object value);
}

public partial interface IDBCursorWithValue : IDBCursor  {
  public new object value { get; }
}

public partial interface IDBDatabaseEventMap  {
  public new object abort { get; set; }
  public new object close { get; set; }
  public new object error { get; set; }
  public new object versionchange { get; set; }
}

public partial interface IDBDatabase : EventTarget  {
  public new string name { get; }
  public new object objectStoreNames { get; }
  public new object onabort { get; set; }
  public new object onclose { get; set; }
  public new object onerror { get; set; }
  public new object onversionchange { get; set; }
  public new double version { get; }
  public new object close();
  public new object createObjectStore(string name, object options);
  public new object deleteObjectStore(string name);
  public new object transaction(object storeNames, object mode, object options);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface IDBFactory  {
  public new double cmp(object first, object second);
  public new object databases();
  public new object deleteDatabase(string name);
  public new object open(string name, double version);
}

public partial interface IDBIndex  {
  public new object keyPath { get; }
  public new bool multiEntry { get; }
  public new string name { get; set; }
  public new object objectStore { get; }
  public new bool unique { get; }
  public new object count(object query);
  public new object get(object query);
  public new object getAll(object query, double count);
  public new object getAllKeys(object query, double count);
  public new object getKey(object query);
  public new object openCursor(object query, object direction);
  public new object openKeyCursor(object query, object direction);
}

public partial interface IDBKeyRange  {
  public new object lower { get; }
  public new bool lowerOpen { get; }
  public new object upper { get; }
  public new bool upperOpen { get; }
  public new bool includes(object key);
}

public partial interface IDBObjectStore  {
  public new bool autoIncrement { get; }
  public new object indexNames { get; }
  public new object keyPath { get; }
  public new string name { get; set; }
  public new object transaction { get; }
  public new object add(object value, object key);
  public new object clear();
  public new object count(object query);
  public new object createIndex(string name, object keyPath, object options);
  public new object delete(object query);
  public new object deleteIndex(string name);
  public new object get(object query);
  public new object getAll(object query, double count);
  public new object getAllKeys(object query, double count);
  public new object getKey(object query);
  public new object index(string name);
  public new object openCursor(object query, object direction);
  public new object openKeyCursor(object query, object direction);
  public new object put(object value, object key);
}

public partial interface IDBOpenDBRequestEventMap : IDBRequestEventMap  {
  public new object blocked { get; set; }
  public new object upgradeneeded { get; set; }
}

public partial interface IDBOpenDBRequest : IDBRequest  {
  public new object onblocked { get; set; }
  public new object onupgradeneeded { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface IDBRequestEventMap  {
  public new object error { get; set; }
  public new object success { get; set; }
}

public partial interface IDBRequest : EventTarget  {
  public new object error { get; }
  public new object onerror { get; set; }
  public new object onsuccess { get; set; }
  public new object readyState { get; }
  public new object result { get; }
  public new object source { get; }
  public new object transaction { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface IDBTransactionEventMap  {
  public new object abort { get; set; }
  public new object complete { get; set; }
  public new object error { get; set; }
}

public partial interface IDBTransaction : EventTarget  {
  public new object db { get; }
  public new object durability { get; }
  public new object error { get; }
  public new object mode { get; }
  public new object objectStoreNames { get; }
  public new object onabort { get; set; }
  public new object oncomplete { get; set; }
  public new object onerror { get; set; }
  public new object abort();
  public new object commit();
  public new object objectStore(string name);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface IDBVersionChangeEvent : Event  {
  public new object newVersion { get; }
  public new double oldVersion { get; }
}

public partial interface IIRFilterNode : AudioNode  {
  public new object getFrequencyResponse(object frequencyHz, object magResponse, object phaseResponse);
}

public partial interface IdleDeadline  {
  public new bool didTimeout { get; }
  public new object timeRemaining();
}

public partial interface ImageBitmap  {
  public new double height { get; }
  public new double width { get; }
  public new object close();
}

public partial interface ImageBitmapRenderingContext  {
  public new object canvas { get; }
  public new object transferFromImageBitmap(object bitmap);
}

public partial interface ImageData  {
  public new object colorSpace { get; }
  public new object data { get; }
  public new double height { get; }
  public new double width { get; }
}

public partial interface InnerHTML  {
  public new string innerHTML { get; set; }
}

public partial interface InputDeviceInfo : MediaDeviceInfo  {
  public new object getCapabilities();
}

public partial interface InputEvent : UIEvent  {
  public new object data { get; }
  public new object dataTransfer { get; }
  public new string inputType { get; }
  public new bool isComposing { get; }
  public new object getTargetRanges();
}

public partial interface IntersectionObserver  {
  public new object root { get; }
  public new string rootMargin { get; }
  public new object thresholds { get; }
  public new object disconnect();
  public new object observe(object target);
  public new object takeRecords();
  public new object unobserve(object target);
}

public partial interface IntersectionObserverEntry  {
  public new object boundingClientRect { get; }
  public new double intersectionRatio { get; }
  public new object intersectionRect { get; }
  public new bool isIntersecting { get; }
  public new object rootBounds { get; }
  public new object target { get; }
  public new object time { get; }
}

public partial interface KHR_parallel_shader_compile  {
  public new object COMPLETION_STATUS_KHR { get; }
}

public partial interface KeyboardEvent : UIEvent  {
  public new bool altKey { get; }
  public new double charCode { get; }
  public new string code { get; }
  public new bool ctrlKey { get; }
  public new bool isComposing { get; }
  public new string key { get; }
  public new double keyCode { get; }
  public new double location { get; }
  public new bool metaKey { get; }
  public new bool repeat { get; }
  public new bool shiftKey { get; }
  public new bool getModifierState(string keyArg);
  public new object initKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, object viewArg, string keyArg, double locationArg, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey);
  public new object DOM_KEY_LOCATION_STANDARD { get; }
  public new object DOM_KEY_LOCATION_LEFT { get; }
  public new object DOM_KEY_LOCATION_RIGHT { get; }
  public new object DOM_KEY_LOCATION_NUMPAD { get; }
}

public partial interface KeyframeEffect : AnimationEffect  {
  public new object composite { get; set; }
  public new object iterationComposite { get; set; }
  public new object pseudoElement { get; set; }
  public new object target { get; set; }
  public new object getKeyframes();
  public new object setKeyframes(object keyframes);
}

public partial interface LinkStyle  {
  public new object sheet { get; }
}

public partial interface Location  {
  public new object ancestorOrigins { get; }
  public new string hash { get; set; }
  public new string host { get; set; }
  public new string hostname { get; set; }
  public new string href { get; set; }
  public new string toStringMethod();
  public new string origin { get; }
  public new string pathname { get; set; }
  public new string port { get; set; }
  public new string protocol { get; set; }
  public new string search { get; set; }
  public new object assign(object url);
  public new object reload();
  public new object replace(object url);
}

public partial interface Lock  {
  public new object mode { get; }
  public new string name { get; }
}

public partial interface LockManager  {
  public new object query();
  public new object request(string name, object callback);
  public new object request(string name, object options, object callback);
}

public partial interface MIDIAccessEventMap  {
  public new object statechange { get; set; }
}

public partial interface MIDIAccess : EventTarget  {
  public new object inputs { get; }
  public new object onstatechange { get; set; }
  public new object outputs { get; }
  public new bool sysexEnabled { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MIDIConnectionEvent : Event  {
  public new object port { get; }
}

public partial interface MIDIInputEventMap : MIDIPortEventMap  {
  public new object midimessage { get; set; }
}

public partial interface MIDIInput : MIDIPort  {
  public new object onmidimessage { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MIDIInputMap  {
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface MIDIMessageEvent : Event  {
  public new object data { get; }
}

public partial interface MIDIOutput : MIDIPort  {
  public new object send(object data, object timestamp);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MIDIOutputMap  {
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface MIDIPortEventMap  {
  public new object statechange { get; set; }
}

public partial interface MIDIPort : EventTarget  {
  public new object connection { get; }
  public new string id { get; }
  public new object manufacturer { get; }
  public new object name { get; }
  public new object onstatechange { get; set; }
  public new object state { get; }
  public new object type { get; }
  public new object version { get; }
  public new object close();
  public new object open();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MathMLElementEventMap : ElementEventMap, GlobalEventHandlersEventMap  {}

public partial interface MathMLElement : Element, ElementCSSInlineStyle, GlobalEventHandlers, HTMLOrSVGElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaCapabilities  {
  public new object decodingInfo(object configuration);
  public new object encodingInfo(object configuration);
}

public partial interface MediaDeviceInfo  {
  public new string deviceId { get; }
  public new string groupId { get; }
  public new object kind { get; }
  public new string label { get; }
  public new object toJSON();
}

public partial interface MediaDevicesEventMap  {
  public new object devicechange { get; set; }
}

public partial interface MediaDevices : EventTarget  {
  public new object ondevicechange { get; set; }
  public new object enumerateDevices();
  public new object getDisplayMedia(object options);
  public new object getSupportedConstraints();
  public new object getUserMedia(object constraints);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaElementAudioSourceNode : AudioNode  {
  public new object mediaElement { get; }
}

public partial interface MediaEncryptedEvent : Event  {
  public new object initData { get; }
  public new string initDataType { get; }
}

public partial interface MediaError  {
  public new double code { get; }
  public new string message { get; }
  public new object MEDIA_ERR_ABORTED { get; }
  public new object MEDIA_ERR_NETWORK { get; }
  public new object MEDIA_ERR_DECODE { get; }
  public new object MEDIA_ERR_SRC_NOT_SUPPORTED { get; }
}

public partial interface MediaKeyMessageEvent : Event  {
  public new object message { get; }
  public new object messageType { get; }
}

public partial interface MediaKeySessionEventMap  {
  public new object keystatuseschange { get; set; }
  public new object message { get; set; }
}

public partial interface MediaKeySession : EventTarget  {
  public new object closed { get; }
  public new double expiration { get; }
  public new object keyStatuses { get; }
  public new object onkeystatuseschange { get; set; }
  public new object onmessage { get; set; }
  public new string sessionId { get; }
  public new object close();
  public new object generateRequest(string initDataType, object initData);
  public new object load(string sessionId);
  public new object remove();
  public new object update(object response);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaKeyStatusMap  {
  public new double size { get; }
  public new object get(object keyId);
  public new bool has(object keyId);
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface MediaKeySystemAccess  {
  public new string keySystem { get; }
  public new object createMediaKeys();
  public new object getConfiguration();
}

public partial interface MediaKeys  {
  public new object createSession(object sessionType);
  public new object setServerCertificate(object serverCertificate);
}

public partial interface MediaList  {
  public new double length { get; }
  public new string mediaText { get; set; }
  public new string toStringMethod();
  public new object appendMedium(string medium);
  public new object deleteMedium(string medium);
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface MediaMetadata  {
  public new string album { get; set; }
  public new string artist { get; set; }
  public new object artwork { get; set; }
  public new string title { get; set; }
}

public partial interface MediaQueryListEventMap  {
  public new object change { get; set; }
}

public partial interface MediaQueryList : EventTarget  {
  public new bool matches { get; }
  public new string media { get; }
  public new object onchange { get; set; }
  public new object addListener(object callback);
  public new object removeListener(object callback);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaQueryListEvent : Event  {
  public new bool matches { get; }
  public new string media { get; }
}

public partial interface MediaRecorderEventMap  {
  public new object dataavailable { get; set; }
  public new object error { get; set; }
  public new object pause { get; set; }
  public new object resume { get; set; }
  public new object start { get; set; }
  public new object stop { get; set; }
}

public partial interface MediaRecorder : EventTarget  {
  public new double audioBitsPerSecond { get; }
  public new string mimeType { get; }
  public new object ondataavailable { get; set; }
  public new object onerror { get; set; }
  public new object onpause { get; set; }
  public new object onresume { get; set; }
  public new object onstart { get; set; }
  public new object onstop { get; set; }
  public new object state { get; }
  public new object stream { get; }
  public new double videoBitsPerSecond { get; }
  public new object pause();
  public new object requestData();
  public new object resume();
  public new object start(double timeslice);
  public new object stop();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaSession  {
  public new object metadata { get; set; }
  public new object playbackState { get; set; }
  public new object setActionHandler(object action, object handler);
  public new object setPositionState(object state);
}

public partial interface MediaSourceEventMap  {
  public new object sourceclose { get; set; }
  public new object sourceended { get; set; }
  public new object sourceopen { get; set; }
}

public partial interface MediaSource : EventTarget  {
  public new object activeSourceBuffers { get; }
  public new double duration { get; set; }
  public new object onsourceclose { get; set; }
  public new object onsourceended { get; set; }
  public new object onsourceopen { get; set; }
  public new object readyState { get; }
  public new object sourceBuffers { get; }
  public new object addSourceBuffer(string type);
  public new object clearLiveSeekableRange();
  public new object endOfStream(object error);
  public new object removeSourceBuffer(object sourceBuffer);
  public new object setLiveSeekableRange(double start, double end);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaStreamEventMap  {
  public new object addtrack { get; set; }
  public new object removetrack { get; set; }
}

public partial interface MediaStream : EventTarget  {
  public new bool active { get; }
  public new string id { get; }
  public new object onaddtrack { get; set; }
  public new object onremovetrack { get; set; }
  public new object addTrack(object track);
  public new object clone();
  public new object getAudioTracks();
  public new object getTrackById(string trackId);
  public new object getTracks();
  public new object getVideoTracks();
  public new object removeTrack(object track);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaStreamAudioDestinationNode : AudioNode  {
  public new object stream { get; }
}

public partial interface MediaStreamAudioSourceNode : AudioNode  {
  public new object mediaStream { get; }
}

public partial interface MediaStreamTrackEventMap  {
  public new object ended { get; set; }
  public new object mute { get; set; }
  public new object unmute { get; set; }
}

public partial interface MediaStreamTrack : EventTarget  {
  public new string contentHint { get; set; }
  public new bool enabled { get; set; }
  public new string id { get; }
  public new string kind { get; }
  public new string label { get; }
  public new bool muted { get; }
  public new object onended { get; set; }
  public new object onmute { get; set; }
  public new object onunmute { get; set; }
  public new object readyState { get; }
  public new object applyConstraints(object constraints);
  public new object clone();
  public new object getCapabilities();
  public new object getConstraints();
  public new object getSettings();
  public new object stop();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MediaStreamTrackEvent : Event  {
  public new object track { get; }
}

public partial interface MessageChannel  {
  public new object port1 { get; }
  public new object port2 { get; }
}

public partial interface MessageEvent : Event  {
  public new object data { get; }
  public new string lastEventId { get; }
  public new string origin { get; }
  public new object ports { get; }
  public new object source { get; }
  public new object initMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId, object source, object ports);
}

public partial interface MessagePortEventMap  {
  public new object message { get; set; }
  public new object messageerror { get; set; }
}

public partial interface MessagePort : EventTarget  {
  public new object onmessage { get; set; }
  public new object onmessageerror { get; set; }
  public new object close();
  public new object postMessage(object message, object transfer);
  public new object postMessage(object message, object options);
  public new object start();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface MimeType  {
  public new string description { get; }
  public new object enabledPlugin { get; }
  public new string suffixes { get; }
  public new string type { get; }
}

public partial interface MimeTypeArray  {
  public new double length { get; }
  public new object item(double index);
  public new object namedItem(string name);
  // TODO: Unsupported member: undefined
}

public partial interface MouseEvent : UIEvent  {
  public new bool altKey { get; }
  public new double button { get; }
  public new double buttons { get; }
  public new double clientX { get; }
  public new double clientY { get; }
  public new bool ctrlKey { get; }
  public new bool metaKey { get; }
  public new double movementX { get; }
  public new double movementY { get; }
  public new double offsetX { get; }
  public new double offsetY { get; }
  public new double pageX { get; }
  public new double pageY { get; }
  public new object relatedTarget { get; }
  public new double screenX { get; }
  public new double screenY { get; }
  public new bool shiftKey { get; }
  public new double x { get; }
  public new double y { get; }
  public new bool getModifierState(string keyArg);
  public new object initMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, double buttonArg, object relatedTargetArg);
}

public partial interface MutationEvent : Event  {
  public new double attrChange { get; }
  public new string attrName { get; }
  public new string newValue { get; }
  public new string prevValue { get; }
  public new object relatedNode { get; }
  public new object initMutationEvent(string typeArg, bool bubblesArg, bool cancelableArg, object relatedNodeArg, string prevValueArg, string newValueArg, string attrNameArg, double attrChangeArg);
  public new object MODIFICATION { get; }
  public new object ADDITION { get; }
  public new object REMOVAL { get; }
}

public partial interface MutationObserver  {
  public new object disconnect();
  public new object observe(object target, object options);
  public new object takeRecords();
}

public partial interface MutationRecord  {
  public new object addedNodes { get; }
  public new object attributeName { get; }
  public new object attributeNamespace { get; }
  public new object nextSibling { get; }
  public new object oldValue { get; }
  public new object previousSibling { get; }
  public new object removedNodes { get; }
  public new object target { get; }
  public new object type { get; }
}

public partial interface NamedNodeMap  {
  public new double length { get; }
  public new object getNamedItem(string qualifiedName);
  public new object getNamedItemNS(object namespace, string localName);
  public new object item(double index);
  public new object removeNamedItem(string qualifiedName);
  public new object removeNamedItemNS(object namespace, string localName);
  public new object setNamedItem(object attr);
  public new object setNamedItemNS(object attr);
  // TODO: Unsupported member: undefined
}

public partial interface NavigationPreloadManager  {
  public new object disable();
  public new object enable();
  public new object getState();
  public new object setHeaderValue(string value);
}

public partial interface Navigator : NavigatorAutomationInformation, NavigatorBadge, NavigatorConcurrentHardware, NavigatorContentUtils, NavigatorCookies, NavigatorID, NavigatorLanguage, NavigatorLocks, NavigatorOnLine, NavigatorPlugins, NavigatorStorage  {
  public new object clipboard { get; }
  public new object credentials { get; }
  public new object doNotTrack { get; }
  public new object geolocation { get; }
  public new double maxTouchPoints { get; }
  public new object mediaCapabilities { get; }
  public new object mediaDevices { get; }
  public new object mediaSession { get; }
  public new object permissions { get; }
  public new object serviceWorker { get; }
  public new object userActivation { get; }
  public new object wakeLock { get; }
  public new bool canShare(object data);
  public new object getGamepads();
  public new object requestMIDIAccess(object options);
  public new object requestMediaKeySystemAccess(string keySystem, object supportedConfigurations);
  public new bool sendBeacon(object url, object data);
  public new object share(object data);
  public new bool vibrate(object pattern);
}

public partial interface NavigatorAutomationInformation  {
  public new bool webdriver { get; }
}

public partial interface NavigatorBadge  {
  public new object clearAppBadge();
  public new object setAppBadge(double contents);
}

public partial interface NavigatorConcurrentHardware  {
  public new double hardwareConcurrency { get; }
}

public partial interface NavigatorContentUtils  {
  public new object registerProtocolHandler(string scheme, object url);
}

public partial interface NavigatorCookies  {
  public new bool cookieEnabled { get; }
}

public partial interface NavigatorID  {
  public new string appCodeName { get; }
  public new string appName { get; }
  public new string appVersion { get; }
  public new string platform { get; }
  public new string product { get; }
  public new string productSub { get; }
  public new string userAgent { get; }
  public new string vendor { get; }
  public new string vendorSub { get; }
}

public partial interface NavigatorLanguage  {
  public new string language { get; }
  public new object languages { get; }
}

public partial interface NavigatorLocks  {
  public new object locks { get; }
}

public partial interface NavigatorOnLine  {
  public new bool onLine { get; }
}

public partial interface NavigatorPlugins  {
  public new object mimeTypes { get; }
  public new bool pdfViewerEnabled { get; }
  public new object plugins { get; }
  public new bool javaEnabled();
}

public partial interface NavigatorStorage  {
  public new object storage { get; }
}

public partial interface Node : EventTarget  {
  public new string baseURI { get; }
  public new object childNodes { get; }
  public new object firstChild { get; }
  public new bool isConnected { get; }
  public new object lastChild { get; }
  public new object nextSibling { get; }
  public new string nodeName { get; }
  public new double nodeType { get; }
  public new object nodeValue { get; set; }
  public new object ownerDocument { get; }
  public new object parentElement { get; }
  public new object parentNode { get; }
  public new object previousSibling { get; }
  public new object textContent { get; set; }
  public new object appendChild(object node);
  public new object cloneNode(bool deep);
  public new double compareDocumentPosition(object other);
  public new bool contains(object other);
  public new object getRootNode(object options);
  public new bool hasChildNodes();
  public new object insertBefore(object node, object child);
  public new bool isDefaultNamespace(object namespace);
  public new bool isEqualNode(object otherNode);
  public new bool isSameNode(object otherNode);
  public new object lookupNamespaceURI(object prefix);
  public new object lookupPrefix(object namespace);
  public new object normalize();
  public new object removeChild(object child);
  public new object replaceChild(object node, object child);
  public new object ELEMENT_NODE { get; }
  public new object ATTRIBUTE_NODE { get; }
  public new object TEXT_NODE { get; }
  public new object CDATA_SECTION_NODE { get; }
  public new object ENTITY_REFERENCE_NODE { get; }
  public new object ENTITY_NODE { get; }
  public new object PROCESSING_INSTRUCTION_NODE { get; }
  public new object COMMENT_NODE { get; }
  public new object DOCUMENT_NODE { get; }
  public new object DOCUMENT_TYPE_NODE { get; }
  public new object DOCUMENT_FRAGMENT_NODE { get; }
  public new object NOTATION_NODE { get; }
  public new object DOCUMENT_POSITION_DISCONNECTED { get; }
  public new object DOCUMENT_POSITION_PRECEDING { get; }
  public new object DOCUMENT_POSITION_FOLLOWING { get; }
  public new object DOCUMENT_POSITION_CONTAINS { get; }
  public new object DOCUMENT_POSITION_CONTAINED_BY { get; }
  public new object DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC { get; }
}

public partial interface NodeIterator  {
  public new object filter { get; }
  public new bool pointerBeforeReferenceNode { get; }
  public new object referenceNode { get; }
  public new object root { get; }
  public new double whatToShow { get; }
  public new object detach();
  public new object nextNode();
  public new object previousNode();
}

public partial interface NodeList  {
  public new double length { get; }
  public new object item(double index);
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface NodeListOf : NodeList  {
  public new object item(double index);
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface NonDocumentTypeChildNode  {
  public new object nextElementSibling { get; }
  public new object previousElementSibling { get; }
}

public partial interface NonElementParentNode  {
  public new object getElementById(string elementId);
}

public partial interface NotificationEventMap  {
  public new object click { get; set; }
  public new object close { get; set; }
  public new object error { get; set; }
  public new object show { get; set; }
}

public partial interface Notification : EventTarget  {
  public new string body { get; }
  public new object data { get; }
  public new object dir { get; }
  public new string icon { get; }
  public new string lang { get; }
  public new object onclick { get; set; }
  public new object onclose { get; set; }
  public new object onerror { get; set; }
  public new object onshow { get; set; }
  public new object silent { get; }
  public new string tag { get; }
  public new string title { get; }
  public new object close();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface OES_draw_buffers_indexed  {
  public new object blendEquationSeparateiOES(object buf, object modeRGB, object modeAlpha);
  public new object blendEquationiOES(object buf, object mode);
  public new object blendFuncSeparateiOES(object buf, object srcRGB, object dstRGB, object srcAlpha, object dstAlpha);
  public new object blendFunciOES(object buf, object src, object dst);
  public new object colorMaskiOES(object buf, object r, object g, object b, object a);
  public new object disableiOES(object target, object index);
  public new object enableiOES(object target, object index);
}

public partial interface OES_element_index_uint  {}

public partial interface OES_fbo_render_mipmap  {}

public partial interface OES_standard_derivatives  {
  public new object FRAGMENT_SHADER_DERIVATIVE_HINT_OES { get; }
}

public partial interface OES_texture_float  {}

public partial interface OES_texture_float_linear  {}

public partial interface OES_texture_half_float  {
  public new object HALF_FLOAT_OES { get; }
}

public partial interface OES_texture_half_float_linear  {}

public partial interface OES_vertex_array_object  {
  public new object bindVertexArrayOES(object arrayObject);
  public new object createVertexArrayOES();
  public new object deleteVertexArrayOES(object arrayObject);
  public new object isVertexArrayOES(object arrayObject);
  public new object VERTEX_ARRAY_BINDING_OES { get; }
}

public partial interface OVR_multiview2  {
  public new object framebufferTextureMultiviewOVR(object target, object attachment, object texture, object level, object baseViewIndex, object numViews);
  public new object FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR { get; }
  public new object FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR { get; }
  public new object MAX_VIEWS_OVR { get; }
  public new object FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR { get; }
}

public partial interface OfflineAudioCompletionEvent : Event  {
  public new object renderedBuffer { get; }
}

public partial interface OfflineAudioContextEventMap : BaseAudioContextEventMap  {
  public new object complete { get; set; }
}

public partial interface OfflineAudioContext : BaseAudioContext  {
  public new double length { get; }
  public new object oncomplete { get; set; }
  public new object resume();
  public new object startRendering();
  public new object suspend(double suspendTime);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface OffscreenCanvasEventMap  {
  public new object contextlost { get; set; }
  public new object contextrestored { get; set; }
}

public partial interface OffscreenCanvas : EventTarget  {
  public new double height { get; set; }
  public new object oncontextlost { get; set; }
  public new object oncontextrestored { get; set; }
  public new double width { get; set; }
  public new object convertToBlob(object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object getContext(object contextId, object options);
  public new object transferToImageBitmap();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface OffscreenCanvasRenderingContext2D : CanvasCompositing, CanvasDrawImage, CanvasDrawPath, CanvasFillStrokeStyles, CanvasFilters, CanvasImageData, CanvasImageSmoothing, CanvasPath, CanvasPathDrawingStyles, CanvasRect, CanvasShadowStyles, CanvasState, CanvasText, CanvasTextDrawingStyles, CanvasTransform  {
  public new object canvas { get; }
  public new object commit();
}

public partial interface OscillatorNode : AudioScheduledSourceNode  {
  public new object detune { get; }
  public new object frequency { get; }
  public new object type { get; set; }
  public new object setPeriodicWave(object periodicWave);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface OverconstrainedError : Error  {
  public new string constraint { get; }
}

public partial interface PageTransitionEvent : Event  {
  public new bool persisted { get; }
}

public partial interface PannerNode : AudioNode  {
  public new double coneInnerAngle { get; set; }
  public new double coneOuterAngle { get; set; }
  public new double coneOuterGain { get; set; }
  public new object distanceModel { get; set; }
  public new double maxDistance { get; set; }
  public new object orientationX { get; }
  public new object orientationY { get; }
  public new object orientationZ { get; }
  public new object panningModel { get; set; }
  public new object positionX { get; }
  public new object positionY { get; }
  public new object positionZ { get; }
  public new double refDistance { get; set; }
  public new double rolloffFactor { get; set; }
  public new object setOrientation(double x, double y, double z);
  public new object setPosition(double x, double y, double z);
}

public partial interface ParentNode : Node  {
  public new double childElementCount { get; }
  public new object children { get; }
  public new object firstElementChild { get; }
  public new object lastElementChild { get; }
  public new object append(object nodes);
  public new object prepend(object nodes);
  public new object querySelector(object selectors);
  public new object querySelector(object selectors);
  public new object querySelector(object selectors);
  public new object querySelector(object selectors);
  public new object querySelector(string selectors);
  public new object querySelectorAll(object selectors);
  public new object querySelectorAll(object selectors);
  public new object querySelectorAll(object selectors);
  public new object querySelectorAll(object selectors);
  public new object querySelectorAll(string selectors);
  public new object replaceChildren(object nodes);
}

public partial interface Path2D : CanvasPath  {
  public new object addPath(object path, object transform);
}

public partial interface PaymentMethodChangeEvent : PaymentRequestUpdateEvent  {
  public new object methodDetails { get; }
  public new string methodName { get; }
}

public partial interface PaymentRequestEventMap  {
  public new object paymentmethodchange { get; set; }
}

public partial interface PaymentRequest : EventTarget  {
  public new string id { get; }
  public new object onpaymentmethodchange { get; set; }
  public new object abort();
  public new object canMakePayment();
  public new object show(object detailsPromise);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface PaymentRequestUpdateEvent : Event  {
  public new object updateWith(object detailsPromise);
}

public partial interface PaymentResponse : EventTarget  {
  public new object details { get; }
  public new string methodName { get; }
  public new string requestId { get; }
  public new object complete(object result);
  public new object retry(object errorFields);
  public new object toJSON();
}

public partial interface PerformanceEventMap  {
  public new object resourcetimingbufferfull { get; set; }
}

public partial interface Performance : EventTarget  {
  public new object eventCounts { get; }
  public new object navigation { get; }
  public new object onresourcetimingbufferfull { get; set; }
  public new object timeOrigin { get; }
  public new object timing { get; }
  public new object clearMarks(string markName);
  public new object clearMeasures(string measureName);
  public new object clearResourceTimings();
  public new object getEntries();
  public new object getEntriesByName(string name, string type);
  public new object getEntriesByType(string type);
  public new object mark(string markName, object markOptions);
  public new object measure(string measureName, object startOrMeasureOptions, string endMark);
  public new object now();
  public new object setResourceTimingBufferSize(double maxSize);
  public new object toJSON();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface PerformanceEntry  {
  public new object duration { get; }
  public new string entryType { get; }
  public new string name { get; }
  public new object startTime { get; }
  public new object toJSON();
}

public partial interface PerformanceEventTiming : PerformanceEntry  {
  public new bool cancelable { get; }
  public new object processingEnd { get; }
  public new object processingStart { get; }
  public new object target { get; }
  public new object toJSON();
}

public partial interface PerformanceMark : PerformanceEntry  {
  public new object detail { get; }
}

public partial interface PerformanceMeasure : PerformanceEntry  {
  public new object detail { get; }
}

public partial interface PerformanceNavigation  {
  public new double redirectCount { get; }
  public new double type { get; }
  public new object toJSON();
  public new object TYPE_NAVIGATE { get; }
  public new object TYPE_RELOAD { get; }
  public new object TYPE_BACK_FORWARD { get; }
  public new object TYPE_RESERVED { get; }
}

public partial interface PerformanceNavigationTiming : PerformanceResourceTiming  {
  public new object domComplete { get; }
  public new object domContentLoadedEventEnd { get; }
  public new object domContentLoadedEventStart { get; }
  public new object domInteractive { get; }
  public new object loadEventEnd { get; }
  public new object loadEventStart { get; }
  public new double redirectCount { get; }
  public new object type { get; }
  public new object unloadEventEnd { get; }
  public new object unloadEventStart { get; }
  public new object toJSON();
}

public partial interface PerformanceObserver  {
  public new object disconnect();
  public new object observe(object options);
  public new object takeRecords();
}

public partial interface PerformanceObserverEntryList  {
  public new object getEntries();
  public new object getEntriesByName(string name, string type);
  public new object getEntriesByType(string type);
}

public partial interface PerformancePaintTiming : PerformanceEntry  {}

public partial interface PerformanceResourceTiming : PerformanceEntry  {
  public new object connectEnd { get; }
  public new object connectStart { get; }
  public new double decodedBodySize { get; }
  public new object domainLookupEnd { get; }
  public new object domainLookupStart { get; }
  public new double encodedBodySize { get; }
  public new object fetchStart { get; }
  public new string initiatorType { get; }
  public new string nextHopProtocol { get; }
  public new object redirectEnd { get; }
  public new object redirectStart { get; }
  public new object requestStart { get; }
  public new object responseEnd { get; }
  public new object responseStart { get; }
  public new object secureConnectionStart { get; }
  public new object serverTiming { get; }
  public new double transferSize { get; }
  public new object workerStart { get; }
  public new object toJSON();
}

public partial interface PerformanceServerTiming  {
  public new string description { get; }
  public new object duration { get; }
  public new string name { get; }
  public new object toJSON();
}

public partial interface PerformanceTiming  {
  public new double connectEnd { get; }
  public new double connectStart { get; }
  public new double domComplete { get; }
  public new double domContentLoadedEventEnd { get; }
  public new double domContentLoadedEventStart { get; }
  public new double domInteractive { get; }
  public new double domLoading { get; }
  public new double domainLookupEnd { get; }
  public new double domainLookupStart { get; }
  public new double fetchStart { get; }
  public new double loadEventEnd { get; }
  public new double loadEventStart { get; }
  public new double navigationStart { get; }
  public new double redirectEnd { get; }
  public new double redirectStart { get; }
  public new double requestStart { get; }
  public new double responseEnd { get; }
  public new double responseStart { get; }
  public new double secureConnectionStart { get; }
  public new double unloadEventEnd { get; }
  public new double unloadEventStart { get; }
  public new object toJSON();
}

public partial interface PeriodicWave  {}

public partial interface PermissionStatusEventMap  {
  public new object change { get; set; }
}

public partial interface PermissionStatus : EventTarget  {
  public new string name { get; }
  public new object onchange { get; set; }
  public new object state { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Permissions  {
  public new object query(object permissionDesc);
}

public partial interface PictureInPictureEvent : Event  {
  public new object pictureInPictureWindow { get; }
}

public partial interface PictureInPictureWindowEventMap  {
  public new object resize { get; set; }
}

public partial interface PictureInPictureWindow : EventTarget  {
  public new double height { get; }
  public new object onresize { get; set; }
  public new double width { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Plugin  {
  public new string description { get; }
  public new string filename { get; }
  public new double length { get; }
  public new string name { get; }
  public new object item(double index);
  public new object namedItem(string name);
  // TODO: Unsupported member: undefined
}

public partial interface PluginArray  {
  public new double length { get; }
  public new object item(double index);
  public new object namedItem(string name);
  public new object refresh();
  // TODO: Unsupported member: undefined
}

public partial interface PointerEvent : MouseEvent  {
  public new double height { get; }
  public new bool isPrimary { get; }
  public new double pointerId { get; }
  public new string pointerType { get; }
  public new double pressure { get; }
  public new double tangentialPressure { get; }
  public new double tiltX { get; }
  public new double tiltY { get; }
  public new double twist { get; }
  public new double width { get; }
  public new object getCoalescedEvents();
  public new object getPredictedEvents();
}

public partial interface PopStateEvent : Event  {
  public new object state { get; }
}

public partial interface PopoverInvokerElement  {
  public new string popoverTargetAction { get; set; }
  public new object popoverTargetElement { get; set; }
}

public partial interface ProcessingInstruction : CharacterData, LinkStyle  {
  public new object ownerDocument { get; }
  public new string target { get; }
}

public partial interface ProgressEvent : Event  {
  public new bool lengthComputable { get; }
  public new double loaded { get; }
  public new object target { get; }
  public new double total { get; }
}

public partial interface PromiseRejectionEvent : Event  {
  public new object promise { get; }
  public new object reason { get; }
}

public partial interface PublicKeyCredential : Credential  {
  public new object authenticatorAttachment { get; }
  public new object rawId { get; }
  public new object response { get; }
  public new object getClientExtensionResults();
}

public partial interface PushManager  {
  public new object getSubscription();
  public new object permissionState(object options);
  public new object subscribe(object options);
}

public partial interface PushSubscription  {
  public new string endpoint { get; }
  public new object expirationTime { get; }
  public new object options { get; }
  public new object getKey(object name);
  public new object toJSON();
  public new object unsubscribe();
}

public partial interface PushSubscriptionOptions  {
  public new object applicationServerKey { get; }
  public new bool userVisibleOnly { get; }
}

public partial interface RTCCertificate  {
  public new object expires { get; }
  public new object getFingerprints();
}

public partial interface RTCDTMFSenderEventMap  {
  public new object tonechange { get; set; }
}

public partial interface RTCDTMFSender : EventTarget  {
  public new bool canInsertDTMF { get; }
  public new object ontonechange { get; set; }
  public new string toneBuffer { get; }
  public new object insertDTMF(string tones, double duration, double interToneGap);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCDTMFToneChangeEvent : Event  {
  public new string tone { get; }
}

public partial interface RTCDataChannelEventMap  {
  public new object bufferedamountlow { get; set; }
  public new object close { get; set; }
  public new object closing { get; set; }
  public new object error { get; set; }
  public new object message { get; set; }
  public new object open { get; set; }
}

public partial interface RTCDataChannel : EventTarget  {
  public new object binaryType { get; set; }
  public new double bufferedAmount { get; }
  public new double bufferedAmountLowThreshold { get; set; }
  public new object id { get; }
  public new string label { get; }
  public new object maxPacketLifeTime { get; }
  public new object maxRetransmits { get; }
  public new bool negotiated { get; }
  public new object onbufferedamountlow { get; set; }
  public new object onclose { get; set; }
  public new object onclosing { get; set; }
  public new object onerror { get; set; }
  public new object onmessage { get; set; }
  public new object onopen { get; set; }
  public new bool ordered { get; }
  public new string protocol { get; }
  public new object readyState { get; }
  public new object close();
  public new object send(string data);
  public new object send(object data);
  public new object send(object data);
  public new object send(object data);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCDataChannelEvent : Event  {
  public new object channel { get; }
}

public partial interface RTCDtlsTransportEventMap  {
  public new object error { get; set; }
  public new object statechange { get; set; }
}

public partial interface RTCDtlsTransport : EventTarget  {
  public new object iceTransport { get; }
  public new object onerror { get; set; }
  public new object onstatechange { get; set; }
  public new object state { get; }
  public new object getRemoteCertificates();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCEncodedAudioFrame  {
  public new object data { get; set; }
  public new double timestamp { get; }
  public new object getMetadata();
}

public partial interface RTCEncodedVideoFrame  {
  public new object data { get; set; }
  public new double timestamp { get; }
  public new object type { get; }
  public new object getMetadata();
}

public partial interface RTCError : DOMException  {
  public new object errorDetail { get; }
  public new object receivedAlert { get; }
  public new object sctpCauseCode { get; }
  public new object sdpLineNumber { get; }
  public new object sentAlert { get; }
}

public partial interface RTCErrorEvent : Event  {
  public new object error { get; }
}

public partial interface RTCIceCandidate  {
  public new object address { get; }
  public new string candidate { get; }
  public new object component { get; }
  public new object foundation { get; }
  public new object port { get; }
  public new object priority { get; }
  public new object protocol { get; }
  public new object relatedAddress { get; }
  public new object relatedPort { get; }
  public new object sdpMLineIndex { get; }
  public new object sdpMid { get; }
  public new object tcpType { get; }
  public new object type { get; }
  public new object usernameFragment { get; }
  public new object toJSON();
}

public partial interface RTCIceTransportEventMap  {
  public new object gatheringstatechange { get; set; }
  public new object selectedcandidatepairchange { get; set; }
  public new object statechange { get; set; }
}

public partial interface RTCIceTransport : EventTarget  {
  public new object gatheringState { get; }
  public new object ongatheringstatechange { get; set; }
  public new object onselectedcandidatepairchange { get; set; }
  public new object onstatechange { get; set; }
  public new object state { get; }
  public new object getSelectedCandidatePair();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCPeerConnectionEventMap  {
  public new object connectionstatechange { get; set; }
  public new object datachannel { get; set; }
  public new object icecandidate { get; set; }
  public new object icecandidateerror { get; set; }
  public new object iceconnectionstatechange { get; set; }
  public new object icegatheringstatechange { get; set; }
  public new object negotiationneeded { get; set; }
  public new object signalingstatechange { get; set; }
  public new object track { get; set; }
}

public partial interface RTCPeerConnection : EventTarget  {
  public new object canTrickleIceCandidates { get; }
  public new object connectionState { get; }
  public new object currentLocalDescription { get; }
  public new object currentRemoteDescription { get; }
  public new object iceConnectionState { get; }
  public new object iceGatheringState { get; }
  public new object localDescription { get; }
  public new object onconnectionstatechange { get; set; }
  public new object ondatachannel { get; set; }
  public new object onicecandidate { get; set; }
  public new object onicecandidateerror { get; set; }
  public new object oniceconnectionstatechange { get; set; }
  public new object onicegatheringstatechange { get; set; }
  public new object onnegotiationneeded { get; set; }
  public new object onsignalingstatechange { get; set; }
  public new object ontrack { get; set; }
  public new object pendingLocalDescription { get; }
  public new object pendingRemoteDescription { get; }
  public new object remoteDescription { get; }
  public new object sctp { get; }
  public new object signalingState { get; }
  public new object addIceCandidate(object candidate);
  public new object addIceCandidate(object candidate, object successCallback, object failureCallback);
  public new object addTrack(object track, object streams);
  public new object addTransceiver(object trackOrKind, object init);
  public new object close();
  public new object createAnswer(object options);
  public new object createAnswer(object successCallback, object failureCallback);
  public new object createDataChannel(string label, object dataChannelDict);
  public new object createOffer(object options);
  public new object createOffer(object successCallback, object failureCallback, object options);
  public new object getConfiguration();
  public new object getReceivers();
  public new object getSenders();
  public new object getStats(object selector);
  public new object getTransceivers();
  public new object removeTrack(object sender);
  public new object restartIce();
  public new object setConfiguration(object configuration);
  public new object setLocalDescription(object description);
  public new object setLocalDescription(object description, object successCallback, object failureCallback);
  public new object setRemoteDescription(object description);
  public new object setRemoteDescription(object description, object successCallback, object failureCallback);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCPeerConnectionIceErrorEvent : Event  {
  public new object address { get; }
  public new double errorCode { get; }
  public new string errorText { get; }
  public new object port { get; }
  public new string url { get; }
}

public partial interface RTCPeerConnectionIceEvent : Event  {
  public new object candidate { get; }
}

public partial interface RTCRtpReceiver  {
  public new object track { get; }
  public new object transport { get; }
  public new object getContributingSources();
  public new object getParameters();
  public new object getStats();
  public new object getSynchronizationSources();
}

public partial interface RTCRtpSender  {
  public new object dtmf { get; }
  public new object track { get; }
  public new object transport { get; }
  public new object getParameters();
  public new object getStats();
  public new object replaceTrack(object withTrack);
  public new object setParameters(object parameters);
  public new object setStreams(object streams);
}

public partial interface RTCRtpTransceiver  {
  public new object currentDirection { get; }
  public new object direction { get; set; }
  public new object mid { get; }
  public new object receiver { get; }
  public new object sender { get; }
  public new object setCodecPreferences(object codecs);
  public new object stop();
}

public partial interface RTCSctpTransportEventMap  {
  public new object statechange { get; set; }
}

public partial interface RTCSctpTransport : EventTarget  {
  public new object maxChannels { get; }
  public new double maxMessageSize { get; }
  public new object onstatechange { get; set; }
  public new object state { get; }
  public new object transport { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface RTCSessionDescription  {
  public new string sdp { get; }
  public new object type { get; }
  public new object toJSON();
}

public partial interface RTCStatsReport  {
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface RTCTrackEvent : Event  {
  public new object receiver { get; }
  public new object streams { get; }
  public new object track { get; }
  public new object transceiver { get; }
}

public partial interface RadioNodeList : NodeList  {
  public new string value { get; set; }
}

public partial interface Range : AbstractRange  {
  public new object commonAncestorContainer { get; }
  public new object cloneContents();
  public new object cloneRange();
  public new object collapse(bool toStart);
  public new double compareBoundaryPoints(double how, object sourceRange);
  public new double comparePoint(object node, double offset);
  public new object createContextualFragment(string fragment);
  public new object deleteContents();
  public new object detach();
  public new object extractContents();
  public new object getBoundingClientRect();
  public new object getClientRects();
  public new object insertNode(object node);
  public new bool intersectsNode(object node);
  public new bool isPointInRange(object node, double offset);
  public new object selectNode(object node);
  public new object selectNodeContents(object node);
  public new object setEnd(object node, double offset);
  public new object setEndAfter(object node);
  public new object setEndBefore(object node);
  public new object setStart(object node, double offset);
  public new object setStartAfter(object node);
  public new object setStartBefore(object node);
  public new object surroundContents(object newParent);
  public new string toStringMethod();
  public new object START_TO_START { get; }
  public new object START_TO_END { get; }
  public new object END_TO_END { get; }
  public new object END_TO_START { get; }
}

public partial interface ReadableByteStreamController  {
  public new object byobRequest { get; }
  public new object desiredSize { get; }
  public new object close();
  public new object enqueue(object chunk);
  public new object error(object e);
}

public partial interface ReadableStream  {
  public new bool locked { get; }
  public new object cancel(object reason);
  public new object getReader(object options);
  public new object getReader();
  public new object getReader(object options);
  public new object pipeThrough(object transform, object options);
  public new object pipeTo(object destination, object options);
  public new object tee();
}

public partial interface ReadableStreamBYOBReader : ReadableStreamGenericReader  {
  public new object read(object view);
  public new object releaseLock();
}

public partial interface ReadableStreamBYOBRequest  {
  public new object view { get; }
  public new object respond(double bytesWritten);
  public new object respondWithNewView(object view);
}

public partial interface ReadableStreamDefaultController  {
  public new object desiredSize { get; }
  public new object close();
  public new object enqueue(object chunk);
  public new object error(object e);
}

public partial interface ReadableStreamDefaultReader : ReadableStreamGenericReader  {
  public new object read();
  public new object releaseLock();
}

public partial interface ReadableStreamGenericReader  {
  public new object closed { get; }
  public new object cancel(object reason);
}

public partial interface RemotePlaybackEventMap  {
  public new object connect { get; set; }
  public new object connecting { get; set; }
  public new object disconnect { get; set; }
}

public partial interface RemotePlayback : EventTarget  {
  public new object onconnect { get; set; }
  public new object onconnecting { get; set; }
  public new object ondisconnect { get; set; }
  public new object state { get; }
  public new object cancelWatchAvailability(double id);
  public new object prompt();
  public new object watchAvailability(object callback);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Report  {
  public new object body { get; }
  public new string type { get; }
  public new string url { get; }
  public new object toJSON();
}

public partial interface ReportBody  {
  public new object toJSON();
}

public partial interface ReportingObserver  {
  public new object disconnect();
  public new object observe();
  public new object takeRecords();
}

public partial interface Request : Body  {
  public new object cache { get; }
  public new object credentials { get; }
  public new object destination { get; }
  public new object headers { get; }
  public new string integrity { get; }
  public new bool keepalive { get; }
  public new string method { get; }
  public new object mode { get; }
  public new object redirect { get; }
  public new string referrer { get; }
  public new object referrerPolicy { get; }
  public new object signal { get; }
  public new string url { get; }
  public new object clone();
}

public partial interface ResizeObserver  {
  public new object disconnect();
  public new object observe(object target, object options);
  public new object unobserve(object target);
}

public partial interface ResizeObserverEntry  {
  public new object borderBoxSize { get; }
  public new object contentBoxSize { get; }
  public new object contentRect { get; }
  public new object devicePixelContentBoxSize { get; }
  public new object target { get; }
}

public partial interface ResizeObserverSize  {
  public new double blockSize { get; }
  public new double inlineSize { get; }
}

public partial interface Response : Body  {
  public new object headers { get; }
  public new bool ok { get; }
  public new bool redirected { get; }
  public new double status { get; }
  public new string statusText { get; }
  public new object type { get; }
  public new string url { get; }
  public new object clone();
}

public partial interface SVGAElement : SVGGraphicsElement, SVGURIReference  {
  public new string rel { get; set; }
  public new object relList { get; }
  public new object target { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGAngle  {
  public new double unitType { get; }
  public new double value { get; set; }
  public new string valueAsString { get; set; }
  public new double valueInSpecifiedUnits { get; set; }
  public new object convertToSpecifiedUnits(double unitType);
  public new object newValueSpecifiedUnits(double unitType, double valueInSpecifiedUnits);
  public new object SVG_ANGLETYPE_UNKNOWN { get; }
  public new object SVG_ANGLETYPE_UNSPECIFIED { get; }
  public new object SVG_ANGLETYPE_DEG { get; }
  public new object SVG_ANGLETYPE_RAD { get; }
  public new object SVG_ANGLETYPE_GRAD { get; }
}

public partial interface SVGAnimateElement : SVGAnimationElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGAnimateMotionElement : SVGAnimationElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGAnimateTransformElement : SVGAnimationElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGAnimatedAngle  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedBoolean  {
  public new bool animVal { get; }
  public new bool baseVal { get; set; }
}

public partial interface SVGAnimatedEnumeration  {
  public new double animVal { get; }
  public new double baseVal { get; set; }
}

public partial interface SVGAnimatedInteger  {
  public new double animVal { get; }
  public new double baseVal { get; set; }
}

public partial interface SVGAnimatedLength  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedLengthList  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedNumber  {
  public new double animVal { get; }
  public new double baseVal { get; set; }
}

public partial interface SVGAnimatedNumberList  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedPoints  {
  public new object animatedPoints { get; }
  public new object points { get; }
}

public partial interface SVGAnimatedPreserveAspectRatio  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedRect  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimatedString  {
  public new string animVal { get; }
  public new string baseVal { get; set; }
}

public partial interface SVGAnimatedTransformList  {
  public new object animVal { get; }
  public new object baseVal { get; }
}

public partial interface SVGAnimationElement : SVGElement, SVGTests  {
  public new object targetElement { get; }
  public new object beginElement();
  public new object beginElementAt(double offset);
  public new object endElement();
  public new object endElementAt(double offset);
  public new double getCurrentTime();
  public new double getSimpleDuration();
  public new double getStartTime();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGCircleElement : SVGGeometryElement  {
  public new object cx { get; }
  public new object cy { get; }
  public new object r { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGClipPathElement : SVGElement  {
  public new object clipPathUnits { get; }
  public new object transform { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGComponentTransferFunctionElement : SVGElement  {
  public new object amplitude { get; }
  public new object exponent { get; }
  public new object intercept { get; }
  public new object offset { get; }
  public new object slope { get; }
  public new object tableValues { get; }
  public new object type { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_TABLE { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_LINEAR { get; }
  public new object SVG_FECOMPONENTTRANSFER_TYPE_GAMMA { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGDefsElement : SVGGraphicsElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGDescElement : SVGElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGElementEventMap : ElementEventMap, GlobalEventHandlersEventMap  {}

public partial interface SVGElement : Element, ElementCSSInlineStyle, GlobalEventHandlers, HTMLOrSVGElement  {
  public new object className { get; }
  public new object ownerSVGElement { get; }
  public new object viewportElement { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGEllipseElement : SVGGeometryElement  {
  public new object cx { get; }
  public new object cy { get; }
  public new object rx { get; }
  public new object ry { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEBlendElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object in2 { get; }
  public new object mode { get; }
  public new object SVG_FEBLEND_MODE_UNKNOWN { get; }
  public new object SVG_FEBLEND_MODE_NORMAL { get; }
  public new object SVG_FEBLEND_MODE_MULTIPLY { get; }
  public new object SVG_FEBLEND_MODE_SCREEN { get; }
  public new object SVG_FEBLEND_MODE_DARKEN { get; }
  public new object SVG_FEBLEND_MODE_LIGHTEN { get; }
  public new object SVG_FEBLEND_MODE_OVERLAY { get; }
  public new object SVG_FEBLEND_MODE_COLOR_DODGE { get; }
  public new object SVG_FEBLEND_MODE_COLOR_BURN { get; }
  public new object SVG_FEBLEND_MODE_HARD_LIGHT { get; }
  public new object SVG_FEBLEND_MODE_SOFT_LIGHT { get; }
  public new object SVG_FEBLEND_MODE_DIFFERENCE { get; }
  public new object SVG_FEBLEND_MODE_EXCLUSION { get; }
  public new object SVG_FEBLEND_MODE_HUE { get; }
  public new object SVG_FEBLEND_MODE_SATURATION { get; }
  public new object SVG_FEBLEND_MODE_COLOR { get; }
  public new object SVG_FEBLEND_MODE_LUMINOSITY { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEColorMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object type { get; }
  public new object values { get; }
  public new object SVG_FECOLORMATRIX_TYPE_UNKNOWN { get; }
  public new object SVG_FECOLORMATRIX_TYPE_MATRIX { get; }
  public new object SVG_FECOLORMATRIX_TYPE_SATURATE { get; }
  public new object SVG_FECOLORMATRIX_TYPE_HUEROTATE { get; }
  public new object SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEComponentTransferElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFECompositeElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object in2 { get; }
  public new object k1 { get; }
  public new object k2 { get; }
  public new object k3 { get; }
  public new object k4 { get; }
  public new object operatorProperty { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_UNKNOWN { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_OVER { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_IN { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_OUT { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_ATOP { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_XOR { get; }
  public new object SVG_FECOMPOSITE_OPERATOR_ARITHMETIC { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEConvolveMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object bias { get; }
  public new object divisor { get; }
  public new object edgeMode { get; }
  public new object in1 { get; }
  public new object kernelMatrix { get; }
  public new object kernelUnitLengthX { get; }
  public new object kernelUnitLengthY { get; }
  public new object orderX { get; }
  public new object orderY { get; }
  public new object preserveAlpha { get; }
  public new object targetX { get; }
  public new object targetY { get; }
  public new object SVG_EDGEMODE_UNKNOWN { get; }
  public new object SVG_EDGEMODE_DUPLICATE { get; }
  public new object SVG_EDGEMODE_WRAP { get; }
  public new object SVG_EDGEMODE_NONE { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEDiffuseLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object diffuseConstant { get; }
  public new object in1 { get; }
  public new object kernelUnitLengthX { get; }
  public new object kernelUnitLengthY { get; }
  public new object surfaceScale { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEDisplacementMapElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object in2 { get; }
  public new object scale { get; }
  public new object xChannelSelector { get; }
  public new object yChannelSelector { get; }
  public new object SVG_CHANNEL_UNKNOWN { get; }
  public new object SVG_CHANNEL_R { get; }
  public new object SVG_CHANNEL_G { get; }
  public new object SVG_CHANNEL_B { get; }
  public new object SVG_CHANNEL_A { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEDistantLightElement : SVGElement  {
  public new object azimuth { get; }
  public new object elevation { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEDropShadowElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object dx { get; }
  public new object dy { get; }
  public new object in1 { get; }
  public new object stdDeviationX { get; }
  public new object stdDeviationY { get; }
  public new object setStdDeviation(double stdDeviationX, double stdDeviationY);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEFloodElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEFuncAElement : SVGComponentTransferFunctionElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEFuncBElement : SVGComponentTransferFunctionElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEFuncGElement : SVGComponentTransferFunctionElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEFuncRElement : SVGComponentTransferFunctionElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEGaussianBlurElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object stdDeviationX { get; }
  public new object stdDeviationY { get; }
  public new object setStdDeviation(double stdDeviationX, double stdDeviationY);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEImageElement : SVGElement, SVGFilterPrimitiveStandardAttributes, SVGURIReference  {
  public new object preserveAspectRatio { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEMergeElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEMergeNodeElement : SVGElement  {
  public new object in1 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEMorphologyElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object operatorProperty { get; }
  public new object radiusX { get; }
  public new object radiusY { get; }
  public new object SVG_MORPHOLOGY_OPERATOR_UNKNOWN { get; }
  public new object SVG_MORPHOLOGY_OPERATOR_ERODE { get; }
  public new object SVG_MORPHOLOGY_OPERATOR_DILATE { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEOffsetElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object dx { get; }
  public new object dy { get; }
  public new object in1 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFEPointLightElement : SVGElement  {
  public new object x { get; }
  public new object y { get; }
  public new object z { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFESpecularLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object kernelUnitLengthX { get; }
  public new object kernelUnitLengthY { get; }
  public new object specularConstant { get; }
  public new object specularExponent { get; }
  public new object surfaceScale { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFESpotLightElement : SVGElement  {
  public new object limitingConeAngle { get; }
  public new object pointsAtX { get; }
  public new object pointsAtY { get; }
  public new object pointsAtZ { get; }
  public new object specularExponent { get; }
  public new object x { get; }
  public new object y { get; }
  public new object z { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFETileElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object in1 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFETurbulenceElement : SVGElement, SVGFilterPrimitiveStandardAttributes  {
  public new object baseFrequencyX { get; }
  public new object baseFrequencyY { get; }
  public new object numOctaves { get; }
  public new object seed { get; }
  public new object stitchTiles { get; }
  public new object type { get; }
  public new object SVG_TURBULENCE_TYPE_UNKNOWN { get; }
  public new object SVG_TURBULENCE_TYPE_FRACTALNOISE { get; }
  public new object SVG_TURBULENCE_TYPE_TURBULENCE { get; }
  public new object SVG_STITCHTYPE_UNKNOWN { get; }
  public new object SVG_STITCHTYPE_STITCH { get; }
  public new object SVG_STITCHTYPE_NOSTITCH { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFilterElement : SVGElement, SVGURIReference  {
  public new object filterUnits { get; }
  public new object height { get; }
  public new object primitiveUnits { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGFilterPrimitiveStandardAttributes  {
  public new object height { get; }
  public new object result { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
}

public partial interface SVGFitToViewBox  {
  public new object preserveAspectRatio { get; }
  public new object viewBox { get; }
}

public partial interface SVGForeignObjectElement : SVGGraphicsElement  {
  public new object height { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGGElement : SVGGraphicsElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGGeometryElement : SVGGraphicsElement  {
  public new object pathLength { get; }
  public new object getPointAtLength(double distance);
  public new double getTotalLength();
  public new bool isPointInFill(object point);
  public new bool isPointInStroke(object point);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGGradientElement : SVGElement, SVGURIReference  {
  public new object gradientTransform { get; }
  public new object gradientUnits { get; }
  public new object spreadMethod { get; }
  public new object SVG_SPREADMETHOD_UNKNOWN { get; }
  public new object SVG_SPREADMETHOD_PAD { get; }
  public new object SVG_SPREADMETHOD_REFLECT { get; }
  public new object SVG_SPREADMETHOD_REPEAT { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGGraphicsElement : SVGElement, SVGTests  {
  public new object transform { get; }
  public new object getBBox(object options);
  public new object getCTM();
  public new object getScreenCTM();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGImageElement : SVGGraphicsElement, SVGURIReference  {
  public new object height { get; }
  public new object preserveAspectRatio { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGLength  {
  public new double unitType { get; }
  public new double value { get; set; }
  public new string valueAsString { get; set; }
  public new double valueInSpecifiedUnits { get; set; }
  public new object convertToSpecifiedUnits(double unitType);
  public new object newValueSpecifiedUnits(double unitType, double valueInSpecifiedUnits);
  public new object SVG_LENGTHTYPE_UNKNOWN { get; }
  public new object SVG_LENGTHTYPE_NUMBER { get; }
  public new object SVG_LENGTHTYPE_PERCENTAGE { get; }
  public new object SVG_LENGTHTYPE_EMS { get; }
  public new object SVG_LENGTHTYPE_EXS { get; }
  public new object SVG_LENGTHTYPE_PX { get; }
  public new object SVG_LENGTHTYPE_CM { get; }
  public new object SVG_LENGTHTYPE_MM { get; }
  public new object SVG_LENGTHTYPE_IN { get; }
  public new object SVG_LENGTHTYPE_PT { get; }
  public new object SVG_LENGTHTYPE_PC { get; }
}

public partial interface SVGLengthList  {
  public new double length { get; }
  public new double numberOfItems { get; }
  public new object appendItem(object newItem);
  public new object clear();
  public new object getItem(double index);
  public new object initialize(object newItem);
  public new object insertItemBefore(object newItem, double index);
  public new object removeItem(double index);
  public new object replaceItem(object newItem, double index);
  // TODO: Unsupported member: undefined
}

public partial interface SVGLineElement : SVGGeometryElement  {
  public new object x1 { get; }
  public new object x2 { get; }
  public new object y1 { get; }
  public new object y2 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGLinearGradientElement : SVGGradientElement  {
  public new object x1 { get; }
  public new object x2 { get; }
  public new object y1 { get; }
  public new object y2 { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGMPathElement : SVGElement, SVGURIReference  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGMarkerElement : SVGElement, SVGFitToViewBox  {
  public new object markerHeight { get; }
  public new object markerUnits { get; }
  public new object markerWidth { get; }
  public new object orientAngle { get; }
  public new object orientType { get; }
  public new object refX { get; }
  public new object refY { get; }
  public new object setOrientToAngle(object angle);
  public new object setOrientToAuto();
  public new object SVG_MARKERUNITS_UNKNOWN { get; }
  public new object SVG_MARKERUNITS_USERSPACEONUSE { get; }
  public new object SVG_MARKERUNITS_STROKEWIDTH { get; }
  public new object SVG_MARKER_ORIENT_UNKNOWN { get; }
  public new object SVG_MARKER_ORIENT_AUTO { get; }
  public new object SVG_MARKER_ORIENT_ANGLE { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGMaskElement : SVGElement  {
  public new object height { get; }
  public new object maskContentUnits { get; }
  public new object maskUnits { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGMetadataElement : SVGElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGNumber  {
  public new double value { get; set; }
}

public partial interface SVGNumberList  {
  public new double length { get; }
  public new double numberOfItems { get; }
  public new object appendItem(object newItem);
  public new object clear();
  public new object getItem(double index);
  public new object initialize(object newItem);
  public new object insertItemBefore(object newItem, double index);
  public new object removeItem(double index);
  public new object replaceItem(object newItem, double index);
  // TODO: Unsupported member: undefined
}

public partial interface SVGPathElement : SVGGeometryElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGPatternElement : SVGElement, SVGFitToViewBox, SVGURIReference  {
  public new object height { get; }
  public new object patternContentUnits { get; }
  public new object patternTransform { get; }
  public new object patternUnits { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGPointList  {
  public new double length { get; }
  public new double numberOfItems { get; }
  public new object appendItem(object newItem);
  public new object clear();
  public new object getItem(double index);
  public new object initialize(object newItem);
  public new object insertItemBefore(object newItem, double index);
  public new object removeItem(double index);
  public new object replaceItem(object newItem, double index);
  // TODO: Unsupported member: undefined
}

public partial interface SVGPolygonElement : SVGGeometryElement, SVGAnimatedPoints  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGPolylineElement : SVGGeometryElement, SVGAnimatedPoints  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGPreserveAspectRatio  {
  public new double align { get; set; }
  public new double meetOrSlice { get; set; }
  public new object SVG_PRESERVEASPECTRATIO_UNKNOWN { get; }
  public new object SVG_PRESERVEASPECTRATIO_NONE { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMINYMIN { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMIDYMIN { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMAXYMIN { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMINYMID { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMIDYMID { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMAXYMID { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMINYMAX { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMIDYMAX { get; }
  public new object SVG_PRESERVEASPECTRATIO_XMAXYMAX { get; }
  public new object SVG_MEETORSLICE_UNKNOWN { get; }
  public new object SVG_MEETORSLICE_MEET { get; }
  public new object SVG_MEETORSLICE_SLICE { get; }
}

public partial interface SVGRadialGradientElement : SVGGradientElement  {
  public new object cx { get; }
  public new object cy { get; }
  public new object fr { get; }
  public new object fx { get; }
  public new object fy { get; }
  public new object r { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGRectElement : SVGGeometryElement  {
  public new object height { get; }
  public new object rx { get; }
  public new object ry { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGSVGElementEventMap : SVGElementEventMap, WindowEventHandlersEventMap  {}

public partial interface SVGSVGElement : SVGGraphicsElement, SVGFitToViewBox, WindowEventHandlers  {
  public new double currentScale { get; set; }
  public new object currentTranslate { get; }
  public new object height { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new bool animationsPaused();
  public new bool checkEnclosure(object element, object rect);
  public new bool checkIntersection(object element, object rect);
  public new object createSVGAngle();
  public new object createSVGLength();
  public new object createSVGMatrix();
  public new object createSVGNumber();
  public new object createSVGPoint();
  public new object createSVGRect();
  public new object createSVGTransform();
  public new object createSVGTransformFromMatrix(object matrix);
  public new object deselectAll();
  public new object forceRedraw();
  public new double getCurrentTime();
  public new object getElementById(string elementId);
  public new object getEnclosureList(object rect, object referenceElement);
  public new object getIntersectionList(object rect, object referenceElement);
  public new object pauseAnimations();
  public new object setCurrentTime(double seconds);
  public new double suspendRedraw(double maxWaitMilliseconds);
  public new object unpauseAnimations();
  public new object unsuspendRedraw(double suspendHandleID);
  public new object unsuspendRedrawAll();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGScriptElement : SVGElement, SVGURIReference  {
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGSetElement : SVGAnimationElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGStopElement : SVGElement  {
  public new object offset { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGStringList  {
  public new double length { get; }
  public new double numberOfItems { get; }
  public new string appendItem(string newItem);
  public new object clear();
  public new string getItem(double index);
  public new string initialize(string newItem);
  public new string insertItemBefore(string newItem, double index);
  public new string removeItem(double index);
  public new string replaceItem(string newItem, double index);
  // TODO: Unsupported member: undefined
}

public partial interface SVGStyleElement : SVGElement, LinkStyle  {
  public new bool disabled { get; set; }
  public new string media { get; set; }
  public new string title { get; set; }
  public new string type { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGSwitchElement : SVGGraphicsElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGSymbolElement : SVGElement, SVGFitToViewBox  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTSpanElement : SVGTextPositioningElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTests  {
  public new object requiredExtensions { get; }
  public new object systemLanguage { get; }
}

public partial interface SVGTextContentElement : SVGGraphicsElement  {
  public new object lengthAdjust { get; }
  public new object textLength { get; }
  public new double getCharNumAtPosition(object point);
  public new double getComputedTextLength();
  public new object getEndPositionOfChar(double charnum);
  public new object getExtentOfChar(double charnum);
  public new double getNumberOfChars();
  public new double getRotationOfChar(double charnum);
  public new object getStartPositionOfChar(double charnum);
  public new double getSubStringLength(double charnum, double nchars);
  public new object selectSubString(double charnum, double nchars);
  public new object LENGTHADJUST_UNKNOWN { get; }
  public new object LENGTHADJUST_SPACING { get; }
  public new object LENGTHADJUST_SPACINGANDGLYPHS { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTextElement : SVGTextPositioningElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTextPathElement : SVGTextContentElement, SVGURIReference  {
  public new object method { get; }
  public new object spacing { get; }
  public new object startOffset { get; }
  public new object TEXTPATH_METHODTYPE_UNKNOWN { get; }
  public new object TEXTPATH_METHODTYPE_ALIGN { get; }
  public new object TEXTPATH_METHODTYPE_STRETCH { get; }
  public new object TEXTPATH_SPACINGTYPE_UNKNOWN { get; }
  public new object TEXTPATH_SPACINGTYPE_AUTO { get; }
  public new object TEXTPATH_SPACINGTYPE_EXACT { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTextPositioningElement : SVGTextContentElement  {
  public new object dx { get; }
  public new object dy { get; }
  public new object rotate { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTitleElement : SVGElement  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGTransform  {
  public new double angle { get; }
  public new object matrix { get; }
  public new double type { get; }
  public new object setMatrix(object matrix);
  public new object setRotate(double angle, double cx, double cy);
  public new object setScale(double sx, double sy);
  public new object setSkewX(double angle);
  public new object setSkewY(double angle);
  public new object setTranslate(double tx, double ty);
  public new object SVG_TRANSFORM_UNKNOWN { get; }
  public new object SVG_TRANSFORM_MATRIX { get; }
  public new object SVG_TRANSFORM_TRANSLATE { get; }
  public new object SVG_TRANSFORM_SCALE { get; }
  public new object SVG_TRANSFORM_ROTATE { get; }
  public new object SVG_TRANSFORM_SKEWX { get; }
  public new object SVG_TRANSFORM_SKEWY { get; }
}

public partial interface SVGTransformList  {
  public new double length { get; }
  public new double numberOfItems { get; }
  public new object appendItem(object newItem);
  public new object clear();
  public new object consolidate();
  public new object createSVGTransformFromMatrix(object matrix);
  public new object getItem(double index);
  public new object initialize(object newItem);
  public new object insertItemBefore(object newItem, double index);
  public new object removeItem(double index);
  public new object replaceItem(object newItem, double index);
  // TODO: Unsupported member: undefined
}

public partial interface SVGURIReference  {
  public new object href { get; }
}

public partial interface SVGUnitTypes  {
  public new object SVG_UNIT_TYPE_UNKNOWN { get; }
  public new object SVG_UNIT_TYPE_USERSPACEONUSE { get; }
  public new object SVG_UNIT_TYPE_OBJECTBOUNDINGBOX { get; }
}

public partial interface SVGUseElement : SVGGraphicsElement, SVGURIReference  {
  public new object height { get; }
  public new object width { get; }
  public new object x { get; }
  public new object y { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SVGViewElement : SVGElement, SVGFitToViewBox  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Screen  {
  public new double availHeight { get; }
  public new double availWidth { get; }
  public new double colorDepth { get; }
  public new double height { get; }
  public new object orientation { get; }
  public new double pixelDepth { get; }
  public new double width { get; }
}

public partial interface ScreenOrientationEventMap  {
  public new object change { get; set; }
}

public partial interface ScreenOrientation : EventTarget  {
  public new double angle { get; }
  public new object onchange { get; set; }
  public new object type { get; }
  public new object unlock();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ScriptProcessorNodeEventMap  {
  public new object audioprocess { get; set; }
}

public partial interface ScriptProcessorNode : AudioNode  {
  public new double bufferSize { get; }
  public new object onaudioprocess { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SecurityPolicyViolationEvent : Event  {
  public new string blockedURI { get; }
  public new double columnNumber { get; }
  public new object disposition { get; }
  public new string documentURI { get; }
  public new string effectiveDirective { get; }
  public new double lineNumber { get; }
  public new string originalPolicy { get; }
  public new string referrer { get; }
  public new string sample { get; }
  public new string sourceFile { get; }
  public new double statusCode { get; }
  public new string violatedDirective { get; }
}

public partial interface Selection  {
  public new object anchorNode { get; }
  public new double anchorOffset { get; }
  public new object focusNode { get; }
  public new double focusOffset { get; }
  public new bool isCollapsed { get; }
  public new double rangeCount { get; }
  public new string type { get; }
  public new object addRange(object range);
  public new object collapse(object node, double offset);
  public new object collapseToEnd();
  public new object collapseToStart();
  public new bool containsNode(object node, bool allowPartialContainment);
  public new object deleteFromDocument();
  public new object empty();
  public new object extend(object node, double offset);
  public new object getRangeAt(double index);
  public new object modify(string alter, string direction, string granularity);
  public new object removeAllRanges();
  public new object removeRange(object range);
  public new object selectAllChildren(object node);
  public new object setBaseAndExtent(object anchorNode, double anchorOffset, object focusNode, double focusOffset);
  public new object setPosition(object node, double offset);
  public new string toStringMethod();
}

public partial interface ServiceWorkerEventMap : AbstractWorkerEventMap  {
  public new object statechange { get; set; }
}

public partial interface ServiceWorker : EventTarget, AbstractWorker  {
  public new object onstatechange { get; set; }
  public new string scriptURL { get; }
  public new object state { get; }
  public new object postMessage(object message, object transfer);
  public new object postMessage(object message, object options);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ServiceWorkerContainerEventMap  {
  public new object controllerchange { get; set; }
  public new object message { get; set; }
  public new object messageerror { get; set; }
}

public partial interface ServiceWorkerContainer : EventTarget  {
  public new object controller { get; }
  public new object oncontrollerchange { get; set; }
  public new object onmessage { get; set; }
  public new object onmessageerror { get; set; }
  public new object ready { get; }
  public new object getRegistration(object clientURL);
  public new object getRegistrations();
  public new object register(object scriptURL, object options);
  public new object startMessages();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ServiceWorkerRegistrationEventMap  {
  public new object updatefound { get; set; }
}

public partial interface ServiceWorkerRegistration : EventTarget  {
  public new object active { get; }
  public new object installing { get; }
  public new object navigationPreload { get; }
  public new object onupdatefound { get; set; }
  public new object pushManager { get; }
  public new string scope { get; }
  public new object updateViaCache { get; }
  public new object waiting { get; }
  public new object getNotifications(object filter);
  public new object showNotification(string title, object options);
  public new object unregister();
  public new object update();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ShadowRootEventMap  {
  public new object slotchange { get; set; }
}

public partial interface ShadowRoot : DocumentFragment, DocumentOrShadowRoot, InnerHTML  {
  public new bool delegatesFocus { get; }
  public new object host { get; }
  public new object mode { get; }
  public new object onslotchange { get; set; }
  public new object slotAssignment { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SharedWorker : EventTarget, AbstractWorker  {
  public new object port { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Slottable  {
  public new object assignedSlot { get; }
}

public partial interface SourceBufferEventMap  {
  public new object abort { get; set; }
  public new object error { get; set; }
  public new object update { get; set; }
  public new object updateend { get; set; }
  public new object updatestart { get; set; }
}

public partial interface SourceBuffer : EventTarget  {
  public new double appendWindowEnd { get; set; }
  public new double appendWindowStart { get; set; }
  public new object buffered { get; }
  public new object mode { get; set; }
  public new object onabort { get; set; }
  public new object onerror { get; set; }
  public new object onupdate { get; set; }
  public new object onupdateend { get; set; }
  public new object onupdatestart { get; set; }
  public new double timestampOffset { get; set; }
  public new bool updating { get; }
  public new object abort();
  public new object appendBuffer(object data);
  public new object changeType(string type);
  public new object remove(double start, double end);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SourceBufferListEventMap  {
  public new object addsourcebuffer { get; set; }
  public new object removesourcebuffer { get; set; }
}

public partial interface SourceBufferList : EventTarget  {
  public new double length { get; }
  public new object onaddsourcebuffer { get; set; }
  public new object onremovesourcebuffer { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  // TODO: Unsupported member: undefined
}

public partial interface SpeechRecognitionAlternative  {
  public new double confidence { get; }
  public new string transcript { get; }
}

public partial interface SpeechRecognitionResult  {
  public new bool isFinal { get; }
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface SpeechRecognitionResultList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface SpeechSynthesisEventMap  {
  public new object voiceschanged { get; set; }
}

public partial interface SpeechSynthesis : EventTarget  {
  public new object onvoiceschanged { get; set; }
  public new bool paused { get; }
  public new bool pending { get; }
  public new bool speaking { get; }
  public new object cancel();
  public new object getVoices();
  public new object pause();
  public new object resume();
  public new object speak(object utterance);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SpeechSynthesisErrorEvent : SpeechSynthesisEvent  {
  public new object error { get; }
}

public partial interface SpeechSynthesisEvent : Event  {
  public new double charIndex { get; }
  public new double charLength { get; }
  public new double elapsedTime { get; }
  public new string name { get; }
  public new object utterance { get; }
}

public partial interface SpeechSynthesisUtteranceEventMap  {
  public new object boundary { get; set; }
  public new object end { get; set; }
  public new object error { get; set; }
  public new object mark { get; set; }
  public new object pause { get; set; }
  public new object resume { get; set; }
  public new object start { get; set; }
}

public partial interface SpeechSynthesisUtterance : EventTarget  {
  public new string lang { get; set; }
  public new object onboundary { get; set; }
  public new object onend { get; set; }
  public new object onerror { get; set; }
  public new object onmark { get; set; }
  public new object onpause { get; set; }
  public new object onresume { get; set; }
  public new object onstart { get; set; }
  public new double pitch { get; set; }
  public new double rate { get; set; }
  public new string text { get; set; }
  public new object voice { get; set; }
  public new double volume { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface SpeechSynthesisVoice  {
  public new bool defaultProperty { get; }
  public new string lang { get; }
  public new bool localService { get; }
  public new string name { get; }
  public new string voiceURI { get; }
}

public partial interface StaticRange : AbstractRange  {}

public partial interface StereoPannerNode : AudioNode  {
  public new object pan { get; }
}

public partial interface Storage  {
  public new double length { get; }
  public new object clear();
  public new object getItem(string key);
  public new object key(double index);
  public new object removeItem(string key);
  public new object setItem(string key, string value);
  // TODO: Unsupported member: undefined
}

public partial interface StorageEvent : Event  {
  public new object key { get; }
  public new object newValue { get; }
  public new object oldValue { get; }
  public new object storageArea { get; }
  public new string url { get; }
  public new object initStorageEvent(string type, bool bubbles, bool cancelable, object key, object oldValue, object newValue, object url, object storageArea);
}

public partial interface StorageManager  {
  public new object estimate();
  public new object getDirectory();
  public new object persist();
  public new object persisted();
}

public partial interface StyleMedia  {
  public new string type { get; set; }
  public new bool matchMedium(string mediaquery);
}