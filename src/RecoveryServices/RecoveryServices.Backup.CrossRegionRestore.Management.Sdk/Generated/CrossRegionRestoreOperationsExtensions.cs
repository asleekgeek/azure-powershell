// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for CrossRegionRestoreOperations
    /// </summary>
    public static partial class CrossRegionRestoreOperationsExtensions
    {
        /// <summary>
        /// Restores the specified backed up data in a different region as compared to where the data is backed up.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='azureRegion'>
        /// Azure region to hit Api
        /// </param>
        public static void Trigger(this ICrossRegionRestoreOperations operations, string azureRegion, CrrAccessToken crossRegionRestoreAccessDetails = default(CrrAccessToken), RestoreRequest restoreRequest = default(RestoreRequest))
        {
                ((ICrossRegionRestoreOperations)operations).TriggerAsync(azureRegion, crossRegionRestoreAccessDetails, restoreRequest).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restores the specified backed up data in a different region as compared to where the data is backed up.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='azureRegion'>
        /// Azure region to hit Api
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task TriggerAsync(this ICrossRegionRestoreOperations operations, string azureRegion, CrrAccessToken crossRegionRestoreAccessDetails = default(CrrAccessToken), RestoreRequest restoreRequest = default(RestoreRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.TriggerWithHttpMessagesAsync(azureRegion, crossRegionRestoreAccessDetails, restoreRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Restores the specified backed up data in a different region as compared to where the data is backed up.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='azureRegion'>
        /// Azure region to hit Api
        /// </param>
        public static void BeginTrigger(this ICrossRegionRestoreOperations operations, string azureRegion, CrrAccessToken crossRegionRestoreAccessDetails = default(CrrAccessToken), RestoreRequest restoreRequest = default(RestoreRequest))
        {
                ((ICrossRegionRestoreOperations)operations).BeginTriggerAsync(azureRegion, crossRegionRestoreAccessDetails, restoreRequest).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restores the specified backed up data in a different region as compared to where the data is backed up.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='azureRegion'>
        /// Azure region to hit Api
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginTriggerAsync(this ICrossRegionRestoreOperations operations, string azureRegion, CrrAccessToken crossRegionRestoreAccessDetails = default(CrrAccessToken), RestoreRequest restoreRequest = default(RestoreRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginTriggerWithHttpMessagesAsync(azureRegion, crossRegionRestoreAccessDetails, restoreRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
    }
}
