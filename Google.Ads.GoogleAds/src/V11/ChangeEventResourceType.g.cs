// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/change_event_resource_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/change_event_resource_type.proto</summary>
  public static partial class ChangeEventResourceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/change_event_resource_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeEventResourceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvY2hhbmdlX2V2ZW50",
            "X3Jlc291cmNlX3R5cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MS5lbnVtcyKuAwobQ2hhbmdlRXZlbnRSZXNvdXJjZVR5cGVFbnVtIo4DChdD",
            "aGFuZ2VFdmVudFJlc291cmNlVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARIGCgJBRBACEgwKCEFEX0dST1VQEAMSFgoSQURfR1JPVVBfQ1JJ",
            "VEVSSU9OEAQSDAoIQ0FNUEFJR04QBRITCg9DQU1QQUlHTl9CVURHRVQQBhIZ",
            "ChVBRF9HUk9VUF9CSURfTU9ESUZJRVIQBxIWChJDQU1QQUlHTl9DUklURVJJ",
            "T04QCBIICgRGRUVEEAkSDQoJRkVFRF9JVEVNEAoSEQoNQ0FNUEFJR05fRkVF",
            "RBALEhEKDUFEX0dST1VQX0ZFRUQQDBIPCgtBRF9HUk9VUF9BRBANEgkKBUFT",
            "U0VUEA4SEgoOQ1VTVE9NRVJfQVNTRVQQDxISCg5DQU1QQUlHTl9BU1NFVBAQ",
            "EhIKDkFEX0dST1VQX0FTU0VUEBESDQoJQVNTRVRfU0VUEBISEwoPQVNTRVRf",
            "U0VUX0FTU0VUEBMSFgoSQ0FNUEFJR05fQVNTRVRfU0VUEBRC9gEKImNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXNCHENoYW5nZUV2ZW50UmVz",
            "b3VyY2VUeXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMS9lbnVtcztlbnVtc6ICA0dB",
            "QaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5FbnVtc8oCHkdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYxMVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.ChangeEventResourceTypeEnum), global::Google.Ads.GoogleAds.V11.Enums.ChangeEventResourceTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.ChangeEventResourceTypeEnum.Types.ChangeEventResourceType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing supported resource types for the ChangeEvent
  /// resource.
  /// </summary>
  public sealed partial class ChangeEventResourceTypeEnum : pb::IMessage<ChangeEventResourceTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeEventResourceTypeEnum> _parser = new pb::MessageParser<ChangeEventResourceTypeEnum>(() => new ChangeEventResourceTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeEventResourceTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.ChangeEventResourceTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeEventResourceTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeEventResourceTypeEnum(ChangeEventResourceTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeEventResourceTypeEnum Clone() {
      return new ChangeEventResourceTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeEventResourceTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeEventResourceTypeEnum other) {
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
    public void MergeFrom(ChangeEventResourceTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ChangeEventResourceTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum listing the resource types support by the ChangeEvent resource.
      /// </summary>
      public enum ChangeEventResourceType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified resource unknown
        /// in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An Ad resource change.
        /// </summary>
        [pbr::OriginalName("AD")] Ad = 2,
        /// <summary>
        /// An AdGroup resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP")] AdGroup = 3,
        /// <summary>
        /// An AdGroupCriterion resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION")] AdGroupCriterion = 4,
        /// <summary>
        /// A Campaign resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN")] Campaign = 5,
        /// <summary>
        /// A CampaignBudget resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET")] CampaignBudget = 6,
        /// <summary>
        /// An AdGroupBidModifier resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_BID_MODIFIER")] AdGroupBidModifier = 7,
        /// <summary>
        /// A CampaignCriterion resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CRITERION")] CampaignCriterion = 8,
        /// <summary>
        /// A Feed resource change.
        /// </summary>
        [pbr::OriginalName("FEED")] Feed = 9,
        /// <summary>
        /// A FeedItem resource change.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM")] FeedItem = 10,
        /// <summary>
        /// A CampaignFeed resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEED")] CampaignFeed = 11,
        /// <summary>
        /// An AdGroupFeed resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEED")] AdGroupFeed = 12,
        /// <summary>
        /// An AdGroupAd resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD")] AdGroupAd = 13,
        /// <summary>
        /// An Asset resource change.
        /// </summary>
        [pbr::OriginalName("ASSET")] Asset = 14,
        /// <summary>
        /// A CustomerAsset resource change.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ASSET")] CustomerAsset = 15,
        /// <summary>
        /// A CampaignAsset resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_ASSET")] CampaignAsset = 16,
        /// <summary>
        /// An AdGroupAsset resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_ASSET")] AdGroupAsset = 17,
        /// <summary>
        /// An AssetSet resource change.
        /// </summary>
        [pbr::OriginalName("ASSET_SET")] AssetSet = 18,
        /// <summary>
        /// An AssetSetAsset resource change.
        /// </summary>
        [pbr::OriginalName("ASSET_SET_ASSET")] AssetSetAsset = 19,
        /// <summary>
        /// A CampaignAssetSet resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_ASSET_SET")] CampaignAssetSet = 20,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
