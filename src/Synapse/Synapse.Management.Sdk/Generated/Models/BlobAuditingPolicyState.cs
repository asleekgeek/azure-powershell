// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{

    /// <summary>
    /// Defines values for BlobAuditingPolicyState.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BlobAuditingPolicyState
    {
        [System.Runtime.Serialization.EnumMember(Value = "Enabled")]
        Enabled,
        [System.Runtime.Serialization.EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class BlobAuditingPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this BlobAuditingPolicyState? value)
        {
            return value == null ? null : ((BlobAuditingPolicyState)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this BlobAuditingPolicyState value)
        {
            switch( value )
            {
                case BlobAuditingPolicyState.Enabled:
                    return "Enabled";
                case BlobAuditingPolicyState.Disabled:
                    return "Disabled";
            }
            return null;
        }
        internal static BlobAuditingPolicyState? ParseBlobAuditingPolicyState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return BlobAuditingPolicyState.Enabled;
                case "Disabled":
                    return BlobAuditingPolicyState.Disabled;
            }
            return null;
        }
    }
}