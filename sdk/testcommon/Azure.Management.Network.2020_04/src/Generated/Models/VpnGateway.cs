// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> VpnGateway Resource. </summary>
    public partial class VpnGateway : Resource
    {
        /// <summary> Initializes a new instance of VpnGateway. </summary>
        public VpnGateway()
        {
            Connections = new ChangeTrackingList<VpnConnection>();
        }

        /// <summary> Initializes a new instance of VpnGateway. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualHub"> The VirtualHub to which the gateway belongs. </param>
        /// <param name="connections"> List of all vpn connections to the gateway. </param>
        /// <param name="bgpSettings"> Local network gateway&apos;s BGP speaker settings. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN gateway resource. </param>
        /// <param name="vpnGatewayScaleUnit"> The scale unit for this vpn gateway. </param>
        internal VpnGateway(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, SubResource virtualHub, IList<VpnConnection> connections, BgpSettings bgpSettings, ProvisioningState? provisioningState, int? vpnGatewayScaleUnit) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualHub = virtualHub;
            Connections = connections;
            BgpSettings = bgpSettings;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualHub to which the gateway belongs. </summary>
        public SubResource VirtualHub { get; set; }
        /// <summary> List of all vpn connections to the gateway. </summary>
        public IList<VpnConnection> Connections { get; }
        /// <summary> Local network gateway&apos;s BGP speaker settings. </summary>
        public BgpSettings BgpSettings { get; set; }
        /// <summary> The provisioning state of the VPN gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The scale unit for this vpn gateway. </summary>
        public int? VpnGatewayScaleUnit { get; set; }
    }
}
