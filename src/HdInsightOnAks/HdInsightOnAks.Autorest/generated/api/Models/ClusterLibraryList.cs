// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Collection of libraries in the cluster.</summary>
    public partial class ClusterLibraryList :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibraryList,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibraryListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibraryListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The url of next result page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary> _value;

        /// <summary>Collection of libraries in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ClusterLibraryList" /> instance.</summary>
        public ClusterLibraryList()
        {

        }
    }
    /// Collection of libraries in the cluster.
    public partial interface IClusterLibraryList :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>The url of next result page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The url of next result page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Collection of libraries in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Collection of libraries in the cluster.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary> Value { get; set; }

    }
    /// Collection of libraries in the cluster.
    internal partial interface IClusterLibraryListInternal

    {
        /// <summary>The url of next result page.</summary>
        string NextLink { get; set; }
        /// <summary>Collection of libraries in the cluster.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary> Value { get; set; }

    }
}