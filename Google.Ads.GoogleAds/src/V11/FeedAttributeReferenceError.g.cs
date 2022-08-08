// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/feed_attribute_reference_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/feed_attribute_reference_error.proto</summary>
  public static partial class FeedAttributeReferenceErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/feed_attribute_reference_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedAttributeReferenceErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2ZlZWRfYXR0cmli",
            "dXRlX3JlZmVyZW5jZV9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjExLmVycm9ycyK6AQofRmVlZEF0dHJpYnV0ZVJlZmVyZW5jZUVycm9y",
            "RW51bSKWAQobRmVlZEF0dHJpYnV0ZVJlZmVyZW5jZUVycm9yEg8KC1VOU1BF",
            "Q0lGSUVEEAASCwoHVU5LTk9XThABEiEKHUNBTk5PVF9SRUZFUkVOQ0VfUkVN",
            "T1ZFRF9GRUVEEAISFQoRSU5WQUxJRF9GRUVEX05BTUUQAxIfChtJTlZBTElE",
            "X0ZFRURfQVRUUklCVVRFX05BTUUQBEKAAgojY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMS5lcnJvcnNCIEZlZWRBdHRyaWJ1dGVSZWZlcmVuY2VFcnJv",
            "clByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5FcnJvcnPKAh9Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMTFcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjExOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.FeedAttributeReferenceErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.FeedAttributeReferenceErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.FeedAttributeReferenceErrorEnum.Types.FeedAttributeReferenceError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed attribute reference errors.
  /// </summary>
  public sealed partial class FeedAttributeReferenceErrorEnum : pb::IMessage<FeedAttributeReferenceErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedAttributeReferenceErrorEnum> _parser = new pb::MessageParser<FeedAttributeReferenceErrorEnum>(() => new FeedAttributeReferenceErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedAttributeReferenceErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.FeedAttributeReferenceErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeReferenceErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeReferenceErrorEnum(FeedAttributeReferenceErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeReferenceErrorEnum Clone() {
      return new FeedAttributeReferenceErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedAttributeReferenceErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedAttributeReferenceErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedAttributeReferenceErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    /// <summary>Container for nested types declared in the FeedAttributeReferenceErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed attribute reference errors.
      /// </summary>
      public enum FeedAttributeReferenceError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A feed referenced by ID has been removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REFERENCE_REMOVED_FEED")] CannotReferenceRemovedFeed = 2,
        /// <summary>
        /// There is no enabled feed with the given name.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_NAME")] InvalidFeedName = 3,
        /// <summary>
        /// There is no feed attribute in an enabled feed with the given name.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_ATTRIBUTE_NAME")] InvalidFeedAttributeName = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code