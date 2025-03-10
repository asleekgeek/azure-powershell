// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using System.Linq;

    /// <summary>
    /// Result of the List NetworkSecurityPerimeterConfiguration operation.
    /// </summary>
    public partial class NetworkSecurityPerimeterConfigurationList
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityPerimeterConfigurationList class.
        /// </summary>
        public NetworkSecurityPerimeterConfigurationList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSecurityPerimeterConfigurationList class.
        /// </summary>

        /// <param name="value">A collection of NetworkSecurityPerimeterConfigurations
        /// </param>
        public NetworkSecurityPerimeterConfigurationList(System.Collections.Generic.IList<NetworkSecurityPerimeterConfiguration> value = default(System.Collections.Generic.IList<NetworkSecurityPerimeterConfiguration>))

        {
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets a collection of NetworkSecurityPerimeterConfigurations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<NetworkSecurityPerimeterConfiguration> Value {get; private set; }
    }
}