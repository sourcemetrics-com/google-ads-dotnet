// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/services/keyword_theme_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/services/keyword_theme_constant_service.proto</summary>
  public static partial class KeywordThemeConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/services/keyword_theme_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordThemeConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9zZXJ2aWNlcy9rZXl3b3JkX3Ro",
            "ZW1lX2NvbnN0YW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNv",
            "dXJjZXMva2V5d29yZF90aGVtZV9jb25zdGFudC5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8ibgoeR2V0S2V5d29yZFRoZW1lQ29uc3RhbnRSZXF1",
            "ZXN0EkwKDXJlc291cmNlX25hbWUYASABKAlCNeBBAvpBLwotZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0tleXdvcmRUaGVtZUNvbnN0YW50ImYKI1N1Z2dl",
            "c3RLZXl3b3JkVGhlbWVDb25zdGFudHNSZXF1ZXN0EhIKCnF1ZXJ5X3RleHQY",
            "ASABKAkSFAoMY291bnRyeV9jb2RlGAIgASgJEhUKDWxhbmd1YWdlX2NvZGUY",
            "AyABKAkigAEKJFN1Z2dlc3RLZXl3b3JkVGhlbWVDb25zdGFudHNSZXNwb25z",
            "ZRJYChdrZXl3b3JkX3RoZW1lX2NvbnN0YW50cxgBIAMoCzI3Lmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNlcy5LZXl3b3JkVGhlbWVDb25zdGFu",
            "dDKeBAobS2V5d29yZFRoZW1lQ29uc3RhbnRTZXJ2aWNlEtkBChdHZXRLZXl3",
            "b3JkVGhlbWVDb25zdGFudBJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnNl",
            "cnZpY2VzLkdldEtleXdvcmRUaGVtZUNvbnN0YW50UmVxdWVzdBo3Lmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNlcy5LZXl3b3JkVGhlbWVDb25z",
            "dGFudCJDgtPkkwItEisvdjkve3Jlc291cmNlX25hbWU9a2V5d29yZFRoZW1l",
            "Q29uc3RhbnRzLyp92kENcmVzb3VyY2VfbmFtZRLbAQocU3VnZ2VzdEtleXdv",
            "cmRUaGVtZUNvbnN0YW50cxJFLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnNl",
            "cnZpY2VzLlN1Z2dlc3RLZXl3b3JkVGhlbWVDb25zdGFudHNSZXF1ZXN0GkYu",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjkuc2VydmljZXMuU3VnZ2VzdEtleXdv",
            "cmRUaGVtZUNvbnN0YW50c1Jlc3BvbnNlIiyC0+STAiYiIS92OS9rZXl3b3Jk",
            "VGhlbWVDb25zdGFudHM6c3VnZ2VzdDoBKhpFykEYZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29t0kEnaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9h",
            "ZHdvcmRzQocCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuc2Vydmlj",
            "ZXNCIEtleXdvcmRUaGVtZUNvbnN0YW50U2VydmljZVByb3RvUAFaSGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92OS9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY5LlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlc",
            "U2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6U2Vydmlj",
            "ZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Services.GetKeywordThemeConstantRequest), global::Google.Ads.GoogleAds.V9.Services.GetKeywordThemeConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Services.SuggestKeywordThemeConstantsRequest), global::Google.Ads.GoogleAds.V9.Services.SuggestKeywordThemeConstantsRequest.Parser, new[]{ "QueryText", "CountryCode", "LanguageCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Services.SuggestKeywordThemeConstantsResponse), global::Google.Ads.GoogleAds.V9.Services.SuggestKeywordThemeConstantsResponse.Parser, new[]{ "KeywordThemeConstants" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [KeywordThemeConstantService.GetKeywordThemeConstant][google.ads.googleads.v9.services.KeywordThemeConstantService.GetKeywordThemeConstant].
  /// </summary>
  public sealed partial class GetKeywordThemeConstantRequest : pb::IMessage<GetKeywordThemeConstantRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetKeywordThemeConstantRequest> _parser = new pb::MessageParser<GetKeywordThemeConstantRequest>(() => new GetKeywordThemeConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetKeywordThemeConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Services.KeywordThemeConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetKeywordThemeConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetKeywordThemeConstantRequest(GetKeywordThemeConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetKeywordThemeConstantRequest Clone() {
      return new GetKeywordThemeConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the keyword theme constant to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetKeywordThemeConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetKeywordThemeConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetKeywordThemeConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request message for
  /// [KeywordThemeConstantService.SuggestKeywordThemeConstants][google.ads.googleads.v9.services.KeywordThemeConstantService.SuggestKeywordThemeConstants].
  /// </summary>
  public sealed partial class SuggestKeywordThemeConstantsRequest : pb::IMessage<SuggestKeywordThemeConstantsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestKeywordThemeConstantsRequest> _parser = new pb::MessageParser<SuggestKeywordThemeConstantsRequest>(() => new SuggestKeywordThemeConstantsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestKeywordThemeConstantsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Services.KeywordThemeConstantServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest(SuggestKeywordThemeConstantsRequest other) : this() {
      queryText_ = other.queryText_;
      countryCode_ = other.countryCode_;
      languageCode_ = other.languageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest Clone() {
      return new SuggestKeywordThemeConstantsRequest(this);
    }

    /// <summary>Field number for the "query_text" field.</summary>
    public const int QueryTextFieldNumber = 1;
    private string queryText_ = "";
    /// <summary>
    /// The query text of a keyword theme that will be used to map to similar
    /// keyword themes. E.g. "plumber" or "roofer".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QueryText {
      get { return queryText_; }
      set {
        queryText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 2;
    private string countryCode_ = "";
    /// <summary>
    /// Upper-case, two-letter country code as defined by ISO-3166. This for
    /// refining the scope of the query, default to 'US' if not set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 3;
    private string languageCode_ = "";
    /// <summary>
    /// The two letter language code for get corresponding keyword theme for
    /// refining the scope of the query, default to 'en' if not set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestKeywordThemeConstantsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestKeywordThemeConstantsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QueryText != other.QueryText) return false;
      if (CountryCode != other.CountryCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueryText.Length != 0) hash ^= QueryText.GetHashCode();
      if (CountryCode.Length != 0) hash ^= CountryCode.GetHashCode();
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
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
      if (QueryText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QueryText);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
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
      if (QueryText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QueryText);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
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
      if (QueryText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QueryText);
      }
      if (CountryCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestKeywordThemeConstantsRequest other) {
      if (other == null) {
        return;
      }
      if (other.QueryText.Length != 0) {
        QueryText = other.QueryText;
      }
      if (other.CountryCode.Length != 0) {
        CountryCode = other.CountryCode;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
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
            QueryText = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
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
            QueryText = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for
  /// [KeywordThemeConstantService.SuggestKeywordThemeConstants][google.ads.googleads.v9.services.KeywordThemeConstantService.SuggestKeywordThemeConstants].
  /// </summary>
  public sealed partial class SuggestKeywordThemeConstantsResponse : pb::IMessage<SuggestKeywordThemeConstantsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestKeywordThemeConstantsResponse> _parser = new pb::MessageParser<SuggestKeywordThemeConstantsResponse>(() => new SuggestKeywordThemeConstantsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestKeywordThemeConstantsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Services.KeywordThemeConstantServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse(SuggestKeywordThemeConstantsResponse other) : this() {
      keywordThemeConstants_ = other.keywordThemeConstants_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse Clone() {
      return new SuggestKeywordThemeConstantsResponse(this);
    }

    /// <summary>Field number for the "keyword_theme_constants" field.</summary>
    public const int KeywordThemeConstantsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstant> _repeated_keywordThemeConstants_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstant.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstant> keywordThemeConstants_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstant>();
    /// <summary>
    /// Smart Campaign keyword theme suggestions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.KeywordThemeConstant> KeywordThemeConstants {
      get { return keywordThemeConstants_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestKeywordThemeConstantsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestKeywordThemeConstantsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!keywordThemeConstants_.Equals(other.keywordThemeConstants_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= keywordThemeConstants_.GetHashCode();
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
      keywordThemeConstants_.WriteTo(output, _repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      keywordThemeConstants_.WriteTo(ref output, _repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += keywordThemeConstants_.CalculateSize(_repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestKeywordThemeConstantsResponse other) {
      if (other == null) {
        return;
      }
      keywordThemeConstants_.Add(other.keywordThemeConstants_);
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
            keywordThemeConstants_.AddEntriesFrom(input, _repeated_keywordThemeConstants_codec);
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
            keywordThemeConstants_.AddEntriesFrom(ref input, _repeated_keywordThemeConstants_codec);
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