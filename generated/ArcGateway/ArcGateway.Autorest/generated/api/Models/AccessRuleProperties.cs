// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Extensions;

    /// <summary>Properties of an access rule.</summary>
    public partial class AccessRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IAccessRuleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IAccessRulePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddressPrefix" /> property.</summary>
        private System.Collections.Generic.List<string> _addressPrefix;

        /// <summary>Address prefixes that are allowed access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AddressPrefix { get => this._addressPrefix; }

        /// <summary>Backing field for <see cref="Direction" /> property.</summary>
        private string _direction;

        /// <summary>Direction of the access rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        public string Direction { get => this._direction; }

        /// <summary>Internal Acessors for AddressPrefix</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IAccessRulePropertiesInternal.AddressPrefix { get => this._addressPrefix; set { {_addressPrefix = value;} } }

        /// <summary>Internal Acessors for Direction</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IAccessRulePropertiesInternal.Direction { get => this._direction; set { {_direction = value;} } }

        /// <summary>Creates an new <see cref="AccessRuleProperties" /> instance.</summary>
        public AccessRuleProperties()
        {

        }
    }
    /// Properties of an access rule.
    public partial interface IAccessRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IJsonSerializable
    {
        /// <summary>Address prefixes that are allowed access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Address prefixes that are allowed access.",
        SerializedName = @"addressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AddressPrefix { get;  }
        /// <summary>Direction of the access rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Direction of the access rule.",
        SerializedName = @"direction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PSArgumentCompleterAttribute("Inbound", "Outbound")]
        string Direction { get;  }

    }
    /// Properties of an access rule.
    internal partial interface IAccessRulePropertiesInternal

    {
        /// <summary>Address prefixes that are allowed access.</summary>
        System.Collections.Generic.List<string> AddressPrefix { get; set; }
        /// <summary>Direction of the access rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PSArgumentCompleterAttribute("Inbound", "Outbound")]
        string Direction { get; set; }

    }
}