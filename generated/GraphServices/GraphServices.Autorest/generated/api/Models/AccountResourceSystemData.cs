// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class AccountResourceSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemData,
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; set => this._createdAt = value; }

        /// <summary>Backing field for <see cref="CreatedByType" /> property.</summary>
        private string _createdByType;

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string CreatedByType { get => this._createdByType; set => this._createdByType = value; }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; set => this._lastModifiedAt = value; }

        /// <summary>Backing field for <see cref="LastModifiedByType" /> property.</summary>
        private string _lastModifiedByType;

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string LastModifiedByType { get => this._lastModifiedByType; set => this._lastModifiedByType = value; }

        /// <summary>Creates an new <see cref="AccountResourceSystemData" /> instance.</summary>
        public AccountResourceSystemData()
        {

        }
    }
    /// Metadata pertaining to creation and last modification of the resource.
    public partial interface IAccountResourceSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string CreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string LastModifiedByType { get; set; }

    }
    /// Metadata pertaining to creation and last modification of the resource.
    internal partial interface IAccountResourceSystemDataInternal

    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string CreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? LastModifiedAt { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string LastModifiedByType { get; set; }

    }
}