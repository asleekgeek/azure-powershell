// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>A ScalingPlanPersonalSchedule.</summary>
    public partial class ScalingPlanPersonalScheduleProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IScalingPlanPersonalScheduleProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IScalingPlanPersonalScheduleProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IScalingPlanPersonalScheduleProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json ? new ScalingPlanPersonalScheduleProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject into a new instance of <see cref="ScalingPlanPersonalScheduleProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScalingPlanPersonalScheduleProperties(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_rampUpStartTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject>("rampUpStartTime"), out var __jsonRampUpStartTime) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Time.FromJson(__jsonRampUpStartTime) : _rampUpStartTime;}
            {_peakStartTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject>("peakStartTime"), out var __jsonPeakStartTime) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Time.FromJson(__jsonPeakStartTime) : _peakStartTime;}
            {_rampDownStartTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject>("rampDownStartTime"), out var __jsonRampDownStartTime) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Time.FromJson(__jsonRampDownStartTime) : _rampDownStartTime;}
            {_offPeakStartTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject>("offPeakStartTime"), out var __jsonOffPeakStartTime) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Time.FromJson(__jsonOffPeakStartTime) : _offPeakStartTime;}
            {_daysOfWeek = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonArray>("daysOfWeek"), out var __jsonDaysOfWeek) ? If( __jsonDaysOfWeek as Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _daysOfWeek;}
            {_rampUpAutoStartHost = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampUpAutoStartHosts"), out var __jsonRampUpAutoStartHosts) ? (string)__jsonRampUpAutoStartHosts : (string)_rampUpAutoStartHost;}
            {_rampUpStartVMOnConnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampUpStartVMOnConnect"), out var __jsonRampUpStartVMOnConnect) ? (string)__jsonRampUpStartVMOnConnect : (string)_rampUpStartVMOnConnect;}
            {_rampUpActionOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampUpActionOnDisconnect"), out var __jsonRampUpActionOnDisconnect) ? (string)__jsonRampUpActionOnDisconnect : (string)_rampUpActionOnDisconnect;}
            {_rampUpMinutesToWaitOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("rampUpMinutesToWaitOnDisconnect"), out var __jsonRampUpMinutesToWaitOnDisconnect) ? (int?)__jsonRampUpMinutesToWaitOnDisconnect : _rampUpMinutesToWaitOnDisconnect;}
            {_rampUpActionOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampUpActionOnLogoff"), out var __jsonRampUpActionOnLogoff) ? (string)__jsonRampUpActionOnLogoff : (string)_rampUpActionOnLogoff;}
            {_rampUpMinutesToWaitOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("rampUpMinutesToWaitOnLogoff"), out var __jsonRampUpMinutesToWaitOnLogoff) ? (int?)__jsonRampUpMinutesToWaitOnLogoff : _rampUpMinutesToWaitOnLogoff;}
            {_peakStartVMOnConnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("peakStartVMOnConnect"), out var __jsonPeakStartVMOnConnect) ? (string)__jsonPeakStartVMOnConnect : (string)_peakStartVMOnConnect;}
            {_peakActionOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("peakActionOnDisconnect"), out var __jsonPeakActionOnDisconnect) ? (string)__jsonPeakActionOnDisconnect : (string)_peakActionOnDisconnect;}
            {_peakMinutesToWaitOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("peakMinutesToWaitOnDisconnect"), out var __jsonPeakMinutesToWaitOnDisconnect) ? (int?)__jsonPeakMinutesToWaitOnDisconnect : _peakMinutesToWaitOnDisconnect;}
            {_peakActionOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("peakActionOnLogoff"), out var __jsonPeakActionOnLogoff) ? (string)__jsonPeakActionOnLogoff : (string)_peakActionOnLogoff;}
            {_peakMinutesToWaitOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("peakMinutesToWaitOnLogoff"), out var __jsonPeakMinutesToWaitOnLogoff) ? (int?)__jsonPeakMinutesToWaitOnLogoff : _peakMinutesToWaitOnLogoff;}
            {_rampDownStartVMOnConnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampDownStartVMOnConnect"), out var __jsonRampDownStartVMOnConnect) ? (string)__jsonRampDownStartVMOnConnect : (string)_rampDownStartVMOnConnect;}
            {_rampDownActionOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampDownActionOnDisconnect"), out var __jsonRampDownActionOnDisconnect) ? (string)__jsonRampDownActionOnDisconnect : (string)_rampDownActionOnDisconnect;}
            {_rampDownMinutesToWaitOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("rampDownMinutesToWaitOnDisconnect"), out var __jsonRampDownMinutesToWaitOnDisconnect) ? (int?)__jsonRampDownMinutesToWaitOnDisconnect : _rampDownMinutesToWaitOnDisconnect;}
            {_rampDownActionOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("rampDownActionOnLogoff"), out var __jsonRampDownActionOnLogoff) ? (string)__jsonRampDownActionOnLogoff : (string)_rampDownActionOnLogoff;}
            {_rampDownMinutesToWaitOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("rampDownMinutesToWaitOnLogoff"), out var __jsonRampDownMinutesToWaitOnLogoff) ? (int?)__jsonRampDownMinutesToWaitOnLogoff : _rampDownMinutesToWaitOnLogoff;}
            {_offPeakStartVMOnConnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("offPeakStartVMOnConnect"), out var __jsonOffPeakStartVMOnConnect) ? (string)__jsonOffPeakStartVMOnConnect : (string)_offPeakStartVMOnConnect;}
            {_offPeakActionOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("offPeakActionOnDisconnect"), out var __jsonOffPeakActionOnDisconnect) ? (string)__jsonOffPeakActionOnDisconnect : (string)_offPeakActionOnDisconnect;}
            {_offPeakMinutesToWaitOnDisconnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("offPeakMinutesToWaitOnDisconnect"), out var __jsonOffPeakMinutesToWaitOnDisconnect) ? (int?)__jsonOffPeakMinutesToWaitOnDisconnect : _offPeakMinutesToWaitOnDisconnect;}
            {_offPeakActionOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("offPeakActionOnLogoff"), out var __jsonOffPeakActionOnLogoff) ? (string)__jsonOffPeakActionOnLogoff : (string)_offPeakActionOnLogoff;}
            {_offPeakMinutesToWaitOnLogoff = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber>("offPeakMinutesToWaitOnLogoff"), out var __jsonOffPeakMinutesToWaitOnLogoff) ? (int?)__jsonOffPeakMinutesToWaitOnLogoff : _offPeakMinutesToWaitOnLogoff;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScalingPlanPersonalScheduleProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScalingPlanPersonalScheduleProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._rampUpStartTime ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) this._rampUpStartTime.ToJson(null,serializationMode) : null, "rampUpStartTime" ,container.Add );
            AddIf( null != this._peakStartTime ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) this._peakStartTime.ToJson(null,serializationMode) : null, "peakStartTime" ,container.Add );
            AddIf( null != this._rampDownStartTime ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) this._rampDownStartTime.ToJson(null,serializationMode) : null, "rampDownStartTime" ,container.Add );
            AddIf( null != this._offPeakStartTime ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) this._offPeakStartTime.ToJson(null,serializationMode) : null, "offPeakStartTime" ,container.Add );
            if (null != this._daysOfWeek)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.XNodeArray();
                foreach( var __x in this._daysOfWeek )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("daysOfWeek",__w);
            }
            AddIf( null != (((object)this._rampUpAutoStartHost)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampUpAutoStartHost.ToString()) : null, "rampUpAutoStartHosts" ,container.Add );
            AddIf( null != (((object)this._rampUpStartVMOnConnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampUpStartVMOnConnect.ToString()) : null, "rampUpStartVMOnConnect" ,container.Add );
            AddIf( null != (((object)this._rampUpActionOnDisconnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampUpActionOnDisconnect.ToString()) : null, "rampUpActionOnDisconnect" ,container.Add );
            AddIf( null != this._rampUpMinutesToWaitOnDisconnect ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._rampUpMinutesToWaitOnDisconnect) : null, "rampUpMinutesToWaitOnDisconnect" ,container.Add );
            AddIf( null != (((object)this._rampUpActionOnLogoff)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampUpActionOnLogoff.ToString()) : null, "rampUpActionOnLogoff" ,container.Add );
            AddIf( null != this._rampUpMinutesToWaitOnLogoff ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._rampUpMinutesToWaitOnLogoff) : null, "rampUpMinutesToWaitOnLogoff" ,container.Add );
            AddIf( null != (((object)this._peakStartVMOnConnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._peakStartVMOnConnect.ToString()) : null, "peakStartVMOnConnect" ,container.Add );
            AddIf( null != (((object)this._peakActionOnDisconnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._peakActionOnDisconnect.ToString()) : null, "peakActionOnDisconnect" ,container.Add );
            AddIf( null != this._peakMinutesToWaitOnDisconnect ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._peakMinutesToWaitOnDisconnect) : null, "peakMinutesToWaitOnDisconnect" ,container.Add );
            AddIf( null != (((object)this._peakActionOnLogoff)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._peakActionOnLogoff.ToString()) : null, "peakActionOnLogoff" ,container.Add );
            AddIf( null != this._peakMinutesToWaitOnLogoff ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._peakMinutesToWaitOnLogoff) : null, "peakMinutesToWaitOnLogoff" ,container.Add );
            AddIf( null != (((object)this._rampDownStartVMOnConnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampDownStartVMOnConnect.ToString()) : null, "rampDownStartVMOnConnect" ,container.Add );
            AddIf( null != (((object)this._rampDownActionOnDisconnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampDownActionOnDisconnect.ToString()) : null, "rampDownActionOnDisconnect" ,container.Add );
            AddIf( null != this._rampDownMinutesToWaitOnDisconnect ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._rampDownMinutesToWaitOnDisconnect) : null, "rampDownMinutesToWaitOnDisconnect" ,container.Add );
            AddIf( null != (((object)this._rampDownActionOnLogoff)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._rampDownActionOnLogoff.ToString()) : null, "rampDownActionOnLogoff" ,container.Add );
            AddIf( null != this._rampDownMinutesToWaitOnLogoff ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._rampDownMinutesToWaitOnLogoff) : null, "rampDownMinutesToWaitOnLogoff" ,container.Add );
            AddIf( null != (((object)this._offPeakStartVMOnConnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._offPeakStartVMOnConnect.ToString()) : null, "offPeakStartVMOnConnect" ,container.Add );
            AddIf( null != (((object)this._offPeakActionOnDisconnect)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._offPeakActionOnDisconnect.ToString()) : null, "offPeakActionOnDisconnect" ,container.Add );
            AddIf( null != this._offPeakMinutesToWaitOnDisconnect ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._offPeakMinutesToWaitOnDisconnect) : null, "offPeakMinutesToWaitOnDisconnect" ,container.Add );
            AddIf( null != (((object)this._offPeakActionOnLogoff)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._offPeakActionOnLogoff.ToString()) : null, "offPeakActionOnLogoff" ,container.Add );
            AddIf( null != this._offPeakMinutesToWaitOnLogoff ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNumber((int)this._offPeakMinutesToWaitOnLogoff) : null, "offPeakMinutesToWaitOnLogoff" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}