// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.PowerShell;

    /// <summary>Describes the properties of a SAP monitor.</summary>
    [System.ComponentModel.TypeConverter(typeof(SapMonitorPropertiesTypeConverter))]
    public partial class SapMonitorProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SapMonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapMonitorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SapMonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapMonitorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapMonitorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SapMonitorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SapMonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapMonitorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ManagedResourceGroupName = (string) content.GetValueForProperty("ManagedResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ManagedResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticsWorkspaceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceArmId = (string) content.GetValueForProperty("LogAnalyticsWorkspaceArmId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("EnableCustomerAnalytic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).EnableCustomerAnalytic = (bool?) content.GetValueForProperty("EnableCustomerAnalytic",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).EnableCustomerAnalytic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LogAnalyticsWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceId = (string) content.GetValueForProperty("LogAnalyticsWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticsWorkspaceSharedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceSharedKey = (string) content.GetValueForProperty("LogAnalyticsWorkspaceSharedKey",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceSharedKey, global::System.Convert.ToString);
            }
            if (content.Contains("SapMonitorCollectorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).SapMonitorCollectorVersion = (string) content.GetValueForProperty("SapMonitorCollectorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).SapMonitorCollectorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("MonitorSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).MonitorSubnet = (string) content.GetValueForProperty("MonitorSubnet",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).MonitorSubnet, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SapMonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapMonitorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ManagedResourceGroupName = (string) content.GetValueForProperty("ManagedResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).ManagedResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticsWorkspaceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceArmId = (string) content.GetValueForProperty("LogAnalyticsWorkspaceArmId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("EnableCustomerAnalytic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).EnableCustomerAnalytic = (bool?) content.GetValueForProperty("EnableCustomerAnalytic",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).EnableCustomerAnalytic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LogAnalyticsWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceId = (string) content.GetValueForProperty("LogAnalyticsWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticsWorkspaceSharedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceSharedKey = (string) content.GetValueForProperty("LogAnalyticsWorkspaceSharedKey",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).LogAnalyticsWorkspaceSharedKey, global::System.Convert.ToString);
            }
            if (content.Contains("SapMonitorCollectorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).SapMonitorCollectorVersion = (string) content.GetValueForProperty("SapMonitorCollectorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).SapMonitorCollectorVersion, global::System.Convert.ToString);
            }
            if (content.Contains("MonitorSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).MonitorSubnet = (string) content.GetValueForProperty("MonitorSubnet",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISapMonitorPropertiesInternal)this).MonitorSubnet, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Describes the properties of a SAP monitor.
    [System.ComponentModel.TypeConverter(typeof(SapMonitorPropertiesTypeConverter))]
    public partial interface ISapMonitorProperties

    {

    }
}