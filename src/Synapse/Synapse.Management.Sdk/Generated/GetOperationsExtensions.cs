// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GetOperations
    /// </summary>
    public static partial class GetOperationsExtensions
    {
        /// <summary>
        /// Get an integration runtime start operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        public static IntegrationRuntimeOperationStatus IntegrationRuntimeStart(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId)
        {
                return ((IGetOperations)operations).IntegrationRuntimeStartAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an integration runtime start operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IntegrationRuntimeOperationStatus> IntegrationRuntimeStartAsync(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.IntegrationRuntimeStartWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get an integration runtime stop operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        public static IntegrationRuntimeStopOperationStatus IntegrationRuntimeStop(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId)
        {
                return ((IGetOperations)operations).IntegrationRuntimeStopAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an integration runtime stop operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IntegrationRuntimeStopOperationStatus> IntegrationRuntimeStopAsync(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.IntegrationRuntimeStopWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get an integration runtime enable interactivequery operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        public static IntegrationRuntimeEnableinteractivequery IntegrationRuntimeEnableInteractivequery(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId)
        {
                return ((IGetOperations)operations).IntegrationRuntimeEnableInteractivequeryAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an integration runtime enable interactivequery operation status
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='integrationRuntimeOperationId'>
        /// Integration runtime Operation Id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IntegrationRuntimeEnableinteractivequery> IntegrationRuntimeEnableInteractivequeryAsync(this IGetOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string integrationRuntimeOperationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.IntegrationRuntimeEnableInteractivequeryWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, integrationRuntimeOperationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
