// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/services/feed_item_target_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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

namespace Google.Ads.GoogleAds.V8.Services {
  /// <summary>
  /// Service to manage feed item targets.
  /// </summary>
  public static partial class FeedItemTargetService
  {
    static readonly string __ServiceName = "google.ads.googleads.v8.services.FeedItemTargetService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest> __Marshaller_google_ads_googleads_v8_services_GetFeedItemTargetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget> __Marshaller_google_ads_googleads_v8_resources_FeedItemTarget = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest> __Marshaller_google_ads_googleads_v8_services_MutateFeedItemTargetsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse> __Marshaller_google_ads_googleads_v8_services_MutateFeedItemTargetsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest, global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget> __Method_GetFeedItemTarget = new grpc::Method<global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest, global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeedItemTarget",
        __Marshaller_google_ads_googleads_v8_services_GetFeedItemTargetRequest,
        __Marshaller_google_ads_googleads_v8_resources_FeedItemTarget);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest, global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse> __Method_MutateFeedItemTargets = new grpc::Method<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest, global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateFeedItemTargets",
        __Marshaller_google_ads_googleads_v8_services_MutateFeedItemTargetsRequest,
        __Marshaller_google_ads_googleads_v8_services_MutateFeedItemTargetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V8.Services.FeedItemTargetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FeedItemTargetService</summary>
    [grpc::BindServiceMethod(typeof(FeedItemTargetService), "BindService")]
    public abstract partial class FeedItemTargetServiceBase
    {
      /// <summary>
      /// Returns the requested feed item targets in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget> GetFeedItemTarget(global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes feed item targets. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CriterionError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FeedItemTargetError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse> MutateFeedItemTargets(global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FeedItemTargetService</summary>
    public partial class FeedItemTargetServiceClient : grpc::ClientBase<FeedItemTargetServiceClient>
    {
      /// <summary>Creates a new client for FeedItemTargetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FeedItemTargetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FeedItemTargetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FeedItemTargetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FeedItemTargetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FeedItemTargetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested feed item targets in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget GetFeedItemTarget(global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeedItemTarget(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed item targets in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget GetFeedItemTarget(global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeedItemTarget, null, options, request);
      }
      /// <summary>
      /// Returns the requested feed item targets in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget> GetFeedItemTargetAsync(global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeedItemTargetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed item targets in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget> GetFeedItemTargetAsync(global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeedItemTarget, null, options, request);
      }
      /// <summary>
      /// Creates or removes feed item targets. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CriterionError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FeedItemTargetError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse MutateFeedItemTargets(global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateFeedItemTargets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes feed item targets. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CriterionError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FeedItemTargetError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse MutateFeedItemTargets(global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateFeedItemTargets, null, options, request);
      }
      /// <summary>
      /// Creates or removes feed item targets. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CriterionError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FeedItemTargetError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateFeedItemTargetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes feed item targets. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CriterionError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FeedItemTargetError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateFeedItemTargets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FeedItemTargetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FeedItemTargetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FeedItemTargetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFeedItemTarget, serviceImpl.GetFeedItemTarget)
          .AddMethod(__Method_MutateFeedItemTargets, serviceImpl.MutateFeedItemTargets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FeedItemTargetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetFeedItemTarget, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V8.Services.GetFeedItemTargetRequest, global::Google.Ads.GoogleAds.V8.Resources.FeedItemTarget>(serviceImpl.GetFeedItemTarget));
      serviceBinder.AddMethod(__Method_MutateFeedItemTargets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsRequest, global::Google.Ads.GoogleAds.V8.Services.MutateFeedItemTargetsResponse>(serviceImpl.MutateFeedItemTargets));
    }

  }
}
#endregion