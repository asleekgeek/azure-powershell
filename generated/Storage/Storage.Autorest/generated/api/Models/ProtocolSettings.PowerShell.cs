// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.PowerShell;

    /// <summary>Protocol settings for file service</summary>
    [System.ComponentModel.TypeConverter(typeof(ProtocolSettingsTypeConverter))]
    public partial class ProtocolSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ProtocolSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProtocolSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ProtocolSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProtocolSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProtocolSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProtocolSettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ProtocolSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProtocolSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Smb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).Smb = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ISmbSetting) content.GetValueForProperty("Smb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).Smb, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.SmbSettingTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmbMultichannel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbMultichannel = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IMultichannel) content.GetValueForProperty("SmbMultichannel",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbMultichannel, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.MultichannelTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmbVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbVersion = (string) content.GetValueForProperty("SmbVersion",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SmbAuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbAuthenticationMethod = (string) content.GetValueForProperty("SmbAuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbAuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("SmbKerberosTicketEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbKerberosTicketEncryption = (string) content.GetValueForProperty("SmbKerberosTicketEncryption",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbKerberosTicketEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("SmbChannelEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbChannelEncryption = (string) content.GetValueForProperty("SmbChannelEncryption",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbChannelEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("MultichannelEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).MultichannelEnabled = (bool?) content.GetValueForProperty("MultichannelEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).MultichannelEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ProtocolSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProtocolSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Smb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).Smb = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ISmbSetting) content.GetValueForProperty("Smb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).Smb, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.SmbSettingTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmbMultichannel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbMultichannel = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IMultichannel) content.GetValueForProperty("SmbMultichannel",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbMultichannel, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.MultichannelTypeConverter.ConvertFrom);
            }
            if (content.Contains("SmbVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbVersion = (string) content.GetValueForProperty("SmbVersion",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbVersion, global::System.Convert.ToString);
            }
            if (content.Contains("SmbAuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbAuthenticationMethod = (string) content.GetValueForProperty("SmbAuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbAuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("SmbKerberosTicketEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbKerberosTicketEncryption = (string) content.GetValueForProperty("SmbKerberosTicketEncryption",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbKerberosTicketEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("SmbChannelEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbChannelEncryption = (string) content.GetValueForProperty("SmbChannelEncryption",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).SmbChannelEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("MultichannelEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).MultichannelEnabled = (bool?) content.GetValueForProperty("MultichannelEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IProtocolSettingsInternal)this).MultichannelEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Protocol settings for file service
    [System.ComponentModel.TypeConverter(typeof(ProtocolSettingsTypeConverter))]
    public partial interface IProtocolSettings

    {

    }
}