// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/conversion_upload_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/conversion_upload_error.proto</summary>
  public static partial class ConversionUploadErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/conversion_upload_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionUploadErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL2NvbnZlcnNpb25f",
            "dXBsb2FkX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMu",
            "ZXJyb3JzIpENChlDb252ZXJzaW9uVXBsb2FkRXJyb3JFbnVtIvMMChVDb252",
            "ZXJzaW9uVXBsb2FkRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESIwofVE9PX01BTllfQ09OVkVSU0lPTlNfSU5fUkVRVUVTVBACEhUKEVVO",
            "UEFSU0VBQkxFX0dDTElEEAMSHQoZQ09OVkVSU0lPTl9QUkVDRURFU19FVkVO",
            "VBAqEhEKDUVYUElSRURfRVZFTlQQKxIUChBUT09fUkVDRU5UX0VWRU5UECwS",
            "EwoPRVZFTlRfTk9UX0ZPVU5EEC0SGQoVVU5BVVRIT1JJWkVEX0NVU1RPTUVS",
            "EAgSHQoZSU5WQUxJRF9DT05WRVJTSU9OX0FDVElPThAJEiAKHFRPT19SRUNF",
            "TlRfQ09OVkVSU0lPTl9BQ1RJT04QChI2CjJDT05WRVJTSU9OX1RSQUNLSU5H",
            "X05PVF9FTkFCTEVEX0FUX0lNUFJFU1NJT05fVElNRRALElEKTUVYVEVSTkFM",
            "X0FUVFJJQlVUSU9OX0RBVEFfU0VUX0ZPUl9OT05fRVhURVJOQUxMWV9BVFRS",
            "SUJVVEVEX0NPTlZFUlNJT05fQUNUSU9OEAwSUQpNRVhURVJOQUxfQVRUUklC",
            "VVRJT05fREFUQV9OT1RfU0VUX0ZPUl9FWFRFUk5BTExZX0FUVFJJQlVURURf",
            "Q09OVkVSU0lPTl9BQ1RJT04QDRJGCkJPUkRFUl9JRF9OT1RfUEVSTUlUVEVE",
            "X0ZPUl9FWFRFUk5BTExZX0FUVFJJQlVURURfQ09OVkVSU0lPTl9BQ1RJT04Q",
            "DhIbChdPUkRFUl9JRF9BTFJFQURZX0lOX1VTRRAPEhYKEkRVUExJQ0FURV9P",
            "UkRFUl9JRBAQEhMKD1RPT19SRUNFTlRfQ0FMTBAREhAKDEVYUElSRURfQ0FM",
            "TBASEhIKDkNBTExfTk9UX0ZPVU5EEBMSHAoYQ09OVkVSU0lPTl9QUkVDRURF",
            "U19DQUxMEBQSMAosQ09OVkVSU0lPTl9UUkFDS0lOR19OT1RfRU5BQkxFRF9B",
            "VF9DQUxMX1RJTUUQFRIkCiBVTlBBUlNFQUJMRV9DQUxMRVJTX1BIT05FX05V",
            "TUJFUhAWEiMKH0NMSUNLX0NPTlZFUlNJT05fQUxSRUFEWV9FWElTVFMQFxIi",
            "Ch5DQUxMX0NPTlZFUlNJT05fQUxSRUFEWV9FWElTVFMQGBIpCiVEVVBMSUNB",
            "VEVfQ0xJQ0tfQ09OVkVSU0lPTl9JTl9SRVFVRVNUEBkSKAokRFVQTElDQVRF",
            "X0NBTExfQ09OVkVSU0lPTl9JTl9SRVFVRVNUEBoSHwobQ1VTVE9NX1ZBUklB",
            "QkxFX05PVF9FTkFCTEVEEBwSJgoiQ1VTVE9NX1ZBUklBQkxFX1ZBTFVFX0NP",
            "TlRBSU5TX1BJSRAdEh4KGklOVkFMSURfQ1VTVE9NRVJfRk9SX0NMSUNLEB4S",
            "HQoZSU5WQUxJRF9DVVNUT01FUl9GT1JfQ0FMTBAfEiwKKENPTlZFUlNJT05f",
            "Tk9UX0NPTVBMSUFOVF9XSVRIX0FUVF9QT0xJQ1kQIBITCg9DTElDS19OT1Rf",
            "Rk9VTkQQIRIbChdJTlZBTElEX1VTRVJfSURFTlRJRklFUhAiEk4KSkVYVEVS",
            "TkFMTFlfQVRUUklCVVRFRF9DT05WRVJTSU9OX0FDVElPTl9OT1RfUEVSTUlU",
            "VEVEX1dJVEhfVVNFUl9JREVOVElGSUVSECMSHwobVU5TVVBQT1JURURfVVNF",
            "Ul9JREVOVElGSUVSECQSGgoWR0JSQUlEX1dCUkFJRF9CT1RIX1NFVBAmEhYK",
            "ElVOUEFSU0VBQkxFX1dCUkFJRBAnEhYKElVOUEFSU0VBQkxFX0dCUkFJRBAo",
            "EjwKOE9ORV9QRVJfQ0xJQ0tfQ09OVkVSU0lPTl9BQ1RJT05fTk9UX1BFUk1J",
            "VFRFRF9XSVRIX0JSQUlEEC4SNwozQ1VTVE9NRVJfREFUQV9QT0xJQ1lfUFJP",
            "SElCSVRTX0VOSEFOQ0VEX0NPTlZFUlNJT05TEC8SLQopQ1VTVE9NRVJfTk9U",
            "X0FDQ0VQVEVEX0NVU1RPTUVSX0RBVEFfVEVSTVMQMBIZChVPUkRFUl9JRF9D",
            "T05UQUlOU19QSUkQMRI3CjNDVVNUT01FUl9OT1RfRU5BQkxFRF9FTkhBTkNF",
            "RF9DT05WRVJTSU9OU19GT1JfTEVBRFMQMkL6AQojY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxMy5lcnJvcnNCGkNvbnZlcnNpb25VcGxvYWRFcnJvclBy",
            "b3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxMy5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMTNcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEz",
            "OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.ConversionUploadErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.ConversionUploadErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.ConversionUploadErrorEnum.Types.ConversionUploadError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion upload errors.
  /// </summary>
  public sealed partial class ConversionUploadErrorEnum : pb::IMessage<ConversionUploadErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionUploadErrorEnum> _parser = new pb::MessageParser<ConversionUploadErrorEnum>(() => new ConversionUploadErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionUploadErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.ConversionUploadErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionUploadErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionUploadErrorEnum(ConversionUploadErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionUploadErrorEnum Clone() {
      return new ConversionUploadErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionUploadErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionUploadErrorEnum other) {
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
    public void MergeFrom(ConversionUploadErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionUploadErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion upload errors.
      /// </summary>
      public enum ConversionUploadError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Upload fewer than 2001 events in a single request.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_CONVERSIONS_IN_REQUEST")] TooManyConversionsInRequest = 2,
        /// <summary>
        /// The imported gclid could not be decoded. Make sure you have not modified
        /// the click IDs.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_GCLID")] UnparseableGclid = 3,
        /// <summary>
        /// The imported event has a `conversion_date_time` that precedes the click.
        /// Make sure your `conversion_date_time` is correct and try again.
        /// </summary>
        [pbr::OriginalName("CONVERSION_PRECEDES_EVENT")] ConversionPrecedesEvent = 42,
        /// <summary>
        /// The imported event can't be recorded because its click occurred before
        /// this conversion's click-through window. Make sure you import the most
        /// recent data.
        /// </summary>
        [pbr::OriginalName("EXPIRED_EVENT")] ExpiredEvent = 43,
        /// <summary>
        /// The click associated with the given identifier or iOS URL parameter
        /// occurred less than 6 hours ago. Retry after 6 hours have passed.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_EVENT")] TooRecentEvent = 44,
        /// <summary>
        /// The imported event could not be attributed to a click. This may be
        /// because the event did not come from a Google Ads campaign.
        /// </summary>
        [pbr::OriginalName("EVENT_NOT_FOUND")] EventNotFound = 45,
        /// <summary>
        /// The click ID or call is associated with an Ads account you don't have
        /// access to. Make sure you import conversions for accounts managed by your
        /// manager account.
        /// </summary>
        [pbr::OriginalName("UNAUTHORIZED_CUSTOMER")] UnauthorizedCustomer = 8,
        /// <summary>
        /// Make sure you specify a valid conversion action set up for offline
        /// import.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_ACTION")] InvalidConversionAction = 9,
        /// <summary>
        /// Can't import events to a conversion action that was just created. Try
        /// importing again in 6 hours.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CONVERSION_ACTION")] TooRecentConversionAction = 10,
        /// <summary>
        /// At the time of the click, conversion tracking was not enabled in the
        /// effective conversion account of the click's Google Ads account.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED_AT_IMPRESSION_TIME")] ConversionTrackingNotEnabledAtImpressionTime = 11,
        /// <summary>
        /// The imported event includes external attribution data, but the conversion
        /// action isn't set up to use an external attribution model. Make sure the
        /// conversion action is correctly configured and try again.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_ATTRIBUTION_DATA_SET_FOR_NON_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] ExternalAttributionDataSetForNonExternallyAttributedConversionAction = 12,
        /// <summary>
        /// The conversion action is set up to use an external attribution model, but
        /// the imported event is missing data. Make sure imported events include the
        /// external attribution credit and all necessary fields.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_ATTRIBUTION_DATA_NOT_SET_FOR_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] ExternalAttributionDataNotSetForExternallyAttributedConversionAction = 13,
        /// <summary>
        /// Order IDs can't be used for a conversion measured with an external
        /// attribution model. Make sure the conversion is correctly configured and
        /// imported events include only necessary data and try again.
        /// </summary>
        [pbr::OriginalName("ORDER_ID_NOT_PERMITTED_FOR_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] OrderIdNotPermittedForExternallyAttributedConversionAction = 14,
        /// <summary>
        /// The imported event includes an order ID that was previously recorded, so
        /// the event was not processed.
        /// </summary>
        [pbr::OriginalName("ORDER_ID_ALREADY_IN_USE")] OrderIdAlreadyInUse = 15,
        /// <summary>
        /// Imported events include multiple conversions with the same order ID and
        /// were not processed.  Make sure order IDs are unique and try again.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ORDER_ID")] DuplicateOrderId = 16,
        /// <summary>
        /// Can't import calls that occurred less than 6 hours ago. Try uploading
        /// again in 6 hours.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CALL")] TooRecentCall = 17,
        /// <summary>
        /// The call can't be recorded because it occurred before this conversion
        /// action's lookback window. Make sure your import is configured to get the
        /// most recent data.
        /// </summary>
        [pbr::OriginalName("EXPIRED_CALL")] ExpiredCall = 18,
        /// <summary>
        /// The call or click leading to the imported event can't be found. Make sure
        /// your data source is set up to include correct identifiers.
        /// </summary>
        [pbr::OriginalName("CALL_NOT_FOUND")] CallNotFound = 19,
        /// <summary>
        /// The call has a `conversion_date_time` that precedes the associated click.
        /// Make sure your `conversion_date_time` is correct.
        /// </summary>
        [pbr::OriginalName("CONVERSION_PRECEDES_CALL")] ConversionPrecedesCall = 20,
        /// <summary>
        /// At the time of the imported call, conversion tracking was not enabled in
        /// the effective conversion account of the click's Google Ads account.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED_AT_CALL_TIME")] ConversionTrackingNotEnabledAtCallTime = 21,
        /// <summary>
        /// Make sure phone numbers are formatted as E.164 (+16502531234),
        /// International (+64 3-331 6005), or US national number (6502531234).
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_CALLERS_PHONE_NUMBER")] UnparseableCallersPhoneNumber = 22,
        /// <summary>
        /// The imported event has the same click and `conversion_date_time` as an
        /// existing conversion. Use a unique `conversion_date_time` or order ID for
        /// each unique event and try again.
        /// </summary>
        [pbr::OriginalName("CLICK_CONVERSION_ALREADY_EXISTS")] ClickConversionAlreadyExists = 23,
        /// <summary>
        /// The imported call has the same `conversion_date_time` as an existing
        /// conversion. Make sure your `conversion_date_time` correctly configured
        /// and try again.
        /// </summary>
        [pbr::OriginalName("CALL_CONVERSION_ALREADY_EXISTS")] CallConversionAlreadyExists = 24,
        /// <summary>
        /// Multiple events have the same click and `conversion_date_time`. Make sure
        /// your `conversion_date_time` is correctly configured and try again.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CLICK_CONVERSION_IN_REQUEST")] DuplicateClickConversionInRequest = 25,
        /// <summary>
        /// Multiple events have the same call and `conversion_date_time`. Make sure
        /// your `conversion_date_time` is correctly configured and try again.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CALL_CONVERSION_IN_REQUEST")] DuplicateCallConversionInRequest = 26,
        /// <summary>
        /// Enable the custom variable in your conversion settings and try again.
        /// </summary>
        [pbr::OriginalName("CUSTOM_VARIABLE_NOT_ENABLED")] CustomVariableNotEnabled = 28,
        /// <summary>
        /// Can't import events with custom variables containing
        /// personally-identifiable information (PII). Remove these variables and try
        /// again.
        /// </summary>
        [pbr::OriginalName("CUSTOM_VARIABLE_VALUE_CONTAINS_PII")] CustomVariableValueContainsPii = 29,
        /// <summary>
        /// The click from the imported event is associated with a different Google
        /// Ads account. Make sure you're importing to the correct account.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOMER_FOR_CLICK")] InvalidCustomerForClick = 30,
        /// <summary>
        /// The click from the call is associated with a different Google Ads
        /// account. Make sure you're importing to the correct account. Query
        /// conversion_tracking_setting.google_ads_conversion_customer on Customer to
        /// identify the correct account.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOMER_FOR_CALL")] InvalidCustomerForCall = 31,
        /// <summary>
        /// The connversion can't be imported because the conversion source didn't
        /// comply with Apple App Transparency Tracking (ATT) policies or because the
        /// customer didn't consent to tracking.
        /// </summary>
        [pbr::OriginalName("CONVERSION_NOT_COMPLIANT_WITH_ATT_POLICY")] ConversionNotCompliantWithAttPolicy = 32,
        /// <summary>
        /// The click can't be found for the specified identifiers. This may be
        /// because it did not come from a Google Ads campaign.
        /// </summary>
        [pbr::OriginalName("CLICK_NOT_FOUND")] ClickNotFound = 33,
        /// <summary>
        /// Make sure you hash user provided data using SHA-256 and ensure you are
        /// normalizing according to the guidelines.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_IDENTIFIER")] InvalidUserIdentifier = 34,
        /// <summary>
        /// User provided data can't be used with external attribution models. Use a
        /// different attribution model or omit user identifiers and try again.
        /// </summary>
        [pbr::OriginalName("EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION_NOT_PERMITTED_WITH_USER_IDENTIFIER")] ExternallyAttributedConversionActionNotPermittedWithUserIdentifier = 35,
        /// <summary>
        /// The provided user identifiers are not supported. Use only hashed email
        /// or phone number and try again.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_USER_IDENTIFIER")] UnsupportedUserIdentifier = 36,
        /// <summary>
        /// Can't use both gbraid and wbraid parameters. Use only 1 and try again.
        /// </summary>
        [pbr::OriginalName("GBRAID_WBRAID_BOTH_SET")] GbraidWbraidBothSet = 38,
        /// <summary>
        /// Can't parse event import data. Check if your wbraid parameter was
        /// not modified and try again.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_WBRAID")] UnparseableWbraid = 39,
        /// <summary>
        /// Can't parse event import data. Check if your gbraid parameter was
        /// not modified and try again.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_GBRAID")] UnparseableGbraid = 40,
        /// <summary>
        /// Conversion actions that use one-per-click counting can't be used with
        /// gbraid or wbraid parameters.
        /// </summary>
        [pbr::OriginalName("ONE_PER_CLICK_CONVERSION_ACTION_NOT_PERMITTED_WITH_BRAID")] OnePerClickConversionActionNotPermittedWithBraid = 46,
        /// <summary>
        /// Enhanced conversions can't be used for this account because of Google
        /// customer data policies. Contact your Google representative.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_DATA_POLICY_PROHIBITS_ENHANCED_CONVERSIONS")] CustomerDataPolicyProhibitsEnhancedConversions = 47,
        /// <summary>
        /// Make sure you agree to the customer data processing terms in conversion
        /// settings and try again. You can check your setting by querying
        /// conversion_tracking_setting.accepted_customer_data_terms on Customer.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ACCEPTED_CUSTOMER_DATA_TERMS")] CustomerNotAcceptedCustomerDataTerms = 48,
        /// <summary>
        /// Can't import events with order IDs containing personally-identifiable
        /// information (PII).
        /// </summary>
        [pbr::OriginalName("ORDER_ID_CONTAINS_PII")] OrderIdContainsPii = 49,
        /// <summary>
        /// Make sure you've turned on enhanced conversions for leads in conversion
        /// settings and try again. You can check your setting by querying
        /// conversion_tracking_setting.enhanced_conversions_for_leads_enabled on
        /// Customer.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ENABLED_ENHANCED_CONVERSIONS_FOR_LEADS")] CustomerNotEnabledEnhancedConversionsForLeads = 50,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
