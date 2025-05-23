// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    public partial class AvailableRuntimeVersions :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IAvailableRuntimeVersions,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IAvailableRuntimeVersionsInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion> Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IAvailableRuntimeVersionsInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion> _value;

        /// <summary>A list of all supported runtime versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion> Value { get => this._value; }

        /// <summary>Creates an new <see cref="AvailableRuntimeVersions" /> instance.</summary>
        public AvailableRuntimeVersions()
        {

        }
    }
    public partial interface IAvailableRuntimeVersions :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>A list of all supported runtime versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of all supported runtime versions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion> Value { get;  }

    }
    internal partial interface IAvailableRuntimeVersionsInternal

    {
        /// <summary>A list of all supported runtime versions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedRuntimeVersion> Value { get; set; }

    }
}