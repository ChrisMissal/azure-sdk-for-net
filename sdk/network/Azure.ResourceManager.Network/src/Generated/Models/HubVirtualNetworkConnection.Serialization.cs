// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubVirtualNetworkConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RemoteVirtualNetwork))
            {
                writer.WritePropertyName("remoteVirtualNetwork");
                writer.WriteObjectValue(RemoteVirtualNetwork);
            }
            if (Optional.IsDefined(AllowHubToRemoteVnetTransit))
            {
                writer.WritePropertyName("allowHubToRemoteVnetTransit");
                writer.WriteBooleanValue(AllowHubToRemoteVnetTransit.Value);
            }
            if (Optional.IsDefined(AllowRemoteVnetToUseHubVnetGateways))
            {
                writer.WritePropertyName("allowRemoteVnetToUseHubVnetGateways");
                writer.WriteBooleanValue(AllowRemoteVnetToUseHubVnetGateways.Value);
            }
            if (Optional.IsDefined(EnableInternetSecurity))
            {
                writer.WritePropertyName("enableInternetSecurity");
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (Optional.IsDefined(RoutingConfiguration))
            {
                writer.WritePropertyName("routingConfiguration");
                writer.WriteObjectValue(RoutingConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HubVirtualNetworkConnection DeserializeHubVirtualNetworkConnection(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<SubResource> remoteVirtualNetwork = default;
            Optional<bool> allowHubToRemoteVnetTransit = default;
            Optional<bool> allowRemoteVnetToUseHubVnetGateways = default;
            Optional<bool> enableInternetSecurity = default;
            Optional<RoutingConfiguration> routingConfiguration = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("remoteVirtualNetwork"))
                        {
                            remoteVirtualNetwork = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowHubToRemoteVnetTransit"))
                        {
                            allowHubToRemoteVnetTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowRemoteVnetToUseHubVnetGateways"))
                        {
                            allowRemoteVnetToUseHubVnetGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"))
                        {
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"))
                        {
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HubVirtualNetworkConnection(id.Value, name.Value, etag.Value, remoteVirtualNetwork.Value, Optional.ToNullable(allowHubToRemoteVnetTransit), Optional.ToNullable(allowRemoteVnetToUseHubVnetGateways), Optional.ToNullable(enableInternetSecurity), routingConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
