// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// SSIS properties for managed integration runtime.
    /// </summary>
    public partial class IntegrationRuntimeSsisProperties
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeSsisProperties class.
        /// </summary>
        public IntegrationRuntimeSsisProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeSsisProperties class.
        /// </summary>

        /// <param name="additionalProperties">SSIS properties for managed integration runtime.
        /// </param>

        /// <param name="catalogInfo">Catalog information for managed dedicated integration runtime.
        /// </param>

        /// <param name="licenseType">License type for bringing your own license scenario.
        /// Possible values include: &#39;BasePrice&#39;, &#39;LicenseIncluded&#39;</param>

        /// <param name="customSetupScriptProperties">Custom setup script properties for a managed dedicated integration runtime.
        /// </param>

        /// <param name="dataProxyProperties">Data proxy properties for a managed dedicated integration runtime.
        /// </param>

        /// <param name="edition">The edition for the SSIS Integration Runtime
        /// Possible values include: &#39;Standard&#39;, &#39;Enterprise&#39;</param>

        /// <param name="expressCustomSetupProperties">Custom setup without script properties for a SSIS integration runtime.
        /// </param>
        public IntegrationRuntimeSsisProperties(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), IntegrationRuntimeSsisCatalogInfo catalogInfo = default(IntegrationRuntimeSsisCatalogInfo), string licenseType = default(string), IntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties = default(IntegrationRuntimeCustomSetupScriptProperties), IntegrationRuntimeDataProxyProperties dataProxyProperties = default(IntegrationRuntimeDataProxyProperties), string edition = default(string), System.Collections.Generic.IList<CustomSetupBase> expressCustomSetupProperties = default(System.Collections.Generic.IList<CustomSetupBase>))

        {
            this.AdditionalProperties = additionalProperties;
            this.CatalogInfo = catalogInfo;
            this.LicenseType = licenseType;
            this.CustomSetupScriptProperties = customSetupScriptProperties;
            this.DataProxyProperties = dataProxyProperties;
            this.Edition = edition;
            this.ExpressCustomSetupProperties = expressCustomSetupProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets sSIS properties for managed integration runtime.
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {get; set; }

        /// <summary>
        /// Gets or sets catalog information for managed dedicated integration runtime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "catalogInfo")]
        public IntegrationRuntimeSsisCatalogInfo CatalogInfo {get; set; }

        /// <summary>
        /// Gets or sets license type for bringing your own license scenario. Possible values include: &#39;BasePrice&#39;, &#39;LicenseIncluded&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "licenseType")]
        public string LicenseType {get; set; }

        /// <summary>
        /// Gets or sets custom setup script properties for a managed dedicated
        /// integration runtime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customSetupScriptProperties")]
        public IntegrationRuntimeCustomSetupScriptProperties CustomSetupScriptProperties {get; set; }

        /// <summary>
        /// Gets or sets data proxy properties for a managed dedicated integration
        /// runtime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataProxyProperties")]
        public IntegrationRuntimeDataProxyProperties DataProxyProperties {get; set; }

        /// <summary>
        /// Gets or sets the edition for the SSIS Integration Runtime Possible values include: &#39;Standard&#39;, &#39;Enterprise&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "edition")]
        public string Edition {get; set; }

        /// <summary>
        /// Gets or sets custom setup without script properties for a SSIS integration
        /// runtime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expressCustomSetupProperties")]
        public System.Collections.Generic.IList<CustomSetupBase> ExpressCustomSetupProperties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.CatalogInfo != null)
            {
                this.CatalogInfo.Validate();
            }

            if (this.CustomSetupScriptProperties != null)
            {
                this.CustomSetupScriptProperties.Validate();
            }



        }
    }
}