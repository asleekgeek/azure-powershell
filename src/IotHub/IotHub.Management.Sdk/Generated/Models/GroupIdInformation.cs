// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System.Linq;

    /// <summary>
    /// The group information for creating a private endpoint on an IotHub
    /// </summary>
    public partial class GroupIdInformation
    {
        /// <summary>
        /// Initializes a new instance of the GroupIdInformation class.
        /// </summary>
        public GroupIdInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupIdInformation class.
        /// </summary>

        /// <param name="id">The resource identifier.
        /// </param>

        /// <param name="name">The resource name.
        /// </param>

        /// <param name="type">The resource type.
        /// </param>

        /// <param name="properties">The properties for a group information object
        /// </param>
        public GroupIdInformation(GroupIdInformationProperties properties, string id = default(string), string name = default(string), string type = default(string))

        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets the properties for a group information object
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public GroupIdInformationProperties Properties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Properties");
            }




        }
    }
}