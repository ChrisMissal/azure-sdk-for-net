// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsDeliveryAttemptProperties
    {
        internal static AcsSmsDeliveryAttemptProperties DeserializeAcsSmsDeliveryAttemptProperties(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<int> segmentsSucceeded = default;
            Optional<int> segmentsFailed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("segmentsSucceeded"))
                {
                    segmentsSucceeded = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("segmentsFailed"))
                {
                    segmentsFailed = property.Value.GetInt32();
                    continue;
                }
            }
            return new AcsSmsDeliveryAttemptProperties(Optional.ToNullable(timestamp), Optional.ToNullable(segmentsSucceeded), Optional.ToNullable(segmentsFailed));
        }
    }
}
