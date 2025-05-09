// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Dynamics linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Dynamics")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DynamicsLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the DynamicsLinkedService class.
        /// </summary>
        public DynamicsLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsLinkedService class.
        /// </summary>

        /// <param name="additionalProperties">The nested object which contains the information and credential which can
        /// be used to connect with related store or compute resource.
        /// </param>

        /// <param name="version">Version of the linked service.
        /// </param>

        /// <param name="connectVia">The integration runtime reference.
        /// </param>

        /// <param name="description">Linked service description.
        /// </param>

        /// <param name="parameters">Parameters for linked service.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the linked service.
        /// </param>

        /// <param name="deploymentType">The deployment type of the Dynamics instance. &#39;Online&#39; for Dynamics Online
        /// and &#39;OnPremisesWithIfd&#39; for Dynamics on-premises with Ifd. Type: string (or
        /// Expression with resultType string).
        /// </param>

        /// <param name="hostName">The host name of the on-premises Dynamics server. The property is required
        /// for on-prem and not allowed for online. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="port">The port of on-premises Dynamics server. The property is required for
        /// on-prem and not allowed for online. Default is 443. Type: integer (or
        /// Expression with resultType integer), minimum: 0.
        /// </param>

        /// <param name="serviceUri">The URL to the Microsoft Dynamics server. The property is required for
        /// on-line and not allowed for on-prem. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="organizationName">The organization name of the Dynamics instance. The property is required
        /// for on-prem and required for online when there are more than one Dynamics
        /// instances associated with the user. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="authenticationType">The authentication type to connect to Dynamics server. &#39;Office365&#39; for
        /// online scenario, &#39;Ifd&#39; for on-premises with Ifd scenario,
        /// &#39;AADServicePrincipal&#39; for Server-To-Server authentication in online
        /// scenario, &#39;Active Directory&#39; for Dynamics on-premises with IFD. Type:
        /// string (or Expression with resultType string).
        /// </param>

        /// <param name="domain">The Active Directory domain that will verify user credentials. Type: string
        /// (or Expression with resultType string).
        /// </param>

        /// <param name="username">User name to access the Dynamics instance. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="password">Password to access the Dynamics instance.
        /// </param>

        /// <param name="servicePrincipalId">The client ID of the application in Azure Active Directory used for
        /// Server-To-Server authentication. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="servicePrincipalCredentialType">The service principal credential type to use in Server-To-Server
        /// authentication. &#39;ServicePrincipalKey&#39; for key/secret,
        /// &#39;ServicePrincipalCert&#39; for certificate. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="servicePrincipalCredential">The credential of the service principal object in Azure Active Directory.
        /// If servicePrincipalCredentialType is &#39;ServicePrincipalKey&#39;,
        /// servicePrincipalCredential can be SecureString or
        /// AzureKeyVaultSecretReference. If servicePrincipalCredentialType is
        /// &#39;ServicePrincipalCert&#39;, servicePrincipalCredential can only be
        /// AzureKeyVaultSecretReference.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>

        /// <param name="credential">The credential reference containing authentication information.
        /// </param>
        public DynamicsLinkedService(object deploymentType, object authenticationType, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string version = default(string), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), object hostName = default(object), object port = default(object), object serviceUri = default(object), object organizationName = default(object), object domain = default(object), object username = default(object), SecretBase password = default(SecretBase), object servicePrincipalId = default(object), object servicePrincipalCredentialType = default(object), SecretBase servicePrincipalCredential = default(SecretBase), string encryptedCredential = default(string), CredentialReference credential = default(CredentialReference))

        : base(additionalProperties, version, connectVia, description, parameters, annotations)
        {
            this.DeploymentType = deploymentType;
            this.HostName = hostName;
            this.Port = port;
            this.ServiceUri = serviceUri;
            this.OrganizationName = organizationName;
            this.AuthenticationType = authenticationType;
            this.Domain = domain;
            this.Username = username;
            this.Password = password;
            this.ServicePrincipalId = servicePrincipalId;
            this.ServicePrincipalCredentialType = servicePrincipalCredentialType;
            this.ServicePrincipalCredential = servicePrincipalCredential;
            this.EncryptedCredential = encryptedCredential;
            this.Credential = credential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the deployment type of the Dynamics instance. &#39;Online&#39; for
        /// Dynamics Online and &#39;OnPremisesWithIfd&#39; for Dynamics on-premises with Ifd.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.deploymentType")]
        public object DeploymentType {get; set; }

        /// <summary>
        /// Gets or sets the host name of the on-premises Dynamics server. The property
        /// is required for on-prem and not allowed for online. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.hostName")]
        public object HostName {get; set; }

        /// <summary>
        /// Gets or sets the port of on-premises Dynamics server. The property is
        /// required for on-prem and not allowed for online. Default is 443. Type:
        /// integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.port")]
        public object Port {get; set; }

        /// <summary>
        /// Gets or sets the URL to the Microsoft Dynamics server. The property is
        /// required for on-line and not allowed for on-prem. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.serviceUri")]
        public object ServiceUri {get; set; }

        /// <summary>
        /// Gets or sets the organization name of the Dynamics instance. The property
        /// is required for on-prem and required for online when there are more than
        /// one Dynamics instances associated with the user. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.organizationName")]
        public object OrganizationName {get; set; }

        /// <summary>
        /// Gets or sets the authentication type to connect to Dynamics server.
        /// &#39;Office365&#39; for online scenario, &#39;Ifd&#39; for on-premises with Ifd scenario,
        /// &#39;AADServicePrincipal&#39; for Server-To-Server authentication in online
        /// scenario, &#39;Active Directory&#39; for Dynamics on-premises with IFD. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public object AuthenticationType {get; set; }

        /// <summary>
        /// Gets or sets the Active Directory domain that will verify user credentials.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.domain")]
        public object Domain {get; set; }

        /// <summary>
        /// Gets or sets user name to access the Dynamics instance. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.username")]
        public object Username {get; set; }

        /// <summary>
        /// Gets or sets password to access the Dynamics instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password {get; set; }

        /// <summary>
        /// Gets or sets the client ID of the application in Azure Active Directory
        /// used for Server-To-Server authentication. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId {get; set; }

        /// <summary>
        /// Gets or sets the service principal credential type to use in
        /// Server-To-Server authentication. &#39;ServicePrincipalKey&#39; for key/secret,
        /// &#39;ServicePrincipalCert&#39; for certificate. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.servicePrincipalCredentialType")]
        public object ServicePrincipalCredentialType {get; set; }

        /// <summary>
        /// Gets or sets the credential of the service principal object in Azure Active
        /// Directory. If servicePrincipalCredentialType is &#39;ServicePrincipalKey&#39;,
        /// servicePrincipalCredential can be SecureString or
        /// AzureKeyVaultSecretReference. If servicePrincipalCredentialType is
        /// &#39;ServicePrincipalCert&#39;, servicePrincipalCredential can only be
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.servicePrincipalCredential")]
        public SecretBase ServicePrincipalCredential {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential {get; set; }

        /// <summary>
        /// Gets or sets the credential reference containing authentication
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.credential")]
        public CredentialReference Credential {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.DeploymentType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DeploymentType");
            }
            if (this.AuthenticationType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AuthenticationType");
            }













            if (this.Credential != null)
            {
                this.Credential.Validate();
            }
        }
    }
}