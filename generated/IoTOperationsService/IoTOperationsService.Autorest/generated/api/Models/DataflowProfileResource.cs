// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Instance dataflowProfile resource</summary>
    public partial class DataflowProfileResource :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResource,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ProxyResource();

        /// <summary>Backing field for <see cref="ExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocation _extendedLocation;

        /// <summary>Edge location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocation ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ExtendedLocation()); set => this._extendedLocation = value; }

        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocationInternal)ExtendedLocation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocationInternal)ExtendedLocation).Name = value ; }

        /// <summary>Type of ExtendedLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocationInternal)ExtendedLocation).Type; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// To manually scale the dataflow profile, specify the maximum number of instances you want to run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public int? InstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).InstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).InstanceCount = value ?? default(int); }

        /// <summary>The log level. Examples - 'debug', 'info', 'warn', 'error', 'trace'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string LogLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).LogLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).LogLevel = value ?? null; }

        /// <summary>The prometheus port to expose the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public int? MetricPrometheusPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).MetricPrometheusPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).MetricPrometheusPort = value ?? default(int); }

        /// <summary>Internal Acessors for Diagnostic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProfileDiagnostics Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.Diagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).Diagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).Diagnostic = value; }

        /// <summary>Internal Acessors for DiagnosticLog</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDiagnosticsLogs Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.DiagnosticLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).DiagnosticLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).DiagnosticLog = value; }

        /// <summary>Internal Acessors for DiagnosticMetric</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IMetrics Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.DiagnosticMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).DiagnosticMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).DiagnosticMetric = value; }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ExtendedLocation()); set { {_extendedLocation = value;} } }

        /// <summary>Internal Acessors for ExtendedLocationType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocationInternal)ExtendedLocation).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocationInternal)ExtendedLocation).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileProperties Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowProfileProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowProfileProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfilePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="DataflowProfileResource" /> instance.</summary>
        public DataflowProfileResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Instance dataflowProfile resource
    public partial interface IDataflowProfileResource :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProxyResource
    {
        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The name of the extended location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>Type of ExtendedLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Type of ExtendedLocation.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationType { get;  }
        /// <summary>
        /// To manually scale the dataflow profile, specify the maximum number of instances you want to run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To manually scale the dataflow profile, specify the maximum number of instances you want to run.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? InstanceCount { get; set; }
        /// <summary>The log level. Examples - 'debug', 'info', 'warn', 'error', 'trace'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The log level. Examples - 'debug', 'info', 'warn', 'error', 'trace'.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(string) })]
        string LogLevel { get; set; }
        /// <summary>The prometheus port to expose the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The prometheus port to expose the metrics.",
        SerializedName = @"prometheusPort",
        PossibleTypes = new [] { typeof(int) })]
        int? MetricPrometheusPort { get; set; }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }

    }
    /// Instance dataflowProfile resource
    internal partial interface IDataflowProfileResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProxyResourceInternal
    {
        /// <summary>Spec defines the desired identities of NBC diagnostics settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IProfileDiagnostics Diagnostic { get; set; }
        /// <summary>Diagnostic log settings for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDiagnosticsLogs DiagnosticLog { get; set; }
        /// <summary>The metrics settings for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IMetrics DiagnosticMetric { get; set; }
        /// <summary>Edge location of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IExtendedLocation ExtendedLocation { get; set; }
        /// <summary>The name of the extended location.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>Type of ExtendedLocation.</summary>
        string ExtendedLocationType { get; set; }
        /// <summary>
        /// To manually scale the dataflow profile, specify the maximum number of instances you want to run.
        /// </summary>
        int? InstanceCount { get; set; }
        /// <summary>The log level. Examples - 'debug', 'info', 'warn', 'error', 'trace'.</summary>
        string LogLevel { get; set; }
        /// <summary>The prometheus port to expose the metrics.</summary>
        int? MetricPrometheusPort { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowProfileProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
}