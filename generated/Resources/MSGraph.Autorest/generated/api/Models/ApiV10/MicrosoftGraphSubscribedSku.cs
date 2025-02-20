// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>subscribedSku</summary>
    public partial class MicrosoftGraphSubscribedSku :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSubscribedSku,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSubscribedSkuInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="AppliesTo" /> property.</summary>
        private string _appliesTo;

        /// <summary>For example, 'User' or 'Company'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AppliesTo { get => this._appliesTo; set => this._appliesTo = value; }

        /// <summary>Backing field for <see cref="CapabilityStatus" /> property.</summary>
        private string _capabilityStatus;

        /// <summary>
        /// Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits
        /// property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string CapabilityStatus { get => this._capabilityStatus; set => this._capabilityStatus = value; }

        /// <summary>Backing field for <see cref="ConsumedUnit" /> property.</summary>
        private int? _consumedUnit;

        /// <summary>The number of licenses that have been assigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? ConsumedUnit { get => this._consumedUnit; set => this._consumedUnit = value; }

        /// <summary>The unique idenfier for an entity. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value ?? null; }

        /// <summary>Backing field for <see cref="PrepaidUnit" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail _prepaidUnit;

        /// <summary>licenseUnitsDetail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail PrepaidUnit { get => (this._prepaidUnit = this._prepaidUnit ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphLicenseUnitsDetail()); set => this._prepaidUnit = value; }

        /// <summary>Backing field for <see cref="ServicePlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePlanInfo[] _servicePlan;

        /// <summary>
        /// Information about the service plans that are available with the SKU. Not nullable
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePlanInfo[] ServicePlan { get => this._servicePlan; set => this._servicePlan = value; }

        /// <summary>Backing field for <see cref="SkuId" /> property.</summary>
        private string _skuId;

        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string SkuId { get => this._skuId; set => this._skuId = value; }

        /// <summary>Backing field for <see cref="SkuPartNumber" /> property.</summary>
        private string _skuPartNumber;

        /// <summary>
        /// The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization
        /// has acquired, see List subscribedSkus.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string SkuPartNumber { get => this._skuPartNumber; set => this._skuPartNumber = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphSubscribedSku" /> instance.</summary>
        public MicrosoftGraphSubscribedSku()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
        }
    }
    /// subscribedSku
    public partial interface IMicrosoftGraphSubscribedSku :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity
    {
        /// <summary>For example, 'User' or 'Company'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For example, 'User' or 'Company'.",
        SerializedName = @"appliesTo",
        PossibleTypes = new [] { typeof(string) })]
        string AppliesTo { get; set; }
        /// <summary>
        /// Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits
        /// property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.",
        SerializedName = @"capabilityStatus",
        PossibleTypes = new [] { typeof(string) })]
        string CapabilityStatus { get; set; }
        /// <summary>The number of licenses that have been assigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of licenses that have been assigned.",
        SerializedName = @"consumedUnits",
        PossibleTypes = new [] { typeof(int) })]
        int? ConsumedUnit { get; set; }
        /// <summary>licenseUnitsDetail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"licenseUnitsDetail",
        SerializedName = @"prepaidUnits",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail PrepaidUnit { get; set; }
        /// <summary>
        /// Information about the service plans that are available with the SKU. Not nullable
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Information about the service plans that are available with the SKU. Not nullable",
        SerializedName = @"servicePlans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePlanInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePlanInfo[] ServicePlan { get; set; }
        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The unique identifier (GUID) for the service SKU.",
        SerializedName = @"skuId",
        PossibleTypes = new [] { typeof(string) })]
        string SkuId { get; set; }
        /// <summary>
        /// The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization
        /// has acquired, see List subscribedSkus.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.",
        SerializedName = @"skuPartNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SkuPartNumber { get; set; }

    }
    /// subscribedSku
    internal partial interface IMicrosoftGraphSubscribedSkuInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        /// <summary>For example, 'User' or 'Company'.</summary>
        string AppliesTo { get; set; }
        /// <summary>
        /// Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits
        /// property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.
        /// </summary>
        string CapabilityStatus { get; set; }
        /// <summary>The number of licenses that have been assigned.</summary>
        int? ConsumedUnit { get; set; }
        /// <summary>licenseUnitsDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail PrepaidUnit { get; set; }
        /// <summary>
        /// Information about the service plans that are available with the SKU. Not nullable
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePlanInfo[] ServicePlan { get; set; }
        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        string SkuId { get; set; }
        /// <summary>
        /// The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization
        /// has acquired, see List subscribedSkus.
        /// </summary>
        string SkuPartNumber { get; set; }

    }
}