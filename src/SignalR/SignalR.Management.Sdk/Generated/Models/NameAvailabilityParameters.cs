// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.SignalR.Models
{
    using System.Linq;

    /// <summary>
    /// Data POST-ed to the nameAvailability action
    /// </summary>
    public partial class NameAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the NameAvailabilityParameters class.
        /// </summary>
        public NameAvailabilityParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NameAvailabilityParameters class.
        /// </summary>

        /// <param name="type">The resource type. Can be &#34;Microsoft.SignalRService/SignalR&#34; or
        /// &#34;Microsoft.SignalRService/webPubSub&#34;
        /// </param>

        /// <param name="name">The resource name to validate. e.g.&#34;my-resource-name&#34;
        /// </param>
        public NameAvailabilityParameters(string type, string name)

        {
            this.Type = type;
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the resource type. Can be &#34;Microsoft.SignalRService/SignalR&#34;
        /// or &#34;Microsoft.SignalRService/webPubSub&#34;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets the resource name to validate. e.g.&#34;my-resource-name&#34;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }


        }
    }
}