// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataAnomaly
    {
        internal static DataAnomaly DeserializeDataAnomaly(JsonElement element)
        {
            Optional<string> metricId = default;
            Optional<string> anomalyDetectionConfigurationId = default;
            DateTimeOffset timestamp = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> modifiedTime = default;
            IReadOnlyDictionary<string, string> dimension = default;
            AnomalyProperty property = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("metricId"))
                {
                    metricId = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("anomalyDetectionConfigurationId"))
                {
                    anomalyDetectionConfigurationId = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("timestamp"))
                {
                    timestamp = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("createdTime"))
                {
                    createdTime = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("modifiedTime"))
                {
                    modifiedTime = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("dimension"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property1 in property0.Value.EnumerateObject())
                    {
                        dictionary.Add(property1.Name, property1.Value.GetString());
                    }
                    dimension = dictionary;
                    continue;
                }
                if (property0.NameEquals("property"))
                {
                    property = AnomalyProperty.DeserializeAnomalyProperty(property0.Value);
                    continue;
                }
            }
            return new DataAnomaly(metricId.Value, anomalyDetectionConfigurationId.Value, timestamp, Optional.ToNullable(createdTime), Optional.ToNullable(modifiedTime), dimension, property);
        }
    }
}
