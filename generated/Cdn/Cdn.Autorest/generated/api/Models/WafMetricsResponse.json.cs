// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Waf Metrics Response</summary>
    public partial class WafMetricsResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafMetricsResponse.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafMetricsResponse.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafMetricsResponse FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json ? new WafMetricsResponse(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WafMetricsResponse" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WafMetricsResponse" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._dateTimeBegin ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._dateTimeBegin?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "dateTimeBegin" ,container.Add );
            AddIf( null != this._dateTimeEnd ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._dateTimeEnd?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "dateTimeEnd" ,container.Add );
            AddIf( null != (((object)this._granularity)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._granularity.ToString()) : null, "granularity" ,container.Add );
            if (null != this._series)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.XNodeArray();
                foreach( var __x in this._series )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("series",__w);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject into a new instance of <see cref="WafMetricsResponse" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WafMetricsResponse(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_dateTimeBegin = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("dateTimeBegin"), out var __jsonDateTimeBegin) ? global::System.DateTime.TryParse((string)__jsonDateTimeBegin, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDateTimeBeginValue) ? __jsonDateTimeBeginValue : _dateTimeBegin : _dateTimeBegin;}
            {_dateTimeEnd = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("dateTimeEnd"), out var __jsonDateTimeEnd) ? global::System.DateTime.TryParse((string)__jsonDateTimeEnd, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDateTimeEndValue) ? __jsonDateTimeEndValue : _dateTimeEnd : _dateTimeEnd;}
            {_granularity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("granularity"), out var __jsonGranularity) ? (string)__jsonGranularity : (string)_granularity;}
            {_series = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray>("series"), out var __jsonSeries) ? If( __jsonSeries as Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafMetricsResponseSeriesItem>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafMetricsResponseSeriesItem) (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.WafMetricsResponseSeriesItem.FromJson(__u) )) ))() : null : _series;}
            AfterFromJson(json);
        }
    }
}