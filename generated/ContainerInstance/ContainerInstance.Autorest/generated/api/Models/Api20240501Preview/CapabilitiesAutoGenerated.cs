// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>The supported capabilities.</summary>
    public partial class CapabilitiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="MaxCpu" /> property.</summary>
        private float? _maxCpu;

        /// <summary>The maximum allowed CPU request in cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public float? MaxCpu { get => this._maxCpu; }

        /// <summary>Backing field for <see cref="MaxGpuCount" /> property.</summary>
        private float? _maxGpuCount;

        /// <summary>The maximum allowed GPU count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public float? MaxGpuCount { get => this._maxGpuCount; }

        /// <summary>Backing field for <see cref="MaxMemoryInGb" /> property.</summary>
        private float? _maxMemoryInGb;

        /// <summary>The maximum allowed memory request in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public float? MaxMemoryInGb { get => this._maxMemoryInGb; }

        /// <summary>Internal Acessors for MaxCpu</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal.MaxCpu { get => this._maxCpu; set { {_maxCpu = value;} } }

        /// <summary>Internal Acessors for MaxGpuCount</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal.MaxGpuCount { get => this._maxGpuCount; set { {_maxGpuCount = value;} } }

        /// <summary>Internal Acessors for MaxMemoryInGb</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal.MaxMemoryInGb { get => this._maxMemoryInGb; set { {_maxMemoryInGb = value;} } }

        /// <summary>Creates an new <see cref="CapabilitiesAutoGenerated" /> instance.</summary>
        public CapabilitiesAutoGenerated()
        {

        }
    }
    /// The supported capabilities.
    public partial interface ICapabilitiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The maximum allowed CPU request in cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed CPU request in cores.",
        SerializedName = @"maxCpu",
        PossibleTypes = new [] { typeof(float) })]
        float? MaxCpu { get;  }
        /// <summary>The maximum allowed GPU count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed GPU count.",
        SerializedName = @"maxGpuCount",
        PossibleTypes = new [] { typeof(float) })]
        float? MaxGpuCount { get;  }
        /// <summary>The maximum allowed memory request in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed memory request in GB.",
        SerializedName = @"maxMemoryInGB",
        PossibleTypes = new [] { typeof(float) })]
        float? MaxMemoryInGb { get;  }

    }
    /// The supported capabilities.
    internal partial interface ICapabilitiesAutoGeneratedInternal

    {
        /// <summary>The maximum allowed CPU request in cores.</summary>
        float? MaxCpu { get; set; }
        /// <summary>The maximum allowed GPU count.</summary>
        float? MaxGpuCount { get; set; }
        /// <summary>The maximum allowed memory request in GB.</summary>
        float? MaxMemoryInGb { get; set; }

    }
}