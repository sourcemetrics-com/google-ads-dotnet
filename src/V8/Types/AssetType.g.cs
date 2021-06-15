// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/asset_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/asset_type.proto</summary>
  public static partial class AssetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/asset_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9hc3NldF90eXBlLnBy",
            "b3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtcxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byLaAQoNQXNzZXRUeXBlRW51bSLIAQoJQXNz",
            "ZXRUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhEKDVlPVVRV",
            "QkVfVklERU8QAhIQCgxNRURJQV9CVU5ETEUQAxIJCgVJTUFHRRAEEggKBFRF",
            "WFQQBRINCglMRUFEX0ZPUk0QBhISCg5CT09LX09OX0dPT0dMRRAHEg0KCVBS",
            "T01PVElPThAIEgsKB0NBTExPVVQQCRIWChJTVFJVQ1RVUkVEX1NOSVBQRVQQ",
            "ChIMCghTSVRFTElOSxALQuMBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djguZW51bXNCDkFzc2V0VHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OC9lbnVtcztl",
            "bnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY4LkVudW1zygId",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjhcRW51bXPqAiFHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWODo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.AssetTypeEnum), global::Google.Ads.GoogleAds.V8.Enums.AssetTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.AssetTypeEnum.Types.AssetType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the types of asset.
  /// </summary>
  public sealed partial class AssetTypeEnum : pb::IMessage<AssetTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetTypeEnum> _parser = new pb::MessageParser<AssetTypeEnum>(() => new AssetTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssetTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.AssetTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetTypeEnum(AssetTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetTypeEnum Clone() {
      return new AssetTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssetTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssetTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssetTypeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AssetTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible types of asset.
      /// </summary>
      public enum AssetType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// YouTube video asset.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 2,
        /// <summary>
        /// Media bundle asset.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE")] MediaBundle = 3,
        /// <summary>
        /// Image asset.
        /// </summary>
        [pbr::OriginalName("IMAGE")] Image = 4,
        /// <summary>
        /// Text asset.
        /// </summary>
        [pbr::OriginalName("TEXT")] Text = 5,
        /// <summary>
        /// Lead form asset.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM")] LeadForm = 6,
        /// <summary>
        /// Book on Google asset.
        /// </summary>
        [pbr::OriginalName("BOOK_ON_GOOGLE")] BookOnGoogle = 7,
        /// <summary>
        /// Promotion asset.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 8,
        /// <summary>
        /// Callout asset.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 9,
        /// <summary>
        /// Structured Snippet asset.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 10,
        /// <summary>
        /// Sitelink asset.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code