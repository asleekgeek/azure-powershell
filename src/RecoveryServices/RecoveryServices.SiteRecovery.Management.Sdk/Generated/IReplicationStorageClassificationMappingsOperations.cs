// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ReplicationStorageClassificationMappingsOperations operations.
    /// </summary>
    public partial interface IReplicationStorageClassificationMappingsOperations
    {
        /// <summary>
        /// Lists the storage classification mappings for the fabric.
        /// </summary>
        /// <remarks>
        /// Lists the storage classification mappings for the fabric.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<StorageClassificationMapping>>> ListByReplicationStorageClassificationsWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the details of the specified storage classification mapping.
        /// </summary>
        /// <remarks>
        /// Gets the details of the specified storage classification mapping.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<StorageClassificationMapping>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, string storageClassificationMappingName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to create a storage classification mapping.
        /// </summary>
        /// <remarks>
        /// The operation to create a storage classification mapping.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='properties'>
        /// Storage mapping input properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<StorageClassificationMapping>> CreateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageMappingInputProperties properties = default(StorageMappingInputProperties), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to delete a storage classification mapping.
        /// </summary>
        /// <remarks>
        /// The operation to delete a storage classification mapping.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, string storageClassificationMappingName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists the storage classification mappings in the vault.
        /// </summary>
        /// <remarks>
        /// Lists the storage classification mappings in the vault.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<StorageClassificationMapping>>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to create a storage classification mapping.
        /// </summary>
        /// <remarks>
        /// The operation to create a storage classification mapping.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='properties'>
        /// Storage mapping input properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<StorageClassificationMapping>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageMappingInputProperties properties = default(StorageMappingInputProperties), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to delete a storage classification mapping.
        /// </summary>
        /// <remarks>
        /// The operation to delete a storage classification mapping.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='storageClassificationMappingName'>
        /// Storage classification mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, string storageClassificationMappingName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists the storage classification mappings for the fabric.
        /// </summary>
        /// <remarks>
        /// Lists the storage classification mappings for the fabric.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<StorageClassificationMapping>>> ListByReplicationStorageClassificationsNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists the storage classification mappings in the vault.
        /// </summary>
        /// <remarks>
        /// Lists the storage classification mappings in the vault.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<StorageClassificationMapping>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}