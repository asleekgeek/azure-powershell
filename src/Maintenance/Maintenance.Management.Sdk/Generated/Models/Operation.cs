// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Maintenance.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an operation returned by the GetOperations request
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>

        /// <param name="name">Name of the operation
        /// </param>

        /// <param name="display">Display name of the operation
        /// </param>

        /// <param name="origin">Origin of the operation
        /// </param>

        /// <param name="properties">Properties of the operation
        /// </param>

        /// <param name="isDataAction">Indicates whether the operation is a data action
        /// </param>
        public Operation(string name = default(string), OperationInfo display = default(OperationInfo), string origin = default(string), object properties = default(object), bool? isDataAction = default(bool?))

        {
            this.Name = name;
            this.Display = display;
            this.Origin = origin;
            this.Properties = properties;
            this.IsDataAction = isDataAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets display name of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "display")]
        public OperationInfo Display {get; set; }

        /// <summary>
        /// Gets or sets origin of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "origin")]
        public string Origin {get; set; }

        /// <summary>
        /// Gets or sets properties of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public object Properties {get; set; }

        /// <summary>
        /// Gets or sets indicates whether the operation is a data action
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction {get; set; }
    }
}