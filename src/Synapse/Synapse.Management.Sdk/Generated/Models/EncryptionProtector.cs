// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// The server encryption protector.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class EncryptionProtector : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionProtector class.
        /// </summary>
        public EncryptionProtector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionProtector class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="kind">Kind of encryption protector. This is metadata used for the Azure portal
        /// experience.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="subregion">Subregion of the encryption protector.
        /// </param>

        /// <param name="serverKeyName">The name of the server key.
        /// </param>

        /// <param name="serverKeyType">The encryption protector type like &#39;ServiceManaged&#39;, &#39;AzureKeyVault&#39;.
        /// Possible values include: &#39;ServiceManaged&#39;, &#39;AzureKeyVault&#39;</param>

        /// <param name="uri">The URI of the server key.
        /// </param>

        /// <param name="thumbprint">Thumbprint of the server key.
        /// </param>
        public EncryptionProtector(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string location = default(string), string subregion = default(string), string serverKeyName = default(string), string serverKeyType = default(string), string uri = default(string), string thumbprint = default(string))

        : base(id, name, type)
        {
            this.Kind = kind;
            this.Location = location;
            this.Subregion = subregion;
            this.ServerKeyName = serverKeyName;
            this.ServerKeyType = serverKeyType;
            this.Uri = uri;
            this.Thumbprint = thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets kind of encryption protector. This is metadata used for the Azure
        /// portal experience.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind {get; private set; }

        /// <summary>
        /// Gets resource location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; private set; }

        /// <summary>
        /// Gets subregion of the encryption protector.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subregion")]
        public string Subregion {get; private set; }

        /// <summary>
        /// Gets or sets the name of the server key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serverKeyName")]
        public string ServerKeyName {get; set; }

        /// <summary>
        /// Gets or sets the encryption protector type like &#39;ServiceManaged&#39;,
        /// &#39;AzureKeyVault&#39;. Possible values include: &#39;ServiceManaged&#39;, &#39;AzureKeyVault&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serverKeyType")]
        public string ServerKeyType {get; set; }

        /// <summary>
        /// Gets the URI of the server key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.uri")]
        public string Uri {get; private set; }

        /// <summary>
        /// Gets thumbprint of the server key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint {get; private set; }
    }
}