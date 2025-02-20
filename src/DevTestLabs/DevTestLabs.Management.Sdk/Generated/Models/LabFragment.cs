// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// A lab.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LabFragment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LabFragment class.
        /// </summary>
        public LabFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabFragment class.
        /// </summary>

        /// <param name="id">The identifier of the resource.
        /// </param>

        /// <param name="name">The name of the resource.
        /// </param>

        /// <param name="type">The type of the resource.
        /// </param>

        /// <param name="location">The location of the resource.
        /// </param>

        /// <param name="tags">The tags of the resource.
        /// </param>

        /// <param name="labStorageType">Type of storage used by the lab. It can be either Premium or Standard.
        /// Default is Premium.
        /// Possible values include: &#39;Standard&#39;, &#39;Premium&#39;</param>

        /// <param name="premiumDataDisks">The setting to enable usage of premium data disks.
        /// When its value is &#39;Enabled&#39;, creation of standard or premium data disks is
        /// allowed.
        /// When its value is &#39;Disabled&#39;, only creation of standard data disks is
        /// allowed.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>

        /// <param name="provisioningState">The provisioning status of the resource.
        /// </param>

        /// <param name="uniqueIdentifier">The unique immutable identifier of a resource (Guid).
        /// </param>
        public LabFragment(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string labStorageType = default(string), string premiumDataDisks = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))

        : base(id, name, type, location, tags)
        {
            this.LabStorageType = labStorageType;
            this.PremiumDataDisks = premiumDataDisks;
            this.ProvisioningState = provisioningState;
            this.UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets type of storage used by the lab. It can be either Premium or
        /// Standard. Default is Premium. Possible values include: &#39;Standard&#39;, &#39;Premium&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.labStorageType")]
        public string LabStorageType {get; set; }

        /// <summary>
        /// Gets or sets the setting to enable usage of premium data disks.
        /// When its value is &#39;Enabled&#39;, creation of standard or premium data disks is
        /// allowed.
        /// When its value is &#39;Disabled&#39;, only creation of standard data disks is
        /// allowed. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.premiumDataDisks")]
        public string PremiumDataDisks {get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier {get; set; }
    }
}