// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/resources/detail_placement_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/resources/detail_placement_view.proto</summary>
  public static partial class DetailPlacementViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/resources/detail_placement_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DetailPlacementViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvcmVzb3VyY2VzL2RldGFpbF9w",
            "bGFjZW1lbnRfdmlldy5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEz",
            "LnJlc291cmNlcxozZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEzL2VudW1zL3Bs",
            "YWNlbWVudF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9y",
            "LnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIpkEChNEZXRhaWxQ",
            "bGFjZW1lbnRWaWV3EksKDXJlc291cmNlX25hbWUYASABKAlCNOBBA/pBLgos",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0RldGFpbFBsYWNlbWVudFZpZXcS",
            "GwoJcGxhY2VtZW50GAcgASgJQgPgQQNIAIgBARIeCgxkaXNwbGF5X25hbWUY",
            "CCABKAlCA+BBA0gBiAEBEiwKGmdyb3VwX3BsYWNlbWVudF90YXJnZXRfdXJs",
            "GAkgASgJQgPgQQNIAogBARIcCgp0YXJnZXRfdXJsGAogASgJQgPgQQNIA4gB",
            "ARJcCg5wbGFjZW1lbnRfdHlwZRgGIAEoDjI/Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMy5lbnVtcy5QbGFjZW1lbnRUeXBlRW51bS5QbGFjZW1lbnRUeXBl",
            "QgPgQQM6gAHqQX0KLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9EZXRhaWxQ",
            "bGFjZW1lbnRWaWV3Ek1jdXN0b21lcnMve2N1c3RvbWVyX2lkfS9kZXRhaWxQ",
            "bGFjZW1lbnRWaWV3cy97YWRfZ3JvdXBfaWR9fntiYXNlNjRfcGxhY2VtZW50",
            "fUIMCgpfcGxhY2VtZW50Qg8KDV9kaXNwbGF5X25hbWVCHQobX2dyb3VwX3Bs",
            "YWNlbWVudF90YXJnZXRfdXJsQg0KC190YXJnZXRfdXJsQooCCiZjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjEzLnJlc291cmNlc0IYRGV0YWlsUGxhY2Vt",
            "ZW50Vmlld1Byb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMvcmVzb3VyY2VzO3Jlc291cmNl",
            "c6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMy5SZXNvdXJjZXPK",
            "AiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTNcUmVzb3VyY2Vz6gImR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjEzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Resources.DetailPlacementView), global::Google.Ads.GoogleAds.V13.Resources.DetailPlacementView.Parser, new[]{ "ResourceName", "Placement", "DisplayName", "GroupPlacementTargetUrl", "TargetUrl", "PlacementType" }, new[]{ "Placement", "DisplayName", "GroupPlacementTargetUrl", "TargetUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A view with metrics aggregated by ad group and URL or YouTube video.
  /// </summary>
  public sealed partial class DetailPlacementView : pb::IMessage<DetailPlacementView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DetailPlacementView> _parser = new pb::MessageParser<DetailPlacementView>(() => new DetailPlacementView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DetailPlacementView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Resources.DetailPlacementViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailPlacementView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailPlacementView(DetailPlacementView other) : this() {
      resourceName_ = other.resourceName_;
      placement_ = other.placement_;
      displayName_ = other.displayName_;
      groupPlacementTargetUrl_ = other.groupPlacementTargetUrl_;
      targetUrl_ = other.targetUrl_;
      placementType_ = other.placementType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailPlacementView Clone() {
      return new DetailPlacementView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the detail placement view.
    /// Detail placement view resource names have the form:
    ///
    /// `customers/{customer_id}/detailPlacementViews/{ad_group_id}~{base64_placement}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 7;
    private string placement_;
    /// <summary>
    /// Output only. The automatic placement string at detail level, e. g. website
    /// URL, mobile application ID, or a YouTube video ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Placement {
      get { return placement_ ?? ""; }
      set {
        placement_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "placement" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPlacement {
      get { return placement_ != null; }
    }
    /// <summary>Clears the value of the "placement" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPlacement() {
      placement_ = null;
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 8;
    private string displayName_;
    /// <summary>
    /// Output only. The display name is URL name for websites, YouTube video name
    /// for YouTube videos, and translated mobile app name for mobile apps.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_ ?? ""; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "display_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDisplayName {
      get { return displayName_ != null; }
    }
    /// <summary>Clears the value of the "display_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDisplayName() {
      displayName_ = null;
    }

    /// <summary>Field number for the "group_placement_target_url" field.</summary>
    public const int GroupPlacementTargetUrlFieldNumber = 9;
    private string groupPlacementTargetUrl_;
    /// <summary>
    /// Output only. URL of the group placement, for example, domain, link to the
    /// mobile application in app store, or a YouTube channel URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupPlacementTargetUrl {
      get { return groupPlacementTargetUrl_ ?? ""; }
      set {
        groupPlacementTargetUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "group_placement_target_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasGroupPlacementTargetUrl {
      get { return groupPlacementTargetUrl_ != null; }
    }
    /// <summary>Clears the value of the "group_placement_target_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearGroupPlacementTargetUrl() {
      groupPlacementTargetUrl_ = null;
    }

    /// <summary>Field number for the "target_url" field.</summary>
    public const int TargetUrlFieldNumber = 10;
    private string targetUrl_;
    /// <summary>
    /// Output only. URL of the placement, for example, website, link to the mobile
    /// application in app store, or a YouTube video URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetUrl {
      get { return targetUrl_ ?? ""; }
      set {
        targetUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "target_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetUrl {
      get { return targetUrl_ != null; }
    }
    /// <summary>Clears the value of the "target_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetUrl() {
      targetUrl_ = null;
    }

    /// <summary>Field number for the "placement_type" field.</summary>
    public const int PlacementTypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType placementType_ = global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified;
    /// <summary>
    /// Output only. Type of the placement, for example, Website, YouTube Video,
    /// and Mobile Application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType PlacementType {
      get { return placementType_; }
      set {
        placementType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DetailPlacementView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DetailPlacementView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Placement != other.Placement) return false;
      if (DisplayName != other.DisplayName) return false;
      if (GroupPlacementTargetUrl != other.GroupPlacementTargetUrl) return false;
      if (TargetUrl != other.TargetUrl) return false;
      if (PlacementType != other.PlacementType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasPlacement) hash ^= Placement.GetHashCode();
      if (HasDisplayName) hash ^= DisplayName.GetHashCode();
      if (HasGroupPlacementTargetUrl) hash ^= GroupPlacementTargetUrl.GetHashCode();
      if (HasTargetUrl) hash ^= TargetUrl.GetHashCode();
      if (PlacementType != global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) hash ^= PlacementType.GetHashCode();
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
      if (PlacementType != global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PlacementType);
      }
      if (HasPlacement) {
        output.WriteRawTag(58);
        output.WriteString(Placement);
      }
      if (HasDisplayName) {
        output.WriteRawTag(66);
        output.WriteString(DisplayName);
      }
      if (HasGroupPlacementTargetUrl) {
        output.WriteRawTag(74);
        output.WriteString(GroupPlacementTargetUrl);
      }
      if (HasTargetUrl) {
        output.WriteRawTag(82);
        output.WriteString(TargetUrl);
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
      if (PlacementType != global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PlacementType);
      }
      if (HasPlacement) {
        output.WriteRawTag(58);
        output.WriteString(Placement);
      }
      if (HasDisplayName) {
        output.WriteRawTag(66);
        output.WriteString(DisplayName);
      }
      if (HasGroupPlacementTargetUrl) {
        output.WriteRawTag(74);
        output.WriteString(GroupPlacementTargetUrl);
      }
      if (HasTargetUrl) {
        output.WriteRawTag(82);
        output.WriteString(TargetUrl);
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
      if (HasPlacement) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Placement);
      }
      if (HasDisplayName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (HasGroupPlacementTargetUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupPlacementTargetUrl);
      }
      if (HasTargetUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlacementType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DetailPlacementView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasPlacement) {
        Placement = other.Placement;
      }
      if (other.HasDisplayName) {
        DisplayName = other.DisplayName;
      }
      if (other.HasGroupPlacementTargetUrl) {
        GroupPlacementTargetUrl = other.GroupPlacementTargetUrl;
      }
      if (other.HasTargetUrl) {
        TargetUrl = other.TargetUrl;
      }
      if (other.PlacementType != global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        PlacementType = other.PlacementType;
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
          case 48: {
            PlacementType = (global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
          case 58: {
            Placement = input.ReadString();
            break;
          }
          case 66: {
            DisplayName = input.ReadString();
            break;
          }
          case 74: {
            GroupPlacementTargetUrl = input.ReadString();
            break;
          }
          case 82: {
            TargetUrl = input.ReadString();
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
          case 48: {
            PlacementType = (global::Google.Ads.GoogleAds.V13.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
          case 58: {
            Placement = input.ReadString();
            break;
          }
          case 66: {
            DisplayName = input.ReadString();
            break;
          }
          case 74: {
            GroupPlacementTargetUrl = input.ReadString();
            break;
          }
          case 82: {
            TargetUrl = input.ReadString();
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