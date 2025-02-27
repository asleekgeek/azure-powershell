// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using System.Linq;

    /// <summary>
    /// Details related to the IPv4 address configuration.
    /// </summary>
    public partial class Ipv4Config
    {
        /// <summary>
        /// Initializes a new instance of the Ipv4Config class.
        /// </summary>
        public Ipv4Config()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Ipv4Config class.
        /// </summary>

        /// <param name="ipAddress">The IPv4 address of the network adapter.
        /// </param>

        /// <param name="subnet">The IPv4 subnet of the network adapter.
        /// </param>

        /// <param name="gateway">The IPv4 gateway of the network adapter.
        /// </param>
        public Ipv4Config(string ipAddress = default(string), string subnet = default(string), string gateway = default(string))

        {
            this.IPAddress = ipAddress;
            this.Subnet = subnet;
            this.Gateway = gateway;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the IPv4 address of the network adapter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddress")]
        public string IPAddress {get; private set; }

        /// <summary>
        /// Gets the IPv4 subnet of the network adapter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subnet")]
        public string Subnet {get; private set; }

        /// <summary>
        /// Gets the IPv4 gateway of the network adapter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "gateway")]
        public string Gateway {get; private set; }
    }
}