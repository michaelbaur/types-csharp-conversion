// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial interface StylePropertyMap : StylePropertyMapReadOnly  {
  public new object append(string property, object values);
  public new object clear();
  public new object delete(string property);
  public new object set(string property, object values);
}

public partial interface StylePropertyMapReadOnly  {
  public new double size { get; }
  public new object get(string property);
  public new object getAll(string property);
  public new bool has(string property);
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface StyleSheet  {
  public new bool disabled { get; set; }
  public new object href { get; }
  public new object media { get; }
  public new object ownerNode { get; }
  public new object parentStyleSheet { get; }
  public new object title { get; }
  public new string type { get; }
}

public partial interface StyleSheetList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface SubmitEvent : Event  {
  public new object submitter { get; }
}

public partial interface SubtleCrypto  {
  public new object decrypt(object algorithm, object key, object data);
  public new object deriveBits(object algorithm, object baseKey, double length);
  public new object deriveKey(object algorithm, object baseKey, object derivedKeyType, bool extractable, object keyUsages);
  public new object digest(object algorithm, object data);
  public new object encrypt(object algorithm, object key, object data);
  public new object exportKey(object format, object key);
  public new object exportKey(object format, object key);
  public new object generateKey(object algorithm, bool extractable, object keyUsages);
  public new object generateKey(object algorithm, bool extractable, object keyUsages);
  public new object generateKey(object algorithm, bool extractable, object keyUsages);
  public new object importKey(object format, object keyData, object algorithm, bool extractable, object keyUsages);
  public new object importKey(object format, object keyData, object algorithm, bool extractable, object keyUsages);
  public new object sign(object algorithm, object key, object data);
  public new object unwrapKey(object format, object wrappedKey, object unwrappingKey, object unwrapAlgorithm, object unwrappedKeyAlgorithm, bool extractable, object keyUsages);
  public new object verify(object algorithm, object key, object signature, object data);
  public new object wrapKey(object format, object key, object wrappingKey, object wrapAlgorithm);
}

public partial interface Text : CharacterData, Slottable  {
  public new string wholeText { get; }
  public new object splitText(double offset);
}

public partial interface TextDecoder : TextDecoderCommon  {
  public new string decode(object input, object options);
}

public partial interface TextDecoderCommon  {
  public new string encoding { get; }
  public new bool fatal { get; }
  public new bool ignoreBOM { get; }
}

public partial interface TextDecoderStream : GenericTransformStream, TextDecoderCommon  {
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface TextEncoder : TextEncoderCommon  {
  public new object encode(string input);
  public new object encodeInto(string source, object destination);
}

public partial interface TextEncoderCommon  {
  public new string encoding { get; }
}

public partial interface TextEncoderStream : GenericTransformStream, TextEncoderCommon  {
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface TextMetrics  {
  public new double actualBoundingBoxAscent { get; }
  public new double actualBoundingBoxDescent { get; }
  public new double actualBoundingBoxLeft { get; }
  public new double actualBoundingBoxRight { get; }
  public new double fontBoundingBoxAscent { get; }
  public new double fontBoundingBoxDescent { get; }
  public new double width { get; }
}

public partial interface TextTrackEventMap  {
  public new object cuechange { get; set; }
}

public partial interface TextTrack : EventTarget  {
  public new object activeCues { get; }
  public new object cues { get; }
  public new string id { get; }
  public new string inBandMetadataTrackDispatchType { get; }
  public new object kind { get; }
  public new string label { get; }
  public new string language { get; }
  public new object mode { get; set; }
  public new object oncuechange { get; set; }
  public new object addCue(object cue);
  public new object removeCue(object cue);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface TextTrackCueEventMap  {
  public new object enter { get; set; }
  public new object exit { get; set; }
}

public partial interface TextTrackCue : EventTarget  {
  public new double endTime { get; set; }
  public new string id { get; set; }
  public new object onenter { get; set; }
  public new object onexit { get; set; }
  public new bool pauseOnExit { get; set; }
  public new double startTime { get; set; }
  public new object track { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface TextTrackCueList  {
  public new double length { get; }
  public new object getCueById(string id);
  // TODO: Unsupported member: undefined
}

public partial interface TextTrackListEventMap  {
  public new object addtrack { get; set; }
  public new object change { get; set; }
  public new object removetrack { get; set; }
}

public partial interface TextTrackList : EventTarget  {
  public new double length { get; }
  public new object onaddtrack { get; set; }
  public new object onchange { get; set; }
  public new object onremovetrack { get; set; }
  public new object getTrackById(string id);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  // TODO: Unsupported member: undefined
}

public partial interface TimeRanges  {
  public new double length { get; }
  public new double end(double index);
  public new double start(double index);
}

public partial interface ToggleEvent : Event  {
  public new string newState { get; }
  public new string oldState { get; }
}

public partial interface Touch  {
  public new double clientX { get; }
  public new double clientY { get; }
  public new double force { get; }
  public new double identifier { get; }
  public new double pageX { get; }
  public new double pageY { get; }
  public new double radiusX { get; }
  public new double radiusY { get; }
  public new double rotationAngle { get; }
  public new double screenX { get; }
  public new double screenY { get; }
  public new object target { get; }
}

public partial interface TouchEvent : UIEvent  {
  public new bool altKey { get; }
  public new object changedTouches { get; }
  public new bool ctrlKey { get; }
  public new bool metaKey { get; }
  public new bool shiftKey { get; }
  public new object targetTouches { get; }
  public new object touches { get; }
}

public partial interface TouchList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface TrackEvent : Event  {
  public new object track { get; }
}

public partial interface TransformStream  {
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface TransformStreamDefaultController  {
  public new object desiredSize { get; }
  public new object enqueue(object chunk);
  public new object error(object reason);
  public new object terminate();
}

public partial interface TransitionEvent : Event  {
  public new double elapsedTime { get; }
  public new string propertyName { get; }
  public new string pseudoElement { get; }
}

public partial interface TreeWalker  {
  public new object currentNode { get; set; }
  public new object filter { get; }
  public new object root { get; }
  public new double whatToShow { get; }
  public new object firstChild();
  public new object lastChild();
  public new object nextNode();
  public new object nextSibling();
  public new object parentNode();
  public new object previousNode();
  public new object previousSibling();
}

public partial interface UIEvent : Event  {
  public new double detail { get; }
  public new object view { get; }
  public new double which { get; }
  public new object initUIEvent(string typeArg, bool bubblesArg, bool cancelableArg, object viewArg, double detailArg);
}

public partial interface URL  {
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
  public new object searchParams { get; }
  public new string username { get; set; }
  public new string toJSON();
}

public partial interface URLSearchParams  {
  public new double size { get; }
  public new object append(string name, string value);
  public new object delete(string name, string value);
  public new object get(string name);
  public new object getAll(string name);
  public new bool has(string name, string value);
  public new object set(string name, string value);
  public new object sort();
  public new string toStringMethod();
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface UserActivation  {
  public new bool hasBeenActive { get; }
  public new bool isActive { get; }
}

public partial interface VTTCue : TextTrackCue  {
  public new object align { get; set; }
  public new object line { get; set; }
  public new object lineAlign { get; set; }
  public new object position { get; set; }
  public new object positionAlign { get; set; }
  public new object region { get; set; }
  public new double size { get; set; }
  public new bool snapToLines { get; set; }
  public new string text { get; set; }
  public new object vertical { get; set; }
  public new object getCueAsHTML();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface VTTRegion  {
  public new string id { get; set; }
  public new double lines { get; set; }
  public new double regionAnchorX { get; set; }
  public new double regionAnchorY { get; set; }
  public new object scroll { get; set; }
  public new double viewportAnchorX { get; set; }
  public new double viewportAnchorY { get; set; }
  public new double width { get; set; }
}

public partial interface ValidityState  {
  public new bool badInput { get; }
  public new bool customError { get; }
  public new bool patternMismatch { get; }
  public new bool rangeOverflow { get; }
  public new bool rangeUnderflow { get; }
  public new bool stepMismatch { get; }
  public new bool tooLong { get; }
  public new bool tooShort { get; }
  public new bool typeMismatch { get; }
  public new bool valid { get; }
  public new bool valueMissing { get; }
}

public partial interface VideoColorSpace  {
  public new object fullRange { get; }
  public new object matrix { get; }
  public new object primaries { get; }
  public new object transfer { get; }
  public new object toJSON();
}

public partial interface VideoDecoderEventMap  {
  public new object dequeue { get; set; }
}

public partial interface VideoDecoder : EventTarget  {
  public new double decodeQueueSize { get; }
  public new object ondequeue { get; set; }
  public new object state { get; }
  public new object close();
  public new object configure(object config);
  public new object decode(object chunk);
  public new object flush();
  public new object reset();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface VideoEncoderEventMap  {
  public new object dequeue { get; set; }
}

public partial interface VideoEncoder : EventTarget  {
  public new double encodeQueueSize { get; }
  public new object ondequeue { get; set; }
  public new object state { get; }
  public new object close();
  public new object configure(object config);
  public new object encode(object frame, object options);
  public new object flush();
  public new object reset();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface VideoFrame  {
  public new double codedHeight { get; }
  public new object codedRect { get; }
  public new double codedWidth { get; }
  public new object colorSpace { get; }
  public new double displayHeight { get; }
  public new double displayWidth { get; }
  public new object duration { get; }
  public new object format { get; }
  public new double timestamp { get; }
  public new object visibleRect { get; }
  public new double allocationSize(object options);
  public new object clone();
  public new object close();
  public new object copyTo(object destination, object options);
}

public partial interface VideoPlaybackQuality  {
  public new double corruptedVideoFrames { get; }
  public new object creationTime { get; }
  public new double droppedVideoFrames { get; }
  public new double totalVideoFrames { get; }
}

public partial interface VisualViewportEventMap  {
  public new object resize { get; set; }
  public new object scroll { get; set; }
}

public partial interface VisualViewport : EventTarget  {
  public new double height { get; }
  public new double offsetLeft { get; }
  public new double offsetTop { get; }
  public new object onresize { get; set; }
  public new object onscroll { get; set; }
  public new double pageLeft { get; }
  public new double pageTop { get; }
  public new double scale { get; }
  public new double width { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface WEBGL_color_buffer_float  {
  public new object RGBA32F_EXT { get; }
  public new object FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT { get; }
  public new object UNSIGNED_NORMALIZED_EXT { get; }
}

public partial interface WEBGL_compressed_texture_astc  {
  public new object getSupportedProfiles();
  public new object COMPRESSED_RGBA_ASTC_4x4_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_5x4_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_5x5_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_6x5_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_6x6_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_8x5_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_8x6_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_8x8_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_10x5_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_10x6_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_10x8_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_10x10_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_12x10_KHR { get; }
  public new object COMPRESSED_RGBA_ASTC_12x12_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR { get; }
}

public partial interface WEBGL_compressed_texture_etc  {
  public new object COMPRESSED_R11_EAC { get; }
  public new object COMPRESSED_SIGNED_R11_EAC { get; }
  public new object COMPRESSED_RG11_EAC { get; }
  public new object COMPRESSED_SIGNED_RG11_EAC { get; }
  public new object COMPRESSED_RGB8_ETC2 { get; }
  public new object COMPRESSED_SRGB8_ETC2 { get; }
  public new object COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 { get; }
  public new object COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 { get; }
  public new object COMPRESSED_RGBA8_ETC2_EAC { get; }
  public new object COMPRESSED_SRGB8_ALPHA8_ETC2_EAC { get; }
}

public partial interface WEBGL_compressed_texture_etc1  {
  public new object COMPRESSED_RGB_ETC1_WEBGL { get; }
}

public partial interface WEBGL_compressed_texture_pvrtc  {
  public new object COMPRESSED_RGB_PVRTC_4BPPV1_IMG { get; }
  public new object COMPRESSED_RGB_PVRTC_2BPPV1_IMG { get; }
  public new object COMPRESSED_RGBA_PVRTC_4BPPV1_IMG { get; }
  public new object COMPRESSED_RGBA_PVRTC_2BPPV1_IMG { get; }
}

public partial interface WEBGL_compressed_texture_s3tc  {
  public new object COMPRESSED_RGB_S3TC_DXT1_EXT { get; }
  public new object COMPRESSED_RGBA_S3TC_DXT1_EXT { get; }
  public new object COMPRESSED_RGBA_S3TC_DXT3_EXT { get; }
  public new object COMPRESSED_RGBA_S3TC_DXT5_EXT { get; }
}

public partial interface WEBGL_compressed_texture_s3tc_srgb  {
  public new object COMPRESSED_SRGB_S3TC_DXT1_EXT { get; }
  public new object COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT { get; }
  public new object COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT { get; }
  public new object COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT { get; }
}

public partial interface WEBGL_debug_renderer_info  {
  public new object UNMASKED_VENDOR_WEBGL { get; }
  public new object UNMASKED_RENDERER_WEBGL { get; }
}

public partial interface WEBGL_debug_shaders  {
  public new string getTranslatedShaderSource(object shader);
}

public partial interface WEBGL_depth_texture  {
  public new object UNSIGNED_INT_24_8_WEBGL { get; }
}

public partial interface WEBGL_draw_buffers  {
  public new object drawBuffersWEBGL(object buffers);
  public new object COLOR_ATTACHMENT0_WEBGL { get; }
  public new object COLOR_ATTACHMENT1_WEBGL { get; }
  public new object COLOR_ATTACHMENT2_WEBGL { get; }
  public new object COLOR_ATTACHMENT3_WEBGL { get; }
  public new object COLOR_ATTACHMENT4_WEBGL { get; }
  public new object COLOR_ATTACHMENT5_WEBGL { get; }
  public new object COLOR_ATTACHMENT6_WEBGL { get; }
  public new object COLOR_ATTACHMENT7_WEBGL { get; }
  public new object COLOR_ATTACHMENT8_WEBGL { get; }
  public new object COLOR_ATTACHMENT9_WEBGL { get; }
  public new object COLOR_ATTACHMENT10_WEBGL { get; }
  public new object COLOR_ATTACHMENT11_WEBGL { get; }
  public new object COLOR_ATTACHMENT12_WEBGL { get; }
  public new object COLOR_ATTACHMENT13_WEBGL { get; }
  public new object COLOR_ATTACHMENT14_WEBGL { get; }
  public new object COLOR_ATTACHMENT15_WEBGL { get; }
  public new object DRAW_BUFFER0_WEBGL { get; }
  public new object DRAW_BUFFER1_WEBGL { get; }
  public new object DRAW_BUFFER2_WEBGL { get; }
  public new object DRAW_BUFFER3_WEBGL { get; }
  public new object DRAW_BUFFER4_WEBGL { get; }
  public new object DRAW_BUFFER5_WEBGL { get; }
  public new object DRAW_BUFFER6_WEBGL { get; }
  public new object DRAW_BUFFER7_WEBGL { get; }
  public new object DRAW_BUFFER8_WEBGL { get; }
  public new object DRAW_BUFFER9_WEBGL { get; }
  public new object DRAW_BUFFER10_WEBGL { get; }
  public new object DRAW_BUFFER11_WEBGL { get; }
  public new object DRAW_BUFFER12_WEBGL { get; }
  public new object DRAW_BUFFER13_WEBGL { get; }
  public new object DRAW_BUFFER14_WEBGL { get; }
  public new object DRAW_BUFFER15_WEBGL { get; }
  public new object MAX_COLOR_ATTACHMENTS_WEBGL { get; }
  public new object MAX_DRAW_BUFFERS_WEBGL { get; }
}

public partial interface WEBGL_lose_context  {
  public new object loseContext();
  public new object restoreContext();
}

public partial interface WEBGL_multi_draw  {
  public new object multiDrawArraysInstancedWEBGL(object mode, object firstsList, object firstsOffset, object countsList, object countsOffset, object instanceCountsList, object instanceCountsOffset, object drawcount);
  public new object multiDrawArraysWEBGL(object mode, object firstsList, object firstsOffset, object countsList, object countsOffset, object drawcount);
  public new object multiDrawElementsInstancedWEBGL(object mode, object countsList, object countsOffset, object type, object offsetsList, object offsetsOffset, object instanceCountsList, object instanceCountsOffset, object drawcount);
  public new object multiDrawElementsWEBGL(object mode, object countsList, object countsOffset, object type, object offsetsList, object offsetsOffset, object drawcount);
}

public partial interface WakeLock  {
  public new object request(object type);
}

public partial interface WakeLockSentinelEventMap  {
  public new object release { get; set; }
}

public partial interface WakeLockSentinel : EventTarget  {
  public new object onrelease { get; set; }
  public new bool released { get; }
  public new object type { get; }
  public new object release();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface WaveShaperNode : AudioNode  {
  public new object curve { get; set; }
  public new object oversample { get; set; }
}

public partial interface WebGL2RenderingContext : WebGL2RenderingContextBase, WebGL2RenderingContextOverloads, WebGLRenderingContextBase  {}

public partial interface WebGL2RenderingContextBase  {
  public new object beginQuery(object target, object query);
  public new object beginTransformFeedback(object primitiveMode);
  public new object bindBufferBase(object target, object index, object buffer);
  public new object bindBufferRange(object target, object index, object buffer, object offset, object size);
  public new object bindSampler(object unit, object sampler);
  public new object bindTransformFeedback(object target, object tf);
  public new object bindVertexArray(object array);
  public new object blitFramebuffer(object srcX0, object srcY0, object srcX1, object srcY1, object dstX0, object dstY0, object dstX1, object dstY1, object mask, object filter);
  public new object clearBufferfi(object buffer, object drawbuffer, object depth, object stencil);
  public new object clearBufferfv(object buffer, object drawbuffer, object values, object srcOffset);
  public new object clearBufferiv(object buffer, object drawbuffer, object values, object srcOffset);
  public new object clearBufferuiv(object buffer, object drawbuffer, object values, object srcOffset);
  public new object clientWaitSync(object sync, object flags, object timeout);
  public new object compressedTexImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object imageSize, object offset);
  public new object compressedTexImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object srcData, object srcOffset, object srcLengthOverride);
  public new object compressedTexSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object width, object height, object depth, object format, object imageSize, object offset);
  public new object compressedTexSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object width, object height, object depth, object format, object srcData, object srcOffset, object srcLengthOverride);
  public new object copyBufferSubData(object readTarget, object writeTarget, object readOffset, object writeOffset, object size);
  public new object copyTexSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object x, object y, object width, object height);
  public new object createQuery();
  public new object createSampler();
  public new object createTransformFeedback();
  public new object createVertexArray();
  public new object deleteQuery(object query);
  public new object deleteSampler(object sampler);
  public new object deleteSync(object sync);
  public new object deleteTransformFeedback(object tf);
  public new object deleteVertexArray(object vertexArray);
  public new object drawArraysInstanced(object mode, object first, object count, object instanceCount);
  public new object drawBuffers(object buffers);
  public new object drawElementsInstanced(object mode, object count, object type, object offset, object instanceCount);
  public new object drawRangeElements(object mode, object start, object end, object count, object type, object offset);
  public new object endQuery(object target);
  public new object endTransformFeedback();
  public new object fenceSync(object condition, object flags);
  public new object framebufferTextureLayer(object target, object attachment, object texture, object level, object layer);
  public new object getActiveUniformBlockName(object program, object uniformBlockIndex);
  public new object getActiveUniformBlockParameter(object program, object uniformBlockIndex, object pname);
  public new object getActiveUniforms(object program, object uniformIndices, object pname);
  public new object getBufferSubData(object target, object srcByteOffset, object dstBuffer, object dstOffset, object length);
  public new object getFragDataLocation(object program, string name);
  public new object getIndexedParameter(object target, object index);
  public new object getInternalformatParameter(object target, object internalformat, object pname);
  public new object getQuery(object target, object pname);
  public new object getQueryParameter(object query, object pname);
  public new object getSamplerParameter(object sampler, object pname);
  public new object getSyncParameter(object sync, object pname);
  public new object getTransformFeedbackVarying(object program, object index);
  public new object getUniformBlockIndex(object program, string uniformBlockName);
  public new object getUniformIndices(object program, object uniformNames);
  public new object invalidateFramebuffer(object target, object attachments);
  public new object invalidateSubFramebuffer(object target, object attachments, object x, object y, object width, object height);
  public new object isQuery(object query);
  public new object isSampler(object sampler);
  public new object isSync(object sync);
  public new object isTransformFeedback(object tf);
  public new object isVertexArray(object vertexArray);
  public new object pauseTransformFeedback();
  public new object readBuffer(object src);
  public new object renderbufferStorageMultisample(object target, object samples, object internalformat, object width, object height);
  public new object resumeTransformFeedback();
  public new object samplerParameterf(object sampler, object pname, object param);
  public new object samplerParameteri(object sampler, object pname, object param);
  public new object texImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object format, object type, object pboOffset);
  public new object texImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object format, object type, object source);
  public new object texImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object format, object type, object srcData);
  public new object texImage3D(object target, object level, object internalformat, object width, object height, object depth, object border, object format, object type, object srcData, object srcOffset);
  public new object texStorage2D(object target, object levels, object internalformat, object width, object height);
  public new object texStorage3D(object target, object levels, object internalformat, object width, object height, object depth);
  public new object texSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object width, object height, object depth, object format, object type, object pboOffset);
  public new object texSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object width, object height, object depth, object format, object type, object source);
  public new object texSubImage3D(object target, object level, object xoffset, object yoffset, object zoffset, object width, object height, object depth, object format, object type, object srcData, object srcOffset);
  public new object transformFeedbackVaryings(object program, object varyings, object bufferMode);
  public new object uniform1ui(object location, object v0);
  public new object uniform1uiv(object location, object data, object srcOffset, object srcLength);
  public new object uniform2ui(object location, object v0, object v1);
  public new object uniform2uiv(object location, object data, object srcOffset, object srcLength);
  public new object uniform3ui(object location, object v0, object v1, object v2);
  public new object uniform3uiv(object location, object data, object srcOffset, object srcLength);
  public new object uniform4ui(object location, object v0, object v1, object v2, object v3);
  public new object uniform4uiv(object location, object data, object srcOffset, object srcLength);
  public new object uniformBlockBinding(object program, object uniformBlockIndex, object uniformBlockBinding);
  public new object uniformMatrix2x3fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix2x4fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix3x2fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix3x4fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix4x2fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix4x3fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object vertexAttribDivisor(object index, object divisor);
  public new object vertexAttribI4i(object index, object x, object y, object z, object w);
  public new object vertexAttribI4iv(object index, object values);
  public new object vertexAttribI4ui(object index, object x, object y, object z, object w);
  public new object vertexAttribI4uiv(object index, object values);
  public new object vertexAttribIPointer(object index, object size, object type, object stride, object offset);
  public new object waitSync(object sync, object flags, object timeout);
  public new object READ_BUFFER { get; }
  public new object UNPACK_ROW_LENGTH { get; }
  public new object UNPACK_SKIP_ROWS { get; }
  public new object UNPACK_SKIP_PIXELS { get; }
  public new object PACK_ROW_LENGTH { get; }
  public new object PACK_SKIP_ROWS { get; }
  public new object PACK_SKIP_PIXELS { get; }
  public new object COLOR { get; }
  public new object DEPTH { get; }
  public new object STENCIL { get; }
  public new object RED { get; }
  public new object RGB8 { get; }
  public new object RGBA8 { get; }
  public new object RGB10_A2 { get; }
  public new object TEXTURE_BINDING_3D { get; }
  public new object UNPACK_SKIP_IMAGES { get; }
  public new object UNPACK_IMAGE_HEIGHT { get; }
  public new object TEXTURE_3D { get; }
  public new object TEXTURE_WRAP_R { get; }
  public new object MAX_3D_TEXTURE_SIZE { get; }
  public new object UNSIGNED_INT_2_10_10_10_REV { get; }
  public new object MAX_ELEMENTS_VERTICES { get; }
  public new object MAX_ELEMENTS_INDICES { get; }
  public new object TEXTURE_MIN_LOD { get; }
  public new object TEXTURE_MAX_LOD { get; }
  public new object TEXTURE_BASE_LEVEL { get; }
  public new object TEXTURE_MAX_LEVEL { get; }
  public new object MIN { get; }
  public new object MAX { get; }
  public new object DEPTH_COMPONENT24 { get; }
  public new object MAX_TEXTURE_LOD_BIAS { get; }
  public new object TEXTURE_COMPARE_MODE { get; }
  public new object TEXTURE_COMPARE_FUNC { get; }
  public new object CURRENT_QUERY { get; }
  public new object QUERY_RESULT { get; }
  public new object QUERY_RESULT_AVAILABLE { get; }
  public new object STREAM_READ { get; }
  public new object STREAM_COPY { get; }
  public new object STATIC_READ { get; }
  public new object STATIC_COPY { get; }
  public new object DYNAMIC_READ { get; }
  public new object DYNAMIC_COPY { get; }
  public new object MAX_DRAW_BUFFERS { get; }
  public new object DRAW_BUFFER0 { get; }
  public new object DRAW_BUFFER1 { get; }
  public new object DRAW_BUFFER2 { get; }
  public new object DRAW_BUFFER3 { get; }
  public new object DRAW_BUFFER4 { get; }
  public new object DRAW_BUFFER5 { get; }
  public new object DRAW_BUFFER6 { get; }
  public new object DRAW_BUFFER7 { get; }
  public new object DRAW_BUFFER8 { get; }
  public new object DRAW_BUFFER9 { get; }
  public new object DRAW_BUFFER10 { get; }
  public new object DRAW_BUFFER11 { get; }
  public new object DRAW_BUFFER12 { get; }
  public new object DRAW_BUFFER13 { get; }
  public new object DRAW_BUFFER14 { get; }
  public new object DRAW_BUFFER15 { get; }
  public new object MAX_FRAGMENT_UNIFORM_COMPONENTS { get; }
  public new object MAX_VERTEX_UNIFORM_COMPONENTS { get; }
  public new object SAMPLER_3D { get; }
  public new object SAMPLER_2D_SHADOW { get; }
  public new object FRAGMENT_SHADER_DERIVATIVE_HINT { get; }
  public new object PIXEL_PACK_BUFFER { get; }
  public new object PIXEL_UNPACK_BUFFER { get; }
  public new object PIXEL_PACK_BUFFER_BINDING { get; }
  public new object PIXEL_UNPACK_BUFFER_BINDING { get; }
  public new object FLOAT_MAT2x3 { get; }
  public new object FLOAT_MAT2x4 { get; }
  public new object FLOAT_MAT3x2 { get; }
  public new object FLOAT_MAT3x4 { get; }
  public new object FLOAT_MAT4x2 { get; }
  public new object FLOAT_MAT4x3 { get; }
  public new object SRGB { get; }
  public new object SRGB8 { get; }
  public new object SRGB8_ALPHA8 { get; }
  public new object COMPARE_REF_TO_TEXTURE { get; }
  public new object RGBA32F { get; }
  public new object RGB32F { get; }
  public new object RGBA16F { get; }
  public new object RGB16F { get; }
  public new object VERTEX_ATTRIB_ARRAY_INTEGER { get; }
  public new object MAX_ARRAY_TEXTURE_LAYERS { get; }
  public new object MIN_PROGRAM_TEXEL_OFFSET { get; }
  public new object MAX_PROGRAM_TEXEL_OFFSET { get; }
  public new object MAX_VARYING_COMPONENTS { get; }
  public new object TEXTURE_2D_ARRAY { get; }
  public new object TEXTURE_BINDING_2D_ARRAY { get; }
  public new object R11F_G11F_B10F { get; }
  public new object UNSIGNED_INT_10F_11F_11F_REV { get; }
  public new object RGB9_E5 { get; }
  public new object UNSIGNED_INT_5_9_9_9_REV { get; }
  public new object TRANSFORM_FEEDBACK_BUFFER_MODE { get; }
  public new object MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS { get; }
  public new object TRANSFORM_FEEDBACK_VARYINGS { get; }
  public new object TRANSFORM_FEEDBACK_BUFFER_START { get; }
  public new object TRANSFORM_FEEDBACK_BUFFER_SIZE { get; }
  public new object TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN { get; }
  public new object RASTERIZER_DISCARD { get; }
  public new object MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS { get; }
  public new object MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS { get; }
  public new object INTERLEAVED_ATTRIBS { get; }
  public new object SEPARATE_ATTRIBS { get; }
  public new object TRANSFORM_FEEDBACK_BUFFER { get; }
  public new object TRANSFORM_FEEDBACK_BUFFER_BINDING { get; }
  public new object RGBA32UI { get; }
  public new object RGB32UI { get; }
  public new object RGBA16UI { get; }
  public new object RGB16UI { get; }
  public new object RGBA8UI { get; }
  public new object RGB8UI { get; }
  public new object RGBA32I { get; }
  public new object RGB32I { get; }
  public new object RGBA16I { get; }
  public new object RGB16I { get; }
  public new object RGBA8I { get; }
  public new object RGB8I { get; }
  public new object RED_INTEGER { get; }
  public new object RGB_INTEGER { get; }
  public new object RGBA_INTEGER { get; }
  public new object SAMPLER_2D_ARRAY { get; }
  public new object SAMPLER_2D_ARRAY_SHADOW { get; }
  public new object SAMPLER_CUBE_SHADOW { get; }
  public new object UNSIGNED_INT_VEC2 { get; }
  public new object UNSIGNED_INT_VEC3 { get; }
  public new object UNSIGNED_INT_VEC4 { get; }
  public new object INT_SAMPLER_2D { get; }
  public new object INT_SAMPLER_3D { get; }
  public new object INT_SAMPLER_CUBE { get; }
  public new object INT_SAMPLER_2D_ARRAY { get; }
  public new object UNSIGNED_INT_SAMPLER_2D { get; }
  public new object UNSIGNED_INT_SAMPLER_3D { get; }
  public new object UNSIGNED_INT_SAMPLER_CUBE { get; }
  public new object UNSIGNED_INT_SAMPLER_2D_ARRAY { get; }
  public new object DEPTH_COMPONENT32F { get; }
  public new object DEPTH32F_STENCIL8 { get; }
  public new object FLOAT_32_UNSIGNED_INT_24_8_REV { get; }
  public new object FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING { get; }
  public new object FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_RED_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_GREEN_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_BLUE_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE { get; }
  public new object FRAMEBUFFER_DEFAULT { get; }
  public new object UNSIGNED_INT_24_8 { get; }
  public new object DEPTH24_STENCIL8 { get; }
  public new object UNSIGNED_NORMALIZED { get; }
  public new object DRAW_FRAMEBUFFER_BINDING { get; }
  public new object READ_FRAMEBUFFER { get; }
  public new object DRAW_FRAMEBUFFER { get; }
  public new object READ_FRAMEBUFFER_BINDING { get; }
  public new object RENDERBUFFER_SAMPLES { get; }
  public new object FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER { get; }
  public new object MAX_COLOR_ATTACHMENTS { get; }
  public new object COLOR_ATTACHMENT1 { get; }
  public new object COLOR_ATTACHMENT2 { get; }
  public new object COLOR_ATTACHMENT3 { get; }
  public new object COLOR_ATTACHMENT4 { get; }
  public new object COLOR_ATTACHMENT5 { get; }
  public new object COLOR_ATTACHMENT6 { get; }
  public new object COLOR_ATTACHMENT7 { get; }
  public new object COLOR_ATTACHMENT8 { get; }
  public new object COLOR_ATTACHMENT9 { get; }
  public new object COLOR_ATTACHMENT10 { get; }
  public new object COLOR_ATTACHMENT11 { get; }
  public new object COLOR_ATTACHMENT12 { get; }
  public new object COLOR_ATTACHMENT13 { get; }
  public new object COLOR_ATTACHMENT14 { get; }
  public new object COLOR_ATTACHMENT15 { get; }
  public new object FRAMEBUFFER_INCOMPLETE_MULTISAMPLE { get; }
  public new object MAX_SAMPLES { get; }
  public new object HALF_FLOAT { get; }
  public new object RG { get; }
  public new object RG_INTEGER { get; }
  public new object R8 { get; }
  public new object RG8 { get; }
  public new object R16F { get; }
  public new object R32F { get; }
  public new object RG16F { get; }
  public new object RG32F { get; }
  public new object R8I { get; }
  public new object R8UI { get; }
  public new object R16I { get; }
  public new object R16UI { get; }
  public new object R32I { get; }
  public new object R32UI { get; }
  public new object RG8I { get; }
  public new object RG8UI { get; }
  public new object RG16I { get; }
  public new object RG16UI { get; }
  public new object RG32I { get; }
  public new object RG32UI { get; }
  public new object VERTEX_ARRAY_BINDING { get; }
  public new object R8_SNORM { get; }
  public new object RG8_SNORM { get; }
  public new object RGB8_SNORM { get; }
  public new object RGBA8_SNORM { get; }
  public new object SIGNED_NORMALIZED { get; }
  public new object COPY_READ_BUFFER { get; }
  public new object COPY_WRITE_BUFFER { get; }
  public new object COPY_READ_BUFFER_BINDING { get; }
  public new object COPY_WRITE_BUFFER_BINDING { get; }
  public new object UNIFORM_BUFFER { get; }
  public new object UNIFORM_BUFFER_BINDING { get; }
  public new object UNIFORM_BUFFER_START { get; }
  public new object UNIFORM_BUFFER_SIZE { get; }
  public new object MAX_VERTEX_UNIFORM_BLOCKS { get; }
  public new object MAX_FRAGMENT_UNIFORM_BLOCKS { get; }
  public new object MAX_COMBINED_UNIFORM_BLOCKS { get; }
  public new object MAX_UNIFORM_BUFFER_BINDINGS { get; }
  public new object MAX_UNIFORM_BLOCK_SIZE { get; }
  public new object MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS { get; }
  public new object MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS { get; }
  public new object UNIFORM_BUFFER_OFFSET_ALIGNMENT { get; }
  public new object ACTIVE_UNIFORM_BLOCKS { get; }
  public new object UNIFORM_TYPE { get; }
  public new object UNIFORM_SIZE { get; }
  public new object UNIFORM_BLOCK_INDEX { get; }
  public new object UNIFORM_OFFSET { get; }
  public new object UNIFORM_ARRAY_STRIDE { get; }
  public new object UNIFORM_MATRIX_STRIDE { get; }
  public new object UNIFORM_IS_ROW_MAJOR { get; }
  public new object UNIFORM_BLOCK_BINDING { get; }
  public new object UNIFORM_BLOCK_DATA_SIZE { get; }
  public new object UNIFORM_BLOCK_ACTIVE_UNIFORMS { get; }
  public new object UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES { get; }
  public new object UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER { get; }
  public new object UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER { get; }
  public new object INVALID_INDEX { get; }
  public new object MAX_VERTEX_OUTPUT_COMPONENTS { get; }
  public new object MAX_FRAGMENT_INPUT_COMPONENTS { get; }
  public new object MAX_SERVER_WAIT_TIMEOUT { get; }
  public new object OBJECT_TYPE { get; }
  public new object SYNC_CONDITION { get; }
  public new object SYNC_STATUS { get; }
  public new object SYNC_FLAGS { get; }
  public new object SYNC_FENCE { get; }
  public new object SYNC_GPU_COMMANDS_COMPLETE { get; }
  public new object UNSIGNALED { get; }
  public new object SIGNALED { get; }
  public new object ALREADY_SIGNALED { get; }
  public new object TIMEOUT_EXPIRED { get; }
  public new object CONDITION_SATISFIED { get; }
  public new object WAIT_FAILED { get; }
  public new object SYNC_FLUSH_COMMANDS_BIT { get; }
  public new object VERTEX_ATTRIB_ARRAY_DIVISOR { get; }
  public new object ANY_SAMPLES_PASSED { get; }
  public new object ANY_SAMPLES_PASSED_CONSERVATIVE { get; }
  public new object SAMPLER_BINDING { get; }
  public new object RGB10_A2UI { get; }
  public new object INT_2_10_10_10_REV { get; }
  public new object TRANSFORM_FEEDBACK { get; }
  public new object TRANSFORM_FEEDBACK_PAUSED { get; }
  public new object TRANSFORM_FEEDBACK_ACTIVE { get; }
  public new object TRANSFORM_FEEDBACK_BINDING { get; }
  public new object TEXTURE_IMMUTABLE_FORMAT { get; }
  public new object MAX_ELEMENT_INDEX { get; }
  public new object TEXTURE_IMMUTABLE_LEVELS { get; }
  public new object TIMEOUT_IGNORED { get; }
  public new object MAX_CLIENT_WAIT_TIMEOUT_WEBGL { get; }
}

public partial interface WebGL2RenderingContextOverloads  {
  public new object bufferData(object target, object size, object usage);
  public new object bufferData(object target, object srcData, object usage);
  public new object bufferData(object target, object srcData, object usage, object srcOffset, object length);
  public new object bufferSubData(object target, object dstByteOffset, object srcData);
  public new object bufferSubData(object target, object dstByteOffset, object srcData, object srcOffset, object length);
  public new object compressedTexImage2D(object target, object level, object internalformat, object width, object height, object border, object imageSize, object offset);
  public new object compressedTexImage2D(object target, object level, object internalformat, object width, object height, object border, object srcData, object srcOffset, object srcLengthOverride);
  public new object compressedTexSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object imageSize, object offset);
  public new object compressedTexSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object srcData, object srcOffset, object srcLengthOverride);
  public new object readPixels(object x, object y, object width, object height, object format, object type, object dstData);
  public new object readPixels(object x, object y, object width, object height, object format, object type, object offset);
  public new object readPixels(object x, object y, object width, object height, object format, object type, object dstData, object dstOffset);
  public new object texImage2D(object target, object level, object internalformat, object width, object height, object border, object format, object type, object pixels);
  public new object texImage2D(object target, object level, object internalformat, object format, object type, object source);
  public new object texImage2D(object target, object level, object internalformat, object width, object height, object border, object format, object type, object pboOffset);
  public new object texImage2D(object target, object level, object internalformat, object width, object height, object border, object format, object type, object source);
  public new object texImage2D(object target, object level, object internalformat, object width, object height, object border, object format, object type, object srcData, object srcOffset);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object type, object pixels);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object format, object type, object source);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object type, object pboOffset);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object type, object source);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object type, object srcData, object srcOffset);
  public new object uniform1fv(object location, object data, object srcOffset, object srcLength);
  public new object uniform1iv(object location, object data, object srcOffset, object srcLength);
  public new object uniform2fv(object location, object data, object srcOffset, object srcLength);
  public new object uniform2iv(object location, object data, object srcOffset, object srcLength);
  public new object uniform3fv(object location, object data, object srcOffset, object srcLength);
  public new object uniform3iv(object location, object data, object srcOffset, object srcLength);
  public new object uniform4fv(object location, object data, object srcOffset, object srcLength);
  public new object uniform4iv(object location, object data, object srcOffset, object srcLength);
  public new object uniformMatrix2fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix3fv(object location, object transpose, object data, object srcOffset, object srcLength);
  public new object uniformMatrix4fv(object location, object transpose, object data, object srcOffset, object srcLength);
}

public partial interface WebGLActiveInfo  {
  public new string name { get; }
  public new object size { get; }
  public new object type { get; }
}

public partial interface WebGLBuffer  {}

public partial interface WebGLContextEvent : Event  {
  public new string statusMessage { get; }
}

public partial interface WebGLFramebuffer  {}

public partial interface WebGLProgram  {}

public partial interface WebGLQuery  {}

public partial interface WebGLRenderbuffer  {}

public partial interface WebGLRenderingContext : WebGLRenderingContextBase, WebGLRenderingContextOverloads  {}

public partial interface WebGLRenderingContextBase  {
  public new object canvas { get; }
  public new object drawingBufferColorSpace { get; set; }
  public new object drawingBufferHeight { get; }
  public new object drawingBufferWidth { get; }
  public new object activeTexture(object texture);
  public new object attachShader(object program, object shader);
  public new object bindAttribLocation(object program, object index, string name);
  public new object bindBuffer(object target, object buffer);
  public new object bindFramebuffer(object target, object framebuffer);
  public new object bindRenderbuffer(object target, object renderbuffer);
  public new object bindTexture(object target, object texture);
  public new object blendColor(object red, object green, object blue, object alpha);
  public new object blendEquation(object mode);
  public new object blendEquationSeparate(object modeRGB, object modeAlpha);
  public new object blendFunc(object sfactor, object dfactor);
  public new object blendFuncSeparate(object srcRGB, object dstRGB, object srcAlpha, object dstAlpha);
  public new object checkFramebufferStatus(object target);
  public new object clear(object mask);
  public new object clearColor(object red, object green, object blue, object alpha);
  public new object clearDepth(object depth);
  public new object clearStencil(object s);
  public new object colorMask(object red, object green, object blue, object alpha);
  public new object compileShader(object shader);
  public new object copyTexImage2D(object target, object level, object internalformat, object x, object y, object width, object height, object border);
  public new object copyTexSubImage2D(object target, object level, object xoffset, object yoffset, object x, object y, object width, object height);
  public new object createBuffer();
  public new object createFramebuffer();
  public new object createProgram();
  public new object createRenderbuffer();
  public new object createShader(object type);
  public new object createTexture();
  public new object cullFace(object mode);
  public new object deleteBuffer(object buffer);
  public new object deleteFramebuffer(object framebuffer);
  public new object deleteProgram(object program);
  public new object deleteRenderbuffer(object renderbuffer);
  public new object deleteShader(object shader);
  public new object deleteTexture(object texture);
  public new object depthFunc(object func);
  public new object depthMask(object flag);
  public new object depthRange(object zNear, object zFar);
  public new object detachShader(object program, object shader);
  public new object disable(object cap);
  public new object disableVertexAttribArray(object index);
  public new object drawArrays(object mode, object first, object count);
  public new object drawElements(object mode, object count, object type, object offset);
  public new object enable(object cap);
  public new object enableVertexAttribArray(object index);
  public new object finish();
  public new object flush();
  public new object framebufferRenderbuffer(object target, object attachment, object renderbuffertarget, object renderbuffer);
  public new object framebufferTexture2D(object target, object attachment, object textarget, object texture, object level);
  public new object frontFace(object mode);
  public new object generateMipmap(object target);
  public new object getActiveAttrib(object program, object index);
  public new object getActiveUniform(object program, object index);
  public new object getAttachedShaders(object program);
  public new object getAttribLocation(object program, string name);
  public new object getBufferParameter(object target, object pname);
  public new object getContextAttributes();
  public new object getError();
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(object extensionName);
  public new object getExtension(string name);
  public new object getFramebufferAttachmentParameter(object target, object attachment, object pname);
  public new object getParameter(object pname);
  public new object getProgramInfoLog(object program);
  public new object getProgramParameter(object program, object pname);
  public new object getRenderbufferParameter(object target, object pname);
  public new object getShaderInfoLog(object shader);
  public new object getShaderParameter(object shader, object pname);
  public new object getShaderPrecisionFormat(object shadertype, object precisiontype);
  public new object getShaderSource(object shader);
  public new object getSupportedExtensions();
  public new object getTexParameter(object target, object pname);
  public new object getUniform(object program, object location);
  public new object getUniformLocation(object program, string name);
  public new object getVertexAttrib(object index, object pname);
  public new object getVertexAttribOffset(object index, object pname);
  public new object hint(object target, object mode);
  public new object isBuffer(object buffer);
  public new bool isContextLost();
  public new object isEnabled(object cap);
  public new object isFramebuffer(object framebuffer);
  public new object isProgram(object program);
  public new object isRenderbuffer(object renderbuffer);
  public new object isShader(object shader);
  public new object isTexture(object texture);
  public new object lineWidth(object width);
  public new object linkProgram(object program);
  public new object pixelStorei(object pname, object param);
  public new object polygonOffset(object factor, object units);
  public new object renderbufferStorage(object target, object internalformat, object width, object height);
  public new object sampleCoverage(object value, object invert);
  public new object scissor(object x, object y, object width, object height);
  public new object shaderSource(object shader, string source);
  public new object stencilFunc(object func, object ref, object mask);
  public new object stencilFuncSeparate(object face, object func, object ref, object mask);
  public new object stencilMask(object mask);
  public new object stencilMaskSeparate(object face, object mask);
  public new object stencilOp(object fail, object zfail, object zpass);
  public new object stencilOpSeparate(object face, object fail, object zfail, object zpass);
  public new object texParameterf(object target, object pname, object param);
  public new object texParameteri(object target, object pname, object param);
  public new object uniform1f(object location, object x);
  public new object uniform1i(object location, object x);
  public new object uniform2f(object location, object x, object y);
  public new object uniform2i(object location, object x, object y);
  public new object uniform3f(object location, object x, object y, object z);
  public new object uniform3i(object location, object x, object y, object z);
  public new object uniform4f(object location, object x, object y, object z, object w);
  public new object uniform4i(object location, object x, object y, object z, object w);
  public new object useProgram(object program);
  public new object validateProgram(object program);
  public new object vertexAttrib1f(object index, object x);
  public new object vertexAttrib1fv(object index, object values);
  public new object vertexAttrib2f(object index, object x, object y);
  public new object vertexAttrib2fv(object index, object values);
  public new object vertexAttrib3f(object index, object x, object y, object z);
  public new object vertexAttrib3fv(object index, object values);
  public new object vertexAttrib4f(object index, object x, object y, object z, object w);
  public new object vertexAttrib4fv(object index, object values);
  public new object vertexAttribPointer(object index, object size, object type, object normalized, object stride, object offset);
  public new object viewport(object x, object y, object width, object height);
  public new object DEPTH_BUFFER_BIT { get; }
  public new object STENCIL_BUFFER_BIT { get; }
  public new object COLOR_BUFFER_BIT { get; }
  public new object POINTS { get; }
  public new object LINES { get; }
  public new object LINE_LOOP { get; }
  public new object LINE_STRIP { get; }
  public new object TRIANGLES { get; }
  public new object TRIANGLE_STRIP { get; }
  public new object TRIANGLE_FAN { get; }
  public new object ZERO { get; }
  public new object ONE { get; }
  public new object SRC_COLOR { get; }
  public new object ONE_MINUS_SRC_COLOR { get; }
  public new object SRC_ALPHA { get; }
  public new object ONE_MINUS_SRC_ALPHA { get; }
  public new object DST_ALPHA { get; }
  public new object ONE_MINUS_DST_ALPHA { get; }
  public new object DST_COLOR { get; }
  public new object ONE_MINUS_DST_COLOR { get; }
  public new object SRC_ALPHA_SATURATE { get; }
  public new object FUNC_ADD { get; }
  public new object BLEND_EQUATION { get; }
  public new object BLEND_EQUATION_RGB { get; }
  public new object BLEND_EQUATION_ALPHA { get; }
  public new object FUNC_SUBTRACT { get; }
  public new object FUNC_REVERSE_SUBTRACT { get; }
  public new object BLEND_DST_RGB { get; }
  public new object BLEND_SRC_RGB { get; }
  public new object BLEND_DST_ALPHA { get; }
  public new object BLEND_SRC_ALPHA { get; }
  public new object CONSTANT_COLOR { get; }
  public new object ONE_MINUS_CONSTANT_COLOR { get; }
  public new object CONSTANT_ALPHA { get; }
  public new object ONE_MINUS_CONSTANT_ALPHA { get; }
  public new object BLEND_COLOR { get; }
  public new object ARRAY_BUFFER { get; }
  public new object ELEMENT_ARRAY_BUFFER { get; }
  public new object ARRAY_BUFFER_BINDING { get; }
  public new object ELEMENT_ARRAY_BUFFER_BINDING { get; }
  public new object STREAM_DRAW { get; }
  public new object STATIC_DRAW { get; }
  public new object DYNAMIC_DRAW { get; }
  public new object BUFFER_SIZE { get; }
  public new object BUFFER_USAGE { get; }
  public new object CURRENT_VERTEX_ATTRIB { get; }
  public new object FRONT { get; }
  public new object BACK { get; }
  public new object FRONT_AND_BACK { get; }
  public new object CULL_FACE { get; }
  public new object BLEND { get; }
  public new object DITHER { get; }
  public new object STENCIL_TEST { get; }
  public new object DEPTH_TEST { get; }
  public new object SCISSOR_TEST { get; }
  public new object POLYGON_OFFSET_FILL { get; }
  public new object SAMPLE_ALPHA_TO_COVERAGE { get; }
  public new object SAMPLE_COVERAGE { get; }
  public new object NO_ERROR { get; }
  public new object INVALID_ENUM { get; }
  public new object INVALID_VALUE { get; }
  public new object INVALID_OPERATION { get; }
  public new object OUT_OF_MEMORY { get; }
  public new object CW { get; }
  public new object CCW { get; }
  public new object LINE_WIDTH { get; }
  public new object ALIASED_POINT_SIZE_RANGE { get; }
  public new object ALIASED_LINE_WIDTH_RANGE { get; }
  public new object CULL_FACE_MODE { get; }
  public new object FRONT_FACE { get; }
  public new object DEPTH_RANGE { get; }
  public new object DEPTH_WRITEMASK { get; }
  public new object DEPTH_CLEAR_VALUE { get; }
  public new object DEPTH_FUNC { get; }
  public new object STENCIL_CLEAR_VALUE { get; }
  public new object STENCIL_FUNC { get; }
  public new object STENCIL_FAIL { get; }
  public new object STENCIL_PASS_DEPTH_FAIL { get; }
  public new object STENCIL_PASS_DEPTH_PASS { get; }
  public new object STENCIL_REF { get; }
  public new object STENCIL_VALUE_MASK { get; }
  public new object STENCIL_WRITEMASK { get; }
  public new object STENCIL_BACK_FUNC { get; }
  public new object STENCIL_BACK_FAIL { get; }
  public new object STENCIL_BACK_PASS_DEPTH_FAIL { get; }
  public new object STENCIL_BACK_PASS_DEPTH_PASS { get; }
  public new object STENCIL_BACK_REF { get; }
  public new object STENCIL_BACK_VALUE_MASK { get; }
  public new object STENCIL_BACK_WRITEMASK { get; }
  public new object VIEWPORT { get; }
  public new object SCISSOR_BOX { get; }
  public new object COLOR_CLEAR_VALUE { get; }
  public new object COLOR_WRITEMASK { get; }
  public new object UNPACK_ALIGNMENT { get; }
  public new object PACK_ALIGNMENT { get; }
  public new object MAX_TEXTURE_SIZE { get; }
  public new object MAX_VIEWPORT_DIMS { get; }
  public new object SUBPIXEL_BITS { get; }
  public new object RED_BITS { get; }
  public new object GREEN_BITS { get; }
  public new object BLUE_BITS { get; }
  public new object ALPHA_BITS { get; }
  public new object DEPTH_BITS { get; }
  public new object STENCIL_BITS { get; }
  public new object POLYGON_OFFSET_UNITS { get; }
  public new object POLYGON_OFFSET_FACTOR { get; }
  public new object TEXTURE_BINDING_2D { get; }
  public new object SAMPLE_BUFFERS { get; }
  public new object SAMPLES { get; }
  public new object SAMPLE_COVERAGE_VALUE { get; }
  public new object SAMPLE_COVERAGE_INVERT { get; }
  public new object COMPRESSED_TEXTURE_FORMATS { get; }
  public new object DONT_CARE { get; }
  public new object FASTEST { get; }
  public new object NICEST { get; }
  public new object GENERATE_MIPMAP_HINT { get; }
  public new object BYTE { get; }
  public new object UNSIGNED_BYTE { get; }
  public new object SHORT { get; }
  public new object UNSIGNED_SHORT { get; }
  public new object INT { get; }
  public new object UNSIGNED_INT { get; }
  public new object FLOAT { get; }
  public new object DEPTH_COMPONENT { get; }
  public new object ALPHA { get; }
  public new object RGB { get; }
  public new object RGBA { get; }
  public new object LUMINANCE { get; }
  public new object LUMINANCE_ALPHA { get; }
  public new object UNSIGNED_SHORT_4_4_4_4 { get; }
  public new object UNSIGNED_SHORT_5_5_5_1 { get; }
  public new object UNSIGNED_SHORT_5_6_5 { get; }
  public new object FRAGMENT_SHADER { get; }
  public new object VERTEX_SHADER { get; }
  public new object MAX_VERTEX_ATTRIBS { get; }
  public new object MAX_VERTEX_UNIFORM_VECTORS { get; }
  public new object MAX_VARYING_VECTORS { get; }
  public new object MAX_COMBINED_TEXTURE_IMAGE_UNITS { get; }
  public new object MAX_VERTEX_TEXTURE_IMAGE_UNITS { get; }
  public new object MAX_TEXTURE_IMAGE_UNITS { get; }
  public new object MAX_FRAGMENT_UNIFORM_VECTORS { get; }
  public new object SHADER_TYPE { get; }
  public new object DELETE_STATUS { get; }
  public new object LINK_STATUS { get; }
  public new object VALIDATE_STATUS { get; }
  public new object ATTACHED_SHADERS { get; }
  public new object ACTIVE_UNIFORMS { get; }
  public new object ACTIVE_ATTRIBUTES { get; }
  public new object SHADING_LANGUAGE_VERSION { get; }
  public new object CURRENT_PROGRAM { get; }
  public new object NEVER { get; }
  public new object LESS { get; }
  public new object EQUAL { get; }
  public new object LEQUAL { get; }
  public new object GREATER { get; }
  public new object NOTEQUAL { get; }
  public new object GEQUAL { get; }
  public new object ALWAYS { get; }
  public new object KEEP { get; }
  public new object REPLACE { get; }
  public new object INCR { get; }
  public new object DECR { get; }
  public new object INVERT { get; }
  public new object INCR_WRAP { get; }
  public new object DECR_WRAP { get; }
  public new object VENDOR { get; }
  public new object RENDERER { get; }
  public new object VERSION { get; }
  public new object NEAREST { get; }
  public new object LINEAR { get; }
  public new object NEAREST_MIPMAP_NEAREST { get; }
  public new object LINEAR_MIPMAP_NEAREST { get; }
  public new object NEAREST_MIPMAP_LINEAR { get; }
  public new object LINEAR_MIPMAP_LINEAR { get; }
  public new object TEXTURE_MAG_FILTER { get; }
  public new object TEXTURE_MIN_FILTER { get; }
  public new object TEXTURE_WRAP_S { get; }
  public new object TEXTURE_WRAP_T { get; }
  public new object TEXTURE_2D { get; }
  public new object TEXTURE { get; }
  public new object TEXTURE_CUBE_MAP { get; }
  public new object TEXTURE_BINDING_CUBE_MAP { get; }
  public new object TEXTURE_CUBE_MAP_POSITIVE_X { get; }
  public new object TEXTURE_CUBE_MAP_NEGATIVE_X { get; }
  public new object TEXTURE_CUBE_MAP_POSITIVE_Y { get; }
  public new object TEXTURE_CUBE_MAP_NEGATIVE_Y { get; }
  public new object TEXTURE_CUBE_MAP_POSITIVE_Z { get; }
  public new object TEXTURE_CUBE_MAP_NEGATIVE_Z { get; }
  public new object MAX_CUBE_MAP_TEXTURE_SIZE { get; }
  public new object TEXTURE0 { get; }
  public new object TEXTURE1 { get; }
  public new object TEXTURE2 { get; }
  public new object TEXTURE3 { get; }
  public new object TEXTURE4 { get; }
  public new object TEXTURE5 { get; }
  public new object TEXTURE6 { get; }
  public new object TEXTURE7 { get; }
  public new object TEXTURE8 { get; }
  public new object TEXTURE9 { get; }
  public new object TEXTURE10 { get; }
  public new object TEXTURE11 { get; }
  public new object TEXTURE12 { get; }
  public new object TEXTURE13 { get; }
  public new object TEXTURE14 { get; }
  public new object TEXTURE15 { get; }
  public new object TEXTURE16 { get; }
  public new object TEXTURE17 { get; }
  public new object TEXTURE18 { get; }
  public new object TEXTURE19 { get; }
  public new object TEXTURE20 { get; }
  public new object TEXTURE21 { get; }
  public new object TEXTURE22 { get; }
  public new object TEXTURE23 { get; }
  public new object TEXTURE24 { get; }
  public new object TEXTURE25 { get; }
  public new object TEXTURE26 { get; }
  public new object TEXTURE27 { get; }
  public new object TEXTURE28 { get; }
  public new object TEXTURE29 { get; }
  public new object TEXTURE30 { get; }
  public new object TEXTURE31 { get; }
  public new object ACTIVE_TEXTURE { get; }
  public new object REPEAT { get; }
  public new object CLAMP_TO_EDGE { get; }
  public new object MIRRORED_REPEAT { get; }
  public new object FLOAT_VEC2 { get; }
  public new object FLOAT_VEC3 { get; }
  public new object FLOAT_VEC4 { get; }
  public new object INT_VEC2 { get; }
  public new object INT_VEC3 { get; }
  public new object INT_VEC4 { get; }
  public new object BOOL { get; }
  public new object BOOL_VEC2 { get; }
  public new object BOOL_VEC3 { get; }
  public new object BOOL_VEC4 { get; }
  public new object FLOAT_MAT2 { get; }
  public new object FLOAT_MAT3 { get; }
  public new object FLOAT_MAT4 { get; }
  public new object SAMPLER_2D { get; }
  public new object SAMPLER_CUBE { get; }
  public new object VERTEX_ATTRIB_ARRAY_ENABLED { get; }
  public new object VERTEX_ATTRIB_ARRAY_SIZE { get; }
  public new object VERTEX_ATTRIB_ARRAY_STRIDE { get; }
  public new object VERTEX_ATTRIB_ARRAY_TYPE { get; }
  public new object VERTEX_ATTRIB_ARRAY_NORMALIZED { get; }
  public new object VERTEX_ATTRIB_ARRAY_POINTER { get; }
  public new object VERTEX_ATTRIB_ARRAY_BUFFER_BINDING { get; }
  public new object IMPLEMENTATION_COLOR_READ_TYPE { get; }
  public new object IMPLEMENTATION_COLOR_READ_FORMAT { get; }
  public new object COMPILE_STATUS { get; }
  public new object LOW_FLOAT { get; }
  public new object MEDIUM_FLOAT { get; }
  public new object HIGH_FLOAT { get; }
  public new object LOW_INT { get; }
  public new object MEDIUM_INT { get; }
  public new object HIGH_INT { get; }
  public new object FRAMEBUFFER { get; }
  public new object RENDERBUFFER { get; }
  public new object RGBA4 { get; }
  public new object RGB5_A1 { get; }
  public new object RGB565 { get; }
  public new object DEPTH_COMPONENT16 { get; }
  public new object STENCIL_INDEX8 { get; }
  public new object DEPTH_STENCIL { get; }
  public new object RENDERBUFFER_WIDTH { get; }
  public new object RENDERBUFFER_HEIGHT { get; }
  public new object RENDERBUFFER_INTERNAL_FORMAT { get; }
  public new object RENDERBUFFER_RED_SIZE { get; }
  public new object RENDERBUFFER_GREEN_SIZE { get; }
  public new object RENDERBUFFER_BLUE_SIZE { get; }
  public new object RENDERBUFFER_ALPHA_SIZE { get; }
  public new object RENDERBUFFER_DEPTH_SIZE { get; }
  public new object RENDERBUFFER_STENCIL_SIZE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE { get; }
  public new object FRAMEBUFFER_ATTACHMENT_OBJECT_NAME { get; }
  public new object FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL { get; }
  public new object FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE { get; }
  public new object COLOR_ATTACHMENT0 { get; }
  public new object DEPTH_ATTACHMENT { get; }
  public new object STENCIL_ATTACHMENT { get; }
  public new object DEPTH_STENCIL_ATTACHMENT { get; }
  public new object NONE { get; }
  public new object FRAMEBUFFER_COMPLETE { get; }
  public new object FRAMEBUFFER_INCOMPLETE_ATTACHMENT { get; }
  public new object FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT { get; }
  public new object FRAMEBUFFER_INCOMPLETE_DIMENSIONS { get; }
  public new object FRAMEBUFFER_UNSUPPORTED { get; }
  public new object FRAMEBUFFER_BINDING { get; }
  public new object RENDERBUFFER_BINDING { get; }
  public new object MAX_RENDERBUFFER_SIZE { get; }
  public new object INVALID_FRAMEBUFFER_OPERATION { get; }
  public new object UNPACK_FLIP_Y_WEBGL { get; }
  public new object UNPACK_PREMULTIPLY_ALPHA_WEBGL { get; }
  public new object CONTEXT_LOST_WEBGL { get; }
  public new object UNPACK_COLORSPACE_CONVERSION_WEBGL { get; }
  public new object BROWSER_DEFAULT_WEBGL { get; }
}

public partial interface WebGLRenderingContextOverloads  {
  public new object bufferData(object target, object size, object usage);
  public new object bufferData(object target, object data, object usage);
  public new object bufferSubData(object target, object offset, object data);
  public new object compressedTexImage2D(object target, object level, object internalformat, object width, object height, object border, object data);
  public new object compressedTexSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object data);
  public new object readPixels(object x, object y, object width, object height, object format, object type, object pixels);
  public new object texImage2D(object target, object level, object internalformat, object width, object height, object border, object format, object type, object pixels);
  public new object texImage2D(object target, object level, object internalformat, object format, object type, object source);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object width, object height, object format, object type, object pixels);
  public new object texSubImage2D(object target, object level, object xoffset, object yoffset, object format, object type, object source);
  public new object uniform1fv(object location, object v);
  public new object uniform1iv(object location, object v);
  public new object uniform2fv(object location, object v);
  public new object uniform2iv(object location, object v);
  public new object uniform3fv(object location, object v);
  public new object uniform3iv(object location, object v);
  public new object uniform4fv(object location, object v);
  public new object uniform4iv(object location, object v);
  public new object uniformMatrix2fv(object location, object transpose, object value);
  public new object uniformMatrix3fv(object location, object transpose, object value);
  public new object uniformMatrix4fv(object location, object transpose, object value);
}

public partial interface WebGLSampler  {}

public partial interface WebGLShader  {}

public partial interface WebGLShaderPrecisionFormat  {
  public new object precision { get; }
  public new object rangeMax { get; }
  public new object rangeMin { get; }
}

public partial interface WebGLSync  {}

public partial interface WebGLTexture  {}

public partial interface WebGLTransformFeedback  {}

public partial interface WebGLUniformLocation  {}

public partial interface WebGLVertexArrayObject  {}

public partial interface WebGLVertexArrayObjectOES  {}

public partial interface WebSocketEventMap  {
  public new object close { get; set; }
  public new object error { get; set; }
  public new object message { get; set; }
  public new object open { get; set; }
}

public partial interface WebSocket : EventTarget  {
  public new object binaryType { get; set; }
  public new double bufferedAmount { get; }
  public new string extensions { get; }
  public new object onclose { get; set; }
  public new object onerror { get; set; }
  public new object onmessage { get; set; }
  public new object onopen { get; set; }
  public new string protocol { get; }
  public new double readyState { get; }
  public new string url { get; }
  public new object close(double code, string reason);
  public new object send(object data);
  public new object CONNECTING { get; }
  public new object OPEN { get; }
  public new object CLOSING { get; }
  public new object CLOSED { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface WebTransport  {
  public new object closed { get; }
  public new object datagrams { get; }
  public new object incomingBidirectionalStreams { get; }
  public new object incomingUnidirectionalStreams { get; }
  public new object ready { get; }
  public new object close(object closeInfo);
  public new object createBidirectionalStream(object options);
  public new object createUnidirectionalStream(object options);
}

public partial interface WebTransportBidirectionalStream  {
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface WebTransportDatagramDuplexStream  {
  public new double incomingHighWaterMark { get; set; }
  public new double incomingMaxAge { get; set; }
  public new double maxDatagramSize { get; }
  public new double outgoingHighWaterMark { get; set; }
  public new double outgoingMaxAge { get; set; }
  public new object readable { get; }
  public new object writable { get; }
}

public partial interface WebTransportError : DOMException  {
  public new object source { get; }
  public new object streamErrorCode { get; }
}

public partial interface WheelEvent : MouseEvent  {
  public new double deltaMode { get; }
  public new double deltaX { get; }
  public new double deltaY { get; }
  public new double deltaZ { get; }
  public new object DOM_DELTA_PIXEL { get; }
  public new object DOM_DELTA_LINE { get; }
  public new object DOM_DELTA_PAGE { get; }
}

public partial interface WindowEventMap : GlobalEventHandlersEventMap, WindowEventHandlersEventMap  {
  public new object DOMContentLoaded { get; set; }
  public new object devicemotion { get; set; }
  public new object deviceorientation { get; set; }
  public new object gamepadconnected { get; set; }
  public new object gamepaddisconnected { get; set; }
  public new object orientationchange { get; set; }
}

public partial interface Window : EventTarget, AnimationFrameProvider, GlobalEventHandlers, WindowEventHandlers, WindowLocalStorage, WindowOrWorkerGlobalScope, WindowSessionStorage  {
  public new object clientInformation { get; }
  public new bool closed { get; }
  public new object customElements { get; }
  public new double devicePixelRatio { get; }
  public new object document { get; }
  public new object eventProperty { get; }
  public new object external { get; }
  public new object frameElement { get; }
  public new object frames { get; }
  public new object history { get; }
  public new double innerHeight { get; }
  public new double innerWidth { get; }
  public new double length { get; }
  // TODO: Unsupported member: [object Object]
  // TODO: Unsupported member: [object Object]
  public new object locationbar { get; }
  public new object menubar { get; }
  public new string name { get; set; }
  public new object navigator { get; }
  public new object ondevicemotion { get; set; }
  public new object ondeviceorientation { get; set; }
  public new object onorientationchange { get; set; }
  public new object opener { get; set; }
  public new double orientation { get; }
  public new double outerHeight { get; }
  public new double outerWidth { get; }
  public new double pageXOffset { get; }
  public new double pageYOffset { get; }
  public new object parent { get; }
  public new object personalbar { get; }
  public new object screen { get; }
  public new double screenLeft { get; }
  public new double screenTop { get; }
  public new double screenX { get; }
  public new double screenY { get; }
  public new double scrollX { get; }
  public new double scrollY { get; }
  public new object scrollbars { get; }
  public new object self { get; }
  public new object speechSynthesis { get; }
  public new string status { get; set; }
  public new object statusbar { get; }
  public new object toolbar { get; }
  public new object top { get; }
  public new object visualViewport { get; }
  public new object window { get; }
  public new object alert(object message);
  public new object blur();
  public new object cancelIdleCallback(double handle);
  public new object captureEvents();
  public new object close();
  public new bool confirm(string message);
  public new object focus();
  public new object getComputedStyle(object elt, object pseudoElt);
  public new object getSelection();
  public new object matchMedia(string query);
  public new object moveBy(double x, double y);
  public new object moveTo(double x, double y);
  public new object open(object url, string target, string features);
  public new object postMessage(object message, string targetOrigin, object transfer);
  public new object postMessage(object message, object options);
  public new object print();
  public new object prompt(string message, string _default);
  public new object releaseEvents();
  public new double requestIdleCallback(object callback, object options);
  public new object resizeBy(double x, double y);
  public new object resizeTo(double width, double height);
  public new object scroll(object options);
  public new object scroll(double x, double y);
  public new object scrollBy(object options);
  public new object scrollBy(double x, double y);
  public new object scrollTo(object options);
  public new object scrollTo(double x, double y);
  public new object stop();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
  // TODO: Unsupported member: undefined
}

public partial interface WindowEventHandlersEventMap  {
  public new object afterprint { get; set; }
  public new object beforeprint { get; set; }
  public new object beforeunload { get; set; }
  public new object gamepadconnected { get; set; }
  public new object gamepaddisconnected { get; set; }
  public new object hashchange { get; set; }
  public new object languagechange { get; set; }
  public new object message { get; set; }
  public new object messageerror { get; set; }
  public new object offline { get; set; }
  public new object online { get; set; }
  public new object pagehide { get; set; }
  public new object pageshow { get; set; }
  public new object popstate { get; set; }
  public new object rejectionhandled { get; set; }
  public new object storage { get; set; }
  public new object unhandledrejection { get; set; }
  public new object unload { get; set; }
}

public partial interface WindowEventHandlers  {
  public new object onafterprint { get; set; }
  public new object onbeforeprint { get; set; }
  public new object onbeforeunload { get; set; }
  public new object ongamepadconnected { get; set; }
  public new object ongamepaddisconnected { get; set; }
  public new object onhashchange { get; set; }
  public new object onlanguagechange { get; set; }
  public new object onmessage { get; set; }
  public new object onmessageerror { get; set; }
  public new object onoffline { get; set; }
  public new object ononline { get; set; }
  public new object onpagehide { get; set; }
  public new object onpageshow { get; set; }
  public new object onpopstate { get; set; }
  public new object onrejectionhandled { get; set; }
  public new object onstorage { get; set; }
  public new object onunhandledrejection { get; set; }
  public new object onunload { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface WindowLocalStorage  {
  public new object localStorage { get; }
}

public partial interface WindowOrWorkerGlobalScope  {
  public new object caches { get; }
  public new bool crossOriginIsolated { get; }
  public new object crypto { get; }
  public new object indexedDB { get; }
  public new bool isSecureContext { get; }
  public new string origin { get; }
  public new object performance { get; }
  public new string atob(string data);
  public new string btoa(string data);
  public new object clearInterval(object id);
  public new object clearTimeout(object id);
  public new object createImageBitmap(object image, object options);
  public new object createImageBitmap(object image, double sx, double sy, double sw, double sh, object options);
  public new object fetch(object input, object init);
  public new object queueMicrotask(object callback);
  public new object reportError(object e);
  public new double setInterval(object handler, double timeout, object arguments);
  public new double setTimeout(object handler, double timeout, object arguments);
  public new object structuredClone(object value, object options);
}

public partial interface WindowSessionStorage  {
  public new object sessionStorage { get; }
}

public partial interface WorkerEventMap : AbstractWorkerEventMap  {
  public new object message { get; set; }
  public new object messageerror { get; set; }
}

public partial interface Worker : EventTarget, AbstractWorker  {
  public new object onmessage { get; set; }
  public new object onmessageerror { get; set; }
  public new object postMessage(object message, object transfer);
  public new object postMessage(object message, object options);
  public new object terminate();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface Worklet  {
  public new object addModule(object moduleURL, object options);
}

public partial interface WritableStream  {
  public new bool locked { get; }
  public new object abort(object reason);
  public new object close();
  public new object getWriter();
}

public partial interface WritableStreamDefaultController  {
  public new object signal { get; }
  public new object error(object e);
}

public partial interface WritableStreamDefaultWriter  {
  public new object closed { get; }
  public new object desiredSize { get; }
  public new object ready { get; }
  public new object abort(object reason);
  public new object close();
  public new object releaseLock();
  public new object write(object chunk);
}

public partial interface XMLDocument : Document  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface XMLHttpRequestEventMap : XMLHttpRequestEventTargetEventMap  {
  public new object readystatechange { get; set; }
}

public partial interface XMLHttpRequest : XMLHttpRequestEventTarget  {
  public new object onreadystatechange { get; set; }
  public new double readyState { get; }
  public new object response { get; }
  public new string responseText { get; }
  public new object responseType { get; set; }
  public new string responseURL { get; }
  public new object responseXML { get; }
  public new double status { get; }
  public new string statusText { get; }
  public new double timeout { get; set; }
  public new object upload { get; }
  public new bool withCredentials { get; set; }
  public new object abort();
  public new string getAllResponseHeaders();
  public new object getResponseHeader(string name);
  public new object open(string method, object url);
  public new object open(string method, object url, bool async, object username, object password);
  public new object overrideMimeType(string mime);
  public new object send(object body);
  public new object setRequestHeader(string name, string value);
  public new object UNSENT { get; }
  public new object OPENED { get; }
  public new object HEADERS_RECEIVED { get; }
  public new object LOADING { get; }
  public new object DONE { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface XMLHttpRequestEventTargetEventMap  {
  public new object abort { get; set; }
  public new object error { get; set; }
  public new object load { get; set; }
  public new object loadend { get; set; }
  public new object loadstart { get; set; }
  public new object progress { get; set; }
  public new object timeout { get; set; }
}

public partial interface XMLHttpRequestEventTarget : EventTarget  {
  public new object onabort { get; set; }
  public new object onerror { get; set; }
  public new object onload { get; set; }
  public new object onloadend { get; set; }
  public new object onloadstart { get; set; }
  public new object onprogress { get; set; }
  public new object ontimeout { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface XMLHttpRequestUpload : XMLHttpRequestEventTarget  {
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface XMLSerializer  {
  public new string serializeToString(object root);
}

public partial interface XPathEvaluator : XPathEvaluatorBase  {}

public partial interface XPathEvaluatorBase  {
  public new object createExpression(string expression, object resolver);
  public new object createNSResolver(object nodeResolver);
  public new object evaluate(string expression, object contextNode, object resolver, double type, object result);
}

public partial interface XPathExpression  {
  public new object evaluate(object contextNode, double type, object result);
}

public partial interface XPathResult  {
  public new bool booleanValue { get; }
  public new bool invalidIteratorState { get; }
  public new double numberValue { get; }
  public new double resultType { get; }
  public new object singleNodeValue { get; }
  public new double snapshotLength { get; }
  public new string stringValue { get; }
  public new object iterateNext();
  public new object snapshotItem(double index);
  public new object ANY_TYPE { get; }
  public new object NUMBER_TYPE { get; }
  public new object STRING_TYPE { get; }
  public new object BOOLEAN_TYPE { get; }
  public new object UNORDERED_NODE_ITERATOR_TYPE { get; }
  public new object ORDERED_NODE_ITERATOR_TYPE { get; }
  public new object UNORDERED_NODE_SNAPSHOT_TYPE { get; }
  public new object ORDERED_NODE_SNAPSHOT_TYPE { get; }
  public new object ANY_UNORDERED_NODE_TYPE { get; }
  public new object FIRST_ORDERED_NODE_TYPE { get; }
}

public partial interface XSLTProcessor  {
  public new object clearParameters();
  public new object getParameter(object namespaceURI, string localName);
  public new object importStylesheet(object style);
  public new object removeParameter(object namespaceURI, string localName);
  public new object reset();
  public new object setParameter(object namespaceURI, string localName, object value);
  public new object transformToDocument(object source);
  public new object transformToFragment(object source, object output);
}

public partial interface Console  {
  public new object assert(bool condition, object data);
  public new object clear();
  public new object count(string label);
  public new object countReset(string label);
  public new object debug(object data);
  public new object dir(object item, object options);
  public new object dirxml(object data);
  public new object error(object data);
  public new object group(object data);
  public new object groupCollapsed(object data);
  public new object groupEnd();
  public new object info(object data);
  public new object log(object data);
  public new object table(object tabularData, object properties);
  public new object time(string label);
  public new object timeEnd(string label);
  public new object timeLog(string label, object data);
  public new object timeStamp(string label);
  public new object trace(object data);
  public new object warn(object data);
}

public partial interface BlobCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface CustomElementConstructor  {
  // TODO: Unsupported member: undefined
}

public partial interface DecodeErrorCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface DecodeSuccessCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface EncodedVideoChunkOutputCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface ErrorCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface FileCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface FileSystemEntriesCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface FileSystemEntryCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface FrameRequestCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface FunctionStringCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface IdleRequestCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface IntersectionObserverCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface LockGrantedCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface MediaSessionActionHandler  {
  // TODO: Unsupported member: undefined
}

public partial interface MutationCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface NotificationPermissionCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface OnBeforeUnloadEventHandlerNonNull  {
  // TODO: Unsupported member: undefined
}

public partial interface OnErrorEventHandlerNonNull  {
  // TODO: Unsupported member: undefined
}

public partial interface PerformanceObserverCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface PositionCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface PositionErrorCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface QueuingStrategySize  {
  // TODO: Unsupported member: undefined
}

public partial interface RTCPeerConnectionErrorCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface RTCSessionDescriptionCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface RemotePlaybackAvailabilityCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface ReportingObserverCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface ResizeObserverCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface TransformerFlushCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface TransformerStartCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface TransformerTransformCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSinkAbortCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSinkCloseCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSinkStartCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSinkWriteCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSourceCancelCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSourcePullCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface UnderlyingSourceStartCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface VideoFrameOutputCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface VideoFrameRequestCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface VoidFunction  {
  // TODO: Unsupported member: undefined
}

public partial interface WebCodecsErrorCallback  {
  // TODO: Unsupported member: undefined
}

public partial interface HTMLElementTagNameMap  {
  public new object a { get; set; }
  public new object abbr { get; set; }
  public new object address { get; set; }
  public new object area { get; set; }
  public new object article { get; set; }
  public new object aside { get; set; }
  public new object audio { get; set; }
  public new object b { get; set; }
  public new object baseProperty { get; set; }
  public new object bdi { get; set; }
  public new object bdo { get; set; }
  public new object blockquote { get; set; }
  public new object body { get; set; }
  public new object br { get; set; }
  public new object button { get; set; }
  public new object canvas { get; set; }
  public new object caption { get; set; }
  public new object cite { get; set; }
  public new object code { get; set; }
  public new object col { get; set; }
  public new object colgroup { get; set; }
  public new object data { get; set; }
  public new object datalist { get; set; }
  public new object dd { get; set; }
  public new object del { get; set; }
  public new object details { get; set; }
  public new object dfn { get; set; }
  public new object dialog { get; set; }
  public new object div { get; set; }
  public new object dl { get; set; }
  public new object dt { get; set; }
  public new object em { get; set; }
  public new object embed { get; set; }
  public new object fieldset { get; set; }
  public new object figcaption { get; set; }
  public new object figure { get; set; }
  public new object footer { get; set; }
  public new object form { get; set; }
  public new object h1 { get; set; }
  public new object h2 { get; set; }
  public new object h3 { get; set; }
  public new object h4 { get; set; }
  public new object h5 { get; set; }
  public new object h6 { get; set; }
  public new object head { get; set; }
  public new object header { get; set; }
  public new object hgroup { get; set; }
  public new object hr { get; set; }
  public new object html { get; set; }
  public new object i { get; set; }
  public new object iframe { get; set; }
  public new object img { get; set; }
  public new object input { get; set; }
  public new object ins { get; set; }
  public new object kbd { get; set; }
  public new object label { get; set; }
  public new object legend { get; set; }
  public new object li { get; set; }
  public new object link { get; set; }
  public new object main { get; set; }
  public new object map { get; set; }
  public new object mark { get; set; }
  public new object menu { get; set; }
  public new object meta { get; set; }
  public new object meter { get; set; }
  public new object nav { get; set; }
  public new object noscript { get; set; }
  public new object objectProperty { get; set; }
  public new object ol { get; set; }
  public new object optgroup { get; set; }
  public new object option { get; set; }
  public new object output { get; set; }
  public new object p { get; set; }
  public new object picture { get; set; }
  public new object pre { get; set; }
  public new object progress { get; set; }
  public new object q { get; set; }
  public new object rp { get; set; }
  public new object rt { get; set; }
  public new object ruby { get; set; }
  public new object s { get; set; }
  public new object samp { get; set; }
  public new object script { get; set; }
  public new object search { get; set; }
  public new object section { get; set; }
  public new object select { get; set; }
  public new object slot { get; set; }
  public new object small { get; set; }
  public new object source { get; set; }
  public new object span { get; set; }
  public new object strong { get; set; }
  public new object style { get; set; }
  public new object sub { get; set; }
  public new object summary { get; set; }
  public new object sup { get; set; }
  public new object table { get; set; }
  public new object tbody { get; set; }
  public new object td { get; set; }
  public new object template { get; set; }
  public new object textarea { get; set; }
  public new object tfoot { get; set; }
  public new object th { get; set; }
  public new object thead { get; set; }
  public new object time { get; set; }
  public new object title { get; set; }
  public new object tr { get; set; }
  public new object track { get; set; }
  public new object u { get; set; }
  public new object ul { get; set; }
  public new object var { get; set; }
  public new object video { get; set; }
  public new object wbr { get; set; }
}

public partial interface HTMLElementDeprecatedTagNameMap  {
  public new object acronym { get; set; }
  public new object applet { get; set; }
  public new object basefont { get; set; }
  public new object bgsound { get; set; }
  public new object big { get; set; }
  public new object blink { get; set; }
  public new object center { get; set; }
  public new object dir { get; set; }
  public new object font { get; set; }
  public new object frame { get; set; }
  public new object frameset { get; set; }
  public new object isindex { get; set; }
  public new object keygen { get; set; }
  public new object listing { get; set; }
  public new object marquee { get; set; }
  public new object menuitem { get; set; }
  public new object multicol { get; set; }
  public new object nextid { get; set; }
  public new object nobr { get; set; }
  public new object noembed { get; set; }
  public new object noframes { get; set; }
  public new object param { get; set; }
  public new object plaintext { get; set; }
  public new object rb { get; set; }
  public new object rtc { get; set; }
  public new object spacer { get; set; }
  public new object strike { get; set; }
  public new object tt { get; set; }
  public new object xmp { get; set; }
}

public partial interface SVGElementTagNameMap  {
  public new object a { get; set; }
  public new object animate { get; set; }
  public new object animateMotion { get; set; }
  public new object animateTransform { get; set; }
  public new object circle { get; set; }
  public new object clipPath { get; set; }
  public new object defs { get; set; }
  public new object desc { get; set; }
  public new object ellipse { get; set; }
  public new object feBlend { get; set; }
  public new object feColorMatrix { get; set; }
  public new object feComponentTransfer { get; set; }
  public new object feComposite { get; set; }
  public new object feConvolveMatrix { get; set; }
  public new object feDiffuseLighting { get; set; }
  public new object feDisplacementMap { get; set; }
  public new object feDistantLight { get; set; }
  public new object feDropShadow { get; set; }
  public new object feFlood { get; set; }
  public new object feFuncA { get; set; }
  public new object feFuncB { get; set; }
  public new object feFuncG { get; set; }
  public new object feFuncR { get; set; }
  public new object feGaussianBlur { get; set; }
  public new object feImage { get; set; }
  public new object feMerge { get; set; }
  public new object feMergeNode { get; set; }
  public new object feMorphology { get; set; }
  public new object feOffset { get; set; }
  public new object fePointLight { get; set; }
  public new object feSpecularLighting { get; set; }
  public new object feSpotLight { get; set; }
  public new object feTile { get; set; }
  public new object feTurbulence { get; set; }
  public new object filter { get; set; }
  public new object foreignObject { get; set; }
  public new object g { get; set; }
  public new object image { get; set; }
  public new object line { get; set; }
  public new object linearGradient { get; set; }
  public new object marker { get; set; }
  public new object mask { get; set; }
  public new object metadata { get; set; }
  public new object mpath { get; set; }
  public new object path { get; set; }
  public new object pattern { get; set; }
  public new object polygon { get; set; }
  public new object polyline { get; set; }
  public new object radialGradient { get; set; }
  public new object rect { get; set; }
  public new object script { get; set; }
  public new object set { get; set; }
  public new object stop { get; set; }
  public new object style { get; set; }
  public new object svg { get; set; }
  public new object switchProperty { get; set; }
  public new object symbol { get; set; }
  public new object text { get; set; }
  public new object textPath { get; set; }
  public new object title { get; set; }
  public new object tspan { get; set; }
  public new object use { get; set; }
  public new object view { get; set; }
}

public partial interface MathMLElementTagNameMap  {
  public new object annotation { get; set; }
  public new object annotation-xml { get; set; }
  public new object maction { get; set; }
  public new object math { get; set; }
  public new object merror { get; set; }
  public new object mfrac { get; set; }
  public new object mi { get; set; }
  public new object mmultiscripts { get; set; }
  public new object mn { get; set; }
  public new object mo { get; set; }
  public new object mover { get; set; }
  public new object mpadded { get; set; }
  public new object mphantom { get; set; }
  public new object mprescripts { get; set; }
  public new object mroot { get; set; }
  public new object mrow { get; set; }
  public new object ms { get; set; }
  public new object mspace { get; set; }
  public new object msqrt { get; set; }
  public new object mstyle { get; set; }
  public new object msub { get; set; }
  public new object msubsup { get; set; }
  public new object msup { get; set; }
  public new object mtable { get; set; }
  public new object mtd { get; set; }
  public new object mtext { get; set; }
  public new object mtr { get; set; }
  public new object munder { get; set; }
  public new object munderover { get; set; }
  public new object semantics { get; set; }
}