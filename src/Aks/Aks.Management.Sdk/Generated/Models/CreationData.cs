// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    public partial class CreationData
    {
        /// <summary>
        /// Initializes a new instance of the CreationData class.
        /// </summary>
        public CreationData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreationData class.
        /// </summary>

        /// <param name="sourceResourceId">This is the ARM ID of the source object to be used to create the target
        /// object.
        /// </param>
        public CreationData(string sourceResourceId = default(string))

        {
            this.SourceResourceId = sourceResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets this is the ARM ID of the source object to be used to create
        /// the target object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceResourceId")]
        public string SourceResourceId {get; set; }
    }
}