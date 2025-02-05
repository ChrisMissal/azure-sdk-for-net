// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class TimeSeriesBaseline
    {
        internal static TimeSeriesBaseline DeserializeTimeSeriesBaseline(JsonElement element)
        {
            string aggregation = default;
            Optional<IReadOnlyList<MetricSingleDimension>> dimensions = default;
            IReadOnlyList<DateTimeOffset> timestamps = default;
            IReadOnlyList<SingleBaseline> data = default;
            Optional<IReadOnlyList<BaselineMetadata>> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"))
                {
                    aggregation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    List<MetricSingleDimension> array = new List<MetricSingleDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSingleDimension.DeserializeMetricSingleDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("timestamps"))
                {
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    timestamps = array;
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    List<SingleBaseline> array = new List<SingleBaseline>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SingleBaseline.DeserializeSingleBaseline(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    List<BaselineMetadata> array = new List<BaselineMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BaselineMetadata.DeserializeBaselineMetadata(item));
                    }
                    metadata = array;
                    continue;
                }
            }
            return new TimeSeriesBaseline(aggregation, Optional.ToList(dimensions), timestamps, data, Optional.ToList(metadata));
        }
    }
}
