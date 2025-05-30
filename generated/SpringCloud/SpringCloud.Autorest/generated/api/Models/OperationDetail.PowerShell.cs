// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Operation detail payload</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationDetailTypeConverter))]
    public partial class OperationDetail
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetail DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationDetail(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetail DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationDetail(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationDetail" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OperationDetail" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetail FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationDetail(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IsDataAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).IsDataAction = (bool?) content.GetValueForProperty("IsDataAction",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).IsDataAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("Origin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Origin, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IServiceSpecification) content.GetValueForProperty("ServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ServiceSpecificationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceSpecificationLogSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationLogSpecification = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ILogSpecification>) content.GetValueForProperty("ServiceSpecificationLogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationLogSpecification, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ILogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.LogSpecificationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceSpecificationMetricSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationMetricSpecification = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecification>) content.GetValueForProperty("ServiceSpecificationMetricSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationMetricSpecification, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.MetricSpecificationTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationDetail(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.OperationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IsDataAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).IsDataAction = (bool?) content.GetValueForProperty("IsDataAction",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).IsDataAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("Origin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).Origin, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IServiceSpecification) content.GetValueForProperty("ServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ServiceSpecificationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceSpecificationLogSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationLogSpecification = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ILogSpecification>) content.GetValueForProperty("ServiceSpecificationLogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationLogSpecification, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ILogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.LogSpecificationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceSpecificationMetricSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationMetricSpecification = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecification>) content.GetValueForProperty("ServiceSpecificationMetricSpecification",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IOperationDetailInternal)this).ServiceSpecificationMetricSpecification, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.MetricSpecificationTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Operation detail payload
    [System.ComponentModel.TypeConverter(typeof(OperationDetailTypeConverter))]
    public partial interface IOperationDetail

    {

    }
}