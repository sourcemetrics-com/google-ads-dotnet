// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/account_link_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// This service allows management of links between Google Ads accounts and other
  /// accounts.
  /// </summary>
  public static partial class AccountLinkService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.AccountLinkService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest> __Marshaller_google_ads_googleads_v4_services_GetAccountLinkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.AccountLink> __Marshaller_google_ads_googleads_v4_resources_AccountLink = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.AccountLink.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest> __Marshaller_google_ads_googleads_v4_services_MutateAccountLinkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse> __Marshaller_google_ads_googleads_v4_services_MutateAccountLinkResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountLink> __Method_GetAccountLink = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountLink>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountLink",
        __Marshaller_google_ads_googleads_v4_services_GetAccountLinkRequest,
        __Marshaller_google_ads_googleads_v4_resources_AccountLink);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse> __Method_MutateAccountLink = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAccountLink",
        __Marshaller_google_ads_googleads_v4_services_MutateAccountLinkRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateAccountLinkResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.AccountLinkServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountLinkService</summary>
    [grpc::BindServiceMethod(typeof(AccountLinkService), "BindService")]
    public abstract partial class AccountLinkServiceBase
    {
      /// <summary>
      /// Returns the account link in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.AccountLink> GetAccountLink(global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes an account link.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse> MutateAccountLink(global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountLinkService</summary>
    public partial class AccountLinkServiceClient : grpc::ClientBase<AccountLinkServiceClient>
    {
      /// <summary>Creates a new client for AccountLinkService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountLinkServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountLinkService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountLinkServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountLinkServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountLinkServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the account link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AccountLink GetAccountLink(global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the account link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AccountLink GetAccountLink(global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccountLink, null, options, request);
      }
      /// <summary>
      /// Returns the account link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AccountLink> GetAccountLinkAsync(global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the account link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AccountLink> GetAccountLinkAsync(global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccountLink, null, options, request);
      }
      /// <summary>
      /// Creates or removes an account link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse MutateAccountLink(global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAccountLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes an account link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse MutateAccountLink(global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAccountLink, null, options, request);
      }
      /// <summary>
      /// Creates or removes an account link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse> MutateAccountLinkAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAccountLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes an account link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse> MutateAccountLinkAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAccountLink, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccountLinkServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountLinkServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AccountLinkServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAccountLink, serviceImpl.GetAccountLink)
          .AddMethod(__Method_MutateAccountLink, serviceImpl.MutateAccountLink).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountLinkServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAccountLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountLink>(serviceImpl.GetAccountLink));
      serviceBinder.AddMethod(__Method_MutateAccountLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountLinkResponse>(serviceImpl.MutateAccountLink));
    }

  }
}
#endregion