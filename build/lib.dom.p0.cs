// ReSharper disable InconsistentNaming, RedundantExtendsListEntry
#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public interface Error { }

public partial interface AddEventListenerOptions : EventListenerOptions  {
  public new bool once { get; set; }
  public new bool passive { get; set; }
  public new object signal { get; set; }
}

public partial interface AesCbcParams : Algorithm  {
  public new object iv { get; set; }
}

public partial interface AesCtrParams : Algorithm  {
  public new object counter { get; set; }
  public new double length { get; set; }
}

public partial interface AesDerivedKeyParams : Algorithm  {
  public new double length { get; set; }
}

public partial interface AesGcmParams : Algorithm  {
  public new object additionalData { get; set; }
  public new object iv { get; set; }
  public new double tagLength { get; set; }
}

public partial interface AesKeyAlgorithm : KeyAlgorithm  {
  public new double length { get; set; }
}

public partial interface AesKeyGenParams : Algorithm  {
  public new double length { get; set; }
}

public partial interface Algorithm  {
  public new string name { get; set; }
}

public partial interface AnalyserOptions : AudioNodeOptions  {
  public new double fftSize { get; set; }
  public new double maxDecibels { get; set; }
  public new double minDecibels { get; set; }
  public new double smoothingTimeConstant { get; set; }
}

public partial interface AnimationEventInit : EventInit  {
  public new string animationName { get; set; }
  public new double elapsedTime { get; set; }
  public new string pseudoElement { get; set; }
}

public partial interface AnimationPlaybackEventInit : EventInit  {
  public new object currentTime { get; set; }
  public new object timelineTime { get; set; }
}

public partial interface AssignedNodesOptions  {
  public new bool flatten { get; set; }
}

public partial interface AudioBufferOptions  {
  public new double length { get; set; }
  public new double numberOfChannels { get; set; }
  public new double sampleRate { get; set; }
}

public partial interface AudioBufferSourceOptions  {
  public new object buffer { get; set; }
  public new double detune { get; set; }
  public new bool loop { get; set; }
  public new double loopEnd { get; set; }
  public new double loopStart { get; set; }
  public new double playbackRate { get; set; }
}

public partial interface AudioConfiguration  {
  public new double bitrate { get; set; }
  public new string channels { get; set; }
  public new string contentType { get; set; }
  public new double samplerate { get; set; }
  public new bool spatialRendering { get; set; }
}

public partial interface AudioContextOptions  {
  public new object latencyHint { get; set; }
  public new double sampleRate { get; set; }
}

public partial interface AudioNodeOptions  {
  public new double channelCount { get; set; }
  public new object channelCountMode { get; set; }
  public new object channelInterpretation { get; set; }
}

public partial interface AudioProcessingEventInit : EventInit  {
  public new object inputBuffer { get; set; }
  public new object outputBuffer { get; set; }
  public new double playbackTime { get; set; }
}

public partial interface AudioTimestamp  {
  public new double contextTime { get; set; }
  public new object performanceTime { get; set; }
}

public partial interface AudioWorkletNodeOptions : AudioNodeOptions  {
  public new double numberOfInputs { get; set; }
  public new double numberOfOutputs { get; set; }
  public new object outputChannelCount { get; set; }
  public new object parameterData { get; set; }
  public new object processorOptions { get; set; }
}

public partial interface AuthenticationExtensionsClientInputs  {
  public new string appid { get; set; }
  public new bool credProps { get; set; }
  public new bool hmacCreateSecret { get; set; }
}

public partial interface AuthenticationExtensionsClientOutputs  {
  public new bool appid { get; set; }
  public new object credProps { get; set; }
  public new bool hmacCreateSecret { get; set; }
}

public partial interface AuthenticatorSelectionCriteria  {
  public new object authenticatorAttachment { get; set; }
  public new bool requireResidentKey { get; set; }
  public new object residentKey { get; set; }
  public new object userVerification { get; set; }
}

public partial interface AvcEncoderConfig  {
  public new object format { get; set; }
}

public partial interface BiquadFilterOptions : AudioNodeOptions  {
  public new double Q { get; set; }
  public new double detune { get; set; }
  public new double frequency { get; set; }
  public new double gain { get; set; }
  public new object type { get; set; }
}

public partial interface BlobEventInit  {
  public new object data { get; set; }
  public new object timecode { get; set; }
}

public partial interface BlobPropertyBag  {
  public new object endings { get; set; }
  public new string type { get; set; }
}

public partial interface CSSMatrixComponentOptions  {
  public new bool is2D { get; set; }
}

public partial interface CSSNumericType  {
  public new double angle { get; set; }
  public new double flex { get; set; }
  public new double frequency { get; set; }
  public new double length { get; set; }
  public new double percent { get; set; }
  public new object percentHint { get; set; }
  public new double resolution { get; set; }
  public new double time { get; set; }
}

public partial interface CSSStyleSheetInit  {
  public new string baseURL { get; set; }
  public new bool disabled { get; set; }
  public new object media { get; set; }
}

public partial interface CacheQueryOptions  {
  public new bool ignoreMethod { get; set; }
  public new bool ignoreSearch { get; set; }
  public new bool ignoreVary { get; set; }
}

public partial interface CanvasRenderingContext2DSettings  {
  public new bool alpha { get; set; }
  public new object colorSpace { get; set; }
  public new bool desynchronized { get; set; }
  public new bool willReadFrequently { get; set; }
}

public partial interface ChannelMergerOptions : AudioNodeOptions  {
  public new double numberOfInputs { get; set; }
}

public partial interface ChannelSplitterOptions : AudioNodeOptions  {
  public new double numberOfOutputs { get; set; }
}

public partial interface CheckVisibilityOptions  {
  public new bool checkOpacity { get; set; }
  public new bool checkVisibilityCSS { get; set; }
}

public partial interface ClientQueryOptions  {
  public new bool includeUncontrolled { get; set; }
  public new object type { get; set; }
}

public partial interface ClipboardEventInit : EventInit  {
  public new object clipboardData { get; set; }
}

public partial interface ClipboardItemOptions  {
  public new object presentationStyle { get; set; }
}

public partial interface CloseEventInit : EventInit  {
  public new double code { get; set; }
  public new string reason { get; set; }
  public new bool wasClean { get; set; }
}

public partial interface CompositionEventInit : UIEventInit  {
  public new string data { get; set; }
}

public partial interface ComputedEffectTiming : EffectTiming  {
  public new object activeDuration { get; set; }
  public new object currentIteration { get; set; }
  public new object endTime { get; set; }
  public new object localTime { get; set; }
  public new object progress { get; set; }
  public new object startTime { get; set; }
}

public partial interface ComputedKeyframe  {
  public new object composite { get; set; }
  public new double computedOffset { get; set; }
  public new string easing { get; set; }
  public new object offset { get; set; }
  // TODO: Unsupported member: undefined
}

public partial interface ConstantSourceOptions  {
  public new double offset { get; set; }
}

public partial interface ConstrainBooleanParameters  {
  public new bool exact { get; set; }
  public new bool ideal { get; set; }
}

public partial interface ConstrainDOMStringParameters  {
  public new object exact { get; set; }
  public new object ideal { get; set; }
}

public partial interface ConstrainDoubleRange : DoubleRange  {
  public new double exact { get; set; }
  public new double ideal { get; set; }
}

public partial interface ConstrainULongRange : ULongRange  {
  public new double exact { get; set; }
  public new double ideal { get; set; }
}

public partial interface ConvolverOptions : AudioNodeOptions  {
  public new object buffer { get; set; }
  public new bool disableNormalization { get; set; }
}

public partial interface CredentialCreationOptions  {
  public new object publicKey { get; set; }
  public new object signal { get; set; }
}

public partial interface CredentialPropertiesOutput  {
  public new bool rk { get; set; }
}

public partial interface CredentialRequestOptions  {
  public new object mediation { get; set; }
  public new object publicKey { get; set; }
  public new object signal { get; set; }
}

public partial interface CryptoKeyPair  {
  public new object privateKey { get; set; }
  public new object publicKey { get; set; }
}

public partial interface CustomEventInit : EventInit  {
  public new object detail { get; set; }
}

public partial interface DOMMatrix2DInit  {
  public new double a { get; set; }
  public new double b { get; set; }
  public new double c { get; set; }
  public new double d { get; set; }
  public new double e { get; set; }
  public new double f { get; set; }
  public new double m11 { get; set; }
  public new double m12 { get; set; }
  public new double m21 { get; set; }
  public new double m22 { get; set; }
  public new double m41 { get; set; }
  public new double m42 { get; set; }
}

public partial interface DOMMatrixInit : DOMMatrix2DInit  {
  public new bool is2D { get; set; }
  public new double m13 { get; set; }
  public new double m14 { get; set; }
  public new double m23 { get; set; }
  public new double m24 { get; set; }
  public new double m31 { get; set; }
  public new double m32 { get; set; }
  public new double m33 { get; set; }
  public new double m34 { get; set; }
  public new double m43 { get; set; }
  public new double m44 { get; set; }
}

public partial interface DOMPointInit  {
  public new double w { get; set; }
  public new double x { get; set; }
  public new double y { get; set; }
  public new double z { get; set; }
}

public partial interface DOMQuadInit  {
  public new object p1 { get; set; }
  public new object p2 { get; set; }
  public new object p3 { get; set; }
  public new object p4 { get; set; }
}

public partial interface DOMRectInit  {
  public new double height { get; set; }
  public new double width { get; set; }
  public new double x { get; set; }
  public new double y { get; set; }
}

public partial interface DelayOptions : AudioNodeOptions  {
  public new double delayTime { get; set; }
  public new double maxDelayTime { get; set; }
}

public partial interface DeviceMotionEventAccelerationInit  {
  public new object x { get; set; }
  public new object y { get; set; }
  public new object z { get; set; }
}

public partial interface DeviceMotionEventInit : EventInit  {
  public new object acceleration { get; set; }
  public new object accelerationIncludingGravity { get; set; }
  public new double interval { get; set; }
  public new object rotationRate { get; set; }
}

public partial interface DeviceMotionEventRotationRateInit  {
  public new object alpha { get; set; }
  public new object beta { get; set; }
  public new object gamma { get; set; }
}

public partial interface DeviceOrientationEventInit : EventInit  {
  public new bool absolute { get; set; }
  public new object alpha { get; set; }
  public new object beta { get; set; }
  public new object gamma { get; set; }
}

public partial interface DisplayMediaStreamOptions  {
  public new object audio { get; set; }
  public new object video { get; set; }
}

public partial interface DocumentTimelineOptions  {
  public new object originTime { get; set; }
}

public partial interface DoubleRange  {
  public new double max { get; set; }
  public new double min { get; set; }
}

public partial interface DragEventInit : MouseEventInit  {
  public new object dataTransfer { get; set; }
}

public partial interface DynamicsCompressorOptions : AudioNodeOptions  {
  public new double attack { get; set; }
  public new double knee { get; set; }
  public new double ratio { get; set; }
  public new double release { get; set; }
  public new double threshold { get; set; }
}

public partial interface EcKeyAlgorithm : KeyAlgorithm  {
  public new object namedCurve { get; set; }
}

public partial interface EcKeyGenParams : Algorithm  {
  public new object namedCurve { get; set; }
}

public partial interface EcKeyImportParams : Algorithm  {
  public new object namedCurve { get; set; }
}

public partial interface EcdhKeyDeriveParams : Algorithm  {
  public new object publicProperty { get; set; }
}

public partial interface EcdsaParams : Algorithm  {
  public new object hash { get; set; }
}

public partial interface EffectTiming  {
  public new double delay { get; set; }
  public new object direction { get; set; }
  public new object duration { get; set; }
  public new string easing { get; set; }
  public new double endDelay { get; set; }
  public new object fill { get; set; }
  public new double iterationStart { get; set; }
  public new double iterations { get; set; }
  public new double playbackRate { get; set; }
}

public partial interface ElementCreationOptions  {
  public new string isProperty { get; set; }
}

public partial interface ElementDefinitionOptions  {
  public new string extends { get; set; }
}

public partial interface EncodedVideoChunkInit  {
  public new object data { get; set; }
  public new double duration { get; set; }
  public new double timestamp { get; set; }
  public new object type { get; set; }
}

public partial interface EncodedVideoChunkMetadata  {
  public new object decoderConfig { get; set; }
}

public partial interface ErrorEventInit : EventInit  {
  public new double colno { get; set; }
  public new object error { get; set; }
  public new string filename { get; set; }
  public new double lineno { get; set; }
  public new string message { get; set; }
}

public partial interface EventInit  {
  public new bool bubbles { get; set; }
  public new bool cancelable { get; set; }
  public new bool composed { get; set; }
}

public partial interface EventListenerOptions  {
  public new bool capture { get; set; }
}

public partial interface EventModifierInit : UIEventInit  {
  public new bool altKey { get; set; }
  public new bool ctrlKey { get; set; }
  public new bool metaKey { get; set; }
  public new bool modifierAltGraph { get; set; }
  public new bool modifierCapsLock { get; set; }
  public new bool modifierFn { get; set; }
  public new bool modifierFnLock { get; set; }
  public new bool modifierHyper { get; set; }
  public new bool modifierNumLock { get; set; }
  public new bool modifierScrollLock { get; set; }
  public new bool modifierSuper { get; set; }
  public new bool modifierSymbol { get; set; }
  public new bool modifierSymbolLock { get; set; }
  public new bool shiftKey { get; set; }
}

public partial interface EventSourceInit  {
  public new bool withCredentials { get; set; }
}

public partial interface FilePropertyBag : BlobPropertyBag  {
  public new double lastModified { get; set; }
}

public partial interface FileSystemCreateWritableOptions  {
  public new bool keepExistingData { get; set; }
}

public partial interface FileSystemFlags  {
  public new bool create { get; set; }
  public new bool exclusive { get; set; }
}

public partial interface FileSystemGetDirectoryOptions  {
  public new bool create { get; set; }
}

public partial interface FileSystemGetFileOptions  {
  public new bool create { get; set; }
}

public partial interface FileSystemRemoveOptions  {
  public new bool recursive { get; set; }
}

public partial interface FocusEventInit : UIEventInit  {
  public new object relatedTarget { get; set; }
}

public partial interface FocusOptions  {
  public new bool preventScroll { get; set; }
}

public partial interface FontFaceDescriptors  {
  public new string ascentOverride { get; set; }
  public new string descentOverride { get; set; }
  public new object display { get; set; }
  public new string featureSettings { get; set; }
  public new string lineGapOverride { get; set; }
  public new string stretch { get; set; }
  public new string style { get; set; }
  public new string unicodeRange { get; set; }
  public new string variant { get; set; }
  public new string weight { get; set; }
}

public partial interface FontFaceSetLoadEventInit : EventInit  {
  public new object fontfaces { get; set; }
}

public partial interface FormDataEventInit : EventInit  {
  public new object formData { get; set; }
}

public partial interface FullscreenOptions  {
  public new object navigationUI { get; set; }
}

public partial interface GainOptions : AudioNodeOptions  {
  public new double gain { get; set; }
}

public partial interface GamepadEffectParameters  {
  public new double duration { get; set; }
  public new double startDelay { get; set; }
  public new double strongMagnitude { get; set; }
  public new double weakMagnitude { get; set; }
}

public partial interface GamepadEventInit : EventInit  {
  public new object gamepad { get; set; }
}

public partial interface GetAnimationsOptions  {
  public new bool subtree { get; set; }
}

public partial interface GetNotificationOptions  {
  public new string tag { get; set; }
}

public partial interface GetRootNodeOptions  {
  public new bool composed { get; set; }
}

public partial interface HashChangeEventInit : EventInit  {
  public new string newURL { get; set; }
  public new string oldURL { get; set; }
}

public partial interface HkdfParams : Algorithm  {
  public new object hash { get; set; }
  public new object info { get; set; }
  public new object salt { get; set; }
}

public partial interface HmacImportParams : Algorithm  {
  public new object hash { get; set; }
  public new double length { get; set; }
}

public partial interface HmacKeyAlgorithm : KeyAlgorithm  {
  public new object hash { get; set; }
  public new double length { get; set; }
}

public partial interface HmacKeyGenParams : Algorithm  {
  public new object hash { get; set; }
  public new double length { get; set; }
}

public partial interface IDBDatabaseInfo  {
  public new string name { get; set; }
  public new double version { get; set; }
}

public partial interface IDBIndexParameters  {
  public new bool multiEntry { get; set; }
  public new bool unique { get; set; }
}

public partial interface IDBObjectStoreParameters  {
  public new bool autoIncrement { get; set; }
  public new object keyPath { get; set; }
}

public partial interface IDBTransactionOptions  {
  public new object durability { get; set; }
}

public partial interface IDBVersionChangeEventInit : EventInit  {
  public new object newVersion { get; set; }
  public new double oldVersion { get; set; }
}

public partial interface IIRFilterOptions : AudioNodeOptions  {
  public new object feedback { get; set; }
  public new object feedforward { get; set; }
}

public partial interface IdleRequestOptions  {
  public new double timeout { get; set; }
}

public partial interface ImageBitmapOptions  {
  public new object colorSpaceConversion { get; set; }
  public new object imageOrientation { get; set; }
  public new object premultiplyAlpha { get; set; }
  public new double resizeHeight { get; set; }
  public new object resizeQuality { get; set; }
  public new double resizeWidth { get; set; }
}

public partial interface ImageBitmapRenderingContextSettings  {
  public new bool alpha { get; set; }
}

public partial interface ImageDataSettings  {
  public new object colorSpace { get; set; }
}

public partial interface ImageEncodeOptions  {
  public new double quality { get; set; }
  public new string type { get; set; }
}

public partial interface ImportMeta  {
  public new string url { get; set; }
}

public partial interface InputEventInit : UIEventInit  {
  public new object data { get; set; }
  public new object dataTransfer { get; set; }
  public new string inputType { get; set; }
  public new bool isComposing { get; set; }
  public new object targetRanges { get; set; }
}

public partial interface IntersectionObserverEntryInit  {
  public new object boundingClientRect { get; set; }
  public new double intersectionRatio { get; set; }
  public new object intersectionRect { get; set; }
  public new bool isIntersecting { get; set; }
  public new object rootBounds { get; set; }
  public new object target { get; set; }
  public new object time { get; set; }
}

public partial interface IntersectionObserverInit  {
  public new object root { get; set; }
  public new string rootMargin { get; set; }
  public new object threshold { get; set; }
}

public partial interface JsonWebKey  {
  public new string alg { get; set; }
  public new string crv { get; set; }
  public new string d { get; set; }
  public new string dp { get; set; }
  public new string dq { get; set; }
  public new string e { get; set; }
  public new bool ext { get; set; }
  public new string k { get; set; }
  public new object key_ops { get; set; }
  public new string kty { get; set; }
  public new string n { get; set; }
  public new object oth { get; set; }
  public new string p { get; set; }
  public new string q { get; set; }
  public new string qi { get; set; }
  public new string use { get; set; }
  public new string x { get; set; }
  public new string y { get; set; }
}

public partial interface KeyAlgorithm  {
  public new string name { get; set; }
}

public partial interface KeyboardEventInit : EventModifierInit  {
  public new double charCode { get; set; }
  public new string code { get; set; }
  public new bool isComposing { get; set; }
  public new string key { get; set; }
  public new double keyCode { get; set; }
  public new double location { get; set; }
  public new bool repeat { get; set; }
}

public partial interface Keyframe  {
  public new object composite { get; set; }
  public new string easing { get; set; }
  public new object offset { get; set; }
  // TODO: Unsupported member: undefined
}

public partial interface KeyframeAnimationOptions : KeyframeEffectOptions  {
  public new string id { get; set; }
  public new object timeline { get; set; }
}

public partial interface KeyframeEffectOptions : EffectTiming  {
  public new object composite { get; set; }
  public new object iterationComposite { get; set; }
  public new object pseudoElement { get; set; }
}

public partial interface LockInfo  {
  public new string clientId { get; set; }
  public new object mode { get; set; }
  public new string name { get; set; }
}

public partial interface LockManagerSnapshot  {
  public new object held { get; set; }
  public new object pending { get; set; }
}

public partial interface LockOptions  {
  public new bool ifAvailable { get; set; }
  public new object mode { get; set; }
  public new object signal { get; set; }
  public new bool steal { get; set; }
}

public partial interface MIDIConnectionEventInit : EventInit  {
  public new object port { get; set; }
}

public partial interface MIDIMessageEventInit : EventInit  {
  public new object data { get; set; }
}

public partial interface MIDIOptions  {
  public new bool software { get; set; }
  public new bool sysex { get; set; }
}

public partial interface MediaCapabilitiesDecodingInfo : MediaCapabilitiesInfo  {
  public new object configuration { get; set; }
}

public partial interface MediaCapabilitiesEncodingInfo : MediaCapabilitiesInfo  {
  public new object configuration { get; set; }
}

public partial interface MediaCapabilitiesInfo  {
  public new bool powerEfficient { get; set; }
  public new bool smooth { get; set; }
  public new bool supported { get; set; }
}

public partial interface MediaConfiguration  {
  public new object audio { get; set; }
  public new object video { get; set; }
}

public partial interface MediaDecodingConfiguration : MediaConfiguration  {
  public new object type { get; set; }
}

public partial interface MediaElementAudioSourceOptions  {
  public new object mediaElement { get; set; }
}

public partial interface MediaEncodingConfiguration : MediaConfiguration  {
  public new object type { get; set; }
}

public partial interface MediaEncryptedEventInit : EventInit  {
  public new object initData { get; set; }
  public new string initDataType { get; set; }
}

public partial interface MediaImage  {
  public new string sizes { get; set; }
  public new string src { get; set; }
  public new string type { get; set; }
}

public partial interface MediaKeyMessageEventInit : EventInit  {
  public new object message { get; set; }
  public new object messageType { get; set; }
}

public partial interface MediaKeySystemConfiguration  {
  public new object audioCapabilities { get; set; }
  public new object distinctiveIdentifier { get; set; }
  public new object initDataTypes { get; set; }
  public new string label { get; set; }
  public new object persistentState { get; set; }
  public new object sessionTypes { get; set; }
  public new object videoCapabilities { get; set; }
}

public partial interface MediaKeySystemMediaCapability  {
  public new string contentType { get; set; }
  public new object encryptionScheme { get; set; }
  public new string robustness { get; set; }
}

public partial interface MediaMetadataInit  {
  public new string album { get; set; }
  public new string artist { get; set; }
  public new object artwork { get; set; }
  public new string title { get; set; }
}

public partial interface MediaPositionState  {
  public new double duration { get; set; }
  public new double playbackRate { get; set; }
  public new double position { get; set; }
}

public partial interface MediaQueryListEventInit : EventInit  {
  public new bool matches { get; set; }
  public new string media { get; set; }
}

public partial interface MediaRecorderOptions  {
  public new double audioBitsPerSecond { get; set; }
  public new double bitsPerSecond { get; set; }
  public new string mimeType { get; set; }
  public new double videoBitsPerSecond { get; set; }
}

public partial interface MediaSessionActionDetails  {
  public new object action { get; set; }
  public new bool fastSeek { get; set; }
  public new double seekOffset { get; set; }
  public new double seekTime { get; set; }
}

public partial interface MediaStreamAudioSourceOptions  {
  public new object mediaStream { get; set; }
}

public partial interface MediaStreamConstraints  {
  public new object audio { get; set; }
  public new string peerIdentity { get; set; }
  public new bool preferCurrentTab { get; set; }
  public new object video { get; set; }
}

public partial interface MediaStreamTrackEventInit : EventInit  {
  public new object track { get; set; }
}

public partial interface MediaTrackCapabilities  {
  public new object aspectRatio { get; set; }
  public new object autoGainControl { get; set; }
  public new object channelCount { get; set; }
  public new string deviceId { get; set; }
  public new string displaySurface { get; set; }
  public new object echoCancellation { get; set; }
  public new object facingMode { get; set; }
  public new object frameRate { get; set; }
  public new string groupId { get; set; }
  public new object height { get; set; }
  public new object noiseSuppression { get; set; }
  public new object sampleRate { get; set; }
  public new object sampleSize { get; set; }
  public new object width { get; set; }
}

public partial interface MediaTrackConstraintSet  {
  public new object aspectRatio { get; set; }
  public new object autoGainControl { get; set; }
  public new object channelCount { get; set; }
  public new object deviceId { get; set; }
  public new object displaySurface { get; set; }
  public new object echoCancellation { get; set; }
  public new object facingMode { get; set; }
  public new object frameRate { get; set; }
  public new object groupId { get; set; }
  public new object height { get; set; }
  public new object noiseSuppression { get; set; }
  public new object sampleRate { get; set; }
  public new object sampleSize { get; set; }
  public new object width { get; set; }
}

public partial interface MediaTrackConstraints : MediaTrackConstraintSet  {
  public new object advanced { get; set; }
}

public partial interface MediaTrackSettings  {
  public new double aspectRatio { get; set; }
  public new bool autoGainControl { get; set; }
  public new double channelCount { get; set; }
  public new string deviceId { get; set; }
  public new string displaySurface { get; set; }
  public new bool echoCancellation { get; set; }
  public new string facingMode { get; set; }
  public new double frameRate { get; set; }
  public new string groupId { get; set; }
  public new double height { get; set; }
  public new bool noiseSuppression { get; set; }
  public new double sampleRate { get; set; }
  public new double sampleSize { get; set; }
  public new double width { get; set; }
}

public partial interface MediaTrackSupportedConstraints  {
  public new bool aspectRatio { get; set; }
  public new bool autoGainControl { get; set; }
  public new bool channelCount { get; set; }
  public new bool deviceId { get; set; }
  public new bool displaySurface { get; set; }
  public new bool echoCancellation { get; set; }
  public new bool facingMode { get; set; }
  public new bool frameRate { get; set; }
  public new bool groupId { get; set; }
  public new bool height { get; set; }
  public new bool noiseSuppression { get; set; }
  public new bool sampleRate { get; set; }
  public new bool sampleSize { get; set; }
  public new bool width { get; set; }
}

public partial interface MessageEventInit : EventInit  {
  public new object data { get; set; }
  public new string lastEventId { get; set; }
  public new string origin { get; set; }
  public new object ports { get; set; }
  public new object source { get; set; }
}

public partial interface MouseEventInit : EventModifierInit  {
  public new double button { get; set; }
  public new double buttons { get; set; }
  public new double clientX { get; set; }
  public new double clientY { get; set; }
  public new double movementX { get; set; }
  public new double movementY { get; set; }
  public new object relatedTarget { get; set; }
  public new double screenX { get; set; }
  public new double screenY { get; set; }
}

public partial interface MultiCacheQueryOptions : CacheQueryOptions  {
  public new string cacheName { get; set; }
}

public partial interface MutationObserverInit  {
  public new object attributeFilter { get; set; }
  public new bool attributeOldValue { get; set; }
  public new bool attributes { get; set; }
  public new bool characterData { get; set; }
  public new bool characterDataOldValue { get; set; }
  public new bool childList { get; set; }
  public new bool subtree { get; set; }
}

public partial interface NavigationPreloadState  {
  public new bool enabled { get; set; }
  public new string headerValue { get; set; }
}

public partial interface NotificationAction  {
  public new string action { get; set; }
  public new string icon { get; set; }
  public new string title { get; set; }
}

public partial interface NotificationOptions  {
  public new object actions { get; set; }
  public new string badge { get; set; }
  public new string body { get; set; }
  public new object data { get; set; }
  public new object dir { get; set; }
  public new string icon { get; set; }
  public new string image { get; set; }
  public new string lang { get; set; }
  public new bool renotify { get; set; }
  public new bool requireInteraction { get; set; }
  public new object silent { get; set; }
  public new string tag { get; set; }
  public new object timestamp { get; set; }
  public new object vibrate { get; set; }
}

public partial interface OfflineAudioCompletionEventInit : EventInit  {
  public new object renderedBuffer { get; set; }
}

public partial interface OfflineAudioContextOptions  {
  public new double length { get; set; }
  public new double numberOfChannels { get; set; }
  public new double sampleRate { get; set; }
}

public partial interface OptionalEffectTiming  {
  public new double delay { get; set; }
  public new object direction { get; set; }
  public new object duration { get; set; }
  public new string easing { get; set; }
  public new double endDelay { get; set; }
  public new object fill { get; set; }
  public new double iterationStart { get; set; }
  public new double iterations { get; set; }
  public new double playbackRate { get; set; }
}

public partial interface OscillatorOptions : AudioNodeOptions  {
  public new double detune { get; set; }
  public new double frequency { get; set; }
  public new object periodicWave { get; set; }
  public new object type { get; set; }
}

public partial interface PageTransitionEventInit : EventInit  {
  public new bool persisted { get; set; }
}

public partial interface PannerOptions : AudioNodeOptions  {
  public new double coneInnerAngle { get; set; }
  public new double coneOuterAngle { get; set; }
  public new double coneOuterGain { get; set; }
  public new object distanceModel { get; set; }
  public new double maxDistance { get; set; }
  public new double orientationX { get; set; }
  public new double orientationY { get; set; }
  public new double orientationZ { get; set; }
  public new object panningModel { get; set; }
  public new double positionX { get; set; }
  public new double positionY { get; set; }
  public new double positionZ { get; set; }
  public new double refDistance { get; set; }
  public new double rolloffFactor { get; set; }
}

public partial interface PaymentCurrencyAmount  {
  public new string currency { get; set; }
  public new string value { get; set; }
}

public partial interface PaymentDetailsBase  {
  public new object displayItems { get; set; }
  public new object modifiers { get; set; }
}

public partial interface PaymentDetailsInit : PaymentDetailsBase  {
  public new string id { get; set; }
  public new object total { get; set; }
}

public partial interface PaymentDetailsModifier  {
  public new object additionalDisplayItems { get; set; }
  public new object data { get; set; }
  public new string supportedMethods { get; set; }
  public new object total { get; set; }
}

public partial interface PaymentDetailsUpdate : PaymentDetailsBase  {
  public new object paymentMethodErrors { get; set; }
  public new object total { get; set; }
}

public partial interface PaymentItem  {
  public new object amount { get; set; }
  public new string label { get; set; }
  public new bool pending { get; set; }
}

public partial interface PaymentMethodChangeEventInit : PaymentRequestUpdateEventInit  {
  public new object methodDetails { get; set; }
  public new string methodName { get; set; }
}

public partial interface PaymentMethodData  {
  public new object data { get; set; }
  public new string supportedMethods { get; set; }
}

public partial interface PaymentRequestUpdateEventInit : EventInit  {}

public partial interface PaymentValidationErrors  {
  public new string error { get; set; }
  public new object paymentMethod { get; set; }
}

public partial interface Pbkdf2Params : Algorithm  {
  public new object hash { get; set; }
  public new double iterations { get; set; }
  public new object salt { get; set; }
}

public partial interface PerformanceMarkOptions  {
  public new object detail { get; set; }
  public new object startTime { get; set; }
}

public partial interface PerformanceMeasureOptions  {
  public new object detail { get; set; }
  public new object duration { get; set; }
  public new object end { get; set; }
  public new object start { get; set; }
}

public partial interface PerformanceObserverInit  {
  public new bool buffered { get; set; }
  public new object entryTypes { get; set; }
  public new string type { get; set; }
}

public partial interface PeriodicWaveConstraints  {
  public new bool disableNormalization { get; set; }
}

public partial interface PeriodicWaveOptions : PeriodicWaveConstraints  {
  public new object imag { get; set; }
  public new object real { get; set; }
}

public partial interface PermissionDescriptor  {
  public new object name { get; set; }
}

public partial interface PictureInPictureEventInit : EventInit  {
  public new object pictureInPictureWindow { get; set; }
}

public partial interface PlaneLayout  {
  public new double offset { get; set; }
  public new double stride { get; set; }
}

public partial interface PointerEventInit : MouseEventInit  {
  public new object coalescedEvents { get; set; }
  public new double height { get; set; }
  public new bool isPrimary { get; set; }
  public new double pointerId { get; set; }
  public new string pointerType { get; set; }
  public new object predictedEvents { get; set; }
  public new double pressure { get; set; }
  public new double tangentialPressure { get; set; }
  public new double tiltX { get; set; }
  public new double tiltY { get; set; }
  public new double twist { get; set; }
  public new double width { get; set; }
}

public partial interface PopStateEventInit : EventInit  {
  public new object state { get; set; }
}

public partial interface PositionOptions  {
  public new bool enableHighAccuracy { get; set; }
  public new double maximumAge { get; set; }
  public new double timeout { get; set; }
}

public partial interface ProgressEventInit : EventInit  {
  public new bool lengthComputable { get; set; }
  public new double loaded { get; set; }
  public new double total { get; set; }
}

public partial interface PromiseRejectionEventInit : EventInit  {
  public new object promise { get; set; }
  public new object reason { get; set; }
}

public partial interface PropertyDefinition  {
  public new bool inherits { get; set; }
  public new string initialValue { get; set; }
  public new string name { get; set; }
  public new string syntax { get; set; }
}

public partial interface PropertyIndexedKeyframes  {
  public new object composite { get; set; }
  public new object easing { get; set; }
  public new object offset { get; set; }
  // TODO: Unsupported member: undefined
}

public partial interface PublicKeyCredentialCreationOptions  {
  public new object attestation { get; set; }
  public new object authenticatorSelection { get; set; }
  public new object challenge { get; set; }
  public new object excludeCredentials { get; set; }
  public new object extensions { get; set; }
  public new object pubKeyCredParams { get; set; }
  public new object rp { get; set; }
  public new double timeout { get; set; }
  public new object user { get; set; }
}

public partial interface PublicKeyCredentialDescriptor  {
  public new object id { get; set; }
  public new object transports { get; set; }
  public new object type { get; set; }
}

public partial interface PublicKeyCredentialEntity  {
  public new string name { get; set; }
}

public partial interface PublicKeyCredentialParameters  {
  public new object alg { get; set; }
  public new object type { get; set; }
}

public partial interface PublicKeyCredentialRequestOptions  {
  public new object allowCredentials { get; set; }
  public new object challenge { get; set; }
  public new object extensions { get; set; }
  public new string rpId { get; set; }
  public new double timeout { get; set; }
  public new object userVerification { get; set; }
}

public partial interface PublicKeyCredentialRpEntity : PublicKeyCredentialEntity  {
  public new string id { get; set; }
}

public partial interface PublicKeyCredentialUserEntity : PublicKeyCredentialEntity  {
  public new string displayName { get; set; }
  public new object id { get; set; }
}

public partial interface PushSubscriptionJSON  {
  public new string endpoint { get; set; }
  public new object expirationTime { get; set; }
  public new object keys { get; set; }
}

public partial interface PushSubscriptionOptionsInit  {
  public new object applicationServerKey { get; set; }
  public new bool userVisibleOnly { get; set; }
}

public partial interface QueuingStrategy  {
  public new double highWaterMark { get; set; }
  public new object size { get; set; }
}

public partial interface QueuingStrategyInit  {
  public new double highWaterMark { get; set; }
}

public partial interface RTCAnswerOptions : RTCOfferAnswerOptions  {}

public partial interface RTCCertificateExpiration  {
  public new double expires { get; set; }
}

public partial interface RTCConfiguration  {
  public new object bundlePolicy { get; set; }
  public new object certificates { get; set; }
  public new double iceCandidatePoolSize { get; set; }
  public new object iceServers { get; set; }
  public new object iceTransportPolicy { get; set; }
  public new object rtcpMuxPolicy { get; set; }
}

public partial interface RTCDTMFToneChangeEventInit : EventInit  {
  public new string tone { get; set; }
}

public partial interface RTCDataChannelEventInit : EventInit  {
  public new object channel { get; set; }
}

public partial interface RTCDataChannelInit  {
  public new double id { get; set; }
  public new double maxPacketLifeTime { get; set; }
  public new double maxRetransmits { get; set; }
  public new bool negotiated { get; set; }
  public new bool ordered { get; set; }
  public new string protocol { get; set; }
}

public partial interface RTCDtlsFingerprint  {
  public new string algorithm { get; set; }
  public new string value { get; set; }
}

public partial interface RTCEncodedAudioFrameMetadata  {
  public new object contributingSources { get; set; }
  public new double synchronizationSource { get; set; }
}

public partial interface RTCEncodedVideoFrameMetadata  {
  public new object dependencies { get; set; }
  public new double frameId { get; set; }
  public new double height { get; set; }
  public new double spatialIndex { get; set; }
  public new double synchronizationSource { get; set; }
  public new double temporalIndex { get; set; }
  public new double width { get; set; }
}

public partial interface RTCErrorEventInit : EventInit  {
  public new object error { get; set; }
}

public partial interface RTCErrorInit  {
  public new object errorDetail { get; set; }
  public new double httpRequestStatusCode { get; set; }
  public new double receivedAlert { get; set; }
  public new double sctpCauseCode { get; set; }
  public new double sdpLineNumber { get; set; }
  public new double sentAlert { get; set; }
}

public partial interface RTCIceCandidateInit  {
  public new string candidate { get; set; }
  public new object sdpMLineIndex { get; set; }
  public new object sdpMid { get; set; }
  public new object usernameFragment { get; set; }
}

public partial interface RTCIceCandidatePair  {
  public new object local { get; set; }
  public new object remote { get; set; }
}

public partial interface RTCIceCandidatePairStats : RTCStats  {
  public new double availableIncomingBitrate { get; set; }
  public new double availableOutgoingBitrate { get; set; }
  public new double bytesReceived { get; set; }
  public new double bytesSent { get; set; }
  public new double currentRoundTripTime { get; set; }
  public new object lastPacketReceivedTimestamp { get; set; }
  public new object lastPacketSentTimestamp { get; set; }
  public new string localCandidateId { get; set; }
  public new bool nominated { get; set; }
  public new string remoteCandidateId { get; set; }
  public new double requestsReceived { get; set; }
  public new double requestsSent { get; set; }
  public new double responsesReceived { get; set; }
  public new double responsesSent { get; set; }
  public new object state { get; set; }
  public new double totalRoundTripTime { get; set; }
  public new string transportId { get; set; }
}

public partial interface RTCIceServer  {
  public new string credential { get; set; }
  public new object urls { get; set; }
  public new string username { get; set; }
}

public partial interface RTCInboundRtpStreamStats : RTCReceivedRtpStreamStats  {
  public new double audioLevel { get; set; }
  public new double bytesReceived { get; set; }
  public new double concealedSamples { get; set; }
  public new double concealmentEvents { get; set; }
  public new string decoderImplementation { get; set; }
  public new object estimatedPlayoutTimestamp { get; set; }
  public new double fecPacketsDiscarded { get; set; }
  public new double fecPacketsReceived { get; set; }
  public new double firCount { get; set; }
  public new double frameHeight { get; set; }
  public new double frameWidth { get; set; }
  public new double framesDecoded { get; set; }
  public new double framesDropped { get; set; }
  public new double framesPerSecond { get; set; }
  public new double framesReceived { get; set; }
  public new double headerBytesReceived { get; set; }
  public new double insertedSamplesForDeceleration { get; set; }
  public new double jitterBufferDelay { get; set; }
  public new double jitterBufferEmittedCount { get; set; }
  public new double keyFramesDecoded { get; set; }
  public new string kind { get; set; }
  public new object lastPacketReceivedTimestamp { get; set; }
  public new double nackCount { get; set; }
  public new double packetsDiscarded { get; set; }
  public new double pliCount { get; set; }
  public new double qpSum { get; set; }
  public new string remoteId { get; set; }
  public new double removedSamplesForAcceleration { get; set; }
  public new double silentConcealedSamples { get; set; }
  public new double totalAudioEnergy { get; set; }
  public new double totalDecodeTime { get; set; }
  public new double totalInterFrameDelay { get; set; }
  public new double totalProcessingDelay { get; set; }
  public new double totalSamplesDuration { get; set; }
  public new double totalSamplesReceived { get; set; }
  public new double totalSquaredInterFrameDelay { get; set; }
}

public partial interface RTCLocalSessionDescriptionInit  {
  public new string sdp { get; set; }
  public new object type { get; set; }
}

public partial interface RTCOfferAnswerOptions  {}

public partial interface RTCOfferOptions : RTCOfferAnswerOptions  {
  public new bool iceRestart { get; set; }
  public new bool offerToReceiveAudio { get; set; }
  public new bool offerToReceiveVideo { get; set; }
}

public partial interface RTCOutboundRtpStreamStats : RTCSentRtpStreamStats  {
  public new double firCount { get; set; }
  public new double frameHeight { get; set; }
  public new double frameWidth { get; set; }
  public new double framesEncoded { get; set; }
  public new double framesPerSecond { get; set; }
  public new double framesSent { get; set; }
  public new double headerBytesSent { get; set; }
  public new double hugeFramesSent { get; set; }
  public new double keyFramesEncoded { get; set; }
  public new string mediaSourceId { get; set; }
  public new double nackCount { get; set; }
  public new double pliCount { get; set; }
  public new double qpSum { get; set; }
  public new double qualityLimitationResolutionChanges { get; set; }
  public new string remoteId { get; set; }
  public new double retransmittedBytesSent { get; set; }
  public new double retransmittedPacketsSent { get; set; }
  public new string rid { get; set; }
  public new double targetBitrate { get; set; }
  public new double totalEncodeTime { get; set; }
  public new double totalEncodedBytesTarget { get; set; }
  public new double totalPacketSendDelay { get; set; }
}

public partial interface RTCPeerConnectionIceErrorEventInit : EventInit  {
  public new object address { get; set; }
  public new double errorCode { get; set; }
  public new string errorText { get; set; }
  public new object port { get; set; }
  public new string url { get; set; }
}

public partial interface RTCPeerConnectionIceEventInit : EventInit  {
  public new object candidate { get; set; }
  public new object url { get; set; }
}

public partial interface RTCReceivedRtpStreamStats : RTCRtpStreamStats  {
  public new double jitter { get; set; }
  public new double packetsLost { get; set; }
  public new double packetsReceived { get; set; }
}

public partial interface RTCRtcpParameters  {
  public new string cname { get; set; }
  public new bool reducedSize { get; set; }
}

public partial interface RTCRtpCapabilities  {
  public new object codecs { get; set; }
  public new object headerExtensions { get; set; }
}

public partial interface RTCRtpCodec  {
  public new double channels { get; set; }
  public new double clockRate { get; set; }
  public new string mimeType { get; set; }
  public new string sdpFmtpLine { get; set; }
}

public partial interface RTCRtpCodecCapability : RTCRtpCodec  {}

public partial interface RTCRtpCodecParameters : RTCRtpCodec  {
  public new double payloadType { get; set; }
}

public partial interface RTCRtpCodingParameters  {
  public new string rid { get; set; }
}

public partial interface RTCRtpContributingSource  {
  public new double audioLevel { get; set; }
  public new double rtpTimestamp { get; set; }
  public new double source { get; set; }
  public new object timestamp { get; set; }
}

public partial interface RTCRtpEncodingParameters : RTCRtpCodingParameters  {
  public new bool active { get; set; }
  public new double maxBitrate { get; set; }
  public new double maxFramerate { get; set; }
  public new object networkPriority { get; set; }
  public new object priority { get; set; }
  public new double scaleResolutionDownBy { get; set; }
}

public partial interface RTCRtpHeaderExtensionCapability  {
  public new string uri { get; set; }
}

public partial interface RTCRtpHeaderExtensionParameters  {
  public new bool encrypted { get; set; }
  public new double id { get; set; }
  public new string uri { get; set; }
}

public partial interface RTCRtpParameters  {
  public new object codecs { get; set; }
  public new object headerExtensions { get; set; }
  public new object rtcp { get; set; }
}

public partial interface RTCRtpReceiveParameters : RTCRtpParameters  {}

public partial interface RTCRtpSendParameters : RTCRtpParameters  {
  public new object degradationPreference { get; set; }
  public new object encodings { get; set; }
  public new string transactionId { get; set; }
}

public partial interface RTCRtpStreamStats : RTCStats  {
  public new string codecId { get; set; }
  public new string kind { get; set; }
  public new double ssrc { get; set; }
  public new string transportId { get; set; }
}

public partial interface RTCRtpSynchronizationSource : RTCRtpContributingSource  {}

public partial interface RTCRtpTransceiverInit  {
  public new object direction { get; set; }
  public new object sendEncodings { get; set; }
  public new object streams { get; set; }
}

public partial interface RTCSentRtpStreamStats : RTCRtpStreamStats  {
  public new double bytesSent { get; set; }
  public new double packetsSent { get; set; }
}

public partial interface RTCSessionDescriptionInit  {
  public new string sdp { get; set; }
  public new object type { get; set; }
}

public partial interface RTCStats  {
  public new string id { get; set; }
  public new object timestamp { get; set; }
  public new object type { get; set; }
}

public partial interface RTCTrackEventInit : EventInit  {
  public new object receiver { get; set; }
  public new object streams { get; set; }
  public new object track { get; set; }
  public new object transceiver { get; set; }
}

public partial interface RTCTransportStats : RTCStats  {
  public new double bytesReceived { get; set; }
  public new double bytesSent { get; set; }
  public new string dtlsCipher { get; set; }
  public new object dtlsState { get; set; }
  public new string localCertificateId { get; set; }
  public new string remoteCertificateId { get; set; }
  public new string selectedCandidatePairId { get; set; }
  public new string srtpCipher { get; set; }
  public new string tlsVersion { get; set; }
}

public partial interface ReadableStreamGetReaderOptions  {
  public new object mode { get; set; }
}

public partial interface ReadableStreamReadDoneResult  {
  public new object done { get; set; }
  public new object value { get; set; }
}

public partial interface ReadableStreamReadValueResult  {
  public new object done { get; set; }
  public new object value { get; set; }
}

public partial interface ReadableWritablePair  {
  public new object readable { get; set; }
  public new object writable { get; set; }
}

public partial interface RegistrationOptions  {
  public new string scope { get; set; }
  public new object type { get; set; }
  public new object updateViaCache { get; set; }
}

public partial interface ReportingObserverOptions  {
  public new bool buffered { get; set; }
  public new object types { get; set; }
}

public partial interface RequestInit  {
  public new object body { get; set; }
  public new object cache { get; set; }
  public new object credentials { get; set; }
  public new object headers { get; set; }
  public new string integrity { get; set; }
  public new bool keepalive { get; set; }
  public new string method { get; set; }
  public new object mode { get; set; }
  public new object redirect { get; set; }
  public new string referrer { get; set; }
  public new object referrerPolicy { get; set; }
  public new object signal { get; set; }
  public new object window { get; set; }
}

public partial interface ResizeObserverOptions  {
  public new object box { get; set; }
}

public partial interface ResponseInit  {
  public new object headers { get; set; }
  public new double status { get; set; }
  public new string statusText { get; set; }
}

public partial interface RsaHashedImportParams : Algorithm  {
  public new object hash { get; set; }
}

public partial interface RsaHashedKeyAlgorithm : RsaKeyAlgorithm  {
  public new object hash { get; set; }
}

public partial interface RsaHashedKeyGenParams : RsaKeyGenParams  {
  public new object hash { get; set; }
}

public partial interface RsaKeyAlgorithm : KeyAlgorithm  {
  public new double modulusLength { get; set; }
  public new object publicExponent { get; set; }
}

public partial interface RsaKeyGenParams : Algorithm  {
  public new double modulusLength { get; set; }
  public new object publicExponent { get; set; }
}

public partial interface RsaOaepParams : Algorithm  {
  public new object label { get; set; }
}

public partial interface RsaOtherPrimesInfo  {
  public new string d { get; set; }
  public new string r { get; set; }
  public new string t { get; set; }
}

public partial interface RsaPssParams : Algorithm  {
  public new double saltLength { get; set; }
}

public partial interface SVGBoundingBoxOptions  {
  public new bool clipped { get; set; }
  public new bool fill { get; set; }
  public new bool markers { get; set; }
  public new bool stroke { get; set; }
}

public partial interface ScrollIntoViewOptions : ScrollOptions  {
  public new object block { get; set; }
  public new object inline { get; set; }
}

public partial interface ScrollOptions  {
  public new object behavior { get; set; }
}

public partial interface ScrollToOptions : ScrollOptions  {
  public new double left { get; set; }
  public new double top { get; set; }
}

public partial interface SecurityPolicyViolationEventInit : EventInit  {
  public new string blockedURI { get; set; }
  public new double columnNumber { get; set; }
  public new object disposition { get; set; }
  public new string documentURI { get; set; }
  public new string effectiveDirective { get; set; }
  public new double lineNumber { get; set; }
  public new string originalPolicy { get; set; }
  public new string referrer { get; set; }
  public new string sample { get; set; }
  public new string sourceFile { get; set; }
  public new double statusCode { get; set; }
  public new string violatedDirective { get; set; }
}

public partial interface ShadowRootInit  {
  public new bool delegatesFocus { get; set; }
  public new object mode { get; set; }
  public new object slotAssignment { get; set; }
}

public partial interface ShareData  {
  public new object files { get; set; }
  public new string text { get; set; }
  public new string title { get; set; }
  public new string url { get; set; }
}

public partial interface SpeechSynthesisErrorEventInit : SpeechSynthesisEventInit  {
  public new object error { get; set; }
}

public partial interface SpeechSynthesisEventInit : EventInit  {
  public new double charIndex { get; set; }
  public new double charLength { get; set; }
  public new double elapsedTime { get; set; }
  public new string name { get; set; }
  public new object utterance { get; set; }
}

public partial interface StaticRangeInit  {
  public new object endContainer { get; set; }
  public new double endOffset { get; set; }
  public new object startContainer { get; set; }
  public new double startOffset { get; set; }
}

public partial interface StereoPannerOptions : AudioNodeOptions  {
  public new double pan { get; set; }
}

public partial interface StorageEstimate  {
  public new double quota { get; set; }
  public new double usage { get; set; }
}

public partial interface StorageEventInit : EventInit  {
  public new object key { get; set; }
  public new object newValue { get; set; }
  public new object oldValue { get; set; }
  public new object storageArea { get; set; }
  public new string url { get; set; }
}

public partial interface StreamPipeOptions  {
  public new bool preventAbort { get; set; }
  public new bool preventCancel { get; set; }
  public new bool preventClose { get; set; }
  public new object signal { get; set; }
}

public partial interface StructuredSerializeOptions  {
  public new object transfer { get; set; }
}

public partial interface SubmitEventInit : EventInit  {
  public new object submitter { get; set; }
}

public partial interface TextDecodeOptions  {
  public new bool stream { get; set; }
}

public partial interface TextDecoderOptions  {
  public new bool fatal { get; set; }
  public new bool ignoreBOM { get; set; }
}

public partial interface TextEncoderEncodeIntoResult  {
  public new double read { get; set; }
  public new double written { get; set; }
}

public partial interface ToggleEventInit : EventInit  {
  public new string newState { get; set; }
  public new string oldState { get; set; }
}

public partial interface TouchEventInit : EventModifierInit  {
  public new object changedTouches { get; set; }
  public new object targetTouches { get; set; }
  public new object touches { get; set; }
}

public partial interface TouchInit  {
  public new double altitudeAngle { get; set; }
  public new double azimuthAngle { get; set; }
  public new double clientX { get; set; }
  public new double clientY { get; set; }
  public new double force { get; set; }
  public new double identifier { get; set; }
  public new double pageX { get; set; }
  public new double pageY { get; set; }
  public new double radiusX { get; set; }
  public new double radiusY { get; set; }
  public new double rotationAngle { get; set; }
  public new double screenX { get; set; }
  public new double screenY { get; set; }
  public new object target { get; set; }
  public new object touchType { get; set; }
}

public partial interface TrackEventInit : EventInit  {
  public new object track { get; set; }
}

public partial interface Transformer  {
  public new object flush { get; set; }
  public new object readableType { get; set; }
  public new object start { get; set; }
  public new object transform { get; set; }
  public new object writableType { get; set; }
}

public partial interface TransitionEventInit : EventInit  {
  public new double elapsedTime { get; set; }
  public new string propertyName { get; set; }
  public new string pseudoElement { get; set; }
}

public partial interface UIEventInit : EventInit  {
  public new double detail { get; set; }
  public new object view { get; set; }
  public new double which { get; set; }
}

public partial interface ULongRange  {
  public new double max { get; set; }
  public new double min { get; set; }
}

public partial interface UnderlyingByteSource  {
  public new double autoAllocateChunkSize { get; set; }
  public new object cancel { get; set; }
  public new object pull { get; set; }
  public new object start { get; set; }
  public new object type { get; set; }
}

public partial interface UnderlyingDefaultSource  {
  public new object cancel { get; set; }
  public new object pull { get; set; }
  public new object start { get; set; }
  public new object type { get; set; }
}

public partial interface UnderlyingSink  {
  public new object abort { get; set; }
  public new object close { get; set; }
  public new object start { get; set; }
  public new object type { get; set; }
  public new object write { get; set; }
}

public partial interface UnderlyingSource  {
  public new double autoAllocateChunkSize { get; set; }
  public new object cancel { get; set; }
  public new object pull { get; set; }
  public new object start { get; set; }
  public new object type { get; set; }
}

public partial interface ValidityStateFlags  {
  public new bool badInput { get; set; }
  public new bool customError { get; set; }
  public new bool patternMismatch { get; set; }
  public new bool rangeOverflow { get; set; }
  public new bool rangeUnderflow { get; set; }
  public new bool stepMismatch { get; set; }
  public new bool tooLong { get; set; }
  public new bool tooShort { get; set; }
  public new bool typeMismatch { get; set; }
  public new bool valueMissing { get; set; }
}

public partial interface VideoColorSpaceInit  {
  public new object fullRange { get; set; }
  public new object matrix { get; set; }
  public new object primaries { get; set; }
  public new object transfer { get; set; }
}

public partial interface VideoConfiguration  {
  public new double bitrate { get; set; }
  public new object colorGamut { get; set; }
  public new string contentType { get; set; }
  public new double framerate { get; set; }
  public new object hdrMetadataType { get; set; }
  public new double height { get; set; }
  public new string scalabilityMode { get; set; }
  public new object transferFunction { get; set; }
  public new double width { get; set; }
}

public partial interface VideoDecoderConfig  {
  public new string codec { get; set; }
  public new double codedHeight { get; set; }
  public new double codedWidth { get; set; }
  public new object colorSpace { get; set; }
  public new object description { get; set; }
  public new double displayAspectHeight { get; set; }
  public new double displayAspectWidth { get; set; }
  public new object hardwareAcceleration { get; set; }
  public new bool optimizeForLatency { get; set; }
}

public partial interface VideoDecoderInit  {
  public new object error { get; set; }
  public new object output { get; set; }
}

public partial interface VideoDecoderSupport  {
  public new object config { get; set; }
  public new bool supported { get; set; }
}

public partial interface VideoEncoderConfig  {
  public new object alpha { get; set; }
  public new object avc { get; set; }
  public new double bitrate { get; set; }
  public new object bitrateMode { get; set; }
  public new string codec { get; set; }
  public new double displayHeight { get; set; }
  public new double displayWidth { get; set; }
  public new double framerate { get; set; }
  public new object hardwareAcceleration { get; set; }
  public new double height { get; set; }
  public new object latencyMode { get; set; }
  public new string scalabilityMode { get; set; }
  public new double width { get; set; }
}

public partial interface VideoEncoderEncodeOptions  {
  public new bool keyFrame { get; set; }
}

public partial interface VideoEncoderInit  {
  public new object error { get; set; }
  public new object output { get; set; }
}

public partial interface VideoEncoderSupport  {
  public new object config { get; set; }
  public new bool supported { get; set; }
}

public partial interface VideoFrameBufferInit  {
  public new double codedHeight { get; set; }
  public new double codedWidth { get; set; }
  public new object colorSpace { get; set; }
  public new double displayHeight { get; set; }
  public new double displayWidth { get; set; }
  public new double duration { get; set; }
  public new object format { get; set; }
  public new object layout { get; set; }
  public new double timestamp { get; set; }
  public new object visibleRect { get; set; }
}

public partial interface VideoFrameCallbackMetadata  {
  public new object captureTime { get; set; }
  public new object expectedDisplayTime { get; set; }
  public new double height { get; set; }
  public new double mediaTime { get; set; }
  public new object presentationTime { get; set; }
  public new double presentedFrames { get; set; }
  public new double processingDuration { get; set; }
  public new object receiveTime { get; set; }
  public new double rtpTimestamp { get; set; }
  public new double width { get; set; }
}

public partial interface VideoFrameCopyToOptions  {
  public new object layout { get; set; }
  public new object rect { get; set; }
}

public partial interface VideoFrameInit  {
  public new object alpha { get; set; }
  public new double displayHeight { get; set; }
  public new double displayWidth { get; set; }
  public new double duration { get; set; }
  public new double timestamp { get; set; }
  public new object visibleRect { get; set; }
}

public partial interface WaveShaperOptions : AudioNodeOptions  {
  public new object curve { get; set; }
  public new object oversample { get; set; }
}

public partial interface WebGLContextAttributes  {
  public new bool alpha { get; set; }
  public new bool antialias { get; set; }
  public new bool depth { get; set; }
  public new bool desynchronized { get; set; }
  public new bool failIfMajorPerformanceCaveat { get; set; }
  public new object powerPreference { get; set; }
  public new bool premultipliedAlpha { get; set; }
  public new bool preserveDrawingBuffer { get; set; }
  public new bool stencil { get; set; }
}

public partial interface WebGLContextEventInit : EventInit  {
  public new string statusMessage { get; set; }
}

public partial interface WebTransportCloseInfo  {
  public new double closeCode { get; set; }
  public new string reason { get; set; }
}

public partial interface WebTransportErrorOptions  {
  public new object source { get; set; }
  public new object streamErrorCode { get; set; }
}

public partial interface WebTransportHash  {
  public new string algorithm { get; set; }
  public new object value { get; set; }
}

public partial interface WebTransportOptions  {
  public new bool allowPooling { get; set; }
  public new object congestionControl { get; set; }
  public new bool requireUnreliable { get; set; }
  public new object serverCertificateHashes { get; set; }
}

public partial interface WebTransportSendStreamOptions  {
  public new object sendOrder { get; set; }
}

public partial interface WheelEventInit : MouseEventInit  {
  public new double deltaMode { get; set; }
  public new double deltaX { get; set; }
  public new double deltaY { get; set; }
  public new double deltaZ { get; set; }
}

public partial interface WindowPostMessageOptions : StructuredSerializeOptions  {
  public new string targetOrigin { get; set; }
}

public partial interface WorkerOptions  {
  public new object credentials { get; set; }
  public new string name { get; set; }
  public new object type { get; set; }
}

public partial interface WorkletOptions  {
  public new object credentials { get; set; }
}

public partial interface WriteParams  {
  public new object data { get; set; }
  public new object position { get; set; }
  public new object size { get; set; }
  public new object type { get; set; }
}

public partial interface ANGLE_instanced_arrays  {
  public new object drawArraysInstancedANGLE(object mode, object first, object count, object primcount);
  public new object drawElementsInstancedANGLE(object mode, object count, object type, object offset, object primcount);
  public new object vertexAttribDivisorANGLE(object index, object divisor);
  public new object VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE { get; }
}

public partial interface ARIAMixin  {
  public new object ariaAtomic { get; set; }
  public new object ariaAutoComplete { get; set; }
  public new object ariaBusy { get; set; }
  public new object ariaChecked { get; set; }
  public new object ariaColCount { get; set; }
  public new object ariaColIndex { get; set; }
  public new object ariaColSpan { get; set; }
  public new object ariaCurrent { get; set; }
  public new object ariaDisabled { get; set; }
  public new object ariaExpanded { get; set; }
  public new object ariaHasPopup { get; set; }
  public new object ariaHidden { get; set; }
  public new object ariaInvalid { get; set; }
  public new object ariaKeyShortcuts { get; set; }
  public new object ariaLabel { get; set; }
  public new object ariaLevel { get; set; }
  public new object ariaLive { get; set; }
  public new object ariaModal { get; set; }
  public new object ariaMultiLine { get; set; }
  public new object ariaMultiSelectable { get; set; }
  public new object ariaOrientation { get; set; }
  public new object ariaPlaceholder { get; set; }
  public new object ariaPosInSet { get; set; }
  public new object ariaPressed { get; set; }
  public new object ariaReadOnly { get; set; }
  public new object ariaRequired { get; set; }
  public new object ariaRoleDescription { get; set; }
  public new object ariaRowCount { get; set; }
  public new object ariaRowIndex { get; set; }
  public new object ariaRowSpan { get; set; }
  public new object ariaSelected { get; set; }
  public new object ariaSetSize { get; set; }
  public new object ariaSort { get; set; }
  public new object ariaValueMax { get; set; }
  public new object ariaValueMin { get; set; }
  public new object ariaValueNow { get; set; }
  public new object ariaValueText { get; set; }
  public new object role { get; set; }
}

public partial interface AbortController  {
  public new object signal { get; }
  public new object abort(object reason);
}

public partial interface AbortSignalEventMap  {
  public new object abort { get; set; }
}

public partial interface AbortSignal : EventTarget  {
  public new bool aborted { get; }
  public new object onabort { get; set; }
  public new object reason { get; }
  public new object throwIfAborted();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AbstractRange  {
  public new bool collapsed { get; }
  public new object endContainer { get; }
  public new double endOffset { get; }
  public new object startContainer { get; }
  public new double startOffset { get; }
}

public partial interface AbstractWorkerEventMap  {
  public new object error { get; set; }
}

public partial interface AbstractWorker  {
  public new object onerror { get; set; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AnalyserNode : AudioNode  {
  public new double fftSize { get; set; }
  public new double frequencyBinCount { get; }
  public new double maxDecibels { get; set; }
  public new double minDecibels { get; set; }
  public new double smoothingTimeConstant { get; set; }
  public new object getByteFrequencyData(object array);
  public new object getByteTimeDomainData(object array);
  public new object getFloatFrequencyData(object array);
  public new object getFloatTimeDomainData(object array);
}

public partial interface Animatable  {
  public new object animate(object keyframes, object options);
  public new object getAnimations(object options);
}

public partial interface AnimationEventMap  {
  public new object cancel { get; set; }
  public new object finish { get; set; }
  public new object remove { get; set; }
}

public partial interface Animation : EventTarget  {
  public new object currentTime { get; set; }
  public new object effect { get; set; }
  public new object finished { get; }
  public new string id { get; set; }
  public new object oncancel { get; set; }
  public new object onfinish { get; set; }
  public new object onremove { get; set; }
  public new bool pending { get; }
  public new object playState { get; }
  public new double playbackRate { get; set; }
  public new object ready { get; }
  public new object replaceState { get; }
  public new object startTime { get; set; }
  public new object timeline { get; set; }
  public new object cancel();
  public new object commitStyles();
  public new object finish();
  public new object pause();
  public new object persist();
  public new object play();
  public new object reverse();
  public new object updatePlaybackRate(double playbackRate);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AnimationEffect  {
  public new object getComputedTiming();
  public new object getTiming();
  public new object updateTiming(object timing);
}

public partial interface AnimationEvent : Event  {
  public new string animationName { get; }
  public new double elapsedTime { get; }
  public new string pseudoElement { get; }
}

public partial interface AnimationFrameProvider  {
  public new object cancelAnimationFrame(double handle);
  public new double requestAnimationFrame(object callback);
}

public partial interface AnimationPlaybackEvent : Event  {
  public new object currentTime { get; }
  public new object timelineTime { get; }
}

public partial interface AnimationTimeline  {
  public new object currentTime { get; }
}

public partial interface Attr : Node  {
  public new string localName { get; }
  public new string name { get; }
  public new object namespaceURI { get; }
  public new object ownerDocument { get; }
  public new object ownerElement { get; }
  public new object prefix { get; }
  public new bool specified { get; }
  public new string value { get; set; }
}

public partial interface AudioBuffer  {
  public new double duration { get; }
  public new double length { get; }
  public new double numberOfChannels { get; }
  public new double sampleRate { get; }
  public new object copyFromChannel(object destination, double channelNumber, double bufferOffset);
  public new object copyToChannel(object source, double channelNumber, double bufferOffset);
  public new object getChannelData(double channel);
}

public partial interface AudioBufferSourceNode : AudioScheduledSourceNode  {
  public new object buffer { get; set; }
  public new object detune { get; }
  public new bool loop { get; set; }
  public new double loopEnd { get; set; }
  public new double loopStart { get; set; }
  public new object playbackRate { get; }
  public new object start(double when, double offset, double duration);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AudioContext : BaseAudioContext  {
  public new double baseLatency { get; }
  public new double outputLatency { get; }
  public new object close();
  public new object createMediaElementSource(object mediaElement);
  public new object createMediaStreamDestination();
  public new object createMediaStreamSource(object mediaStream);
  public new object getOutputTimestamp();
  public new object resume();
  public new object suspend();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AudioDestinationNode : AudioNode  {
  public new double maxChannelCount { get; }
}

public partial interface AudioListener  {
  public new object forwardX { get; }
  public new object forwardY { get; }
  public new object forwardZ { get; }
  public new object positionX { get; }
  public new object positionY { get; }
  public new object positionZ { get; }
  public new object upX { get; }
  public new object upY { get; }
  public new object upZ { get; }
  public new object setOrientation(double x, double y, double z, double xUp, double yUp, double zUp);
  public new object setPosition(double x, double y, double z);
}

public partial interface AudioNode : EventTarget  {
  public new double channelCount { get; set; }
  public new object channelCountMode { get; set; }
  public new object channelInterpretation { get; set; }
  public new object context { get; }
  public new double numberOfInputs { get; }
  public new double numberOfOutputs { get; }
  public new object connect(object destinationNode, double output, double input);
  public new object connect(object destinationParam, double output);
  public new object disconnect();
  public new object disconnect(double output);
  public new object disconnect(object destinationNode);
  public new object disconnect(object destinationNode, double output);
  public new object disconnect(object destinationNode, double output, double input);
  public new object disconnect(object destinationParam);
  public new object disconnect(object destinationParam, double output);
}

public partial interface AudioParam  {
  public new object automationRate { get; set; }
  public new double defaultValue { get; }
  public new double maxValue { get; }
  public new double minValue { get; }
  public new double value { get; set; }
  public new object cancelAndHoldAtTime(double cancelTime);
  public new object cancelScheduledValues(double cancelTime);
  public new object exponentialRampToValueAtTime(double value, double endTime);
  public new object linearRampToValueAtTime(double value, double endTime);
  public new object setTargetAtTime(double target, double startTime, double timeConstant);
  public new object setValueAtTime(double value, double startTime);
  public new object setValueCurveAtTime(object values, double startTime, double duration);
}

public partial interface AudioParamMap  {
  public new object forEach(object callbackfn, object thisArg);
}

public partial interface AudioProcessingEvent : Event  {
  public new object inputBuffer { get; }
  public new object outputBuffer { get; }
  public new double playbackTime { get; }
}

public partial interface AudioScheduledSourceNodeEventMap  {
  public new object ended { get; set; }
}

public partial interface AudioScheduledSourceNode : AudioNode  {
  public new object onended { get; set; }
  public new object start(double when);
  public new object stop(double when);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AudioWorklet : Worklet  {}

public partial interface AudioWorkletNodeEventMap  {
  public new object processorerror { get; set; }
}

public partial interface AudioWorkletNode : AudioNode  {
  public new object onprocessorerror { get; set; }
  public new object parameters { get; }
  public new object port { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface AuthenticatorAssertionResponse : AuthenticatorResponse  {
  public new object authenticatorData { get; }
  public new object signature { get; }
  public new object userHandle { get; }
}

public partial interface AuthenticatorAttestationResponse : AuthenticatorResponse  {
  public new object attestationObject { get; }
  public new object getAuthenticatorData();
  public new object getPublicKey();
  public new object getPublicKeyAlgorithm();
  public new object getTransports();
}

public partial interface AuthenticatorResponse  {
  public new object clientDataJSON { get; }
}

public partial interface BarProp  {
  public new bool visible { get; }
}

public partial interface BaseAudioContextEventMap  {
  public new object statechange { get; set; }
}

public partial interface BaseAudioContext : EventTarget  {
  public new object audioWorklet { get; }
  public new double currentTime { get; }
  public new object destination { get; }
  public new object listener { get; }
  public new object onstatechange { get; set; }
  public new double sampleRate { get; }
  public new object state { get; }
  public new object createAnalyser();
  public new object createBiquadFilter();
  public new object createBuffer(double numberOfChannels, double length, double sampleRate);
  public new object createBufferSource();
  public new object createChannelMerger(double numberOfInputs);
  public new object createChannelSplitter(double numberOfOutputs);
  public new object createConstantSource();
  public new object createConvolver();
  public new object createDelay(double maxDelayTime);
  public new object createDynamicsCompressor();
  public new object createGain();
  public new object createIIRFilter(object feedforward, object feedback);
  public new object createOscillator();
  public new object createPanner();
  public new object createPeriodicWave(object real, object imag, object constraints);
  public new object createScriptProcessor(double bufferSize, double numberOfInputChannels, double numberOfOutputChannels);
  public new object createStereoPanner();
  public new object createWaveShaper();
  public new object decodeAudioData(object audioData, object successCallback, object errorCallback);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface BeforeUnloadEvent : Event  {
  public new object returnValue { get; set; }
}

public partial interface BiquadFilterNode : AudioNode  {
  public new object Q { get; }
  public new object detune { get; }
  public new object frequency { get; }
  public new object gain { get; }
  public new object type { get; set; }
  public new object getFrequencyResponse(object frequencyHz, object magResponse, object phaseResponse);
}

public partial interface Blob  {
  public new double size { get; }
  public new string type { get; }
  public new object arrayBuffer();
  public new object slice(double start, double end, string contentType);
  public new object stream();
  public new object text();
}

public partial interface BlobEvent : Event  {
  public new object data { get; }
  public new object timecode { get; }
}

public partial interface Body  {
  public new object body { get; }
  public new bool bodyUsed { get; }
  public new object arrayBuffer();
  public new object blob();
  public new object formData();
  public new object json();
  public new object text();
}

public partial interface BroadcastChannelEventMap  {
  public new object message { get; set; }
  public new object messageerror { get; set; }
}

public partial interface BroadcastChannel : EventTarget  {
  public new string name { get; }
  public new object onmessage { get; set; }
  public new object onmessageerror { get; set; }
  public new object close();
  public new object postMessage(object message);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ByteLengthQueuingStrategy : QueuingStrategy  {
  public new double highWaterMark { get; }
  public new object size { get; }
}

public partial interface CDATASection : Text  {}

public partial interface CSSAnimation : Animation  {
  public new string animationName { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface CSSConditionRule : CSSGroupingRule  {
  public new string conditionText { get; }
}

public partial interface CSSContainerRule : CSSConditionRule  {
  public new string containerName { get; }
  public new string containerQuery { get; }
}

public partial interface CSSCounterStyleRule : CSSRule  {
  public new string additiveSymbols { get; set; }
  public new string fallback { get; set; }
  public new string name { get; set; }
  public new string negative { get; set; }
  public new string pad { get; set; }
  public new string prefix { get; set; }
  public new string range { get; set; }
  public new string speakAs { get; set; }
  public new string suffix { get; set; }
  public new string symbols { get; set; }
  public new string system { get; set; }
}

public partial interface CSSFontFaceRule : CSSRule  {
  public new object style { get; }
}

public partial interface CSSFontFeatureValuesRule : CSSRule  {
  public new string fontFamily { get; set; }
}

public partial interface CSSFontPaletteValuesRule : CSSRule  {
  public new string basePalette { get; }
  public new string fontFamily { get; }
  public new string name { get; }
  public new string overrideColors { get; }
}

public partial interface CSSGroupingRule : CSSRule  {
  public new object cssRules { get; }
  public new object deleteRule(double index);
  public new double insertRule(string rule, double index);
}

public partial interface CSSImageValue : CSSStyleValue  {}

public partial interface CSSImportRule : CSSRule  {
  public new string href { get; }
  public new object layerName { get; }
  public new object media { get; }
  public new object styleSheet { get; }
}

public partial interface CSSKeyframeRule : CSSRule  {
  public new string keyText { get; set; }
  public new object style { get; }
}

public partial interface CSSKeyframesRule : CSSRule  {
  public new object cssRules { get; }
  public new double length { get; }
  public new string name { get; set; }
  public new object appendRule(string rule);
  public new object deleteRule(string select);
  public new object findRule(string select);
  // TODO: Unsupported member: undefined
}

public partial interface CSSKeywordValue : CSSStyleValue  {
  public new string value { get; set; }
}

public partial interface CSSLayerBlockRule : CSSGroupingRule  {
  public new string name { get; }
}

public partial interface CSSLayerStatementRule : CSSRule  {
  public new object nameList { get; }
}

public partial interface CSSMathClamp : CSSMathValue  {
  public new object lower { get; }
  public new object upper { get; }
  public new object value { get; }
}

public partial interface CSSMathInvert : CSSMathValue  {
  public new object value { get; }
}

public partial interface CSSMathMax : CSSMathValue  {
  public new object values { get; }
}

public partial interface CSSMathMin : CSSMathValue  {
  public new object values { get; }
}

public partial interface CSSMathNegate : CSSMathValue  {
  public new object value { get; }
}

public partial interface CSSMathProduct : CSSMathValue  {
  public new object values { get; }
}

public partial interface CSSMathSum : CSSMathValue  {
  public new object values { get; }
}

public partial interface CSSMathValue : CSSNumericValue  {
  public new object operatorProperty { get; }
}

public partial interface CSSMatrixComponent : CSSTransformComponent  {
  public new object matrix { get; set; }
}

public partial interface CSSMediaRule : CSSConditionRule  {
  public new object media { get; }
}

public partial interface CSSNamespaceRule : CSSRule  {
  public new string namespaceURI { get; }
  public new string prefix { get; }
}

public partial interface CSSNumericArray  {
  public new double length { get; }
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface CSSNumericValue : CSSStyleValue  {
  public new object add(object values);
  public new object div(object values);
  public new bool equals(object value);
  public new object max(object values);
  public new object min(object values);
  public new object mul(object values);
  public new object sub(object values);
  public new object to(string unit);
  public new object toSum(object units);
  public new object type();
}

public partial interface CSSPageRule : CSSGroupingRule  {
  public new string selectorText { get; set; }
  public new object style { get; }
}

public partial interface CSSPerspective : CSSTransformComponent  {
  public new object length { get; set; }
}

public partial interface CSSPropertyRule : CSSRule  {
  public new bool inherits { get; }
  public new object initialValue { get; }
  public new string name { get; }
  public new string syntax { get; }
}

public partial interface CSSRotate : CSSTransformComponent  {
  public new object angle { get; set; }
  public new object x { get; set; }
  public new object y { get; set; }
  public new object z { get; set; }
}

public partial interface CSSRule  {
  public new string cssText { get; set; }
  public new object parentRule { get; }
  public new object parentStyleSheet { get; }
  public new double type { get; }
  public new object STYLE_RULE { get; }
  public new object CHARSET_RULE { get; }
  public new object IMPORT_RULE { get; }
  public new object MEDIA_RULE { get; }
  public new object FONT_FACE_RULE { get; }
  public new object PAGE_RULE { get; }
  public new object NAMESPACE_RULE { get; }
  public new object KEYFRAMES_RULE { get; }
  public new object KEYFRAME_RULE { get; }
  public new object SUPPORTS_RULE { get; }
}

public partial interface CSSRuleList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface CSSScale : CSSTransformComponent  {
  public new object x { get; set; }
  public new object y { get; set; }
  public new object z { get; set; }
}

public partial interface CSSSkew : CSSTransformComponent  {
  public new object ax { get; set; }
  public new object ay { get; set; }
}

public partial interface CSSSkewX : CSSTransformComponent  {
  public new object ax { get; set; }
}

public partial interface CSSSkewY : CSSTransformComponent  {
  public new object ay { get; set; }
}

public partial interface CSSStyleDeclaration  {
  public new string accentColor { get; set; }
  public new string alignContent { get; set; }
  public new string alignItems { get; set; }
  public new string alignSelf { get; set; }
  public new string alignmentBaseline { get; set; }
  public new string all { get; set; }
  public new string animation { get; set; }
  public new string animationComposition { get; set; }
  public new string animationDelay { get; set; }
  public new string animationDirection { get; set; }
  public new string animationDuration { get; set; }
  public new string animationFillMode { get; set; }
  public new string animationIterationCount { get; set; }
  public new string animationName { get; set; }
  public new string animationPlayState { get; set; }
  public new string animationTimingFunction { get; set; }
  public new string appearance { get; set; }
  public new string aspectRatio { get; set; }
  public new string backdropFilter { get; set; }
  public new string backfaceVisibility { get; set; }
  public new string background { get; set; }
  public new string backgroundAttachment { get; set; }
  public new string backgroundBlendMode { get; set; }
  public new string backgroundClip { get; set; }
  public new string backgroundColor { get; set; }
  public new string backgroundImage { get; set; }
  public new string backgroundOrigin { get; set; }
  public new string backgroundPosition { get; set; }
  public new string backgroundPositionX { get; set; }
  public new string backgroundPositionY { get; set; }
  public new string backgroundRepeat { get; set; }
  public new string backgroundSize { get; set; }
  public new string baselineShift { get; set; }
  public new string blockSize { get; set; }
  public new string border { get; set; }
  public new string borderBlock { get; set; }
  public new string borderBlockColor { get; set; }
  public new string borderBlockEnd { get; set; }
  public new string borderBlockEndColor { get; set; }
  public new string borderBlockEndStyle { get; set; }
  public new string borderBlockEndWidth { get; set; }
  public new string borderBlockStart { get; set; }
  public new string borderBlockStartColor { get; set; }
  public new string borderBlockStartStyle { get; set; }
  public new string borderBlockStartWidth { get; set; }
  public new string borderBlockStyle { get; set; }
  public new string borderBlockWidth { get; set; }
  public new string borderBottom { get; set; }
  public new string borderBottomColor { get; set; }
  public new string borderBottomLeftRadius { get; set; }
  public new string borderBottomRightRadius { get; set; }
  public new string borderBottomStyle { get; set; }
  public new string borderBottomWidth { get; set; }
  public new string borderCollapse { get; set; }
  public new string borderColor { get; set; }
  public new string borderEndEndRadius { get; set; }
  public new string borderEndStartRadius { get; set; }
  public new string borderImage { get; set; }
  public new string borderImageOutset { get; set; }
  public new string borderImageRepeat { get; set; }
  public new string borderImageSlice { get; set; }
  public new string borderImageSource { get; set; }
  public new string borderImageWidth { get; set; }
  public new string borderInline { get; set; }
  public new string borderInlineColor { get; set; }
  public new string borderInlineEnd { get; set; }
  public new string borderInlineEndColor { get; set; }
  public new string borderInlineEndStyle { get; set; }
  public new string borderInlineEndWidth { get; set; }
  public new string borderInlineStart { get; set; }
  public new string borderInlineStartColor { get; set; }
  public new string borderInlineStartStyle { get; set; }
  public new string borderInlineStartWidth { get; set; }
  public new string borderInlineStyle { get; set; }
  public new string borderInlineWidth { get; set; }
  public new string borderLeft { get; set; }
  public new string borderLeftColor { get; set; }
  public new string borderLeftStyle { get; set; }
  public new string borderLeftWidth { get; set; }
  public new string borderRadius { get; set; }
  public new string borderRight { get; set; }
  public new string borderRightColor { get; set; }
  public new string borderRightStyle { get; set; }
  public new string borderRightWidth { get; set; }
  public new string borderSpacing { get; set; }
  public new string borderStartEndRadius { get; set; }
  public new string borderStartStartRadius { get; set; }
  public new string borderStyle { get; set; }
  public new string borderTop { get; set; }
  public new string borderTopColor { get; set; }
  public new string borderTopLeftRadius { get; set; }
  public new string borderTopRightRadius { get; set; }
  public new string borderTopStyle { get; set; }
  public new string borderTopWidth { get; set; }
  public new string borderWidth { get; set; }
  public new string bottom { get; set; }
  public new string boxShadow { get; set; }
  public new string boxSizing { get; set; }
  public new string breakAfter { get; set; }
  public new string breakBefore { get; set; }
  public new string breakInside { get; set; }
  public new string captionSide { get; set; }
  public new string caretColor { get; set; }
  public new string clear { get; set; }
  public new string clip { get; set; }
  public new string clipPath { get; set; }
  public new string clipRule { get; set; }
  public new string color { get; set; }
  public new string colorInterpolation { get; set; }
  public new string colorInterpolationFilters { get; set; }
  public new string colorScheme { get; set; }
  public new string columnCount { get; set; }
  public new string columnFill { get; set; }
  public new string columnGap { get; set; }
  public new string columnRule { get; set; }
  public new string columnRuleColor { get; set; }
  public new string columnRuleStyle { get; set; }
  public new string columnRuleWidth { get; set; }
  public new string columnSpan { get; set; }
  public new string columnWidth { get; set; }
  public new string columns { get; set; }
  public new string contain { get; set; }
  public new string containIntrinsicBlockSize { get; set; }
  public new string containIntrinsicHeight { get; set; }
  public new string containIntrinsicInlineSize { get; set; }
  public new string containIntrinsicSize { get; set; }
  public new string containIntrinsicWidth { get; set; }
  public new string container { get; set; }
  public new string containerName { get; set; }
  public new string containerType { get; set; }
  public new string content { get; set; }
  public new string counterIncrement { get; set; }
  public new string counterReset { get; set; }
  public new string counterSet { get; set; }
  public new string cssFloat { get; set; }
  public new string cssText { get; set; }
  public new string cursor { get; set; }
  public new string direction { get; set; }
  public new string display { get; set; }
  public new string dominantBaseline { get; set; }
  public new string emptyCells { get; set; }
  public new string fill { get; set; }
  public new string fillOpacity { get; set; }
  public new string fillRule { get; set; }
  public new string filter { get; set; }
  public new string flex { get; set; }
  public new string flexBasis { get; set; }
  public new string flexDirection { get; set; }
  public new string flexFlow { get; set; }
  public new string flexGrow { get; set; }
  public new string flexShrink { get; set; }
  public new string flexWrap { get; set; }
  public new string floatProperty { get; set; }
  public new string floodColor { get; set; }
  public new string floodOpacity { get; set; }
  public new string font { get; set; }
  public new string fontFamily { get; set; }
  public new string fontFeatureSettings { get; set; }
  public new string fontKerning { get; set; }
  public new string fontOpticalSizing { get; set; }
  public new string fontPalette { get; set; }
  public new string fontSize { get; set; }
  public new string fontSizeAdjust { get; set; }
  public new string fontStretch { get; set; }
  public new string fontStyle { get; set; }
  public new string fontSynthesis { get; set; }
  public new string fontSynthesisSmallCaps { get; set; }
  public new string fontSynthesisStyle { get; set; }
  public new string fontSynthesisWeight { get; set; }
  public new string fontVariant { get; set; }
  public new string fontVariantAlternates { get; set; }
  public new string fontVariantCaps { get; set; }
  public new string fontVariantEastAsian { get; set; }
  public new string fontVariantLigatures { get; set; }
  public new string fontVariantNumeric { get; set; }
  public new string fontVariantPosition { get; set; }
  public new string fontVariationSettings { get; set; }
  public new string fontWeight { get; set; }
  public new string forcedColorAdjust { get; set; }
  public new string gap { get; set; }
  public new string grid { get; set; }
  public new string gridArea { get; set; }
  public new string gridAutoColumns { get; set; }
  public new string gridAutoFlow { get; set; }
  public new string gridAutoRows { get; set; }
  public new string gridColumn { get; set; }
  public new string gridColumnEnd { get; set; }
  public new string gridColumnGap { get; set; }
  public new string gridColumnStart { get; set; }
  public new string gridGap { get; set; }
  public new string gridRow { get; set; }
  public new string gridRowEnd { get; set; }
  public new string gridRowGap { get; set; }
  public new string gridRowStart { get; set; }
  public new string gridTemplate { get; set; }
  public new string gridTemplateAreas { get; set; }
  public new string gridTemplateColumns { get; set; }
  public new string gridTemplateRows { get; set; }
  public new string height { get; set; }
  public new string hyphenateCharacter { get; set; }
  public new string hyphens { get; set; }
  public new string imageOrientation { get; set; }
  public new string imageRendering { get; set; }
  public new string inlineSize { get; set; }
  public new string inset { get; set; }
  public new string insetBlock { get; set; }
  public new string insetBlockEnd { get; set; }
  public new string insetBlockStart { get; set; }
  public new string insetInline { get; set; }
  public new string insetInlineEnd { get; set; }
  public new string insetInlineStart { get; set; }
  public new string isolation { get; set; }
  public new string justifyContent { get; set; }
  public new string justifyItems { get; set; }
  public new string justifySelf { get; set; }
  public new string left { get; set; }
  public new double length { get; }
  public new string letterSpacing { get; set; }
  public new string lightingColor { get; set; }
  public new string lineBreak { get; set; }
  public new string lineHeight { get; set; }
  public new string listStyle { get; set; }
  public new string listStyleImage { get; set; }
  public new string listStylePosition { get; set; }
  public new string listStyleType { get; set; }
  public new string margin { get; set; }
  public new string marginBlock { get; set; }
  public new string marginBlockEnd { get; set; }
  public new string marginBlockStart { get; set; }
  public new string marginBottom { get; set; }
  public new string marginInline { get; set; }
  public new string marginInlineEnd { get; set; }
  public new string marginInlineStart { get; set; }
  public new string marginLeft { get; set; }
  public new string marginRight { get; set; }
  public new string marginTop { get; set; }
  public new string marker { get; set; }
  public new string markerEnd { get; set; }
  public new string markerMid { get; set; }
  public new string markerStart { get; set; }
  public new string mask { get; set; }
  public new string maskClip { get; set; }
  public new string maskComposite { get; set; }
  public new string maskImage { get; set; }
  public new string maskMode { get; set; }
  public new string maskOrigin { get; set; }
  public new string maskPosition { get; set; }
  public new string maskRepeat { get; set; }
  public new string maskSize { get; set; }
  public new string maskType { get; set; }
  public new string mathStyle { get; set; }
  public new string maxBlockSize { get; set; }
  public new string maxHeight { get; set; }
  public new string maxInlineSize { get; set; }
  public new string maxWidth { get; set; }
  public new string minBlockSize { get; set; }
  public new string minHeight { get; set; }
  public new string minInlineSize { get; set; }
  public new string minWidth { get; set; }
  public new string mixBlendMode { get; set; }
  public new string objectFit { get; set; }
  public new string objectPosition { get; set; }
  public new string offset { get; set; }
  public new string offsetDistance { get; set; }
  public new string offsetPath { get; set; }
  public new string offsetRotate { get; set; }
  public new string opacity { get; set; }
  public new string order { get; set; }
  public new string orphans { get; set; }
  public new string outline { get; set; }
  public new string outlineColor { get; set; }
  public new string outlineOffset { get; set; }
  public new string outlineStyle { get; set; }
  public new string outlineWidth { get; set; }
  public new string overflow { get; set; }
  public new string overflowAnchor { get; set; }
  public new string overflowClipMargin { get; set; }
  public new string overflowWrap { get; set; }
  public new string overflowX { get; set; }
  public new string overflowY { get; set; }
  public new string overscrollBehavior { get; set; }
  public new string overscrollBehaviorBlock { get; set; }
  public new string overscrollBehaviorInline { get; set; }
  public new string overscrollBehaviorX { get; set; }
  public new string overscrollBehaviorY { get; set; }
  public new string padding { get; set; }
  public new string paddingBlock { get; set; }
  public new string paddingBlockEnd { get; set; }
  public new string paddingBlockStart { get; set; }
  public new string paddingBottom { get; set; }
  public new string paddingInline { get; set; }
  public new string paddingInlineEnd { get; set; }
  public new string paddingInlineStart { get; set; }
  public new string paddingLeft { get; set; }
  public new string paddingRight { get; set; }
  public new string paddingTop { get; set; }
  public new string page { get; set; }
  public new string pageBreakAfter { get; set; }
  public new string pageBreakBefore { get; set; }
  public new string pageBreakInside { get; set; }
  public new string paintOrder { get; set; }
  public new object parentRule { get; }
  public new string perspective { get; set; }
  public new string perspectiveOrigin { get; set; }
  public new string placeContent { get; set; }
  public new string placeItems { get; set; }
  public new string placeSelf { get; set; }
  public new string pointerEvents { get; set; }
  public new string position { get; set; }
  public new string printColorAdjust { get; set; }
  public new string quotes { get; set; }
  public new string resize { get; set; }
  public new string right { get; set; }
  public new string rotate { get; set; }
  public new string rowGap { get; set; }
  public new string rubyPosition { get; set; }
  public new string scale { get; set; }
  public new string scrollBehavior { get; set; }
  public new string scrollMargin { get; set; }
  public new string scrollMarginBlock { get; set; }
  public new string scrollMarginBlockEnd { get; set; }
  public new string scrollMarginBlockStart { get; set; }
  public new string scrollMarginBottom { get; set; }
  public new string scrollMarginInline { get; set; }
  public new string scrollMarginInlineEnd { get; set; }
  public new string scrollMarginInlineStart { get; set; }
  public new string scrollMarginLeft { get; set; }
  public new string scrollMarginRight { get; set; }
  public new string scrollMarginTop { get; set; }
  public new string scrollPadding { get; set; }
  public new string scrollPaddingBlock { get; set; }
  public new string scrollPaddingBlockEnd { get; set; }
  public new string scrollPaddingBlockStart { get; set; }
  public new string scrollPaddingBottom { get; set; }
  public new string scrollPaddingInline { get; set; }
  public new string scrollPaddingInlineEnd { get; set; }
  public new string scrollPaddingInlineStart { get; set; }
  public new string scrollPaddingLeft { get; set; }
  public new string scrollPaddingRight { get; set; }
  public new string scrollPaddingTop { get; set; }
  public new string scrollSnapAlign { get; set; }
  public new string scrollSnapStop { get; set; }
  public new string scrollSnapType { get; set; }
  public new string scrollbarGutter { get; set; }
  public new string shapeImageThreshold { get; set; }
  public new string shapeMargin { get; set; }
  public new string shapeOutside { get; set; }
  public new string shapeRendering { get; set; }
  public new string stopColor { get; set; }
  public new string stopOpacity { get; set; }
  public new string stroke { get; set; }
  public new string strokeDasharray { get; set; }
  public new string strokeDashoffset { get; set; }
  public new string strokeLinecap { get; set; }
  public new string strokeLinejoin { get; set; }
  public new string strokeMiterlimit { get; set; }
  public new string strokeOpacity { get; set; }
  public new string strokeWidth { get; set; }
  public new string tabSize { get; set; }
  public new string tableLayout { get; set; }
  public new string textAlign { get; set; }
  public new string textAlignLast { get; set; }
  public new string textAnchor { get; set; }
  public new string textCombineUpright { get; set; }
  public new string textDecoration { get; set; }
  public new string textDecorationColor { get; set; }
  public new string textDecorationLine { get; set; }
  public new string textDecorationSkipInk { get; set; }
  public new string textDecorationStyle { get; set; }
  public new string textDecorationThickness { get; set; }
  public new string textEmphasis { get; set; }
  public new string textEmphasisColor { get; set; }
  public new string textEmphasisPosition { get; set; }
  public new string textEmphasisStyle { get; set; }
  public new string textIndent { get; set; }
  public new string textOrientation { get; set; }
  public new string textOverflow { get; set; }
  public new string textRendering { get; set; }
  public new string textShadow { get; set; }
  public new string textTransform { get; set; }
  public new string textUnderlineOffset { get; set; }
  public new string textUnderlinePosition { get; set; }
  public new string top { get; set; }
  public new string touchAction { get; set; }
  public new string transform { get; set; }
  public new string transformBox { get; set; }
  public new string transformOrigin { get; set; }
  public new string transformStyle { get; set; }
  public new string transition { get; set; }
  public new string transitionDelay { get; set; }
  public new string transitionDuration { get; set; }
  public new string transitionProperty { get; set; }
  public new string transitionTimingFunction { get; set; }
  public new string translate { get; set; }
  public new string unicodeBidi { get; set; }
  public new string userSelect { get; set; }
  public new string verticalAlign { get; set; }
  public new string visibility { get; set; }
  public new string webkitAlignContent { get; set; }
  public new string webkitAlignItems { get; set; }
  public new string webkitAlignSelf { get; set; }
  public new string webkitAnimation { get; set; }
  public new string webkitAnimationDelay { get; set; }
  public new string webkitAnimationDirection { get; set; }
  public new string webkitAnimationDuration { get; set; }
  public new string webkitAnimationFillMode { get; set; }
  public new string webkitAnimationIterationCount { get; set; }
  public new string webkitAnimationName { get; set; }
  public new string webkitAnimationPlayState { get; set; }
  public new string webkitAnimationTimingFunction { get; set; }
  public new string webkitAppearance { get; set; }
  public new string webkitBackfaceVisibility { get; set; }
  public new string webkitBackgroundClip { get; set; }
  public new string webkitBackgroundOrigin { get; set; }
  public new string webkitBackgroundSize { get; set; }
  public new string webkitBorderBottomLeftRadius { get; set; }
  public new string webkitBorderBottomRightRadius { get; set; }
  public new string webkitBorderRadius { get; set; }
  public new string webkitBorderTopLeftRadius { get; set; }
  public new string webkitBorderTopRightRadius { get; set; }
  public new string webkitBoxAlign { get; set; }
  public new string webkitBoxFlex { get; set; }
  public new string webkitBoxOrdinalGroup { get; set; }
  public new string webkitBoxOrient { get; set; }
  public new string webkitBoxPack { get; set; }
  public new string webkitBoxShadow { get; set; }
  public new string webkitBoxSizing { get; set; }
  public new string webkitFilter { get; set; }
  public new string webkitFlex { get; set; }
  public new string webkitFlexBasis { get; set; }
  public new string webkitFlexDirection { get; set; }
  public new string webkitFlexFlow { get; set; }
  public new string webkitFlexGrow { get; set; }
  public new string webkitFlexShrink { get; set; }
  public new string webkitFlexWrap { get; set; }
  public new string webkitJustifyContent { get; set; }
  public new string webkitLineClamp { get; set; }
  public new string webkitMask { get; set; }
  public new string webkitMaskBoxImage { get; set; }
  public new string webkitMaskBoxImageOutset { get; set; }
  public new string webkitMaskBoxImageRepeat { get; set; }
  public new string webkitMaskBoxImageSlice { get; set; }
  public new string webkitMaskBoxImageSource { get; set; }
  public new string webkitMaskBoxImageWidth { get; set; }
  public new string webkitMaskClip { get; set; }
  public new string webkitMaskComposite { get; set; }
  public new string webkitMaskImage { get; set; }
  public new string webkitMaskOrigin { get; set; }
  public new string webkitMaskPosition { get; set; }
  public new string webkitMaskRepeat { get; set; }
  public new string webkitMaskSize { get; set; }
  public new string webkitOrder { get; set; }
  public new string webkitPerspective { get; set; }
  public new string webkitPerspectiveOrigin { get; set; }
  public new string webkitTextFillColor { get; set; }
  public new string webkitTextSizeAdjust { get; set; }
  public new string webkitTextStroke { get; set; }
  public new string webkitTextStrokeColor { get; set; }
  public new string webkitTextStrokeWidth { get; set; }
  public new string webkitTransform { get; set; }
  public new string webkitTransformOrigin { get; set; }
  public new string webkitTransformStyle { get; set; }
  public new string webkitTransition { get; set; }
  public new string webkitTransitionDelay { get; set; }
  public new string webkitTransitionDuration { get; set; }
  public new string webkitTransitionProperty { get; set; }
  public new string webkitTransitionTimingFunction { get; set; }
  public new string webkitUserSelect { get; set; }
  public new string whiteSpace { get; set; }
  public new string widows { get; set; }
  public new string width { get; set; }
  public new string willChange { get; set; }
  public new string wordBreak { get; set; }
  public new string wordSpacing { get; set; }
  public new string wordWrap { get; set; }
  public new string writingMode { get; set; }
  public new string zIndex { get; set; }
  public new string getPropertyPriority(string property);
  public new string getPropertyValue(string property);
  public new string item(double index);
  public new string removeProperty(string property);
  public new object setProperty(string property, object value, string priority);
  // TODO: Unsupported member: undefined
}

public partial interface CSSStyleRule : CSSRule  {
  public new object cssRules { get; }
  public new string selectorText { get; set; }
  public new object style { get; }
  public new object styleMap { get; }
  public new object deleteRule(double index);
  public new double insertRule(string rule, double index);
}

public partial interface CSSStyleSheet : StyleSheet  {
  public new object cssRules { get; }
  public new object ownerRule { get; }
  public new object rules { get; }
  public new double addRule(string selector, string style, double index);
  public new object deleteRule(double index);
  public new double insertRule(string rule, double index);
  public new object removeRule(double index);
  public new object replace(string text);
  public new object replaceSync(string text);
}

public partial interface CSSStyleValue  {
  public new string toStringMethod();
}

public partial interface CSSSupportsRule : CSSConditionRule  {}

public partial interface CSSTransformComponent  {
  public new bool is2D { get; set; }
  public new object toMatrix();
  public new string toStringMethod();
}

public partial interface CSSTransformValue : CSSStyleValue  {
  public new bool is2D { get; }
  public new double length { get; }
  public new object toMatrix();
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface CSSTransition : Animation  {
  public new string transitionProperty { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface CSSTranslate : CSSTransformComponent  {
  public new object x { get; set; }
  public new object y { get; set; }
  public new object z { get; set; }
}

public partial interface CSSUnitValue : CSSNumericValue  {
  public new string unit { get; }
  public new double value { get; set; }
}

public partial interface CSSUnparsedValue : CSSStyleValue  {
  public new double length { get; }
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface CSSVariableReferenceValue  {
  public new object fallback { get; }
  public new string variable { get; set; }
}

public partial interface Cache  {
  public new object add(object request);
  public new object addAll(object requests);
  public new object delete(object request, object options);
  public new object keys(object request, object options);
  public new object match(object request, object options);
  public new object matchAll(object request, object options);
  public new object put(object request, object response);
}

public partial interface CacheStorage  {
  public new object delete(string cacheName);
  public new object has(string cacheName);
  public new object keys();
  public new object match(object request, object options);
  public new object open(string cacheName);
}

public partial interface CanvasCaptureMediaStreamTrack : MediaStreamTrack  {
  public new object canvas { get; }
  public new object requestFrame();
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface CanvasCompositing  {
  public new double globalAlpha { get; set; }
  public new object globalCompositeOperation { get; set; }
}

public partial interface CanvasDrawImage  {
  public new object drawImage(object image, double dx, double dy);
  public new object drawImage(object image, double dx, double dy, double dw, double dh);
  public new object drawImage(object image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);
}

public partial interface CanvasDrawPath  {
  public new object beginPath();
  public new object clip(object fillRule);
  public new object clip(object path, object fillRule);
  public new object fill(object fillRule);
  public new object fill(object path, object fillRule);
  public new bool isPointInPath(double x, double y, object fillRule);
  public new bool isPointInPath(object path, double x, double y, object fillRule);
  public new bool isPointInStroke(double x, double y);
  public new bool isPointInStroke(object path, double x, double y);
  public new object stroke();
  public new object stroke(object path);
}

public partial interface CanvasFillStrokeStyles  {
  public new object fillStyle { get; set; }
  public new object strokeStyle { get; set; }
  public new object createConicGradient(double startAngle, double x, double y);
  public new object createLinearGradient(double x0, double y0, double x1, double y1);
  public new object createPattern(object image, object repetition);
  public new object createRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1);
}

public partial interface CanvasFilters  {
  public new string filter { get; set; }
}

public partial interface CanvasGradient  {
  public new object addColorStop(double offset, string color);
}

public partial interface CanvasImageData  {
  public new object createImageData(double sw, double sh, object settings);
  public new object createImageData(object imagedata);
  public new object getImageData(double sx, double sy, double sw, double sh, object settings);
  public new object putImageData(object imagedata, double dx, double dy);
  public new object putImageData(object imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight);
}

public partial interface CanvasImageSmoothing  {
  public new bool imageSmoothingEnabled { get; set; }
  public new object imageSmoothingQuality { get; set; }
}

public partial interface CanvasPath  {
  public new object arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise);
  public new object arcTo(double x1, double y1, double x2, double y2, double radius);
  public new object bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);
  public new object closePath();
  public new object ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise);
  public new object lineTo(double x, double y);
  public new object moveTo(double x, double y);
  public new object quadraticCurveTo(double cpx, double cpy, double x, double y);
  public new object rect(double x, double y, double w, double h);
  public new object roundRect(double x, double y, double w, double h, object radii);
}

public partial interface CanvasPathDrawingStyles  {
  public new object lineCap { get; set; }
  public new double lineDashOffset { get; set; }
  public new object lineJoin { get; set; }
  public new double lineWidth { get; set; }
  public new double miterLimit { get; set; }
  public new object getLineDash();
  public new object setLineDash(object segments);
}

public partial interface CanvasPattern  {
  public new object setTransform(object transform);
}

public partial interface CanvasRect  {
  public new object clearRect(double x, double y, double w, double h);
  public new object fillRect(double x, double y, double w, double h);
  public new object strokeRect(double x, double y, double w, double h);
}

public partial interface CanvasRenderingContext2D : CanvasCompositing, CanvasDrawImage, CanvasDrawPath, CanvasFillStrokeStyles, CanvasFilters, CanvasImageData, CanvasImageSmoothing, CanvasPath, CanvasPathDrawingStyles, CanvasRect, CanvasShadowStyles, CanvasState, CanvasText, CanvasTextDrawingStyles, CanvasTransform, CanvasUserInterface  {
  public new object canvas { get; }
  public new object getContextAttributes();
}

public partial interface CanvasShadowStyles  {
  public new double shadowBlur { get; set; }
  public new string shadowColor { get; set; }
  public new double shadowOffsetX { get; set; }
  public new double shadowOffsetY { get; set; }
}

public partial interface CanvasState  {
  public new object reset();
  public new object restore();
  public new object save();
}

public partial interface CanvasText  {
  public new object fillText(string text, double x, double y, double maxWidth);
  public new object measureText(string text);
  public new object strokeText(string text, double x, double y, double maxWidth);
}

public partial interface CanvasTextDrawingStyles  {
  public new object direction { get; set; }
  public new string font { get; set; }
  public new object fontKerning { get; set; }
  public new object textAlign { get; set; }
  public new object textBaseline { get; set; }
}

public partial interface CanvasTransform  {
  public new object getTransform();
  public new object resetTransform();
  public new object rotate(double angle);
  public new object scale(double x, double y);
  public new object setTransform(double a, double b, double c, double d, double e, double f);
  public new object setTransform(object transform);
  public new object transform(double a, double b, double c, double d, double e, double f);
  public new object translate(double x, double y);
}

public partial interface CanvasUserInterface  {
  public new object drawFocusIfNeeded(object element);
  public new object drawFocusIfNeeded(object path, object element);
}

public partial interface ChannelMergerNode : AudioNode  {}

public partial interface ChannelSplitterNode : AudioNode  {}

public partial interface CharacterData : Node, ChildNode, NonDocumentTypeChildNode  {
  public new string data { get; set; }
  public new double length { get; }
  public new object ownerDocument { get; }
  public new object appendData(string data);
  public new object deleteData(double offset, double count);
  public new object insertData(double offset, string data);
  public new object replaceData(double offset, double count, string data);
  public new string substringData(double offset, double count);
}

public partial interface ChildNode : Node  {
  public new object after(object nodes);
  public new object before(object nodes);
  public new object remove();
  public new object replaceWith(object nodes);
}

public partial interface ClientRect : DOMRect  {}

public partial interface Clipboard : EventTarget  {
  public new object read();
  public new object readText();
  public new object write(object data);
  public new object writeText(string data);
}

public partial interface ClipboardEvent : Event  {
  public new object clipboardData { get; }
}

public partial interface ClipboardItem  {
  public new object types { get; }
  public new object getType(string type);
}

public partial interface CloseEvent : Event  {
  public new double code { get; }
  public new string reason { get; }
  public new bool wasClean { get; }
}

public partial interface Comment : CharacterData  {}

public partial interface CompositionEvent : UIEvent  {
  public new string data { get; }
  public new object initCompositionEvent(string typeArg, bool bubblesArg, bool cancelableArg, object viewArg, string dataArg);
}

public partial interface CompressionStream : GenericTransformStream  {}

public partial interface ConstantSourceNode : AudioScheduledSourceNode  {
  public new object offset { get; }
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface ConvolverNode : AudioNode  {
  public new object buffer { get; set; }
  public new bool normalize { get; set; }
}

public partial interface CountQueuingStrategy : QueuingStrategy  {
  public new double highWaterMark { get; }
  public new object size { get; }
}

public partial interface Credential  {
  public new string id { get; }
  public new string type { get; }
}

public partial interface CredentialsContainer  {
  public new object create(object options);
  public new object get(object options);
  public new object preventSilentAccess();
  public new object store(object credential);
}

public partial interface Crypto  {
  public new object subtle { get; }
  public new object getRandomValues(object array);
  public new object randomUUID();
}

public partial interface CryptoKey  {
  public new object algorithm { get; }
  public new bool extractable { get; }
  public new object type { get; }
  public new object usages { get; }
}

public partial interface CustomElementRegistry  {
  public new object define(string name, object constructor, object options);
  public new object get(string name);
  public new object upgrade(object root);
  public new object whenDefined(string name);
}

public partial interface CustomEvent : Event  {
  public new object detail { get; }
  public new object initCustomEvent(string type, bool bubbles, bool cancelable, object detail);
}

public partial interface DOMException : Error  {
  public new double code { get; }
  public new string message { get; }
  public new string name { get; }
  public new object INDEX_SIZE_ERR { get; }
  public new object DOMSTRING_SIZE_ERR { get; }
  public new object HIERARCHY_REQUEST_ERR { get; }
  public new object WRONG_DOCUMENT_ERR { get; }
  public new object INVALID_CHARACTER_ERR { get; }
  public new object NO_DATA_ALLOWED_ERR { get; }
  public new object NO_MODIFICATION_ALLOWED_ERR { get; }
  public new object NOT_FOUND_ERR { get; }
  public new object NOT_SUPPORTED_ERR { get; }
  public new object INUSE_ATTRIBUTE_ERR { get; }
  public new object INVALID_STATE_ERR { get; }
  public new object SYNTAX_ERR { get; }
  public new object INVALID_MODIFICATION_ERR { get; }
  public new object NAMESPACE_ERR { get; }
  public new object INVALID_ACCESS_ERR { get; }
  public new object VALIDATION_ERR { get; }
  public new object TYPE_MISMATCH_ERR { get; }
  public new object SECURITY_ERR { get; }
  public new object NETWORK_ERR { get; }
  public new object ABORT_ERR { get; }
  public new object URL_MISMATCH_ERR { get; }
  public new object QUOTA_EXCEEDED_ERR { get; }
  public new object TIMEOUT_ERR { get; }
  public new object INVALID_NODE_TYPE_ERR { get; }
  public new object DATA_CLONE_ERR { get; }
}

public partial interface DOMImplementation  {
  public new object createDocument(object namespace, object qualifiedName, object doctype);
  public new object createDocumentType(string qualifiedName, string publicId, string systemId);
  public new object createHTMLDocument(string title);
  public new object hasFeature(object args);
}

public partial interface DOMMatrix : DOMMatrixReadOnly  {
  public new double a { get; set; }
  public new double b { get; set; }
  public new double c { get; set; }
  public new double d { get; set; }
  public new double e { get; set; }
  public new double f { get; set; }
  public new double m11 { get; set; }
  public new double m12 { get; set; }
  public new double m13 { get; set; }
  public new double m14 { get; set; }
  public new double m21 { get; set; }
  public new double m22 { get; set; }
  public new double m23 { get; set; }
  public new double m24 { get; set; }
  public new double m31 { get; set; }
  public new double m32 { get; set; }
  public new double m33 { get; set; }
  public new double m34 { get; set; }
  public new double m41 { get; set; }
  public new double m42 { get; set; }
  public new double m43 { get; set; }
  public new double m44 { get; set; }
  public new object invertSelf();
  public new object multiplySelf(object other);
  public new object preMultiplySelf(object other);
  public new object rotateAxisAngleSelf(double x, double y, double z, double angle);
  public new object rotateFromVectorSelf(double x, double y);
  public new object rotateSelf(double rotX, double rotY, double rotZ);
  public new object scale3dSelf(double scale, double originX, double originY, double originZ);
  public new object scaleSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ);
  public new object setMatrixValue(string transformList);
  public new object skewXSelf(double sx);
  public new object skewYSelf(double sy);
  public new object translateSelf(double tx, double ty, double tz);
}

public partial interface DOMMatrixReadOnly  {
  public new double a { get; }
  public new double b { get; }
  public new double c { get; }
  public new double d { get; }
  public new double e { get; }
  public new double f { get; }
  public new bool is2D { get; }
  public new bool isIdentity { get; }
  public new double m11 { get; }
  public new double m12 { get; }
  public new double m13 { get; }
  public new double m14 { get; }
  public new double m21 { get; }
  public new double m22 { get; }
  public new double m23 { get; }
  public new double m24 { get; }
  public new double m31 { get; }
  public new double m32 { get; }
  public new double m33 { get; }
  public new double m34 { get; }
  public new double m41 { get; }
  public new double m42 { get; }
  public new double m43 { get; }
  public new double m44 { get; }
  public new object flipX();
  public new object flipY();
  public new object inverse();
  public new object multiply(object other);
  public new object rotate(double rotX, double rotY, double rotZ);
  public new object rotateAxisAngle(double x, double y, double z, double angle);
  public new object rotateFromVector(double x, double y);
  public new object scale(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ);
  public new object scale3d(double scale, double originX, double originY, double originZ);
  public new object scaleNonUniform(double scaleX, double scaleY);
  public new object skewX(double sx);
  public new object skewY(double sy);
  public new object toFloat32Array();
  public new object toFloat64Array();
  public new object toJSON();
  public new object transformPoint(object point);
  public new object translate(double tx, double ty, double tz);
  public new string toStringMethod();
}

public partial interface DOMParser  {
  public new object parseFromString(string string, object type);
}

public partial interface DOMPoint : DOMPointReadOnly  {
  public new double w { get; set; }
  public new double x { get; set; }
  public new double y { get; set; }
  public new double z { get; set; }
}

public partial interface DOMPointReadOnly  {
  public new double w { get; }
  public new double x { get; }
  public new double y { get; }
  public new double z { get; }
  public new object matrixTransform(object matrix);
  public new object toJSON();
}

public partial interface DOMQuad  {
  public new object p1 { get; }
  public new object p2 { get; }
  public new object p3 { get; }
  public new object p4 { get; }
  public new object getBounds();
  public new object toJSON();
}

public partial interface DOMRect : DOMRectReadOnly  {
  public new double height { get; set; }
  public new double width { get; set; }
  public new double x { get; set; }
  public new double y { get; set; }
}

public partial interface DOMRectList  {
  public new double length { get; }
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface DOMRectReadOnly  {
  public new double bottom { get; }
  public new double height { get; }
  public new double left { get; }
  public new double right { get; }
  public new double top { get; }
  public new double width { get; }
  public new double x { get; }
  public new double y { get; }
  public new object toJSON();
}

public partial interface DOMStringList  {
  public new double length { get; }
  public new bool contains(string string);
  public new object item(double index);
  // TODO: Unsupported member: undefined
}

public partial interface DOMStringMap  {
  // TODO: Unsupported member: undefined
}

public partial interface DOMTokenList  {
  public new double length { get; }
  public new string value { get; set; }
  public new string toStringMethod();
  public new object add(object tokens);
  public new bool contains(string token);
  public new object item(double index);
  public new object remove(object tokens);
  public new bool replace(string token, string newToken);
  public new bool supports(string token);
  public new bool toggle(string token, bool force);
  public new object forEach(object callbackfn, object thisArg);
  // TODO: Unsupported member: undefined
}

public partial interface DataTransfer  {
  public new object dropEffect { get; set; }
  public new object effectAllowed { get; set; }
  public new object files { get; }
  public new object items { get; }
  public new object types { get; }
  public new object clearData(string format);
  public new string getData(string format);
  public new object setData(string format, string data);
  public new object setDragImage(object image, double x, double y);
}

public partial interface DataTransferItem  {
  public new string kind { get; }
  public new string type { get; }
  public new object getAsFile();
  public new object getAsString(object callback);
  public new object webkitGetAsEntry();
}

public partial interface DataTransferItemList  {
  public new double length { get; }
  public new object add(string data, string type);
  public new object add(object data);
  public new object clear();
  public new object remove(double index);
  // TODO: Unsupported member: undefined
}

public partial interface DecompressionStream : GenericTransformStream  {}

public partial interface DelayNode : AudioNode  {
  public new object delayTime { get; }
}

public partial interface DeviceMotionEvent : Event  {
  public new object acceleration { get; }
  public new object accelerationIncludingGravity { get; }
  public new double interval { get; }
  public new object rotationRate { get; }
}

public partial interface DeviceMotionEventAcceleration  {
  public new object x { get; }
  public new object y { get; }
  public new object z { get; }
}

public partial interface DeviceMotionEventRotationRate  {
  public new object alpha { get; }
  public new object beta { get; }
  public new object gamma { get; }
}

public partial interface DeviceOrientationEvent : Event  {
  public new bool absolute { get; }
  public new object alpha { get; }
  public new object beta { get; }
  public new object gamma { get; }
}

public partial interface DocumentEventMap : GlobalEventHandlersEventMap  {
  public new object DOMContentLoaded { get; set; }
  public new object fullscreenchange { get; set; }
  public new object fullscreenerror { get; set; }
  public new object pointerlockchange { get; set; }
  public new object pointerlockerror { get; set; }
  public new object readystatechange { get; set; }
  public new object visibilitychange { get; set; }
}

public partial interface Document : Node, DocumentOrShadowRoot, FontFaceSource, GlobalEventHandlers, NonElementParentNode, ParentNode, XPathEvaluatorBase  {
  public new string URL { get; }
  public new string alinkColor { get; set; }
  public new object all { get; }
  public new object anchors { get; }
  public new object applets { get; }
  public new string bgColor { get; set; }
  public new object body { get; set; }
  public new string characterSet { get; }
  public new string charset { get; }
  public new string compatMode { get; }
  public new string contentType { get; }
  public new string cookie { get; set; }
  public new object currentScript { get; }
  public new object defaultView { get; }
  public new string designMode { get; set; }
  public new string dir { get; set; }
  public new object doctype { get; }
  public new object documentElement { get; }
  public new string documentURI { get; }
  public new string domain { get; set; }
  public new object embeds { get; }
  public new string fgColor { get; set; }
  public new object forms { get; }
  public new bool fullscreen { get; }
  public new bool fullscreenEnabled { get; }
  public new object head { get; }
  public new bool hidden { get; }
  public new object images { get; }
  public new object implementation { get; }
  public new string inputEncoding { get; }
  public new string lastModified { get; }
  public new string linkColor { get; set; }
  public new object links { get; }
  // TODO: Unsupported member: [object Object]
  // TODO: Unsupported member: [object Object]
  public new object onfullscreenchange { get; set; }
  public new object onfullscreenerror { get; set; }
  public new object onpointerlockchange { get; set; }
  public new object onpointerlockerror { get; set; }
  public new object onreadystatechange { get; set; }
  public new object onvisibilitychange { get; set; }
  public new object ownerDocument { get; }
  public new bool pictureInPictureEnabled { get; }
  public new object plugins { get; }
  public new object readyState { get; }
  public new string referrer { get; }
  public new object rootElement { get; }
  public new object scripts { get; }
  public new object scrollingElement { get; }
  public new object timeline { get; }
  public new string title { get; set; }
  public new object visibilityState { get; }
  public new string vlinkColor { get; set; }
  public new object adoptNode(object node);
  public new object captureEvents();
  public new object caretRangeFromPoint(double x, double y);
  public new object clear();
  public new object close();
  public new object createAttribute(string localName);
  public new object createAttributeNS(object namespace, string qualifiedName);
  public new object createCDATASection(string data);
  public new object createComment(string data);
  public new object createDocumentFragment();
  public new object createElement(object tagName, object options);
  public new object createElement(object tagName, object options);
  public new object createElement(string tagName, object options);
  public new object createElementNS(object namespaceURI, string qualifiedName);
  public new object createElementNS(object namespaceURI, object qualifiedName);
  public new object createElementNS(object namespaceURI, string qualifiedName);
  public new object createElementNS(object namespaceURI, object qualifiedName);
  public new object createElementNS(object namespaceURI, string qualifiedName);
  public new object createElementNS(object namespaceURI, string qualifiedName, object options);
  public new object createElementNS(object namespace, string qualifiedName, object options);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(object eventInterface);
  public new object createEvent(string eventInterface);
  public new object createNodeIterator(object root, double whatToShow, object filter);
  public new object createProcessingInstruction(string target, string data);
  public new object createRange();
  public new object createTextNode(string data);
  public new object createTreeWalker(object root, double whatToShow, object filter);
  public new bool execCommand(string commandId, bool showUI, string value);
  public new object exitFullscreen();
  public new object exitPictureInPicture();
  public new object exitPointerLock();
  public new object getElementById(string elementId);
  public new object getElementsByClassName(string classNames);
  public new object getElementsByName(string elementName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(object qualifiedName);
  public new object getElementsByTagName(string qualifiedName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespaceURI, string localName);
  public new object getElementsByTagNameNS(object namespace, string localName);
  public new object getSelection();
  public new bool hasFocus();
  public new object hasStorageAccess();
  public new object importNode(object node, bool deep);
  public new object open(string unused1, string unused2);
  public new object open(object url, string name, string features);
  public new bool queryCommandEnabled(string commandId);
  public new bool queryCommandIndeterm(string commandId);
  public new bool queryCommandState(string commandId);
  public new bool queryCommandSupported(string commandId);
  public new string queryCommandValue(string commandId);
  public new object releaseEvents();
  public new object requestStorageAccess();
  public new object write(object text);
  public new object writeln(object text);
  public new object addEventListener(object type, object listener, object options);
  public new object addEventListener(string type, object listener, object options);
  public new object removeEventListener(object type, object listener, object options);
  public new object removeEventListener(string type, object listener, object options);
}

public partial interface DocumentFragment : Node, NonElementParentNode, ParentNode  {
  public new object ownerDocument { get; }
  public new object getElementById(string elementId);
}

public partial interface DocumentOrShadowRoot  {
  public new object activeElement { get; }
  public new object adoptedStyleSheets { get; set; }
  public new object fullscreenElement { get; }
  public new object pictureInPictureElement { get; }
  public new object pointerLockElement { get; }
  public new object styleSheets { get; }
  public new object elementFromPoint(double x, double y);
  public new object elementsFromPoint(double x, double y);
  public new object getAnimations();
}

public partial interface DocumentTimeline : AnimationTimeline  {}

public partial interface DocumentType : Node, ChildNode  {
  public new string name { get; }
  public new object ownerDocument { get; }
  public new string publicId { get; }
  public new string systemId { get; }
}

public partial interface DragEvent : MouseEvent  {
  public new object dataTransfer { get; }
}

public partial interface DynamicsCompressorNode : AudioNode  {
  public new object attack { get; }
  public new object knee { get; }
  public new object ratio { get; }
  public new double reduction { get; }
  public new object release { get; }
  public new object threshold { get; }
}

public partial interface EXT_blend_minmax  {
  public new object MIN_EXT { get; }
  public new object MAX_EXT { get; }
}