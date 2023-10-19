// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/resources/asset_set_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/resources/asset_set_asset.proto</summary>
  public static partial class AssetSetAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/resources/asset_set_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetSetAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvcmVzb3VyY2VzL2Fzc2V0X3Nl",
            "dF9hc3NldC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LnJlc291",
            "cmNlcxo7Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE1L2VudW1zL2Fzc2V0X3Nl",
            "dF9hc3NldF9zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8inAMKDUFzc2V0",
            "U2V0QXNzZXQSRQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIu4EEF+kEoCiZnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRTZXRBc3NldBI8Cglhc3NldF9z",
            "ZXQYAiABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Fz",
            "c2V0U2V0EjUKBWFzc2V0GAMgASgJQibgQQX6QSAKHmdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9Bc3NldBJgCgZzdGF0dXMYBCABKA4ySy5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTUuZW51bXMuQXNzZXRTZXRBc3NldFN0YXR1c0VudW0u",
            "QXNzZXRTZXRBc3NldFN0YXR1c0ID4EEDOm3qQWoKJmdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9Bc3NldFNldEFzc2V0EkBjdXN0b21lcnMve2N1c3RvbWVy",
            "X2lkfS9hc3NldFNldEFzc2V0cy97YXNzZXRfc2V0X2lkfX57YXNzZXRfaWR9",
            "QoQCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LnJlc291cmNlc0IS",
            "QXNzZXRTZXRBc3NldFByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTUvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNS5SZXNv",
            "dXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTVcUmVzb3VyY2Vz6gIm",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE1OjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Resources.AssetSetAsset), global::Google.Ads.GoogleAds.V15.Resources.AssetSetAsset.Parser, new[]{ "ResourceName", "AssetSet", "Asset", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// AssetSetAsset is the link between an asset and an asset set.
  /// Adding an AssetSetAsset links an asset with an asset set.
  /// </summary>
  public sealed partial class AssetSetAsset : pb::IMessage<AssetSetAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetSetAsset> _parser = new pb::MessageParser<AssetSetAsset>(() => new AssetSetAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetSetAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Resources.AssetSetAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAsset(AssetSetAsset other) : this() {
      resourceName_ = other.resourceName_;
      assetSet_ = other.assetSet_;
      asset_ = other.asset_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAsset Clone() {
      return new AssetSetAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the asset set asset.
    /// Asset set asset resource names have the form:
    ///
    /// `customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_set" field.</summary>
    public const int AssetSetFieldNumber = 2;
    private string assetSet_ = "";
    /// <summary>
    /// Immutable. The asset set which this asset set asset is linking to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetSet {
      get { return assetSet_; }
      set {
        assetSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 3;
    private string asset_ = "";
    /// <summary>
    /// Immutable. The asset which this asset set asset is linking to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus status_ = global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the asset set asset. Read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetSetAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetSetAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AssetSet != other.AssetSet) return false;
      if (Asset != other.Asset) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AssetSet.Length != 0) hash ^= AssetSet.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetSet);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetSet);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (AssetSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetSet);
      }
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetSetAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AssetSet.Length != 0) {
        AssetSet = other.AssetSet;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AssetSet = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus) input.ReadEnum();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AssetSet = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.AssetSetAssetStatusEnum.Types.AssetSetAssetStatus) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
