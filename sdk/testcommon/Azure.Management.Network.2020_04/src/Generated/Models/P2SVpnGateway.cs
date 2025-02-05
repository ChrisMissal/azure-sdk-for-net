// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> P2SVpnGateway Resource. </summary>
    public partial class P2SVpnGateway : Resource
    {
        /// <summary> Initializes a new instance of P2SVpnGateway. </summary>
        public P2SVpnGateway()
        {
            P2SConnectionConfigurations = new ChangeTrackingList<P2SConnectionConfiguration>();
        }

        /// <summary> Initializes a new instance of P2SVpnGateway. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualHub"> The VirtualHub to which the gateway belongs. </param>
        /// <param name="p2SConnectionConfigurations"> List of all p2s connection configurations of the gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the P2S VPN gateway resource. </param>
        /// <param name="vpnGatewayScaleUnit"> The scale unit for this p2s vpn gateway. </param>
        /// <param name="vpnServerConfiguration"> The VpnServerConfiguration to which the p2sVpnGateway is attached to. </param>
        /// <param name="vpnClientConnectionHealth"> All P2S VPN clients&apos; connection health status. </param>
        internal P2SVpnGateway(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, SubResource virtualHub, IList<P2SConnectionConfiguration> p2SConnectionConfigurations, ProvisioningState? provisioningState, int? vpnGatewayScaleUnit, SubResource vpnServerConfiguration, VpnClientConnectionHealth vpnClientConnectionHealth) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualHub = virtualHub;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            VpnServerConfiguration = vpnServerConfiguration;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualHub to which the gateway belongs. </summary>
        public SubResource VirtualHub { get; set; }
        /// <summary> List of all p2s connection configurations of the gateway. </summary>
        public IList<P2SConnectionConfiguration> P2SConnectionConfigurations { get; }
        /// <summary> The provisioning state of the P2S VPN gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The scale unit for this p2s vpn gateway. </summary>
        public int? VpnGatewayScaleUnit { get; set; }
        /// <summary> The VpnServerConfiguration to which the p2sVpnGateway is attached to. </summary>
        public SubResource VpnServerConfiguration { get; set; }
        /// <summary> All P2S VPN clients&apos; connection health status. </summary>
        public VpnClientConnectionHealth VpnClientConnectionHealth { get; }
    }
}
