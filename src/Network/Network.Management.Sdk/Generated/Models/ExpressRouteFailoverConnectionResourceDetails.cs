// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    public partial class ExpressRouteFailoverConnectionResourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteFailoverConnectionResourceDetails class.
        /// </summary>
        public ExpressRouteFailoverConnectionResourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteFailoverConnectionResourceDetails class.
        /// </summary>

        /// <param name="nrpResourceUri">NRP Resource URI of the connection
        /// </param>

        /// <param name="name">Connection Name
        /// </param>

        /// <param name="status">The current status of the connection
        /// Possible values include: &#39;Connected&#39;, &#39;Disconnected&#39;</param>

        /// <param name="lastUpdatedTime">Time when the connection was last updated
        /// </param>
        public ExpressRouteFailoverConnectionResourceDetails(string nrpResourceUri = default(string), string name = default(string), string status = default(string), string lastUpdatedTime = default(string))

        {
            this.NrpResourceUri = nrpResourceUri;
            this.Name = name;
            this.Status = status;
            this.LastUpdatedTime = lastUpdatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets nRP Resource URI of the connection
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nrpResourceUri")]
        public string NrpResourceUri {get; set; }

        /// <summary>
        /// Gets or sets connection Name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the current status of the connection Possible values include: &#39;Connected&#39;, &#39;Disconnected&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets time when the connection was last updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdatedTime")]
        public string LastUpdatedTime {get; set; }
    }
}