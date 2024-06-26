// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for VpnServerConfigurationsAssociatedWithVirtualWanOperations
    /// </summary>
    public static partial class VpnServerConfigurationsAssociatedWithVirtualWanOperationsExtensions
    {
        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual Wan in a
        /// resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations is
        /// needed.
        /// </param>
        public static VpnServerConfigurationsResponse List(this IVpnServerConfigurationsAssociatedWithVirtualWanOperations operations, string resourceGroupName, string virtualWANName)
        {
                return ((IVpnServerConfigurationsAssociatedWithVirtualWanOperations)operations).ListAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual Wan in a
        /// resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations is
        /// needed.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfigurationsResponse> ListAsync(this IVpnServerConfigurationsAssociatedWithVirtualWanOperations operations, string resourceGroupName, string virtualWANName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual Wan in a
        /// resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations is
        /// needed.
        /// </param>
        public static VpnServerConfigurationsResponse BeginList(this IVpnServerConfigurationsAssociatedWithVirtualWanOperations operations, string resourceGroupName, string virtualWANName)
        {
                return ((IVpnServerConfigurationsAssociatedWithVirtualWanOperations)operations).BeginListAsync(resourceGroupName, virtualWANName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual Wan in a
        /// resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations is
        /// needed.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfigurationsResponse> BeginListAsync(this IVpnServerConfigurationsAssociatedWithVirtualWanOperations operations, string resourceGroupName, string virtualWANName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginListWithHttpMessagesAsync(resourceGroupName, virtualWANName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
