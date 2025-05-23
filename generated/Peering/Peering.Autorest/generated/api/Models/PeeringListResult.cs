// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The paginated list of peerings.</summary>
    public partial class PeeringListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of peerings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeering> _value;

        /// <summary>The list of peerings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeering> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PeeringListResult" /> instance.</summary>
        public PeeringListResult()
        {

        }
    }
    /// The paginated list of peerings.
    public partial interface IPeeringListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of peerings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to fetch the next page of peerings.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of peerings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of peerings.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeering) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeering> Value { get; set; }

    }
    /// The paginated list of peerings.
    internal partial interface IPeeringListResultInternal

    {
        /// <summary>The link to fetch the next page of peerings.</summary>
        string NextLink { get; set; }
        /// <summary>The list of peerings.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeering> Value { get; set; }

    }
}