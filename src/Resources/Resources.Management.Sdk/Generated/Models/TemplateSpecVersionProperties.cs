// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Template Spec Version properties.
    /// </summary>
    public partial class TemplateSpecVersionProperties
    {
        /// <summary>
        /// Initializes a new instance of the TemplateSpecVersionProperties class.
        /// </summary>
        public TemplateSpecVersionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateSpecVersionProperties class.
        /// </summary>

        /// <param name="description">Template Spec version description.
        /// </param>

        /// <param name="linkedTemplates">An array of linked template artifacts.
        /// </param>

        /// <param name="metadata">The version metadata. Metadata is an open-ended object and is typically a
        /// collection of key-value pairs.
        /// </param>

        /// <param name="mainTemplate">The main Azure Resource Manager template content.
        /// </param>

        /// <param name="uiFormDefinition">The Azure Resource Manager template UI definition content.
        /// </param>
        public TemplateSpecVersionProperties(string description = default(string), System.Collections.Generic.IList<LinkedTemplateArtifact> linkedTemplates = default(System.Collections.Generic.IList<LinkedTemplateArtifact>), object metadata = default(object), object mainTemplate = default(object), object uiFormDefinition = default(object))

        {
            this.Description = description;
            this.LinkedTemplates = linkedTemplates;
            this.Metadata = metadata;
            this.MainTemplate = mainTemplate;
            this.UiFormDefinition = uiFormDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets template Spec version description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets an array of linked template artifacts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linkedTemplates")]
        public System.Collections.Generic.IList<LinkedTemplateArtifact> LinkedTemplates {get; set; }

        /// <summary>
        /// Gets or sets the version metadata. Metadata is an open-ended object and is
        /// typically a collection of key-value pairs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public object Metadata {get; set; }

        /// <summary>
        /// Gets or sets the main Azure Resource Manager template content.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mainTemplate")]
        public object MainTemplate {get; set; }

        /// <summary>
        /// Gets or sets the Azure Resource Manager template UI definition content.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uiFormDefinition")]
        public object UiFormDefinition {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Description != null)
            {
                if (this.Description.Length > 4096)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "Description", 4096);
                }
            }
            if (this.LinkedTemplates != null)
            {
                foreach (var element in this.LinkedTemplates)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }



        }
    }
}