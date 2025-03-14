// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.PowerShell;

    /// <summary>The setting of the content of markdown part.</summary>
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataSettingsContentSettingsTypeConverter))]
    public partial class MarkdownPartMetadataSettingsContentSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.MarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MarkdownPartMetadataSettingsContentSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.MarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MarkdownPartMetadataSettingsContentSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MarkdownPartMetadataSettingsContentSettings" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="MarkdownPartMetadataSettingsContentSettings" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.MarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MarkdownPartMetadataSettingsContentSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Subtitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Subtitle = (string) content.GetValueForProperty("Subtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Subtitle, global::System.Convert.ToString);
            }
            if (content.Contains("MarkdownSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownSource = (int?) content.GetValueForProperty("MarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MarkdownUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownUri = (string) content.GetValueForProperty("MarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.MarkdownPartMetadataSettingsContentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MarkdownPartMetadataSettingsContentSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Subtitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Subtitle = (string) content.GetValueForProperty("Subtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).Subtitle, global::System.Convert.ToString);
            }
            if (content.Contains("MarkdownSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownSource = (int?) content.GetValueForProperty("MarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MarkdownUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownUri = (string) content.GetValueForProperty("MarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20221201Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)this).MarkdownUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The setting of the content of markdown part.
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataSettingsContentSettingsTypeConverter))]
    public partial interface IMarkdownPartMetadataSettingsContentSettings

    {

    }
}