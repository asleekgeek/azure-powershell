// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Provider specific unplanned cluster failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ClusterUnplannedFailoverProviderSpecificInput")]
    public partial class ClusterUnplannedFailoverProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUnplannedFailoverProviderSpecificInput class.
        /// </summary>
        public ClusterUnplannedFailoverProviderSpecificInput()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}