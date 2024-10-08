// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Service Principal credential type properties.
    /// </summary>
    public partial class ServicePrincipalCredentialTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCredentialTypeProperties class.
        /// </summary>
        public ServicePrincipalCredentialTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCredentialTypeProperties class.
        /// </summary>

        /// <param name="servicePrincipalId">The app ID of the service principal used to authenticate
        /// </param>

        /// <param name="servicePrincipalKey">The key of the service principal used to authenticate.
        /// </param>

        /// <param name="tenant">The ID of the tenant to which the service principal belongs
        /// </param>
        public ServicePrincipalCredentialTypeProperties(object servicePrincipalId = default(object), AzureKeyVaultSecretReference servicePrincipalKey = default(AzureKeyVaultSecretReference), object tenant = default(object))

        {
            this.ServicePrincipalId = servicePrincipalId;
            this.ServicePrincipalKey = servicePrincipalKey;
            this.Tenant = tenant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the app ID of the service principal used to authenticate
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "servicePrincipalId")]
        public object ServicePrincipalId {get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "servicePrincipalKey")]
        public AzureKeyVaultSecretReference ServicePrincipalKey {get; set; }

        /// <summary>
        /// Gets or sets the ID of the tenant to which the service principal belongs
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenant")]
        public object Tenant {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.ServicePrincipalKey != null)
            {
                this.ServicePrincipalKey.Validate();
            }

        }
    }
}