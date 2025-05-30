// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Restore status
    /// </summary>
    public partial class RestoreStatus
    {
        /// <summary>
        /// Initializes a new instance of the RestoreStatus class.
        /// </summary>
        public RestoreStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestoreStatus class.
        /// </summary>

        /// <param name="healthy">Restore health status
        /// </param>

        /// <param name="relationshipStatus">Status of the restore SnapMirror relationship
        /// Possible values include: &#39;Idle&#39;, &#39;Transferring&#39;, &#39;Failed&#39;, &#39;Unknown&#39;</param>

        /// <param name="mirrorState">The status of the restore
        /// Possible values include: &#39;Uninitialized&#39;, &#39;Mirrored&#39;, &#39;Broken&#39;</param>

        /// <param name="unhealthyReason">Reason for the unhealthy restore relationship
        /// </param>

        /// <param name="errorMessage">Displays error message if the restore is in an error state
        /// </param>

        /// <param name="totalTransferBytes">Displays the total bytes transferred
        /// </param>
        public RestoreStatus(bool? healthy = default(bool?), string relationshipStatus = default(string), string mirrorState = default(string), string unhealthyReason = default(string), string errorMessage = default(string), long? totalTransferBytes = default(long?))

        {
            this.Healthy = healthy;
            this.RelationshipStatus = relationshipStatus;
            this.MirrorState = mirrorState;
            this.UnhealthyReason = unhealthyReason;
            this.ErrorMessage = errorMessage;
            this.TotalTransferBytes = totalTransferBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets restore health status
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "healthy")]
        public bool? Healthy {get; private set; }

        /// <summary>
        /// Gets status of the restore SnapMirror relationship Possible values include: &#39;Idle&#39;, &#39;Transferring&#39;, &#39;Failed&#39;, &#39;Unknown&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "relationshipStatus")]
        public string RelationshipStatus {get; private set; }

        /// <summary>
        /// Gets the status of the restore Possible values include: &#39;Uninitialized&#39;, &#39;Mirrored&#39;, &#39;Broken&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mirrorState")]
        public string MirrorState {get; private set; }

        /// <summary>
        /// Gets reason for the unhealthy restore relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unhealthyReason")]
        public string UnhealthyReason {get; private set; }

        /// <summary>
        /// Gets displays error message if the restore is in an error state
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage {get; private set; }

        /// <summary>
        /// Gets displays the total bytes transferred
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "totalTransferBytes")]
        public long? TotalTransferBytes {get; private set; }
    }
}