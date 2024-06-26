// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The parameters used to check the availability of the managed hsm name.</summary>
    public partial class CheckMhsmNameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ICheckMhsmNameAvailabilityParameters,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ICheckMhsmNameAvailabilityParametersInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The managed hsm name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="CheckMhsmNameAvailabilityParameters" /> instance.</summary>
        public CheckMhsmNameAvailabilityParameters()
        {

        }
    }
    /// The parameters used to check the availability of the managed hsm name.
    public partial interface ICheckMhsmNameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>The managed hsm name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The managed hsm name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// The parameters used to check the availability of the managed hsm name.
    internal partial interface ICheckMhsmNameAvailabilityParametersInternal

    {
        /// <summary>The managed hsm name.</summary>
        string Name { get; set; }

    }
}