// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/carrier_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/carrier_constant.proto</summary>
  public static partial class CarrierConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/carrier_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CarrierConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2NhcnJpZXJf",
            "Y29uc3RhbnQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5yZXNv",
            "dXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8imQIKD0NhcnJpZXJDb25zdGFudBJHCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQjDgQQP6QSoKKGdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DYXJyaWVyQ29uc3RhbnQSFAoCaWQYBSABKANCA+BBA0gAiAEB",
            "EhYKBG5hbWUYBiABKAlCA+BBA0gBiAEBEh4KDGNvdW50cnlfY29kZRgHIAEo",
            "CUID4EEDSAKIAQE6TupBSwooZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Nh",
            "cnJpZXJDb25zdGFudBIfY2FycmllckNvbnN0YW50cy97Y3JpdGVyaW9uX2lk",
            "fUIFCgNfaWRCBwoFX25hbWVCDwoNX2NvdW50cnlfY29kZUKGAgomY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5yZXNvdXJjZXNCFENhcnJpZXJDb25z",
            "dGFudFByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzO3Jlc291cmNlc6IC",
            "A0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5SZXNvdXJjZXPKAiJH",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcUmVzb3VyY2Vz6gImR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjExOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CarrierConstant), global::Google.Ads.GoogleAds.V11.Resources.CarrierConstant.Parser, new[]{ "ResourceName", "Id", "Name", "CountryCode" }, new[]{ "Id", "Name", "CountryCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A carrier criterion that can be used in campaign targeting.
  /// </summary>
  public sealed partial class CarrierConstant : pb::IMessage<CarrierConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CarrierConstant> _parser = new pb::MessageParser<CarrierConstant>(() => new CarrierConstant());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CarrierConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CarrierConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CarrierConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CarrierConstant(CarrierConstant other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      countryCode_ = other.countryCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CarrierConstant Clone() {
      return new CarrierConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the carrier criterion.
    /// Carrier criterion resource names have the form:
    ///
    /// `carrierConstants/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private long id_;
    /// <summary>
    /// Output only. The ID of the carrier criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 6;
    private string name_;
    /// <summary>
    /// Output only. The full name of the carrier in English.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 7;
    private string countryCode_;
    /// <summary>
    /// Output only. The country code of the country where the carrier is located, for example,
    /// "AR", "FR", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CountryCode {
      get { return countryCode_ ?? ""; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "country_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCountryCode {
      get { return countryCode_ != null; }
    }
    /// <summary>Clears the value of the "country_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCountryCode() {
      countryCode_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CarrierConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CarrierConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (CountryCode != other.CountryCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasCountryCode) hash ^= CountryCode.GetHashCode();
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
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(50);
        output.WriteString(Name);
      }
      if (HasCountryCode) {
        output.WriteRawTag(58);
        output.WriteString(CountryCode);
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
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(50);
        output.WriteString(Name);
      }
      if (HasCountryCode) {
        output.WriteRawTag(58);
        output.WriteString(CountryCode);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasCountryCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CarrierConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasCountryCode) {
        CountryCode = other.CountryCode;
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
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            Name = input.ReadString();
            break;
          }
          case 58: {
            CountryCode = input.ReadString();
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
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            Name = input.ReadString();
            break;
          }
          case 58: {
            CountryCode = input.ReadString();
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
