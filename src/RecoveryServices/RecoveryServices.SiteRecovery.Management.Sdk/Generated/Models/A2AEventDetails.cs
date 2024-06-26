// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Model class for event details of a A2A event.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AEventDetails : EventProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AEventDetails class.
        /// </summary>
        public A2AEventDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AEventDetails class.
        /// </summary>

        /// <param name="protectedItemName">The protected item arm name.
        /// </param>

        /// <param name="fabricObjectId">The azure vm arm id.
        /// </param>

        /// <param name="fabricName">Fabric arm name.
        /// </param>

        /// <param name="fabricLocation">The fabric location.
        /// </param>

        /// <param name="remoteFabricName">Remote fabric arm name.
        /// </param>

        /// <param name="remoteFabricLocation">Remote fabric location.
        /// </param>
        public A2AEventDetails(string protectedItemName = default(string), string fabricObjectId = default(string), string fabricName = default(string), string fabricLocation = default(string), string remoteFabricName = default(string), string remoteFabricLocation = default(string))

        {
            this.ProtectedItemName = protectedItemName;
            this.FabricObjectId = fabricObjectId;
            this.FabricName = fabricName;
            this.FabricLocation = fabricLocation;
            this.RemoteFabricName = remoteFabricName;
            this.RemoteFabricLocation = remoteFabricLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the protected item arm name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedItemName")]
        public string ProtectedItemName {get; set; }

        /// <summary>
        /// Gets or sets the azure vm arm id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId {get; set; }

        /// <summary>
        /// Gets or sets fabric arm name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricName")]
        public string FabricName {get; set; }

        /// <summary>
        /// Gets or sets the fabric location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricLocation")]
        public string FabricLocation {get; set; }

        /// <summary>
        /// Gets or sets remote fabric arm name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remoteFabricName")]
        public string RemoteFabricName {get; set; }

        /// <summary>
        /// Gets or sets remote fabric location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remoteFabricLocation")]
        public string RemoteFabricLocation {get; set; }
    }
}