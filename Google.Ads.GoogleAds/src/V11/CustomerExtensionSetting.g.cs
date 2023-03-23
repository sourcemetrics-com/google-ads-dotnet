// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/customer_extension_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/customer_extension_setting.proto</summary>
  public static partial class CustomerExtensionSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/customer_extension_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerExtensionSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2V4dGVuc2lvbl9zZXR0aW5nLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTEucmVzb3VyY2VzGj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51",
            "bXMvZXh0ZW5zaW9uX3NldHRpbmdfZGV2aWNlLnByb3RvGjNnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92MTEvZW51bXMvZXh0ZW5zaW9uX3R5cGUucHJvdG8aH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVz",
            "b3VyY2UucHJvdG8i+AMKGEN1c3RvbWVyRXh0ZW5zaW9uU2V0dGluZxJQCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQjngQQX6QTMKMWdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DdXN0b21lckV4dGVuc2lvblNldHRpbmcSXAoOZXh0ZW5zaW9u",
            "X3R5cGUYAiABKA4yPy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXMu",
            "RXh0ZW5zaW9uVHlwZUVudW0uRXh0ZW5zaW9uVHlwZUID4EEFEk0KFGV4dGVu",
            "c2lvbl9mZWVkX2l0ZW1zGAUgAygJQi/6QSwKKmdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9FeHRlbnNpb25GZWVkSXRlbRJhCgZkZXZpY2UYBCABKA4yUS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXMuRXh0ZW5zaW9uU2V0dGlu",
            "Z0RldmljZUVudW0uRXh0ZW5zaW9uU2V0dGluZ0RldmljZTp66kF3CjFnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJFeHRlbnNpb25TZXR0aW5n",
            "EkJjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9jdXN0b21lckV4dGVuc2lvblNl",
            "dHRpbmdzL3tleHRlbnNpb25fdHlwZX1CjwIKJmNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTEucmVzb3VyY2VzQh1DdXN0b21lckV4dGVuc2lvblNldHRp",
            "bmdQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjExL3Jlc291cmNlcztyZXNvdXJjZXOiAgNH",
            "QUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTEuUmVzb3VyY2VzygIiR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjExXFJlc291cmNlc+oCJkdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYxMTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CustomerExtensionSetting), global::Google.Ads.GoogleAds.V11.Resources.CustomerExtensionSetting.Parser, new[]{ "ResourceName", "ExtensionType", "ExtensionFeedItems", "Device" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customer extension setting.
  /// </summary>
  public sealed partial class CustomerExtensionSetting : pb::IMessage<CustomerExtensionSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerExtensionSetting> _parser = new pb::MessageParser<CustomerExtensionSetting>(() => new CustomerExtensionSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerExtensionSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CustomerExtensionSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting(CustomerExtensionSetting other) : this() {
      resourceName_ = other.resourceName_;
      extensionType_ = other.extensionType_;
      extensionFeedItems_ = other.extensionFeedItems_.Clone();
      device_ = other.device_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting Clone() {
      return new CustomerExtensionSetting(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer extension setting.
    /// CustomerExtensionSetting resource names have the form:
    ///
    /// `customers/{customer_id}/customerExtensionSettings/{extension_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extension_type" field.</summary>
    public const int ExtensionTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType extensionType_ = global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified;
    /// <summary>
    /// Immutable. The extension type of the customer extension setting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType ExtensionType {
      get { return extensionType_; }
      set {
        extensionType_ = value;
      }
    }

    /// <summary>Field number for the "extension_feed_items" field.</summary>
    public const int ExtensionFeedItemsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_extensionFeedItems_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> extensionFeedItems_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The resource names of the extension feed items to serve under the customer.
    /// ExtensionFeedItem resource names have the form:
    ///
    /// `customers/{customer_id}/extensionFeedItems/{feed_item_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ExtensionFeedItems {
      get { return extensionFeedItems_; }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice device_ = global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified;
    /// <summary>
    /// The device for which the extensions will serve. Optional.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice Device {
      get { return device_; }
      set {
        device_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerExtensionSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerExtensionSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ExtensionType != other.ExtensionType) return false;
      if(!extensionFeedItems_.Equals(other.extensionFeedItems_)) return false;
      if (Device != other.Device) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (ExtensionType != global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) hash ^= ExtensionType.GetHashCode();
      hash ^= extensionFeedItems_.GetHashCode();
      if (Device != global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) hash ^= Device.GetHashCode();
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Device);
      }
      extensionFeedItems_.WriteTo(output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Device);
      }
      extensionFeedItems_.WriteTo(ref output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtensionType);
      }
      size += extensionFeedItems_.CalculateSize(_repeated_extensionFeedItems_codec);
      if (Device != global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Device);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerExtensionSetting other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.ExtensionType != global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        ExtensionType = other.ExtensionType;
      }
      extensionFeedItems_.Add(other.extensionFeedItems_);
      if (other.Device != global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        Device = other.Device;
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
          case 16: {
            ExtensionType = (global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 32: {
            Device = (global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 42: {
            extensionFeedItems_.AddEntriesFrom(input, _repeated_extensionFeedItems_codec);
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
          case 16: {
            ExtensionType = (global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 32: {
            Device = (global::Google.Ads.GoogleAds.V11.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 42: {
            extensionFeedItems_.AddEntriesFrom(ref input, _repeated_extensionFeedItems_codec);
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
