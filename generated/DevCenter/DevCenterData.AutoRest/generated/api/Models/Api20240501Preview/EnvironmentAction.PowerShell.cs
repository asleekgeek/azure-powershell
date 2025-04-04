// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.PowerShell;

    /// <summary>An upcoming Environment Action.</summary>
    [System.ComponentModel.TypeConverter(typeof(EnvironmentActionTypeConverter))]
    public partial class EnvironmentAction
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentAction"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentAction DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EnvironmentAction(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentAction"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentAction DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EnvironmentAction(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EnvironmentAction(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Next"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Next = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentNextAction) content.GetValueForProperty("Next",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Next, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentNextActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NextScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).NextScheduledTime = (global::System.DateTime?) content.GetValueForProperty("NextScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).NextScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EnvironmentAction(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Next"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Next = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentNextAction) content.GetValueForProperty("Next",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Next, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.EnvironmentNextActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).ActionType = (string) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).ActionType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NextScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).NextScheduledTime = (global::System.DateTime?) content.GetValueForProperty("NextScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentActionInternal)this).NextScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EnvironmentAction" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EnvironmentAction" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IEnvironmentAction FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An upcoming Environment Action.
    [System.ComponentModel.TypeConverter(typeof(EnvironmentActionTypeConverter))]
    public partial interface IEnvironmentAction

    {

    }
}