// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/user_list_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/user_list_error.proto</summary>
  public static partial class UserListErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/user_list_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL3VzZXJfbGlzdF9l",
            "cnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEzLmVycm9ycyLB",
            "CAoRVXNlckxpc3RFcnJvckVudW0iqwgKDVVzZXJMaXN0RXJyb3ISDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESNwozRVhURVJOQUxfUkVNQVJLRVRJ",
            "TkdfVVNFUl9MSVNUX01VVEFURV9OT1RfU1VQUE9SVEVEEAISGgoWQ09OQ1JF",
            "VEVfVFlQRV9SRVFVSVJFRBADEh8KG0NPTlZFUlNJT05fVFlQRV9JRF9SRVFV",
            "SVJFRBAEEh4KGkRVUExJQ0FURV9DT05WRVJTSU9OX1RZUEVTEAUSGwoXSU5W",
            "QUxJRF9DT05WRVJTSU9OX1RZUEUQBhIXChNJTlZBTElEX0RFU0NSSVBUSU9O",
            "EAcSEAoMSU5WQUxJRF9OQU1FEAgSEAoMSU5WQUxJRF9UWVBFEAkSNAowQ0FO",
            "X05PVF9BRERfTE9HSUNBTF9MSVNUX0FTX0xPR0lDQUxfTElTVF9PUEVSQU5E",
            "EAoSKgomSU5WQUxJRF9VU0VSX0xJU1RfTE9HSUNBTF9SVUxFX09QRVJBTkQQ",
            "CxIVChFOQU1FX0FMUkVBRFlfVVNFRBAMEiUKIU5FV19DT05WRVJTSU9OX1RZ",
            "UEVfTkFNRV9SRVFVSVJFRBANEiUKIUNPTlZFUlNJT05fVFlQRV9OQU1FX0FM",
            "UkVBRFlfVVNFRBAOEh4KGk9XTkVSU0hJUF9SRVFVSVJFRF9GT1JfU0VUEA8S",
            "IgoeVVNFUl9MSVNUX01VVEFURV9OT1RfU1VQUE9SVEVEEBASEAoMSU5WQUxJ",
            "RF9SVUxFEBESFgoSSU5WQUxJRF9EQVRFX1JBTkdFEBsSJQohQ0FOX05PVF9N",
            "VVRBVEVfU0VOU0lUSVZFX1VTRVJMSVNUEBwSHwobTUFYX05VTV9SVUxFQkFT",
            "RURfVVNFUkxJU1RTEB0SJwojQ0FOTk9UX01PRElGWV9CSUxMQUJMRV9SRUNP",
            "UkRfQ09VTlQQHhISCg5BUFBfSURfTk9UX1NFVBAfEi0KKVVTRVJMSVNUX05B",
            "TUVfSVNfUkVTRVJWRURfRk9SX1NZU1RFTV9MSVNUECASNwozQURWRVJUSVNF",
            "Ul9OT1RfT05fQUxMT1dMSVNUX0ZPUl9VU0lOR19VUExPQURFRF9EQVRBECUS",
            "HgoaUlVMRV9UWVBFX0lTX05PVF9TVVBQT1JURUQQIhI6CjZDQU5fTk9UX0FE",
            "RF9BX1NJTUlMQVJfVVNFUkxJU1RfQVNfTE9HSUNBTF9MSVNUX09QRVJBTkQQ",
            "IxI6CjZDQU5fTk9UX01JWF9DUk1fQkFTRURfSU5fTE9HSUNBTF9MSVNUX1dJ",
            "VEhfT1RIRVJfTElTVFMQJBIWChJBUFBfSURfTk9UX0FMTE9XRUQQJxIdChlD",
            "QU5OT1RfTVVUQVRFX1NZU1RFTV9MSVNUECgSGwoXTU9CSUxFX0FQUF9JU19T",
            "RU5TSVRJVkUQKULyAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMy5l",
            "cnJvcnNCElVzZXJMaXN0RXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEzL2Vycm9y",
            "cztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTMuRXJy",
            "b3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEzXEVycm9yc+oCI0dvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxMzo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.UserListErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.UserListErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.UserListErrorEnum.Types.UserListError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible user list errors.
  /// </summary>
  public sealed partial class UserListErrorEnum : pb::IMessage<UserListErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserListErrorEnum> _parser = new pb::MessageParser<UserListErrorEnum>(() => new UserListErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserListErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.UserListErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListErrorEnum(UserListErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListErrorEnum Clone() {
      return new UserListErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserListErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserListErrorEnum other) {
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
    public void MergeFrom(UserListErrorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list errors.
      /// </summary>
      public enum UserListError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Creating and updating external remarketing user lists is not supported.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED")] ExternalRemarketingUserListMutateNotSupported = 2,
        /// <summary>
        /// Concrete type of user list is required.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 3,
        /// <summary>
        /// Creating/updating user list conversion types requires specifying the
        /// conversion type Id.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_ID_REQUIRED")] ConversionTypeIdRequired = 4,
        /// <summary>
        /// Remarketing user list cannot have duplicate conversion types.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CONVERSION_TYPES")] DuplicateConversionTypes = 5,
        /// <summary>
        /// Conversion type is invalid/unknown.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_TYPE")] InvalidConversionType = 6,
        /// <summary>
        /// User list description is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_DESCRIPTION")] InvalidDescription = 7,
        /// <summary>
        /// User list name is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_NAME")] InvalidName = 8,
        /// <summary>
        /// Type of the UserList does not match.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE")] InvalidType = 9,
        /// <summary>
        /// Embedded logical user lists are not allowed.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_ADD_LOGICAL_LIST_AS_LOGICAL_LIST_OPERAND")] CanNotAddLogicalListAsLogicalListOperand = 10,
        /// <summary>
        /// User list rule operand is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_LOGICAL_RULE_OPERAND")] InvalidUserListLogicalRuleOperand = 11,
        /// <summary>
        /// Name is already being used for another user list for the account.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_USED")] NameAlreadyUsed = 12,
        /// <summary>
        /// Name is required when creating a new conversion type.
        /// </summary>
        [pbr::OriginalName("NEW_CONVERSION_TYPE_NAME_REQUIRED")] NewConversionTypeNameRequired = 13,
        /// <summary>
        /// The given conversion type name has been used.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_NAME_ALREADY_USED")] ConversionTypeNameAlreadyUsed = 14,
        /// <summary>
        /// Only an owner account may edit a user list.
        /// </summary>
        [pbr::OriginalName("OWNERSHIP_REQUIRED_FOR_SET")] OwnershipRequiredForSet = 15,
        /// <summary>
        /// Creating user list without setting type in oneof user_list field, or
        /// creating/updating read-only user list types is not allowed.
        /// </summary>
        [pbr::OriginalName("USER_LIST_MUTATE_NOT_SUPPORTED")] UserListMutateNotSupported = 16,
        /// <summary>
        /// Rule is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_RULE")] InvalidRule = 17,
        /// <summary>
        /// The specified date range is empty.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_RANGE")] InvalidDateRange = 27,
        /// <summary>
        /// A UserList which is privacy sensitive or legal rejected cannot be mutated
        /// by external users.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_MUTATE_SENSITIVE_USERLIST")] CanNotMutateSensitiveUserlist = 28,
        /// <summary>
        /// Maximum number of rulebased user lists a customer can have.
        /// </summary>
        [pbr::OriginalName("MAX_NUM_RULEBASED_USERLISTS")] MaxNumRulebasedUserlists = 29,
        /// <summary>
        /// BasicUserList's billable record field cannot be modified once it is set.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_BILLABLE_RECORD_COUNT")] CannotModifyBillableRecordCount = 30,
        /// <summary>
        /// crm_based_user_list.app_id field must be set when upload_key_type is
        /// MOBILE_ADVERTISING_ID.
        /// </summary>
        [pbr::OriginalName("APP_ID_NOT_SET")] AppIdNotSet = 31,
        /// <summary>
        /// Name of the user list is reserved for system generated lists and cannot
        /// be used.
        /// </summary>
        [pbr::OriginalName("USERLIST_NAME_IS_RESERVED_FOR_SYSTEM_LIST")] UserlistNameIsReservedForSystemList = 32,
        /// <summary>
        /// Advertiser needs to be on the allow-list to use remarketing lists created
        /// from advertiser uploaded data (for example, Customer Match lists).
        /// </summary>
        [pbr::OriginalName("ADVERTISER_NOT_ON_ALLOWLIST_FOR_USING_UPLOADED_DATA")] AdvertiserNotOnAllowlistForUsingUploadedData = 37,
        /// <summary>
        /// The provided rule_type is not supported for the user list.
        /// </summary>
        [pbr::OriginalName("RULE_TYPE_IS_NOT_SUPPORTED")] RuleTypeIsNotSupported = 34,
        /// <summary>
        /// Similar user list cannot be used as a logical user list operand.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_ADD_A_SIMILAR_USERLIST_AS_LOGICAL_LIST_OPERAND")] CanNotAddASimilarUserlistAsLogicalListOperand = 35,
        /// <summary>
        /// Logical user list should not have a mix of CRM based user list and other
        /// types of lists in its rules.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_MIX_CRM_BASED_IN_LOGICAL_LIST_WITH_OTHER_LISTS")] CanNotMixCrmBasedInLogicalListWithOtherLists = 36,
        /// <summary>
        /// crm_based_user_list.app_id field can only be set when upload_key_type is
        /// MOBILE_ADVERTISING_ID.
        /// </summary>
        [pbr::OriginalName("APP_ID_NOT_ALLOWED")] AppIdNotAllowed = 39,
        /// <summary>
        /// Google system generated user lists cannot be mutated.
        /// </summary>
        [pbr::OriginalName("CANNOT_MUTATE_SYSTEM_LIST")] CannotMutateSystemList = 40,
        /// <summary>
        /// The mobile app associated with the remarketing list is sensitive.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_IS_SENSITIVE")] MobileAppIsSensitive = 41,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
