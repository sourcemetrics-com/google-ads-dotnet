// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/campaign_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/campaign_error.proto</summary>
  public static partial class CampaignErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/campaign_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2NhbXBhaWduX2Vy",
            "cm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZXJyb3JzIswQ",
            "ChFDYW1wYWlnbkVycm9yRW51bSK2EAoNQ2FtcGFpZ25FcnJvchIPCgtVTlNQ",
            "RUNJRklFRBAAEgsKB1VOS05PV04QARIhCh1DQU5OT1RfVEFSR0VUX0NPTlRF",
            "TlRfTkVUV09SSxADEiAKHENBTk5PVF9UQVJHRVRfU0VBUkNIX05FVFdPUksQ",
            "BBI2CjJDQU5OT1RfVEFSR0VUX1NFQVJDSF9ORVRXT1JLX1dJVEhPVVRfR09P",
            "R0xFX1NFQVJDSBAFEjAKLENBTk5PVF9UQVJHRVRfR09PR0xFX1NFQVJDSF9G",
            "T1JfQ1BNX0NBTVBBSUdOEAYSLQopQ0FNUEFJR05fTVVTVF9UQVJHRVRfQVRf",
            "TEVBU1RfT05FX05FVFdPUksQBxIoCiRDQU5OT1RfVEFSR0VUX1BBUlRORVJf",
            "U0VBUkNIX05FVFdPUksQCBJLCkdDQU5OT1RfVEFSR0VUX0NPTlRFTlRfTkVU",
            "V09SS19PTkxZX1dJVEhfQ1JJVEVSSUFfTEVWRUxfQklERElOR19TVFJBVEVH",
            "WRAJEjYKMkNBTVBBSUdOX0RVUkFUSU9OX01VU1RfQ09OVEFJTl9BTExfUlVO",
            "TkFCTEVfVFJJQUxTEAoSJAogQ0FOTk9UX01PRElGWV9GT1JfVFJJQUxfQ0FN",
            "UEFJR04QCxIbChdEVVBMSUNBVEVfQ0FNUEFJR05fTkFNRRAMEh8KG0lOQ09N",
            "UEFUSUJMRV9DQU1QQUlHTl9GSUVMRBANEhkKFUlOVkFMSURfQ0FNUEFJR05f",
            "TkFNRRAOEioKJklOVkFMSURfQURfU0VSVklOR19PUFRJTUlaQVRJT05fU1RB",
            "VFVTEA8SGAoUSU5WQUxJRF9UUkFDS0lOR19VUkwQEBI+CjpDQU5OT1RfU0VU",
            "X0JPVEhfVFJBQ0tJTkdfVVJMX1RFTVBMQVRFX0FORF9UUkFDS0lOR19TRVRU",
            "SU5HEBESIAocTUFYX0lNUFJFU1NJT05TX05PVF9JTl9SQU5HRRASEhsKF1RJ",
            "TUVfVU5JVF9OT1RfU1VQUE9SVEVEEBMSMQotSU5WQUxJRF9PUEVSQVRJT05f",
            "SUZfU0VSVklOR19TVEFUVVNfSEFTX0VOREVEEBQSGwoXQlVER0VUX0NBTk5P",
            "VF9CRV9TSEFSRUQQFRIlCiFDQU1QQUlHTl9DQU5OT1RfVVNFX1NIQVJFRF9C",
            "VURHRVQQFhIwCixDQU5OT1RfQ0hBTkdFX0JVREdFVF9PTl9DQU1QQUlHTl9X",
            "SVRIX1RSSUFMUxAXEiEKHUNBTVBBSUdOX0xBQkVMX0RPRVNfTk9UX0VYSVNU",
            "EBgSIQodQ0FNUEFJR05fTEFCRUxfQUxSRUFEWV9FWElTVFMQGRIcChhNSVNT",
            "SU5HX1NIT1BQSU5HX1NFVFRJTkcQGhIiCh5JTlZBTElEX1NIT1BQSU5HX1NB",
            "TEVTX0NPVU5UUlkQGxI7CjdBRFZFUlRJU0lOR19DSEFOTkVMX1RZUEVfTk9U",
            "X0FWQUlMQUJMRV9GT1JfQUNDT1VOVF9UWVBFEB8SKAokSU5WQUxJRF9BRFZF",
            "UlRJU0lOR19DSEFOTkVMX1NVQl9UWVBFECASLAooQVRfTEVBU1RfT05FX0NP",
            "TlZFUlNJT05fTVVTVF9CRV9TRUxFQ1RFRBAhEh8KG0NBTk5PVF9TRVRfQURf",
            "Uk9UQVRJT05fTU9ERRAiEi8KK0NBTk5PVF9NT0RJRllfU1RBUlRfREFURV9J",
            "Rl9BTFJFQURZX1NUQVJURUQQIxIbChdDQU5OT1RfU0VUX0RBVEVfVE9fUEFT",
            "VBAkEh8KG01JU1NJTkdfSE9URUxfQ1VTVE9NRVJfTElOSxAlEh8KG0lOVkFM",
            "SURfSE9URUxfQ1VTVE9NRVJfTElOSxAmEhkKFU1JU1NJTkdfSE9URUxfU0VU",
            "VElORxAnEkIKPkNBTk5PVF9VU0VfU0hBUkVEX0NBTVBBSUdOX0JVREdFVF9X",
            "SElMRV9QQVJUX09GX0NBTVBBSUdOX0dST1VQECgSEQoNQVBQX05PVF9GT1VO",
            "RBApEjkKNVNIT1BQSU5HX0VOQUJMRV9MT0NBTF9OT1RfU1VQUE9SVEVEX0ZP",
            "Ul9DQU1QQUlHTl9UWVBFECoSMwovTUVSQ0hBTlRfTk9UX0FMTE9XRURfRk9S",
            "X0NPTVBBUklTT05fTElTVElOR19BRFMQKxIjCh9JTlNVRkZJQ0lFTlRfQVBQ",
            "X0lOU1RBTExTX0NPVU5UECwSGgoWU0VOU0lUSVZFX0NBVEVHT1JZX0FQUBAt",
            "EhoKFkhFQ19BR1JFRU1FTlRfUkVRVUlSRUQQLhI8CjhOT1RfQ09NUEFUSUJM",
            "RV9XSVRIX1ZJRVdfVEhST1VHSF9DT05WRVJTSU9OX09QVElNSVpBVElPThAx",
            "EiwKKElOVkFMSURfRVhDTFVERURfUEFSRU5UX0FTU0VUX0ZJRUxEX1RZUEUQ",
            "MBI6CjZDQU5OT1RfQ1JFQVRFX0FQUF9QUkVfUkVHSVNUUkFUSU9OX0ZPUl9O",
            "T05fQU5EUk9JRF9BUFAQMhI9CjlBUFBfTk9UX0FWQUlMQUJMRV9UT19DUkVB",
            "VEVfQVBQX1BSRV9SRUdJU1RSQVRJT05fQ0FNUEFJR04QMxIcChhJTkNPTVBB",
            "VElCTEVfQlVER0VUX1RZUEUQNBIpCiVMT0NBTF9TRVJWSUNFU19EVVBMSUNB",
            "VEVfQ0FURUdPUllfQklEEDUSJwojTE9DQUxfU0VSVklDRVNfSU5WQUxJRF9D",
            "QVRFR09SWV9CSUQQNhInCiNMT0NBTF9TRVJWSUNFU19NSVNTSU5HX0NBVEVH",
            "T1JZX0JJRBA3QvIBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVy",
            "cm9yc0ISQ2FtcGFpZ25FcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3Jz",
            "O2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5FcnJv",
            "cnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcRXJyb3Jz6gIjR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjExOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.CampaignErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignErrorEnum.Types.CampaignError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign errors.
  /// </summary>
  public sealed partial class CampaignErrorEnum : pb::IMessage<CampaignErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignErrorEnum> _parser = new pb::MessageParser<CampaignErrorEnum>(() => new CampaignErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.CampaignErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum(CampaignErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignErrorEnum Clone() {
      return new CampaignErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignErrorEnum other) {
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
    public void MergeFrom(CampaignErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign errors.
      /// </summary>
      public enum CampaignError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot target content network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK")] CannotTargetContentNetwork = 3,
        /// <summary>
        /// Cannot target search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK")] CannotTargetSearchNetwork = 4,
        /// <summary>
        /// Cannot cover search network without google search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK_WITHOUT_GOOGLE_SEARCH")] CannotTargetSearchNetworkWithoutGoogleSearch = 5,
        /// <summary>
        /// Cannot target Google Search network for a CPM campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN")] CannotTargetGoogleSearchForCpmCampaign = 6,
        /// <summary>
        /// Must target at least one network.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_MUST_TARGET_AT_LEAST_ONE_NETWORK")] CampaignMustTargetAtLeastOneNetwork = 7,
        /// <summary>
        /// Only some Google partners are allowed to target partner search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_PARTNER_SEARCH_NETWORK")] CannotTargetPartnerSearchNetwork = 8,
        /// <summary>
        /// Cannot target content network only as campaign has criteria-level bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CRITERIA_LEVEL_BIDDING_STRATEGY")] CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy = 9,
        /// <summary>
        /// Cannot modify the start or end date such that the campaign duration would
        /// not contain the durations of all runnable trials.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_DURATION_MUST_CONTAIN_ALL_RUNNABLE_TRIALS")] CampaignDurationMustContainAllRunnableTrials = 10,
        /// <summary>
        /// Cannot modify dates, budget or status of a trial campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FOR_TRIAL_CAMPAIGN")] CannotModifyForTrialCampaign = 11,
        /// <summary>
        /// Trying to modify the name of an active or paused campaign, where the name
        /// is already assigned to another active or paused campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CAMPAIGN_NAME")] DuplicateCampaignName = 12,
        /// <summary>
        /// Two fields are in conflicting modes.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_CAMPAIGN_FIELD")] IncompatibleCampaignField = 13,
        /// <summary>
        /// Campaign name cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN_NAME")] InvalidCampaignName = 14,
        /// <summary>
        /// Given status is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_AD_SERVING_OPTIMIZATION_STATUS")] InvalidAdServingOptimizationStatus = 15,
        /// <summary>
        /// Error in the campaign level tracking URL.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL")] InvalidTrackingUrl = 16,
        /// <summary>
        /// Cannot set both tracking URL template and tracking setting. A user has
        /// to clear legacy tracking setting in order to add tracking URL template.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_TRACKING_URL_TEMPLATE_AND_TRACKING_SETTING")] CannotSetBothTrackingUrlTemplateAndTrackingSetting = 17,
        /// <summary>
        /// The maximum number of impressions for Frequency Cap should be an integer
        /// greater than 0.
        /// </summary>
        [pbr::OriginalName("MAX_IMPRESSIONS_NOT_IN_RANGE")] MaxImpressionsNotInRange = 18,
        /// <summary>
        /// Only the Day, Week and Month time units are supported.
        /// </summary>
        [pbr::OriginalName("TIME_UNIT_NOT_SUPPORTED")] TimeUnitNotSupported = 19,
        /// <summary>
        /// Operation not allowed on a campaign whose serving status has ended
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED")] InvalidOperationIfServingStatusHasEnded = 20,
        /// <summary>
        /// This budget is exclusively linked to a Campaign that is using experiments
        /// so it cannot be shared.
        /// </summary>
        [pbr::OriginalName("BUDGET_CANNOT_BE_SHARED")] BudgetCannotBeShared = 21,
        /// <summary>
        /// Campaigns using experiments cannot use a shared budget.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_USE_SHARED_BUDGET")] CampaignCannotUseSharedBudget = 22,
        /// <summary>
        /// A different budget cannot be assigned to a campaign when there are
        /// running or scheduled trials.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_BUDGET_ON_CAMPAIGN_WITH_TRIALS")] CannotChangeBudgetOnCampaignWithTrials = 23,
        /// <summary>
        /// No link found between the campaign and the label.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_DOES_NOT_EXIST")] CampaignLabelDoesNotExist = 24,
        /// <summary>
        /// The label has already been attached to the campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_ALREADY_EXISTS")] CampaignLabelAlreadyExists = 25,
        /// <summary>
        /// A ShoppingSetting was not found when creating a shopping campaign.
        /// </summary>
        [pbr::OriginalName("MISSING_SHOPPING_SETTING")] MissingShoppingSetting = 26,
        /// <summary>
        /// The country in shopping setting is not an allowed country.
        /// </summary>
        [pbr::OriginalName("INVALID_SHOPPING_SALES_COUNTRY")] InvalidShoppingSalesCountry = 27,
        /// <summary>
        /// The requested channel type is not available according to the customer's
        /// account setting.
        /// </summary>
        [pbr::OriginalName("ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE")] AdvertisingChannelTypeNotAvailableForAccountType = 31,
        /// <summary>
        /// The AdvertisingChannelSubType is not a valid subtype of the primary
        /// channel type.
        /// </summary>
        [pbr::OriginalName("INVALID_ADVERTISING_CHANNEL_SUB_TYPE")] InvalidAdvertisingChannelSubType = 32,
        /// <summary>
        /// At least one conversion must be selected.
        /// </summary>
        [pbr::OriginalName("AT_LEAST_ONE_CONVERSION_MUST_BE_SELECTED")] AtLeastOneConversionMustBeSelected = 33,
        /// <summary>
        /// Setting ad rotation mode for a campaign is not allowed. Ad rotation mode
        /// at campaign is deprecated.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_AD_ROTATION_MODE")] CannotSetAdRotationMode = 34,
        /// <summary>
        /// Trying to change start date on a campaign that has started.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED")] CannotModifyStartDateIfAlreadyStarted = 35,
        /// <summary>
        /// Trying to modify a date into the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_DATE_TO_PAST")] CannotSetDateToPast = 36,
        /// <summary>
        /// Hotel center id in the hotel setting does not match any customer links.
        /// </summary>
        [pbr::OriginalName("MISSING_HOTEL_CUSTOMER_LINK")] MissingHotelCustomerLink = 37,
        /// <summary>
        /// Hotel center id in the hotel setting must match an active customer link.
        /// </summary>
        [pbr::OriginalName("INVALID_HOTEL_CUSTOMER_LINK")] InvalidHotelCustomerLink = 38,
        /// <summary>
        /// Hotel setting was not found when creating a hotel ads campaign.
        /// </summary>
        [pbr::OriginalName("MISSING_HOTEL_SETTING")] MissingHotelSetting = 39,
        /// <summary>
        /// A Campaign cannot use shared campaign budgets and be part of a campaign
        /// group.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_SHARED_CAMPAIGN_BUDGET_WHILE_PART_OF_CAMPAIGN_GROUP")] CannotUseSharedCampaignBudgetWhilePartOfCampaignGroup = 40,
        /// <summary>
        /// The app ID was not found.
        /// </summary>
        [pbr::OriginalName("APP_NOT_FOUND")] AppNotFound = 41,
        /// <summary>
        /// Campaign.shopping_setting.enable_local is not supported for the specified
        /// campaign type.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ENABLE_LOCAL_NOT_SUPPORTED_FOR_CAMPAIGN_TYPE")] ShoppingEnableLocalNotSupportedForCampaignType = 42,
        /// <summary>
        /// The merchant does not support the creation of campaigns for Shopping
        /// Comparison Listing Ads.
        /// </summary>
        [pbr::OriginalName("MERCHANT_NOT_ALLOWED_FOR_COMPARISON_LISTING_ADS")] MerchantNotAllowedForComparisonListingAds = 43,
        /// <summary>
        /// The App campaign for engagement cannot be created because there aren't
        /// enough installs.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_APP_INSTALLS_COUNT")] InsufficientAppInstallsCount = 44,
        /// <summary>
        /// The App campaign for engagement cannot be created because the app is
        /// sensitive.
        /// </summary>
        [pbr::OriginalName("SENSITIVE_CATEGORY_APP")] SensitiveCategoryApp = 45,
        /// <summary>
        /// Customers with Housing, Employment, or Credit ads must accept updated
        /// personalized ads policy to continue creating campaigns.
        /// </summary>
        [pbr::OriginalName("HEC_AGREEMENT_REQUIRED")] HecAgreementRequired = 46,
        /// <summary>
        /// The field is not compatible with view through conversion optimization.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_VIEW_THROUGH_CONVERSION_OPTIMIZATION")] NotCompatibleWithViewThroughConversionOptimization = 49,
        /// <summary>
        /// The field type cannot be excluded because an active campaign-asset link
        /// of this type exists.
        /// </summary>
        [pbr::OriginalName("INVALID_EXCLUDED_PARENT_ASSET_FIELD_TYPE")] InvalidExcludedParentAssetFieldType = 48,
        /// <summary>
        /// The app pre-registration campaign cannot be created for non-Android
        /// applications.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_APP_PRE_REGISTRATION_FOR_NON_ANDROID_APP")] CannotCreateAppPreRegistrationForNonAndroidApp = 50,
        /// <summary>
        /// The campaign cannot be created since the app is not available for
        /// pre-registration in any country.
        /// </summary>
        [pbr::OriginalName("APP_NOT_AVAILABLE_TO_CREATE_APP_PRE_REGISTRATION_CAMPAIGN")] AppNotAvailableToCreateAppPreRegistrationCampaign = 51,
        /// <summary>
        /// The type of the Budget is not compatible with this Campaign.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_BUDGET_TYPE")] IncompatibleBudgetType = 52,
        /// <summary>
        /// Category bid list in the local services campaign setting contains
        /// multiple bids for the same category ID.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICES_DUPLICATE_CATEGORY_BID")] LocalServicesDuplicateCategoryBid = 53,
        /// <summary>
        /// Category bid list in the local services campaign setting contains
        /// a bid for an invalid category ID.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICES_INVALID_CATEGORY_BID")] LocalServicesInvalidCategoryBid = 54,
        /// <summary>
        /// Category bid list in the local services campaign setting is missing a
        /// bid for a category ID that must be present.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICES_MISSING_CATEGORY_BID")] LocalServicesMissingCategoryBid = 55,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
