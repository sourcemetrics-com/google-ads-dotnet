// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>FeedItem</c> resource.</summary>
    public sealed partial class FeedItemName : gax::IResourceName, sys::IEquatable<FeedItemName>
    {
        /// <summary>The possible contents of <see cref="FeedItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
            /// </summary>
            CustomerFeedFeedItem = 1,
        }

        private static gax::PathTemplate s_customerFeedFeedItem = new gax::PathTemplate("customers/{customer_id}/feedItems/{feed_id_feed_item_id}");

        /// <summary>Creates a <see cref="FeedItemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedItemName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static FeedItemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedItemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedItemName"/> with the pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedItemName"/> constructed from the provided ids.</returns>
        public static FeedItemName FromCustomerFeedFeedItem(string customerId, string feedId, string feedItemId) =>
            new FeedItemName(ResourceNameType.CustomerFeedFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)), feedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
        /// </returns>
        public static string Format(string customerId, string feedId, string feedItemId) =>
            FormatCustomerFeedFeedItem(customerId, feedId, feedItemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>.
        /// </returns>
        public static string FormatCustomerFeedFeedItem(string customerId, string feedId, string feedItemId) =>
            s_customerFeedFeedItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="FeedItemName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemName"/> if successful.</returns>
        public static FeedItemName Parse(string feedItemName) => Parse(feedItemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedItemName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedItemName"/> if successful.</returns>
        public static FeedItemName Parse(string feedItemName, bool allowUnparsed) =>
            TryParse(feedItemName, allowUnparsed, out FeedItemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemName, out FeedItemName result) => TryParse(feedItemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemName, bool allowUnparsed, out FeedItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemName, nameof(feedItemName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeedFeedItem.TryParseName(feedItemName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerFeedFeedItem(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedItemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private FeedItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedId = null, string feedItemId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedId = feedId;
            FeedItemId = feedItemId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedItemName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedItemName(string customerId, string feedId, string feedItemId) : this(ResourceNameType.CustomerFeedFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)), feedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Feed</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedId { get; }

        /// <summary>
        /// The <c>FeedItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedItemId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeedFeedItem: return s_customerFeedFeedItem.Expand(CustomerId, $"{FeedId}~{FeedItemId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedItemName);

        /// <inheritdoc/>
        public bool Equals(FeedItemName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeedItemName a, FeedItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeedItemName a, FeedItemName b) => !(a == b);
    }

    public partial class FeedItem
    {
        /// <summary>
        /// <see cref="FeedItemName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal FeedItemName ResourceNameAsFeedItemName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FeedItemName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary><see cref="FeedName"/>-typed view over the <see cref="Feed"/> resource name property.</summary>
        internal FeedName FeedAsFeedName
        {
            get => string.IsNullOrEmpty(Feed) ? null : FeedName.Parse(Feed, allowUnparsed: true);
            set => Feed = value?.ToString() ?? "";
        }
    }
}
