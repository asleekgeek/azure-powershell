// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Parameters to authenticate using a Managed Identity.</summary>
    public partial class ManagedIdentityDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IManagedIdentityDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IManagedIdentityDefinitionInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client Id for authenticating a Managed Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; set => this._clientId = value; }

        /// <summary>Creates an new <see cref="ManagedIdentityDefinition" /> instance.</summary>
        public ManagedIdentityDefinition()
        {

        }
    }
    /// Parameters to authenticate using a Managed Identity.
    public partial interface IManagedIdentityDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The client Id for authenticating a Managed Identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The client Id for authenticating a Managed Identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }

    }
    /// Parameters to authenticate using a Managed Identity.
    internal partial interface IManagedIdentityDefinitionInternal

    {
        /// <summary>The client Id for authenticating a Managed Identity.</summary>
        string ClientId { get; set; }

    }
}