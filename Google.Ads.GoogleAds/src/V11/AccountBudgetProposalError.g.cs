// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/account_budget_proposal_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/account_budget_proposal_error.proto</summary>
  public static partial class AccountBudgetProposalErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/account_budget_proposal_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountBudgetProposalErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2FjY291bnRfYnVk",
            "Z2V0X3Byb3Bvc2FsX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTEuZXJyb3JzIpgHCh5BY2NvdW50QnVkZ2V0UHJvcG9zYWxFcnJvckVu",
            "dW0i9QYKGkFjY291bnRCdWRnZXRQcm9wb3NhbEVycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhoKFkZJRUxEX01BU0tfTk9UX0FMTE9XRUQQ",
            "AhITCg9JTU1VVEFCTEVfRklFTEQQAxIaChZSRVFVSVJFRF9GSUVMRF9NSVNT",
            "SU5HEAQSIwofQ0FOTk9UX0NBTkNFTF9BUFBST1ZFRF9QUk9QT1NBTBAFEiMK",
            "H0NBTk5PVF9SRU1PVkVfVU5BUFBST1ZFRF9CVURHRVQQBhIgChxDQU5OT1Rf",
            "UkVNT1ZFX1JVTk5JTkdfQlVER0VUEAcSIAocQ0FOTk9UX0VORF9VTkFQUFJP",
            "VkVEX0JVREdFVBAIEh4KGkNBTk5PVF9FTkRfSU5BQ1RJVkVfQlVER0VUEAkS",
            "GAoUQlVER0VUX05BTUVfUkVRVUlSRUQQChIcChhDQU5OT1RfVVBEQVRFX09M",
            "RF9CVURHRVQQCxIWChJDQU5OT1RfRU5EX0lOX1BBU1QQDBIaChZDQU5OT1Rf",
            "RVhURU5EX0VORF9USU1FEA0SIgoeUFVSQ0hBU0VfT1JERVJfTlVNQkVSX1JF",
            "UVVJUkVEEA4SIgoeUEVORElOR19VUERBVEVfUFJPUE9TQUxfRVhJU1RTEA8S",
            "PQo5TVVMVElQTEVfQlVER0VUU19OT1RfQUxMT1dFRF9GT1JfVU5BUFBST1ZF",
            "RF9CSUxMSU5HX1NFVFVQEBASLworQ0FOTk9UX1VQREFURV9TVEFSVF9USU1F",
            "X0ZPUl9TVEFSVEVEX0JVREdFVBAREjYKMlNQRU5ESU5HX0xJTUlUX0xPV0VS",
            "X1RIQU5fQUNDUlVFRF9DT1NUX05PVF9BTExPV0VEEBISEwoPVVBEQVRFX0lT",
            "X05PX09QEBMSIwofRU5EX1RJTUVfTVVTVF9GT0xMT1dfU1RBUlRfVElNRRAU",
            "EjUKMUJVREdFVF9EQVRFX1JBTkdFX0lOQ09NUEFUSUJMRV9XSVRIX0JJTExJ",
            "TkdfU0VUVVAQFRISCg5OT1RfQVVUSE9SSVpFRBAWEhkKFUlOVkFMSURfQklM",
            "TElOR19TRVRVUBAXEhwKGE9WRVJMQVBTX0VYSVNUSU5HX0JVREdFVBAYEiQK",
            "IENBTk5PVF9DUkVBVEVfQlVER0VUX1RIUk9VR0hfQVBJEBlC/wEKI2NvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZXJyb3JzQh9BY2NvdW50QnVkZ2V0",
            "UHJvcG9zYWxFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzO2Vycm9y",
            "c6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5FcnJvcnPKAh9H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjExOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.AccountBudgetProposalErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.AccountBudgetProposalErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.AccountBudgetProposalErrorEnum.Types.AccountBudgetProposalError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible account budget proposal errors.
  /// </summary>
  public sealed partial class AccountBudgetProposalErrorEnum : pb::IMessage<AccountBudgetProposalErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccountBudgetProposalErrorEnum> _parser = new pb::MessageParser<AccountBudgetProposalErrorEnum>(() => new AccountBudgetProposalErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccountBudgetProposalErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.AccountBudgetProposalErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum(AccountBudgetProposalErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum Clone() {
      return new AccountBudgetProposalErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccountBudgetProposalErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccountBudgetProposalErrorEnum other) {
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
    public void MergeFrom(AccountBudgetProposalErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AccountBudgetProposalErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible account budget proposal errors.
      /// </summary>
      public enum AccountBudgetProposalError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The field mask must be empty for create/end/remove proposals.
        /// </summary>
        [pbr::OriginalName("FIELD_MASK_NOT_ALLOWED")] FieldMaskNotAllowed = 2,
        /// <summary>
        /// The field cannot be set because of the proposal type.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 3,
        /// <summary>
        /// The field is required because of the proposal type.
        /// </summary>
        [pbr::OriginalName("REQUIRED_FIELD_MISSING")] RequiredFieldMissing = 4,
        /// <summary>
        /// Proposals that have been approved cannot be cancelled.
        /// </summary>
        [pbr::OriginalName("CANNOT_CANCEL_APPROVED_PROPOSAL")] CannotCancelApprovedProposal = 5,
        /// <summary>
        /// Budgets that haven't been approved cannot be removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_UNAPPROVED_BUDGET")] CannotRemoveUnapprovedBudget = 6,
        /// <summary>
        /// Budgets that are currently running cannot be removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_RUNNING_BUDGET")] CannotRemoveRunningBudget = 7,
        /// <summary>
        /// Budgets that haven't been approved cannot be truncated.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_UNAPPROVED_BUDGET")] CannotEndUnapprovedBudget = 8,
        /// <summary>
        /// Only budgets that are currently running can be truncated.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_INACTIVE_BUDGET")] CannotEndInactiveBudget = 9,
        /// <summary>
        /// All budgets must have names.
        /// </summary>
        [pbr::OriginalName("BUDGET_NAME_REQUIRED")] BudgetNameRequired = 10,
        /// <summary>
        /// Expired budgets cannot be edited after a sufficient amount of time has
        /// passed.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_OLD_BUDGET")] CannotUpdateOldBudget = 11,
        /// <summary>
        /// It is not permissible a propose a new budget that ends in the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_IN_PAST")] CannotEndInPast = 12,
        /// <summary>
        /// An expired budget cannot be extended to overlap with the running budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXTEND_END_TIME")] CannotExtendEndTime = 13,
        /// <summary>
        /// A purchase order number is required.
        /// </summary>
        [pbr::OriginalName("PURCHASE_ORDER_NUMBER_REQUIRED")] PurchaseOrderNumberRequired = 14,
        /// <summary>
        /// Budgets that have a pending update cannot be updated.
        /// </summary>
        [pbr::OriginalName("PENDING_UPDATE_PROPOSAL_EXISTS")] PendingUpdateProposalExists = 15,
        /// <summary>
        /// Cannot propose more than one budget when the corresponding billing setup
        /// hasn't been approved.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_BUDGETS_NOT_ALLOWED_FOR_UNAPPROVED_BILLING_SETUP")] MultipleBudgetsNotAllowedForUnapprovedBillingSetup = 16,
        /// <summary>
        /// Cannot update the start time of a budget that has already started.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_START_TIME_FOR_STARTED_BUDGET")] CannotUpdateStartTimeForStartedBudget = 17,
        /// <summary>
        /// Cannot update the spending limit of a budget with an amount lower than
        /// what has already been spent.
        /// </summary>
        [pbr::OriginalName("SPENDING_LIMIT_LOWER_THAN_ACCRUED_COST_NOT_ALLOWED")] SpendingLimitLowerThanAccruedCostNotAllowed = 18,
        /// <summary>
        /// Cannot propose a budget update without actually changing any fields.
        /// </summary>
        [pbr::OriginalName("UPDATE_IS_NO_OP")] UpdateIsNoOp = 19,
        /// <summary>
        /// The end time must come after the start time.
        /// </summary>
        [pbr::OriginalName("END_TIME_MUST_FOLLOW_START_TIME")] EndTimeMustFollowStartTime = 20,
        /// <summary>
        /// The budget's date range must fall within the date range of its billing
        /// setup.
        /// </summary>
        [pbr::OriginalName("BUDGET_DATE_RANGE_INCOMPATIBLE_WITH_BILLING_SETUP")] BudgetDateRangeIncompatibleWithBillingSetup = 21,
        /// <summary>
        /// The user is not authorized to mutate budgets for the given billing setup.
        /// </summary>
        [pbr::OriginalName("NOT_AUTHORIZED")] NotAuthorized = 22,
        /// <summary>
        /// Mutates are not allowed for the given billing setup.
        /// </summary>
        [pbr::OriginalName("INVALID_BILLING_SETUP")] InvalidBillingSetup = 23,
        /// <summary>
        /// Budget creation failed as it overlaps with an pending budget proposal
        /// or an approved budget.
        /// </summary>
        [pbr::OriginalName("OVERLAPS_EXISTING_BUDGET")] OverlapsExistingBudget = 24,
        /// <summary>
        /// The control setting in user's payments profile doesn't allow budget
        /// creation through API. Log in to Google Ads to create budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_BUDGET_THROUGH_API")] CannotCreateBudgetThroughApi = 25,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
