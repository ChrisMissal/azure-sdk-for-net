// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PrivateEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceConnections))
            {
                writer.WritePropertyName("privateLinkServiceConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections");
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomDnsConfigs))
            {
                writer.WritePropertyName("customDnsConfigs");
                writer.WriteStartArray();
                foreach (var item in CustomDnsConfigs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateEndpoint DeserializePrivateEndpoint(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<Subnet> subnet = default;
            Optional<IReadOnlyList<NetworkInterface>> networkInterfaces = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<PrivateLinkServiceConnection>> privateLinkServiceConnections = default;
            Optional<IList<PrivateLinkServiceConnection>> manualPrivateLinkServiceConnections = default;
            Optional<IList<CustomDnsConfigPropertiesFormat>> customDnsConfigs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnet"))
                        {
                            subnet = Subnet.DeserializeSubnet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"))
                        {
                            List<NetworkInterface> array = new List<NetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterface.DeserializeNetworkInterface(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnections"))
                        {
                            List<PrivateLinkServiceConnection> array = new List<PrivateLinkServiceConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateLinkServiceConnection.DeserializePrivateLinkServiceConnection(item));
                            }
                            privateLinkServiceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("manualPrivateLinkServiceConnections"))
                        {
                            List<PrivateLinkServiceConnection> array = new List<PrivateLinkServiceConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateLinkServiceConnection.DeserializePrivateLinkServiceConnection(item));
                            }
                            manualPrivateLinkServiceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("customDnsConfigs"))
                        {
                            List<CustomDnsConfigPropertiesFormat> array = new List<CustomDnsConfigPropertiesFormat>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomDnsConfigPropertiesFormat.DeserializeCustomDnsConfigPropertiesFormat(item));
                            }
                            customDnsConfigs = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateEndpoint(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, subnet.Value, Optional.ToList(networkInterfaces), Optional.ToNullable(provisioningState), Optional.ToList(privateLinkServiceConnections), Optional.ToList(manualPrivateLinkServiceConnections), Optional.ToList(customDnsConfigs));
        }
    }
}
