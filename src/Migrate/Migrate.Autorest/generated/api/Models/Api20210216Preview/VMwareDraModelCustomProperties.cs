// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMware DRA model custom properties.</summary>
    public partial class VMwareDraModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomProperties __draModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.DraModelCustomProperties();

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>Gets or sets the BIOS Id of the DRA machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; set => this._biosId = value; }

        /// <summary>Gets or sets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)__draModelCustomProperties).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)__draModelCustomProperties).InstanceType = value ; }

        /// <summary>Gets or sets the authority of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).AadAuthority = value ; }

        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).ApplicationId = value ; }

        /// <summary>Gets or sets the audience of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).Audience = value ; }

        /// <summary>Gets or sets the object Id of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).ObjectId = value ; }

        /// <summary>Gets or sets the tenant Id of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModelInternal)MarsAuthenticationIdentity).TenantId = value ; }

        /// <summary>Backing field for <see cref="MarsAuthenticationIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel _marsAuthenticationIdentity;

        /// <summary>Identity model.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel MarsAuthenticationIdentity { get => (this._marsAuthenticationIdentity = this._marsAuthenticationIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IdentityModel()); set => this._marsAuthenticationIdentity = value; }

        /// <summary>Internal Acessors for MarsAuthenticationIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal.MarsAuthenticationIdentity { get => (this._marsAuthenticationIdentity = this._marsAuthenticationIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IdentityModel()); set { {_marsAuthenticationIdentity = value;} } }

        /// <summary>Creates an new <see cref="VMwareDraModelCustomProperties" /> instance.</summary>
        public VMwareDraModelCustomProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__draModelCustomProperties), __draModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__draModelCustomProperties), __draModelCustomProperties);
        }
    }
    /// VMware DRA model custom properties.
    public partial interface IVMwareDraModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomProperties
    {
        /// <summary>Gets or sets the BIOS Id of the DRA machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the BIOS Id of the DRA machine.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>Gets or sets the authority of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the authority of the SPN with which Dra communicates to service.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityAadAuthority { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the client/application Id of the SPN with which Dra communicates to
        service.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityApplicationId { get; set; }
        /// <summary>Gets or sets the audience of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the audience of the SPN with which Dra communicates to service.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityAudience { get; set; }
        /// <summary>Gets or sets the object Id of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the object Id of the SPN with which Dra communicates to service.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityObjectId { get; set; }
        /// <summary>Gets or sets the tenant Id of the SPN with which Dra communicates to service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the tenant Id of the SPN with which Dra communicates to service.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityTenantId { get; set; }

    }
    /// VMware DRA model custom properties.
    internal partial interface IVMwareDraModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets the BIOS Id of the DRA machine.</summary>
        string BiosId { get; set; }
        /// <summary>Gets or sets the authority of the SPN with which Dra communicates to service.</summary>
        string MarAuthenticationIdentityAadAuthority { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </summary>
        string MarAuthenticationIdentityApplicationId { get; set; }
        /// <summary>Gets or sets the audience of the SPN with which Dra communicates to service.</summary>
        string MarAuthenticationIdentityAudience { get; set; }
        /// <summary>Gets or sets the object Id of the SPN with which Dra communicates to service.</summary>
        string MarAuthenticationIdentityObjectId { get; set; }
        /// <summary>Gets or sets the tenant Id of the SPN with which Dra communicates to service.</summary>
        string MarAuthenticationIdentityTenantId { get; set; }
        /// <summary>Identity model.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel MarsAuthenticationIdentity { get; set; }

    }
}