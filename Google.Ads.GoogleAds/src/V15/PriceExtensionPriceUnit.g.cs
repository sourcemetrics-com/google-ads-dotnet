// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/enums/price_extension_price_unit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/enums/price_extension_price_unit.proto</summary>
  public static partial class PriceExtensionPriceUnitReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/enums/price_extension_price_unit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceExtensionPriceUnitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvcHJpY2VfZXh0ZW5z",
            "aW9uX3ByaWNlX3VuaXQucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "NS5lbnVtcyKsAQobUHJpY2VFeHRlbnNpb25QcmljZVVuaXRFbnVtIowBChdQ",
            "cmljZUV4dGVuc2lvblByaWNlVW5pdBIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARIMCghQRVJfSE9VUhACEgsKB1BFUl9EQVkQAxIMCghQRVJfV0VF",
            "SxAEEg0KCVBFUl9NT05USBAFEgwKCFBFUl9ZRUFSEAYSDQoJUEVSX05JR0hU",
            "EAdC9gEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuZW51bXNCHFBy",
            "aWNlRXh0ZW5zaW9uUHJpY2VVbml0UHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNS9lbnVt",
            "cztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNS5FbnVt",
            "c8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNVxFbnVtc+oCIkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYxNTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Enums.PriceExtensionPriceUnitEnum), global::Google.Ads.GoogleAds.V15.Enums.PriceExtensionPriceUnitEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Enums.PriceExtensionPriceUnitEnum.Types.PriceExtensionPriceUnit) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing price extension price unit.
  /// </summary>
  public sealed partial class PriceExtensionPriceUnitEnum : pb::IMessage<PriceExtensionPriceUnitEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PriceExtensionPriceUnitEnum> _parser = new pb::MessageParser<PriceExtensionPriceUnitEnum>(() => new PriceExtensionPriceUnitEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PriceExtensionPriceUnitEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Enums.PriceExtensionPriceUnitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionPriceUnitEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionPriceUnitEnum(PriceExtensionPriceUnitEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionPriceUnitEnum Clone() {
      return new PriceExtensionPriceUnitEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PriceExtensionPriceUnitEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PriceExtensionPriceUnitEnum other) {
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
    public void MergeFrom(PriceExtensionPriceUnitEnum other) {
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
    /// <summary>Container for nested types declared in the PriceExtensionPriceUnitEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Price extension price unit.
      /// </summary>
      public enum PriceExtensionPriceUnit {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Per hour.
        /// </summary>
        [pbr::OriginalName("PER_HOUR")] PerHour = 2,
        /// <summary>
        /// Per day.
        /// </summary>
        [pbr::OriginalName("PER_DAY")] PerDay = 3,
        /// <summary>
        /// Per week.
        /// </summary>
        [pbr::OriginalName("PER_WEEK")] PerWeek = 4,
        /// <summary>
        /// Per month.
        /// </summary>
        [pbr::OriginalName("PER_MONTH")] PerMonth = 5,
        /// <summary>
        /// Per year.
        /// </summary>
        [pbr::OriginalName("PER_YEAR")] PerYear = 6,
        /// <summary>
        /// Per night.
        /// </summary>
        [pbr::OriginalName("PER_NIGHT")] PerNight = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
