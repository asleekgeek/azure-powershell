// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// New Protection profile input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("New")]
    public partial class NewProtectionProfile : ProtectionProfileCustomDetails
    {
        /// <summary>
        /// Initializes a new instance of the NewProtectionProfile class.
        /// </summary>
        public NewProtectionProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewProtectionProfile class.
        /// </summary>

        /// <param name="policyName">The protection profile input.
        /// </param>

        /// <param name="recoveryPointHistory">The duration in minutes until which the recovery points need to be stored.
        /// </param>

        /// <param name="crashConsistentFrequencyInMinutes">The crash consistent snapshot frequency (in minutes).
        /// </param>

        /// <param name="appConsistentFrequencyInMinutes">The app consistent snapshot frequency (in minutes).
        /// </param>

        /// <param name="multiVMSyncStatus">A value indicating whether multi-VM sync has to be enabled. Value should be
        /// &#39;Enabled&#39; or &#39;Disabled&#39;.
        /// Possible values include: &#39;Enable&#39;, &#39;Disable&#39;</param>
        public NewProtectionProfile(string policyName, string multiVMSyncStatus, int? recoveryPointHistory = default(int?), int? crashConsistentFrequencyInMinutes = default(int?), int? appConsistentFrequencyInMinutes = default(int?))

        {
            this.PolicyName = policyName;
            this.RecoveryPointHistory = recoveryPointHistory;
            this.CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            this.AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            this.MultiVMSyncStatus = multiVMSyncStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the protection profile input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyName")]
        public string PolicyName {get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes until which the recovery points need
        /// to be stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointHistory")]
        public int? RecoveryPointHistory {get; set; }

        /// <summary>
        /// Gets or sets the crash consistent snapshot frequency (in minutes).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "crashConsistentFrequencyInMinutes")]
        public int? CrashConsistentFrequencyInMinutes {get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency (in minutes).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi-VM sync has to be enabled.
        /// Value should be &#39;Enabled&#39; or &#39;Disabled&#39;. Possible values include: &#39;Enable&#39;, &#39;Disable&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVMSyncStatus {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.PolicyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PolicyName");
            }
            if (this.MultiVMSyncStatus == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MultiVMSyncStatus");
            }


        }
    }
}