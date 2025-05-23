// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Properties for the container service agent pool profile.</summary>
    public partial class ManagedClusterAgentPoolProfileProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAgentPoolProfileProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAgentPoolProfileProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAgentPoolProfileProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json ? new ManagedClusterAgentPoolProfileProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject into a new instance of <see cref="ManagedClusterAgentPoolProfileProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedClusterAgentPoolProfileProperties(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_upgradeSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("upgradeSettings"), out var __jsonUpgradeSettings) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.AgentPoolUpgradeSettings.FromJson(__jsonUpgradeSettings) : _upgradeSetting;}
            {_powerState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("powerState"), out var __jsonPowerState) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.PowerState.FromJson(__jsonPowerState) : _powerState;}
            {_kubeletConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("kubeletConfig"), out var __jsonKubeletConfig) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.KubeletConfig.FromJson(__jsonKubeletConfig) : _kubeletConfig;}
            {_linuxOSConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("linuxOSConfig"), out var __jsonLinuxOSConfig) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.LinuxOSConfig.FromJson(__jsonLinuxOSConfig) : _linuxOSConfig;}
            {_creationData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("creationData"), out var __jsonCreationData) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.CreationData.FromJson(__jsonCreationData) : _creationData;}
            {_count = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("count"), out var __jsonCount) ? (int?)__jsonCount : _count;}
            {_vMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("vmSize"), out var __jsonVMSize) ? (string)__jsonVMSize : (string)_vMSize;}
            {_oSDiskSizeGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("osDiskSizeGB"), out var __jsonOSDiskSizeGb) ? (int?)__jsonOSDiskSizeGb : _oSDiskSizeGb;}
            {_oSDiskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("osDiskType"), out var __jsonOSDiskType) ? (string)__jsonOSDiskType : (string)_oSDiskType;}
            {_kubeletDiskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("kubeletDiskType"), out var __jsonKubeletDiskType) ? (string)__jsonKubeletDiskType : (string)_kubeletDiskType;}
            {_workloadRuntime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("workloadRuntime"), out var __jsonWorkloadRuntime) ? (string)__jsonWorkloadRuntime : (string)_workloadRuntime;}
            {_vnetSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("vnetSubnetID"), out var __jsonVnetSubnetId) ? (string)__jsonVnetSubnetId : (string)_vnetSubnetId;}
            {_podSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("podSubnetID"), out var __jsonPodSubnetId) ? (string)__jsonPodSubnetId : (string)_podSubnetId;}
            {_maxPod = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("maxPods"), out var __jsonMaxPods) ? (int?)__jsonMaxPods : _maxPod;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_oSSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("osSKU"), out var __jsonOSSku) ? (string)__jsonOSSku : (string)_oSSku;}
            {_maxCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("maxCount"), out var __jsonMaxCount) ? (int?)__jsonMaxCount : _maxCount;}
            {_minCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("minCount"), out var __jsonMinCount) ? (int?)__jsonMinCount : _minCount;}
            {_enableAutoScaling = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableAutoScaling"), out var __jsonEnableAutoScaling) ? (bool?)__jsonEnableAutoScaling : _enableAutoScaling;}
            {_scaleDownMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("scaleDownMode"), out var __jsonScaleDownMode) ? (string)__jsonScaleDownMode : (string)_scaleDownMode;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_mode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("mode"), out var __jsonMode) ? (string)__jsonMode : (string)_mode;}
            {_orchestratorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("orchestratorVersion"), out var __jsonOrchestratorVersion) ? (string)__jsonOrchestratorVersion : (string)_orchestratorVersion;}
            {_currentOrchestratorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("currentOrchestratorVersion"), out var __jsonCurrentOrchestratorVersion) ? (string)__jsonCurrentOrchestratorVersion : (string)_currentOrchestratorVersion;}
            {_nodeImageVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("nodeImageVersion"), out var __jsonNodeImageVersion) ? (string)__jsonNodeImageVersion : (string)_nodeImageVersion;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("availabilityZones"), out var __jsonAvailabilityZones) ? If( __jsonAvailabilityZones as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _availabilityZone;}
            {_enableNodePublicIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableNodePublicIP"), out var __jsonEnableNodePublicIP) ? (bool?)__jsonEnableNodePublicIP : _enableNodePublicIP;}
            {_nodePublicIPPrefixId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("nodePublicIPPrefixID"), out var __jsonNodePublicIPPrefixId) ? (string)__jsonNodePublicIPPrefixId : (string)_nodePublicIPPrefixId;}
            {_scaleSetPriority = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("scaleSetPriority"), out var __jsonScaleSetPriority) ? (string)__jsonScaleSetPriority : (string)_scaleSetPriority;}
            {_scaleSetEvictionPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("scaleSetEvictionPolicy"), out var __jsonScaleSetEvictionPolicy) ? (string)__jsonScaleSetEvictionPolicy : (string)_scaleSetEvictionPolicy;}
            {_spotMaxPrice = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("spotMaxPrice"), out var __jsonSpotMaxPrice) ? (float?)__jsonSpotMaxPrice : _spotMaxPrice;}
            {_tag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("tags"), out var __jsonTags) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterAgentPoolProfilePropertiesTags.FromJson(__jsonTags) : _tag;}
            {_nodeLabel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("nodeLabels"), out var __jsonNodeLabels) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterAgentPoolProfilePropertiesNodeLabels.FromJson(__jsonNodeLabels) : _nodeLabel;}
            {_nodeTaint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("nodeTaints"), out var __jsonNodeTaints) ? If( __jsonNodeTaints as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : _nodeTaint;}
            {_proximityPlacementGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("proximityPlacementGroupID"), out var __jsonProximityPlacementGroupId) ? (string)__jsonProximityPlacementGroupId : (string)_proximityPlacementGroupId;}
            {_enableEncryptionAtHost = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableEncryptionAtHost"), out var __jsonEnableEncryptionAtHost) ? (bool?)__jsonEnableEncryptionAtHost : _enableEncryptionAtHost;}
            {_enableUltraSsd = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableUltraSSD"), out var __jsonEnableUltraSsd) ? (bool?)__jsonEnableUltraSsd : _enableUltraSsd;}
            {_enableFips = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableFIPS"), out var __jsonEnableFips) ? (bool?)__jsonEnableFips : _enableFips;}
            {_gpuInstanceProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("gpuInstanceProfile"), out var __jsonGpuInstanceProfile) ? (string)__jsonGpuInstanceProfile : (string)_gpuInstanceProfile;}
            {_hostGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("hostGroupID"), out var __jsonHostGroupId) ? (string)__jsonHostGroupId : (string)_hostGroupId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedClusterAgentPoolProfileProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedClusterAgentPoolProfileProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._upgradeSetting ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._upgradeSetting.ToJson(null,serializationMode) : null, "upgradeSettings" ,container.Add );
            AddIf( null != this._powerState ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._powerState.ToJson(null,serializationMode) : null, "powerState" ,container.Add );
            AddIf( null != this._kubeletConfig ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._kubeletConfig.ToJson(null,serializationMode) : null, "kubeletConfig" ,container.Add );
            AddIf( null != this._linuxOSConfig ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._linuxOSConfig.ToJson(null,serializationMode) : null, "linuxOSConfig" ,container.Add );
            AddIf( null != this._creationData ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._creationData.ToJson(null,serializationMode) : null, "creationData" ,container.Add );
            AddIf( null != this._count ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._count) : null, "count" ,container.Add );
            AddIf( null != (((object)this._vMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._vMSize.ToString()) : null, "vmSize" ,container.Add );
            AddIf( null != this._oSDiskSizeGb ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._oSDiskSizeGb) : null, "osDiskSizeGB" ,container.Add );
            AddIf( null != (((object)this._oSDiskType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._oSDiskType.ToString()) : null, "osDiskType" ,container.Add );
            AddIf( null != (((object)this._kubeletDiskType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._kubeletDiskType.ToString()) : null, "kubeletDiskType" ,container.Add );
            AddIf( null != (((object)this._workloadRuntime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._workloadRuntime.ToString()) : null, "workloadRuntime" ,container.Add );
            AddIf( null != (((object)this._vnetSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._vnetSubnetId.ToString()) : null, "vnetSubnetID" ,container.Add );
            AddIf( null != (((object)this._podSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._podSubnetId.ToString()) : null, "podSubnetID" ,container.Add );
            AddIf( null != this._maxPod ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._maxPod) : null, "maxPods" ,container.Add );
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            AddIf( null != (((object)this._oSSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._oSSku.ToString()) : null, "osSKU" ,container.Add );
            AddIf( null != this._maxCount ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._maxCount) : null, "maxCount" ,container.Add );
            AddIf( null != this._minCount ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._minCount) : null, "minCount" ,container.Add );
            AddIf( null != this._enableAutoScaling ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableAutoScaling) : null, "enableAutoScaling" ,container.Add );
            AddIf( null != (((object)this._scaleDownMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._scaleDownMode.ToString()) : null, "scaleDownMode" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._mode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._mode.ToString()) : null, "mode" ,container.Add );
            AddIf( null != (((object)this._orchestratorVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._orchestratorVersion.ToString()) : null, "orchestratorVersion" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._currentOrchestratorVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._currentOrchestratorVersion.ToString()) : null, "currentOrchestratorVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._nodeImageVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._nodeImageVersion.ToString()) : null, "nodeImageVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._availabilityZone)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __x in this._availabilityZone )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("availabilityZones",__w);
            }
            AddIf( null != this._enableNodePublicIP ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableNodePublicIP) : null, "enableNodePublicIP" ,container.Add );
            AddIf( null != (((object)this._nodePublicIPPrefixId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._nodePublicIPPrefixId.ToString()) : null, "nodePublicIPPrefixID" ,container.Add );
            AddIf( null != (((object)this._scaleSetPriority)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._scaleSetPriority.ToString()) : null, "scaleSetPriority" ,container.Add );
            AddIf( null != (((object)this._scaleSetEvictionPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._scaleSetEvictionPolicy.ToString()) : null, "scaleSetEvictionPolicy" ,container.Add );
            AddIf( null != this._spotMaxPrice ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((float)this._spotMaxPrice) : null, "spotMaxPrice" ,container.Add );
            AddIf( null != this._tag ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._tag.ToJson(null,serializationMode) : null, "tags" ,container.Add );
            AddIf( null != this._nodeLabel ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._nodeLabel.ToJson(null,serializationMode) : null, "nodeLabels" ,container.Add );
            if (null != this._nodeTaint)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __s in this._nodeTaint )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("nodeTaints",__r);
            }
            AddIf( null != (((object)this._proximityPlacementGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._proximityPlacementGroupId.ToString()) : null, "proximityPlacementGroupID" ,container.Add );
            AddIf( null != this._enableEncryptionAtHost ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableEncryptionAtHost) : null, "enableEncryptionAtHost" ,container.Add );
            AddIf( null != this._enableUltraSsd ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableUltraSsd) : null, "enableUltraSSD" ,container.Add );
            AddIf( null != this._enableFips ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableFips) : null, "enableFIPS" ,container.Add );
            AddIf( null != (((object)this._gpuInstanceProfile)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._gpuInstanceProfile.ToString()) : null, "gpuInstanceProfile" ,container.Add );
            AddIf( null != (((object)this._hostGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._hostGroupId.ToString()) : null, "hostGroupID" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}