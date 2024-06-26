// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Workload Auto-scaler profile for the managed cluster.
    /// </summary>
    public partial class ManagedClusterWorkloadAutoScalerProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterWorkloadAutoScalerProfile class.
        /// </summary>
        public ManagedClusterWorkloadAutoScalerProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterWorkloadAutoScalerProfile class.
        /// </summary>

        /// <param name="keda">KEDA (Kubernetes Event-driven Autoscaling) settings for the workload
        /// auto-scaler profile.
        /// </param>
        public ManagedClusterWorkloadAutoScalerProfile(ManagedClusterWorkloadAutoScalerProfileKeda keda = default(ManagedClusterWorkloadAutoScalerProfileKeda))

        {
            this.Keda = keda;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets kEDA (Kubernetes Event-driven Autoscaling) settings for the
        /// workload auto-scaler profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keda")]
        public ManagedClusterWorkloadAutoScalerProfileKeda Keda {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Keda != null)
            {
                this.Keda.Validate();
            }
        }
    }
}