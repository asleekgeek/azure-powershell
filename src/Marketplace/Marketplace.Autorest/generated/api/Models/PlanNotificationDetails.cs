// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Plan notification details</summary>
    public partial class PlanNotificationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanNotificationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanNotificationDetailsInternal
    {

        /// <summary>Backing field for <see cref="PlanDisplayName" /> property.</summary>
        private string _planDisplayName;

        /// <summary>Gets or sets the plan display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PlanDisplayName { get => this._planDisplayName; set => this._planDisplayName = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>Gets or sets the plan id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Creates an new <see cref="PlanNotificationDetails" /> instance.</summary>
        public PlanNotificationDetails()
        {

        }
    }
    /// Plan notification details
    public partial interface IPlanNotificationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the plan display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the plan display name",
        SerializedName = @"planDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PlanDisplayName { get; set; }
        /// <summary>Gets or sets the plan id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the plan id",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }

    }
    /// Plan notification details
    internal partial interface IPlanNotificationDetailsInternal

    {
        /// <summary>Gets or sets the plan display name</summary>
        string PlanDisplayName { get; set; }
        /// <summary>Gets or sets the plan id</summary>
        string PlanId { get; set; }

    }
}