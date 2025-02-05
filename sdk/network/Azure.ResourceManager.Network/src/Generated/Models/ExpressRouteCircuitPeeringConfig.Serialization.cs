// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdvertisedPublicPrefixes))
            {
                writer.WritePropertyName("advertisedPublicPrefixes");
                writer.WriteStartArray();
                foreach (var item in AdvertisedPublicPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdvertisedCommunities))
            {
                writer.WritePropertyName("advertisedCommunities");
                writer.WriteStartArray();
                foreach (var item in AdvertisedCommunities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LegacyMode))
            {
                writer.WritePropertyName("legacyMode");
                writer.WriteNumberValue(LegacyMode.Value);
            }
            if (Optional.IsDefined(CustomerASN))
            {
                writer.WritePropertyName("customerASN");
                writer.WriteNumberValue(CustomerASN.Value);
            }
            if (Optional.IsDefined(RoutingRegistryName))
            {
                writer.WritePropertyName("routingRegistryName");
                writer.WriteStringValue(RoutingRegistryName);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitPeeringConfig DeserializeExpressRouteCircuitPeeringConfig(JsonElement element)
        {
            Optional<IList<string>> advertisedPublicPrefixes = default;
            Optional<IList<string>> advertisedCommunities = default;
            Optional<ExpressRouteCircuitPeeringAdvertisedPublicPrefixState> advertisedPublicPrefixesState = default;
            Optional<int> legacyMode = default;
            Optional<int> customerASN = default;
            Optional<string> routingRegistryName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advertisedPublicPrefixes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedPublicPrefixes = array;
                    continue;
                }
                if (property.NameEquals("advertisedCommunities"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedCommunities = array;
                    continue;
                }
                if (property.NameEquals("advertisedPublicPrefixesState"))
                {
                    advertisedPublicPrefixesState = new ExpressRouteCircuitPeeringAdvertisedPublicPrefixState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyMode"))
                {
                    legacyMode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customerASN"))
                {
                    customerASN = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("routingRegistryName"))
                {
                    routingRegistryName = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCircuitPeeringConfig(Optional.ToList(advertisedPublicPrefixes), Optional.ToList(advertisedCommunities), Optional.ToNullable(advertisedPublicPrefixesState), Optional.ToNullable(legacyMode), Optional.ToNullable(customerASN), routingRegistryName.Value);
        }
    }
}
