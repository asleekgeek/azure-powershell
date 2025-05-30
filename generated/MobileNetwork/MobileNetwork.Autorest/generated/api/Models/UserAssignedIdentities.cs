// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>
    /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    /// The dictionary values can be empty objects ({}) in requests.
    /// </summary>
    public partial class UserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="UserAssignedIdentities" /> instance.</summary>
        public UserAssignedIdentities()
        {

        }
    }
    /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    /// The dictionary values can be empty objects ({}) in requests.
    public partial interface IUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IUserAssignedIdentity>
    {

    }
    /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
    /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    /// The dictionary values can be empty objects ({}) in requests.
    internal partial interface IUserAssignedIdentitiesInternal

    {

    }
}