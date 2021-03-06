// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// VirtualNetworkGatewayConnection properties
    /// </summary>
    public partial class TunnelConnectionHealth
    {
        /// <summary>
        /// Initializes a new instance of the TunnelConnectionHealth class.
        /// </summary>
        public TunnelConnectionHealth() { }

        /// <summary>
        /// Initializes a new instance of the TunnelConnectionHealth class.
        /// </summary>
        public TunnelConnectionHealth(string tunnel = default(string), string connectionStatus = default(string), long? ingressBytesTransferred = default(long?), long? egressBytesTransferred = default(long?), string lastConnectionEstablishedUtcTime = default(string))
        {
            Tunnel = tunnel;
            ConnectionStatus = connectionStatus;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            LastConnectionEstablishedUtcTime = lastConnectionEstablishedUtcTime;
        }

        /// <summary>
        /// Tunnel name.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel")]
        public string Tunnel { get; private set; }

        /// <summary>
        /// Virtual network Gateway connection status. Possible values
        /// include: 'Unknown', 'Connecting', 'Connected', 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "connectionStatus")]
        public string ConnectionStatus { get; private set; }

        /// <summary>
        /// The Ingress Bytes Transferred in this connection
        /// </summary>
        [JsonProperty(PropertyName = "ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// The Egress Bytes Transferred in this connection
        /// </summary>
        [JsonProperty(PropertyName = "egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// The time at which connection was established in Utc format.
        /// </summary>
        [JsonProperty(PropertyName = "lastConnectionEstablishedUtcTime")]
        public string LastConnectionEstablishedUtcTime { get; private set; }

    }
}
