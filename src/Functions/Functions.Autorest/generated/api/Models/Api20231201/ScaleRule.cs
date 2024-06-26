// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Container App container scaling rule.</summary>
    public partial class ScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRule,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleInternal
    {

        /// <summary>Backing field for <see cref="AzureQueue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRule _azureQueue;

        /// <summary>Azure Queue based scaling.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRule AzureQueue { get => (this._azureQueue = this._azureQueue ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.QueueScaleRule()); set => this._azureQueue = value; }

        /// <summary>Authentication secrets for the queue scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] AzureQueueAuth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).Auth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).Auth = value ?? null /* arrayOf */; }

        /// <summary>Queue length.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? AzureQueueLength { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).QueueLength; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).QueueLength = value ?? default(int); }

        /// <summary>Queue name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string AzureQueueName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).QueueName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRuleInternal)AzureQueue).QueueName = value ?? null; }

        /// <summary>Backing field for <see cref="Custom" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRule _custom;

        /// <summary>Custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRule Custom { get => (this._custom = this._custom ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomScaleRule()); set => this._custom = value; }

        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] CustomAuth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Auth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Auth = value ?? null /* arrayOf */; }

        /// <summary>Metadata properties to describe custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleMetadata CustomMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Metadata = value ?? null /* model class */; }

        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string CustomType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleInternal)Custom).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Http" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRule _http;

        /// <summary>HTTP requests based scaling.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRule Http { get => (this._http = this._http ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.HttpScaleRule()); set => this._http = value; }

        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] HttpAuth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleInternal)Http).Auth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleInternal)Http).Auth = value ?? null /* arrayOf */; }

        /// <summary>Metadata properties to describe http scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata HttpMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleInternal)Http).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleInternal)Http).Metadata = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AzureQueue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRule Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleInternal.AzureQueue { get => (this._azureQueue = this._azureQueue ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.QueueScaleRule()); set { {_azureQueue = value;} } }

        /// <summary>Internal Acessors for Custom</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRule Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleInternal.Custom { get => (this._custom = this._custom ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomScaleRule()); set { {_custom = value;} } }

        /// <summary>Internal Acessors for Http</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRule Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleInternal.Http { get => (this._http = this._http ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.HttpScaleRule()); set { {_http = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Scale Rule Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ScaleRule" /> instance.</summary>
        public ScaleRule()
        {

        }
    }
    /// Container App container scaling rule.
    public partial interface IScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Authentication secrets for the queue scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authentication secrets for the queue scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] AzureQueueAuth { get; set; }
        /// <summary>Queue length.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Queue length.",
        SerializedName = @"queueLength",
        PossibleTypes = new [] { typeof(int) })]
        int? AzureQueueLength { get; set; }
        /// <summary>Queue name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Queue name.",
        SerializedName = @"queueName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureQueueName { get; set; }
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authentication secrets for the custom scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] CustomAuth { get; set; }
        /// <summary>Metadata properties to describe custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata properties to describe custom scale rule.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleMetadata CustomMetadata { get; set; }
        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the custom scale rule
        eg: azure-servicebus, redis etc.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string CustomType { get; set; }
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authentication secrets for the custom scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] HttpAuth { get; set; }
        /// <summary>Metadata properties to describe http scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata properties to describe http scale rule.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata HttpMetadata { get; set; }
        /// <summary>Scale Rule Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scale Rule Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Container App container scaling rule.
    internal partial interface IScaleRuleInternal

    {
        /// <summary>Azure Queue based scaling.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IQueueScaleRule AzureQueue { get; set; }
        /// <summary>Authentication secrets for the queue scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] AzureQueueAuth { get; set; }
        /// <summary>Queue length.</summary>
        int? AzureQueueLength { get; set; }
        /// <summary>Queue name.</summary>
        string AzureQueueName { get; set; }
        /// <summary>Custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRule Custom { get; set; }
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] CustomAuth { get; set; }
        /// <summary>Metadata properties to describe custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomScaleRuleMetadata CustomMetadata { get; set; }
        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        string CustomType { get; set; }
        /// <summary>HTTP requests based scaling.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRule Http { get; set; }
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] HttpAuth { get; set; }
        /// <summary>Metadata properties to describe http scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata HttpMetadata { get; set; }
        /// <summary>Scale Rule Name</summary>
        string Name { get; set; }

    }
}