// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/resources/ad_group_ad.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/resources/ad_group_ad.proto</summary>
  public static partial class AdGroupAdReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/resources/ad_group_ad.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2FkLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTUucmVzb3VyY2Vz",
            "Gixnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvY29tbW9uL3BvbGljeS5wcm90",
            "bxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE1L2VudW1zL2FkX2dyb3VwX2Fk",
            "X3N0YXR1cy5wcm90bxowZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE1L2VudW1z",
            "L2FkX3N0cmVuZ3RoLnByb3RvGjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUv",
            "ZW51bXMvcG9saWN5X2FwcHJvdmFsX3N0YXR1cy5wcm90bxo5Z29vZ2xlL2Fk",
            "cy9nb29nbGVhZHMvdjE1L2VudW1zL3BvbGljeV9yZXZpZXdfc3RhdHVzLnBy",
            "b3RvGitnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvcmVzb3VyY2VzL2FkLnBy",
            "b3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvIpcFCglBZEdyb3VwQWQSQQoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCUIq4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRHcm91cEFkElMKBnN0YXR1cxgDIAEoDjJDLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNS5lbnVtcy5BZEdyb3VwQWRTdGF0dXNFbnVtLkFkR3JvdXBBZFN0",
            "YXR1cxI/CghhZF9ncm91cBgJIAEoCUIo4EEF+kEiCiBnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQWRHcm91cEgAiAEBEjcKAmFkGAUgASgLMiYuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE1LnJlc291cmNlcy5BZEID4EEFElcKDnBvbGlj",
            "eV9zdW1tYXJ5GAYgASgLMjouZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LnJl",
            "c291cmNlcy5BZEdyb3VwQWRQb2xpY3lTdW1tYXJ5QgPgQQMSUwoLYWRfc3Ry",
            "ZW5ndGgYByABKA4yOS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuZW51bXMu",
            "QWRTdHJlbmd0aEVudW0uQWRTdHJlbmd0aEID4EEDEhkKDGFjdGlvbl9pdGVt",
            "cxgNIAMoCUID4EEDEj8KBmxhYmVscxgKIAMoCUIv4EED+kEpCidnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFkTGFiZWw6YepBXgoiZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBBZBI4Y3VzdG9tZXJzL3tjdXN0",
            "b21lcl9pZH0vYWRHcm91cEFkcy97YWRfZ3JvdXBfaWR9fnthZF9pZH1CCwoJ",
            "X2FkX2dyb3VwIsICChZBZEdyb3VwQWRQb2xpY3lTdW1tYXJ5ElQKFHBvbGlj",
            "eV90b3BpY19lbnRyaWVzGAEgAygLMjEuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djE1LmNvbW1vbi5Qb2xpY3lUb3BpY0VudHJ5QgPgQQMSZQoNcmV2aWV3X3N0",
            "YXR1cxgCIAEoDjJJLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5lbnVtcy5Q",
            "b2xpY3lSZXZpZXdTdGF0dXNFbnVtLlBvbGljeVJldmlld1N0YXR1c0ID4EED",
            "EmsKD2FwcHJvdmFsX3N0YXR1cxgDIAEoDjJNLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNS5lbnVtcy5Qb2xpY3lBcHByb3ZhbFN0YXR1c0VudW0uUG9saWN5",
            "QXBwcm92YWxTdGF0dXNCA+BBA0KAAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNS5yZXNvdXJjZXNCDkFkR3JvdXBBZFByb3RvUAFaS2dvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTUvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxNS5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MTVcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE1OjpS",
            "ZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V15.Common.PolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.AdStrengthReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Resources.AdReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Resources.AdGroupAd), global::Google.Ads.GoogleAds.V15.Resources.AdGroupAd.Parser, new[]{ "ResourceName", "Status", "AdGroup", "Ad", "PolicySummary", "AdStrength", "ActionItems", "Labels" }, new[]{ "AdGroup" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary), global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary.Parser, new[]{ "PolicyTopicEntries", "ReviewStatus", "ApprovalStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad group ad.
  /// </summary>
  public sealed partial class AdGroupAd : pb::IMessage<AdGroupAd>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAd> _parser = new pb::MessageParser<AdGroupAd>(() => new AdGroupAd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAd(AdGroupAd other) : this() {
      resourceName_ = other.resourceName_;
      status_ = other.status_;
      adGroup_ = other.adGroup_;
      ad_ = other.ad_ != null ? other.ad_.Clone() : null;
      policySummary_ = other.policySummary_ != null ? other.policySummary_.Clone() : null;
      adStrength_ = other.adStrength_;
      actionItems_ = other.actionItems_.Clone();
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAd Clone() {
      return new AdGroupAd(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad.
    /// Ad group ad resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus status_ = global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified;
    /// <summary>
    /// The status of the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 9;
    private readonly static string AdGroupDefaultValue = "";

    private string adGroup_;
    /// <summary>
    /// Immutable. The ad group to which the ad belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_ ?? AdGroupDefaultValue; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroup {
      get { return adGroup_ != null; }
    }
    /// <summary>Clears the value of the "ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroup() {
      adGroup_ = null;
    }

    /// <summary>Field number for the "ad" field.</summary>
    public const int AdFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V15.Resources.Ad ad_;
    /// <summary>
    /// Immutable. The ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Resources.Ad Ad {
      get { return ad_; }
      set {
        ad_ = value;
      }
    }

    /// <summary>Field number for the "policy_summary" field.</summary>
    public const int PolicySummaryFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary policySummary_;
    /// <summary>
    /// Output only. Policy information for the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary PolicySummary {
      get { return policySummary_; }
      set {
        policySummary_ = value;
      }
    }

    /// <summary>Field number for the "ad_strength" field.</summary>
    public const int AdStrengthFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength adStrength_ = global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified;
    /// <summary>
    /// Output only. Overall ad strength for this ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength AdStrength {
      get { return adStrength_; }
      set {
        adStrength_ = value;
      }
    }

    /// <summary>Field number for the "action_items" field.</summary>
    public const int ActionItemsFieldNumber = 13;
    private static readonly pb::FieldCodec<string> _repeated_actionItems_codec
        = pb::FieldCodec.ForString(106);
    private readonly pbc::RepeatedField<string> actionItems_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. A list of recommendations to improve the ad strength. For
    /// example, a recommendation could be "Try adding a few more unique headlines
    /// or unpinning some assets.".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ActionItems {
      get { return actionItems_; }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_labels_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> labels_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The resource names of labels attached to this ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Status != other.Status) return false;
      if (AdGroup != other.AdGroup) return false;
      if (!object.Equals(Ad, other.Ad)) return false;
      if (!object.Equals(PolicySummary, other.PolicySummary)) return false;
      if (AdStrength != other.AdStrength) return false;
      if(!actionItems_.Equals(other.actionItems_)) return false;
      if(!labels_.Equals(other.labels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasAdGroup) hash ^= AdGroup.GetHashCode();
      if (ad_ != null) hash ^= Ad.GetHashCode();
      if (policySummary_ != null) hash ^= PolicySummary.GetHashCode();
      if (AdStrength != global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) hash ^= AdStrength.GetHashCode();
      hash ^= actionItems_.GetHashCode();
      hash ^= labels_.GetHashCode();
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
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (ad_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Ad);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) AdStrength);
      }
      if (HasAdGroup) {
        output.WriteRawTag(74);
        output.WriteString(AdGroup);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      actionItems_.WriteTo(output, _repeated_actionItems_codec);
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
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (ad_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Ad);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) AdStrength);
      }
      if (HasAdGroup) {
        output.WriteRawTag(74);
        output.WriteString(AdGroup);
      }
      labels_.WriteTo(ref output, _repeated_labels_codec);
      actionItems_.WriteTo(ref output, _repeated_actionItems_codec);
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
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasAdGroup) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (ad_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ad);
      }
      if (policySummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AdStrength);
      }
      size += actionItems_.CalculateSize(_repeated_actionItems_codec);
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAd other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasAdGroup) {
        AdGroup = other.AdGroup;
      }
      if (other.ad_ != null) {
        if (ad_ == null) {
          Ad = new global::Google.Ads.GoogleAds.V15.Resources.Ad();
        }
        Ad.MergeFrom(other.Ad);
      }
      if (other.policySummary_ != null) {
        if (policySummary_ == null) {
          PolicySummary = new global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary();
        }
        PolicySummary.MergeFrom(other.PolicySummary);
      }
      if (other.AdStrength != global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        AdStrength = other.AdStrength;
      }
      actionItems_.Add(other.actionItems_);
      labels_.Add(other.labels_);
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
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (ad_ == null) {
              Ad = new global::Google.Ads.GoogleAds.V15.Resources.Ad();
            }
            input.ReadMessage(Ad);
            break;
          }
          case 50: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 56: {
            AdStrength = (global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 74: {
            AdGroup = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
          case 106: {
            actionItems_.AddEntriesFrom(input, _repeated_actionItems_codec);
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
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (ad_ == null) {
              Ad = new global::Google.Ads.GoogleAds.V15.Resources.Ad();
            }
            input.ReadMessage(Ad);
            break;
          }
          case 50: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdPolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 56: {
            AdStrength = (global::Google.Ads.GoogleAds.V15.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 74: {
            AdGroup = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(ref input, _repeated_labels_codec);
            break;
          }
          case 106: {
            actionItems_.AddEntriesFrom(ref input, _repeated_actionItems_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Contains policy information for an ad.
  /// </summary>
  public sealed partial class AdGroupAdPolicySummary : pb::IMessage<AdGroupAdPolicySummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdPolicySummary> _parser = new pb::MessageParser<AdGroupAdPolicySummary>(() => new AdGroupAdPolicySummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAdPolicySummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Resources.AdGroupAdReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdPolicySummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdPolicySummary(AdGroupAdPolicySummary other) : this() {
      policyTopicEntries_ = other.policyTopicEntries_.Clone();
      reviewStatus_ = other.reviewStatus_;
      approvalStatus_ = other.approvalStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdPolicySummary Clone() {
      return new AdGroupAdPolicySummary(this);
    }

    /// <summary>Field number for the "policy_topic_entries" field.</summary>
    public const int PolicyTopicEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V15.Common.PolicyTopicEntry> _repeated_policyTopicEntries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V15.Common.PolicyTopicEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Common.PolicyTopicEntry> policyTopicEntries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Common.PolicyTopicEntry>();
    /// <summary>
    /// Output only. The list of policy findings for this ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Common.PolicyTopicEntry> PolicyTopicEntries {
      get { return policyTopicEntries_; }
    }

    /// <summary>Field number for the "review_status" field.</summary>
    public const int ReviewStatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus reviewStatus_ = global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified;
    /// <summary>
    /// Output only. Where in the review process this ad is.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus ReviewStatus {
      get { return reviewStatus_; }
      set {
        reviewStatus_ = value;
      }
    }

    /// <summary>Field number for the "approval_status" field.</summary>
    public const int ApprovalStatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus approvalStatus_ = global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified;
    /// <summary>
    /// Output only. The overall approval status of this ad, calculated based on
    /// the status of its individual policy topic entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus ApprovalStatus {
      get { return approvalStatus_; }
      set {
        approvalStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdPolicySummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAdPolicySummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!policyTopicEntries_.Equals(other.policyTopicEntries_)) return false;
      if (ReviewStatus != other.ReviewStatus) return false;
      if (ApprovalStatus != other.ApprovalStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= policyTopicEntries_.GetHashCode();
      if (ReviewStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) hash ^= ReviewStatus.GetHashCode();
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) hash ^= ApprovalStatus.GetHashCode();
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
      policyTopicEntries_.WriteTo(output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      policyTopicEntries_.WriteTo(ref output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      size += policyTopicEntries_.CalculateSize(_repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAdPolicySummary other) {
      if (other == null) {
        return;
      }
      policyTopicEntries_.Add(other.policyTopicEntries_);
      if (other.ReviewStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        ReviewStatus = other.ReviewStatus;
      }
      if (other.ApprovalStatus != global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        ApprovalStatus = other.ApprovalStatus;
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
            policyTopicEntries_.AddEntriesFrom(input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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
            policyTopicEntries_.AddEntriesFrom(ref input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V15.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V15.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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
