// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>List of role instances of vendor network function.</summary>
    public partial class NetworkFunctionRoleInstanceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionRoleInstanceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionRoleInstanceListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionRoleInstanceListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance> Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionRoleInstanceListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance> _value;

        /// <summary>A list of role instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance> Value { get => this._value; }

        /// <summary>Creates an new <see cref="NetworkFunctionRoleInstanceListResult" /> instance.</summary>
        public NetworkFunctionRoleInstanceListResult()
        {

        }
    }
    /// List of role instances of vendor network function.
    public partial interface INetworkFunctionRoleInstanceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URL to get the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>A list of role instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of role instances.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance> Value { get;  }

    }
    /// List of role instances of vendor network function.
    internal partial interface INetworkFunctionRoleInstanceListResultInternal

    {
        /// <summary>The URL to get the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>A list of role instances.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IRoleInstance> Value { get; set; }

    }
}