// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/offline_event_upload_client_enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/offline_event_upload_client_enum.proto</summary>
  public static partial class OfflineEventUploadClientEnumReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/offline_event_upload_client_enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineEventUploadClientEnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvb2ZmbGluZV9ldmVu",
            "dF91cGxvYWRfY2xpZW50X2VudW0ucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNC5lbnVtcyKfAQocT2ZmbGluZUV2ZW50VXBsb2FkQ2xpZW50RW51",
            "bSJ/ChhPZmZsaW5lRXZlbnRVcGxvYWRDbGllbnQSDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESEgoOR09PR0xFX0FEU19BUEkQAhIZChVHT09HTEVf",
            "QURTX1dFQl9DTElFTlQQAxIWChJBRFNfREFUQV9DT05ORUNUT1IQBEL7AQoi",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNC5lbnVtc0IhT2ZmbGluZUV2",
            "ZW50VXBsb2FkQ2xpZW50RW51bVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTQvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTQuRW51bXPK",
            "Ah5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTRcRW51bXPqAiJHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTQ6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.OfflineEventUploadClientEnum), global::Google.Ads.GoogleAds.V14.Enums.OfflineEventUploadClientEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// All possible clients for an offline upload event.
  /// </summary>
  public sealed partial class OfflineEventUploadClientEnum : pb::IMessage<OfflineEventUploadClientEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineEventUploadClientEnum> _parser = new pb::MessageParser<OfflineEventUploadClientEnum>(() => new OfflineEventUploadClientEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineEventUploadClientEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.OfflineEventUploadClientEnumReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineEventUploadClientEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineEventUploadClientEnum(OfflineEventUploadClientEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineEventUploadClientEnum Clone() {
      return new OfflineEventUploadClientEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineEventUploadClientEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineEventUploadClientEnum other) {
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
    public void MergeFrom(OfflineEventUploadClientEnum other) {
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
    /// <summary>Container for nested types declared in the OfflineEventUploadClientEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Type of client.
      /// </summary>
      public enum OfflineEventUploadClient {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google Ads API.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_API")] GoogleAdsApi = 2,
        /// <summary>
        /// Google Ads web client, which could include multiple sources like Ads UI,
        /// SFTP, etc.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_WEB_CLIENT")] GoogleAdsWebClient = 3,
        /// <summary>
        /// Connection platform.
        /// </summary>
        [pbr::OriginalName("ADS_DATA_CONNECTOR")] AdsDataConnector = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
