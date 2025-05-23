// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    /// </summary>
    public partial class ThreeTierFullResourceNames
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IThreeTierFullResourceNames.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IThreeTierFullResourceNames.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IThreeTierFullResourceNames FromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject json ? new ThreeTierFullResourceNames(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject into a new instance of <see cref="ThreeTierFullResourceNames" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ThreeTierFullResourceNames(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __threeTierCustomResourceNames = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.ThreeTierCustomResourceNames(json);
            {_centralServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject>("centralServer"), out var __jsonCentralServer) ? Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.CentralServerFullResourceNames.FromJson(__jsonCentralServer) : CentralServer;}
            {_applicationServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject>("applicationServer"), out var __jsonApplicationServer) ? Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.ApplicationServerFullResourceNames.FromJson(__jsonApplicationServer) : ApplicationServer;}
            {_databaseServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject>("databaseServer"), out var __jsonDatabaseServer) ? Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.DatabaseServerFullResourceNames.FromJson(__jsonDatabaseServer) : DatabaseServer;}
            {_sharedStorage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject>("sharedStorage"), out var __jsonSharedStorage) ? Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.SharedStorageResourceNames.FromJson(__jsonSharedStorage) : SharedStorage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ThreeTierFullResourceNames" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ThreeTierFullResourceNames" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __threeTierCustomResourceNames?.ToJson(container, serializationMode);
            AddIf( null != this._centralServer ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode) this._centralServer.ToJson(null,serializationMode) : null, "centralServer" ,container.Add );
            AddIf( null != this._applicationServer ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode) this._applicationServer.ToJson(null,serializationMode) : null, "applicationServer" ,container.Add );
            AddIf( null != this._databaseServer ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode) this._databaseServer.ToJson(null,serializationMode) : null, "databaseServer" ,container.Add );
            AddIf( null != this._sharedStorage ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Json.JsonNode) this._sharedStorage.ToJson(null,serializationMode) : null, "sharedStorage" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}