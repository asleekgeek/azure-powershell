// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// Cognitive Services account is an Azure resource representing the
    /// provisioned account, it&#39;s type, location and SKU.
    /// </summary>
    public partial class Account : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        public Account()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="etag">Resource Etag.
        /// </param>

        /// <param name="kind">The Kind of the resource.
        /// </param>

        /// <param name="sku">The resource model definition representing SKU
        /// </param>

        /// <param name="identity">Identity for the resource.
        /// </param>

        /// <param name="systemData">Metadata pertaining to creation and last modification of the resource.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="location">The geo-location where the resource lives
        /// </param>

        /// <param name="properties">Properties of Cognitive Services account.
        /// </param>
        public Account(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string kind = default(string), Sku sku = default(Sku), Identity identity = default(Identity), SystemData systemData = default(SystemData), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string location = default(string), AccountProperties properties = default(AccountProperties))

        : base(id, name, type, etag)
        {
            this.Kind = kind;
            this.Sku = sku;
            this.Identity = identity;
            this.SystemData = systemData;
            this.Tags = tags;
            this.Location = location;
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the Kind of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind {get; set; }

        /// <summary>
        /// Gets or sets the resource model definition representing SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku {get; set; }

        /// <summary>
        /// Gets or sets identity for the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public Identity Identity {get; set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData {get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets properties of Cognitive Services account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public AccountProperties Properties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.Sku != null)
            {
                this.Sku.Validate();
            }




            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}