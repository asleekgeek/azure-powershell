// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Settings for feature store type workspace.</summary>
    public partial class FeatureStoreSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IFeatureStoreSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IFeatureStoreSettingsInternal
    {

        /// <summary>Backing field for <see cref="ComputeRuntime" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDto _computeRuntime;

        /// <summary>Compute runtime config for feature store type workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDto ComputeRuntime { get => (this._computeRuntime = this._computeRuntime ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ComputeRuntimeDto()); set => this._computeRuntime = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ComputeRuntimeSparkRuntimeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDtoInternal)ComputeRuntime).SparkRuntimeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDtoInternal)ComputeRuntime).SparkRuntimeVersion = value ?? null; }

        /// <summary>Internal Acessors for ComputeRuntime</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDto Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IFeatureStoreSettingsInternal.ComputeRuntime { get => (this._computeRuntime = this._computeRuntime ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ComputeRuntimeDto()); set { {_computeRuntime = value;} } }

        /// <summary>Backing field for <see cref="OfflineStoreConnectionName" /> property.</summary>
        private string _offlineStoreConnectionName;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string OfflineStoreConnectionName { get => this._offlineStoreConnectionName; set => this._offlineStoreConnectionName = value; }

        /// <summary>Backing field for <see cref="OnlineStoreConnectionName" /> property.</summary>
        private string _onlineStoreConnectionName;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string OnlineStoreConnectionName { get => this._onlineStoreConnectionName; set => this._onlineStoreConnectionName = value; }

        /// <summary>Creates an new <see cref="FeatureStoreSettings" /> instance.</summary>
        public FeatureStoreSettings()
        {

        }
    }
    /// Settings for feature store type workspace.
    public partial interface IFeatureStoreSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sparkRuntimeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeRuntimeSparkRuntimeVersion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"offlineStoreConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string OfflineStoreConnectionName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"onlineStoreConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string OnlineStoreConnectionName { get; set; }

    }
    /// Settings for feature store type workspace.
    internal partial interface IFeatureStoreSettingsInternal

    {
        /// <summary>Compute runtime config for feature store type workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRuntimeDto ComputeRuntime { get; set; }

        string ComputeRuntimeSparkRuntimeVersion { get; set; }

        string OfflineStoreConnectionName { get; set; }

        string OnlineStoreConnectionName { get; set; }

    }
}