// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Extensions;

    /// <summary>Collection of OutboundEnvironmentEndpoint</summary>
    public partial class OutboundEnvironmentEndpointCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpointCollection,
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpointCollectionInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpointCollectionInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpoint> _value;

        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpoint> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpointCollection" /> instance.</summary>
        public OutboundEnvironmentEndpointCollection()
        {

        }
    }
    /// Collection of OutboundEnvironmentEndpoint
    public partial interface IOutboundEnvironmentEndpointCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.IJsonSerializable
    {
        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Link to next page of resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Collection of resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpoint) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpoint> Value { get; set; }

    }
    /// Collection of OutboundEnvironmentEndpoint
    internal partial interface IOutboundEnvironmentEndpointCollectionInternal

    {
        /// <summary>Link to next page of resources.</summary>
        string NextLink { get; set; }
        /// <summary>Collection of resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.IOutboundEnvironmentEndpoint> Value { get; set; }

    }
}