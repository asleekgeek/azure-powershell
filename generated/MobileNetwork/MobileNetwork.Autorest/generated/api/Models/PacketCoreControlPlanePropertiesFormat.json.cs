// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Packet core control plane properties.</summary>
    public partial class PacketCoreControlPlanePropertiesFormat
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPacketCoreControlPlanePropertiesFormat.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPacketCoreControlPlanePropertiesFormat.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPacketCoreControlPlanePropertiesFormat FromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json ? new PacketCoreControlPlanePropertiesFormat(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject into a new instance of <see cref="PacketCoreControlPlanePropertiesFormat" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PacketCoreControlPlanePropertiesFormat(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_installation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("installation"), out var __jsonInstallation) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Installation.FromJson(__jsonInstallation) : _installation;}
            {_platform = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("platform"), out var __jsonPlatform) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.PlatformConfiguration.FromJson(__jsonPlatform) : _platform;}
            {_controlPlaneAccessInterface = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("controlPlaneAccessInterface"), out var __jsonControlPlaneAccessInterface) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.InterfaceProperties.FromJson(__jsonControlPlaneAccessInterface) : _controlPlaneAccessInterface;}
            {_localDiagnosticsAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("localDiagnosticsAccess"), out var __jsonLocalDiagnosticsAccess) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.LocalDiagnosticsAccessConfiguration.FromJson(__jsonLocalDiagnosticsAccess) : _localDiagnosticsAccess;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_site = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray>("sites"), out var __jsonSites) ? If( __jsonSites as Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteResourceId>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteResourceId) (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SiteResourceId.FromJson(__u) )) ))() : null : _site;}
            {_coreNetworkTechnology = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("coreNetworkTechnology"), out var __jsonCoreNetworkTechnology) ? (string)__jsonCoreNetworkTechnology : (string)_coreNetworkTechnology;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)_version;}
            {_rollbackVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("rollbackVersion"), out var __jsonRollbackVersion) ? (string)__jsonRollbackVersion : (string)_rollbackVersion;}
            {_sku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("sku"), out var __jsonSku) ? (string)__jsonSku : (string)_sku;}
            {_ueMtu = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNumber>("ueMtu"), out var __jsonUeMtu) ? (int?)__jsonUeMtu : _ueMtu;}
            {_interopSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("interopSettings"), out var __jsonInteropSettings) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.PacketCoreControlPlanePropertiesFormatInteropSettings.FromJson(__jsonInteropSettings) : _interopSetting;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PacketCoreControlPlanePropertiesFormat" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PacketCoreControlPlanePropertiesFormat" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._installation ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._installation.ToJson(null,serializationMode) : null, "installation" ,container.Add );
            }
            AddIf( null != this._platform ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._platform.ToJson(null,serializationMode) : null, "platform" ,container.Add );
            AddIf( null != this._controlPlaneAccessInterface ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._controlPlaneAccessInterface.ToJson(null,serializationMode) : null, "controlPlaneAccessInterface" ,container.Add );
            AddIf( null != this._localDiagnosticsAccess ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._localDiagnosticsAccess.ToJson(null,serializationMode) : null, "localDiagnosticsAccess" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._site)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.XNodeArray();
                foreach( var __x in this._site )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("sites",__w);
            }
            AddIf( null != (((object)this._coreNetworkTechnology)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._coreNetworkTechnology.ToString()) : null, "coreNetworkTechnology" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._rollbackVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._rollbackVersion.ToString()) : null, "rollbackVersion" ,container.Add );
            }
            AddIf( null != (((object)this._sku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._sku.ToString()) : null, "sku" ,container.Add );
            AddIf( null != this._ueMtu ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNumber((int)this._ueMtu) : null, "ueMtu" ,container.Add );
            AddIf( null != this._interopSetting ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._interopSetting.ToJson(null,serializationMode) : null, "interopSettings" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}