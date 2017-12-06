// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Peerings in a virtual network resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkPeering : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkPeering class.
        /// </summary>
        public VirtualNetworkPeering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkPeering class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="allowVirtualNetworkAccess">Whether the VMs in the
        /// linked virtual network space would be able to access all the VMs in
        /// local Virtual network space.</param>
        /// <param name="allowForwardedTraffic">Whether the forwarded traffic
        /// from the VMs in the remote virtual network will be
        /// allowed/disallowed.</param>
        /// <param name="allowGatewayTransit">If gateway links can be used in
        /// remote virtual networking to link to this virtual network.</param>
        /// <param name="useRemoteGateways">If remote gateways can be used on
        /// this virtual network. If the flag is set to true, and
        /// allowGatewayTransit on remote peering is also true, virtual network
        /// will use gateways of remote virtual network for transit. Only one
        /// peering can have this flag set to true. This flag cannot be set if
        /// virtual network already has a gateway.</param>
        /// <param name="remoteVirtualNetwork">The reference of the remote
        /// virtual network. The remote virtual network can be in the same or
        /// different region (preview). See here to register for the preview
        /// and learn more
        /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).</param>
        /// <param name="remoteAddressSpace">The reference of the remote
        /// virtual network address space.</param>
        /// <param name="peeringState">The status of the virtual network
        /// peering. Possible values are 'Initiated', 'Connected', and
        /// 'Disconnected'. Possible values include: 'Initiated', 'Connected',
        /// 'Disconnected'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualNetworkPeering(string id = default(string), bool? allowVirtualNetworkAccess = default(bool?), bool? allowForwardedTraffic = default(bool?), bool? allowGatewayTransit = default(bool?), bool? useRemoteGateways = default(bool?), SubResource remoteVirtualNetwork = default(SubResource), AddressSpace remoteAddressSpace = default(AddressSpace), string peeringState = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AllowVirtualNetworkAccess = allowVirtualNetworkAccess;
            AllowForwardedTraffic = allowForwardedTraffic;
            AllowGatewayTransit = allowGatewayTransit;
            UseRemoteGateways = useRemoteGateways;
            RemoteVirtualNetwork = remoteVirtualNetwork;
            RemoteAddressSpace = remoteAddressSpace;
            PeeringState = peeringState;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the VMs in the linked virtual network space
        /// would be able to access all the VMs in local Virtual network space.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowVirtualNetworkAccess")]
        public bool? AllowVirtualNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets whether the forwarded traffic from the VMs in the
        /// remote virtual network will be allowed/disallowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowForwardedTraffic")]
        public bool? AllowForwardedTraffic { get; set; }

        /// <summary>
        /// Gets or sets if gateway links can be used in remote virtual
        /// networking to link to this virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowGatewayTransit")]
        public bool? AllowGatewayTransit { get; set; }

        /// <summary>
        /// Gets or sets if remote gateways can be used on this virtual
        /// network. If the flag is set to true, and allowGatewayTransit on
        /// remote peering is also true, virtual network will use gateways of
        /// remote virtual network for transit. Only one peering can have this
        /// flag set to true. This flag cannot be set if virtual network
        /// already has a gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.useRemoteGateways")]
        public bool? UseRemoteGateways { get; set; }

        /// <summary>
        /// Gets or sets the reference of the remote virtual network. The
        /// remote virtual network can be in the same or different region
        /// (preview). See here to register for the preview and learn more
        /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteVirtualNetwork")]
        public SubResource RemoteVirtualNetwork { get; set; }

        /// <summary>
        /// Gets or sets the reference of the remote virtual network address
        /// space.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteAddressSpace")]
        public AddressSpace RemoteAddressSpace { get; set; }

        /// <summary>
        /// Gets or sets the status of the virtual network peering. Possible
        /// values are 'Initiated', 'Connected', and 'Disconnected'. Possible
        /// values include: 'Initiated', 'Connected', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringState")]
        public string PeeringState { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
