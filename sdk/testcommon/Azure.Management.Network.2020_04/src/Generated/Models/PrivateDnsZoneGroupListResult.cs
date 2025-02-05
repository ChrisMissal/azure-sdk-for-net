// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListPrivateDnsZoneGroups API service call. </summary>
    public partial class PrivateDnsZoneGroupListResult
    {
        /// <summary> Initializes a new instance of PrivateDnsZoneGroupListResult. </summary>
        internal PrivateDnsZoneGroupListResult()
        {
            Value = new ChangeTrackingList<PrivateDnsZoneGroup>();
        }

        /// <summary> Initializes a new instance of PrivateDnsZoneGroupListResult. </summary>
        /// <param name="value"> A list of private dns zone group resources in a private endpoint. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PrivateDnsZoneGroupListResult(IReadOnlyList<PrivateDnsZoneGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of private dns zone group resources in a private endpoint. </summary>
        public IReadOnlyList<PrivateDnsZoneGroup> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
