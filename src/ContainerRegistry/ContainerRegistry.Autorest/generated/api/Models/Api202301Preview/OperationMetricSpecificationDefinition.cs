// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The definition of Azure Monitoring metric.</summary>
    public partial class OperationMetricSpecificationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IOperationMetricSpecificationDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IOperationMetricSpecificationDefinitionInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>Metric aggregation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>Metric description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Metric display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="InternalMetricName" /> property.</summary>
        private string _internalMetricName;

        /// <summary>Internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string InternalMetricName { get => this._internalMetricName; set => this._internalMetricName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>Metric unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="OperationMetricSpecificationDefinition" /> instance.</summary>
        public OperationMetricSpecificationDefinition()
        {

        }
    }
    /// The definition of Azure Monitoring metric.
    public partial interface IOperationMetricSpecificationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Metric aggregation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric aggregation type.",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>Metric description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric description.",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Metric display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Internal metric name.",
        SerializedName = @"internalMetricName",
        PossibleTypes = new [] { typeof(string) })]
        string InternalMetricName { get; set; }
        /// <summary>Metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Metric unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric unit.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// The definition of Azure Monitoring metric.
    internal partial interface IOperationMetricSpecificationDefinitionInternal

    {
        /// <summary>Metric aggregation type.</summary>
        string AggregationType { get; set; }
        /// <summary>Metric description.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Metric display name.</summary>
        string DisplayName { get; set; }
        /// <summary>Internal metric name.</summary>
        string InternalMetricName { get; set; }
        /// <summary>Metric name.</summary>
        string Name { get; set; }
        /// <summary>Metric unit.</summary>
        string Unit { get; set; }

    }
}