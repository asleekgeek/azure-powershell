// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Properties of the cluster pool underlying AKS cluster.</summary>
    public partial class AksClusterProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfile,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileInternal
    {

        /// <summary>ClientId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public string AkClusterAgentPoolIdentityProfileMsiClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiClientId = value ?? null; }

        /// <summary>ObjectId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public string AkClusterAgentPoolIdentityProfileMsiObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiObjectId = value ?? null; }

        /// <summary>ResourceId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public string AkClusterAgentPoolIdentityProfileMsiResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IIdentityProfileInternal)AksClusterAgentPoolIdentityProfile).MsiResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="AksClusterAgentPoolIdentityProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileAksClusterAgentPoolIdentityProfile _aksClusterAgentPoolIdentityProfile;

        /// <summary>Identity properties of the AKS cluster agentpool MSI</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileAksClusterAgentPoolIdentityProfile AksClusterAgentPoolIdentityProfile { get => (this._aksClusterAgentPoolIdentityProfile = this._aksClusterAgentPoolIdentityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.AksClusterProfileAksClusterAgentPoolIdentityProfile()); set => this._aksClusterAgentPoolIdentityProfile = value; }

        /// <summary>Backing field for <see cref="AksClusterResourceId" /> property.</summary>
        private string _aksClusterResourceId;

        /// <summary>ARM Resource ID of the AKS cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string AksClusterResourceId { get => this._aksClusterResourceId; set => this._aksClusterResourceId = value; }

        /// <summary>Backing field for <see cref="AksVersion" /> property.</summary>
        private string _aksVersion;

        /// <summary>AKS control plane and default node pool version of this ClusterPool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string AksVersion { get => this._aksVersion; }

        /// <summary>Internal Acessors for AksClusterAgentPoolIdentityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileAksClusterAgentPoolIdentityProfile Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileInternal.AksClusterAgentPoolIdentityProfile { get => (this._aksClusterAgentPoolIdentityProfile = this._aksClusterAgentPoolIdentityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.AksClusterProfileAksClusterAgentPoolIdentityProfile()); set { {_aksClusterAgentPoolIdentityProfile = value;} } }

        /// <summary>Internal Acessors for AksVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileInternal.AksVersion { get => this._aksVersion; set { {_aksVersion = value;} } }

        /// <summary>Creates an new <see cref="AksClusterProfile" /> instance.</summary>
        public AksClusterProfile()
        {

        }
    }
    /// Properties of the cluster pool underlying AKS cluster.
    public partial interface IAksClusterProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>ClientId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ClientId of the MSI.",
        SerializedName = @"msiClientId",
        PossibleTypes = new [] { typeof(string) })]
        string AkClusterAgentPoolIdentityProfileMsiClientId { get; set; }
        /// <summary>ObjectId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ObjectId of the MSI.",
        SerializedName = @"msiObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string AkClusterAgentPoolIdentityProfileMsiObjectId { get; set; }
        /// <summary>ResourceId of the MSI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceId of the MSI.",
        SerializedName = @"msiResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AkClusterAgentPoolIdentityProfileMsiResourceId { get; set; }
        /// <summary>ARM Resource ID of the AKS cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM Resource ID of the AKS cluster",
        SerializedName = @"aksClusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AksClusterResourceId { get; set; }
        /// <summary>AKS control plane and default node pool version of this ClusterPool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"AKS control plane and default node pool version of this ClusterPool",
        SerializedName = @"aksVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AksVersion { get;  }

    }
    /// Properties of the cluster pool underlying AKS cluster.
    internal partial interface IAksClusterProfileInternal

    {
        /// <summary>ClientId of the MSI.</summary>
        string AkClusterAgentPoolIdentityProfileMsiClientId { get; set; }
        /// <summary>ObjectId of the MSI.</summary>
        string AkClusterAgentPoolIdentityProfileMsiObjectId { get; set; }
        /// <summary>ResourceId of the MSI.</summary>
        string AkClusterAgentPoolIdentityProfileMsiResourceId { get; set; }
        /// <summary>Identity properties of the AKS cluster agentpool MSI</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IAksClusterProfileAksClusterAgentPoolIdentityProfile AksClusterAgentPoolIdentityProfile { get; set; }
        /// <summary>ARM Resource ID of the AKS cluster</summary>
        string AksClusterResourceId { get; set; }
        /// <summary>AKS control plane and default node pool version of this ClusterPool</summary>
        string AksVersion { get; set; }

    }
}