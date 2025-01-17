// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> MarketplaceDetails of Qumulo FileSystem resource. </summary>
    public partial class MarketplaceDetails
    {
        /// <summary> Initializes a new instance of MarketplaceDetails. </summary>
        /// <param name="planId"> Plan Id. </param>
        /// <param name="offerId"> Offer Id. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="planId"/>, <paramref name="offerId"/> or <paramref name="publisherId"/> is null. </exception>
        public MarketplaceDetails(string planId, string offerId, string publisherId)
        {
            Argument.AssertNotNull(planId, nameof(planId));
            Argument.AssertNotNull(offerId, nameof(offerId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            PlanId = planId;
            OfferId = offerId;
            PublisherId = publisherId;
        }

        /// <summary> Initializes a new instance of MarketplaceDetails. </summary>
        /// <param name="marketplaceSubscriptionId"> Marketplace Subscription Id. </param>
        /// <param name="planId"> Plan Id. </param>
        /// <param name="offerId"> Offer Id. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="marketplaceSubscriptionStatus"> Marketplace subscription status. </param>
        internal MarketplaceDetails(string marketplaceSubscriptionId, string planId, string offerId, string publisherId, MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus)
        {
            MarketplaceSubscriptionId = marketplaceSubscriptionId;
            PlanId = planId;
            OfferId = offerId;
            PublisherId = publisherId;
            MarketplaceSubscriptionStatus = marketplaceSubscriptionStatus;
        }

        /// <summary> Marketplace Subscription Id. </summary>
        public string MarketplaceSubscriptionId { get; set; }
        /// <summary> Plan Id. </summary>
        public string PlanId { get; set; }
        /// <summary> Offer Id. </summary>
        public string OfferId { get; set; }
        /// <summary> Publisher Id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Marketplace subscription status. </summary>
        public MarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; }
    }
}
