// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Mobile network properties.</summary>
    public partial class MobileNetworkPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkPropertiesFormatInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for PublicLandMobileNetworkIdentifier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnId Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkPropertiesFormatInternal.PublicLandMobileNetworkIdentifier { get => (this._publicLandMobileNetworkIdentifier = this._publicLandMobileNetworkIdentifier ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.PlmnId()); set { {_publicLandMobileNetworkIdentifier = value;} } }

        /// <summary>Internal Acessors for ServiceKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkPropertiesFormatInternal.ServiceKey { get => this._serviceKey; set { {_serviceKey = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the mobile network resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicLandMobileNetworkIdentifier" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnId _publicLandMobileNetworkIdentifier;

        /// <summary>
        /// The unique public land mobile network identifier for the network. This is made up of the mobile country code and mobile
        /// network code, as defined in https://www.itu.int/rec/T-REC-E.212. The values 001-01 and 001-001 can be used for testing
        /// and the values 999-99 and 999-999 can be used on internal private networks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnId PublicLandMobileNetworkIdentifier { get => (this._publicLandMobileNetworkIdentifier = this._publicLandMobileNetworkIdentifier ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.PlmnId()); set => this._publicLandMobileNetworkIdentifier = value; }

        /// <summary>Mobile country code (MCC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string PublicLandMobileNetworkIdentifierMcc { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnIdInternal)PublicLandMobileNetworkIdentifier).Mcc; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnIdInternal)PublicLandMobileNetworkIdentifier).Mcc = value ; }

        /// <summary>Mobile network code (MNC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string PublicLandMobileNetworkIdentifierMnc { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnIdInternal)PublicLandMobileNetworkIdentifier).Mnc; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnIdInternal)PublicLandMobileNetworkIdentifier).Mnc = value ; }

        /// <summary>Backing field for <see cref="ServiceKey" /> property.</summary>
        private string _serviceKey;

        /// <summary>The mobile network resource identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string ServiceKey { get => this._serviceKey; }

        /// <summary>Creates an new <see cref="MobileNetworkPropertiesFormat" /> instance.</summary>
        public MobileNetworkPropertiesFormat()
        {

        }
    }
    /// Mobile network properties.
    public partial interface IMobileNetworkPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the mobile network resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the mobile network resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>Mobile country code (MCC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mobile country code (MCC).",
        SerializedName = @"mcc",
        PossibleTypes = new [] { typeof(string) })]
        string PublicLandMobileNetworkIdentifierMcc { get; set; }
        /// <summary>Mobile network code (MNC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mobile network code (MNC).",
        SerializedName = @"mnc",
        PossibleTypes = new [] { typeof(string) })]
        string PublicLandMobileNetworkIdentifierMnc { get; set; }
        /// <summary>The mobile network resource identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The mobile network resource identifier",
        SerializedName = @"serviceKey",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceKey { get;  }

    }
    /// Mobile network properties.
    internal partial interface IMobileNetworkPropertiesFormatInternal

    {
        /// <summary>The provisioning state of the mobile network resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The unique public land mobile network identifier for the network. This is made up of the mobile country code and mobile
        /// network code, as defined in https://www.itu.int/rec/T-REC-E.212. The values 001-01 and 001-001 can be used for testing
        /// and the values 999-99 and 999-999 can be used on internal private networks.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPlmnId PublicLandMobileNetworkIdentifier { get; set; }
        /// <summary>Mobile country code (MCC).</summary>
        string PublicLandMobileNetworkIdentifierMcc { get; set; }
        /// <summary>Mobile network code (MNC).</summary>
        string PublicLandMobileNetworkIdentifierMnc { get; set; }
        /// <summary>The mobile network resource identifier</summary>
        string ServiceKey { get; set; }

    }
}