// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Specifies the operating system settings for the role instance.</summary>
    public partial class OSProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IOSProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IOSProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IOSProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json ? new OSProfile(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject into a new instance of <see cref="OSProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OSProfile(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_linuxConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject>("linuxConfiguration"), out var __jsonLinuxConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.LinuxConfiguration.FromJson(__jsonLinuxConfiguration) : _linuxConfiguration;}
            {_adminUsername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("adminUsername"), out var __jsonAdminUsername) ? (string)__jsonAdminUsername : (string)_adminUsername;}
            {_customData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("customData"), out var __jsonCustomData) ? (string)__jsonCustomData : (string)_customData;}
            {_customDataRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonBoolean>("customDataRequired"), out var __jsonCustomDataRequired) ? (bool?)__jsonCustomDataRequired : _customDataRequired;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OSProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OSProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._linuxConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) this._linuxConfiguration.ToJson(null,serializationMode) : null, "linuxConfiguration" ,container.Add );
            AddIf( null != (((object)this._adminUsername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._adminUsername.ToString()) : null, "adminUsername" ,container.Add );
            AddIf( null != (((object)this._customData)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._customData.ToString()) : null, "customData" ,container.Add );
            AddIf( null != this._customDataRequired ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonBoolean((bool)this._customDataRequired) : null, "customDataRequired" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}