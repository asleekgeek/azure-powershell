// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Class to represent shoebox service specification in json client discovery.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClientDiscoveryForServiceSpecificationTypeConverter))]
    public partial class ClientDiscoveryForServiceSpecification
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForServiceSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClientDiscoveryForServiceSpecification(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecificationInternal)this).LogSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForLogSpecification[]) content.GetValueForProperty("LogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecificationInternal)this).LogSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForLogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForLogSpecificationTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForServiceSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClientDiscoveryForServiceSpecification(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecificationInternal)this).LogSpecification = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForLogSpecification[]) content.GetValueForProperty("LogSpecification",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecificationInternal)this).LogSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForLogSpecification>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForLogSpecificationTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForServiceSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecification"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecification DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClientDiscoveryForServiceSpecification(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ClientDiscoveryForServiceSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecification"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecification DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClientDiscoveryForServiceSpecification(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClientDiscoveryForServiceSpecification" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ClientDiscoveryForServiceSpecification" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IClientDiscoveryForServiceSpecification FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class to represent shoebox service specification in json client discovery.
    [System.ComponentModel.TypeConverter(typeof(ClientDiscoveryForServiceSpecificationTypeConverter))]
    public partial interface IClientDiscoveryForServiceSpecification

    {

    }
}