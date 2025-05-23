// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Cert Manager Cert properties</summary>
    public partial class CertManagerCertOptions :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerCertOptions,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerCertOptionsInternal
    {

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private string _duration;

        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Internal Acessors for PrivateKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerCertOptionsInternal.PrivateKey { get => (this._privateKey = this._privateKey ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.CertManagerPrivateKey()); set { {_privateKey = value;} } }

        /// <summary>Backing field for <see cref="PrivateKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey _privateKey;

        /// <summary>Configuration of certificate private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey PrivateKey { get => (this._privateKey = this._privateKey ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.CertManagerPrivateKey()); set => this._privateKey = value; }

        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string PrivateKeyAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKeyInternal)PrivateKey).Algorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKeyInternal)PrivateKey).Algorithm = value ; }

        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string PrivateKeyRotationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKeyInternal)PrivateKey).RotationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKeyInternal)PrivateKey).RotationPolicy = value ; }

        /// <summary>Backing field for <see cref="RenewBefore" /> property.</summary>
        private string _renewBefore;

        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string RenewBefore { get => this._renewBefore; set => this._renewBefore = value; }

        /// <summary>Creates an new <see cref="CertManagerCertOptions" /> instance.</summary>
        public CertManagerCertOptions()
        {

        }
    }
    /// Cert Manager Cert properties
    public partial interface ICertManagerCertOptions :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for 45 minutes.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string Duration { get; set; }
        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"algorithm for private key.",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string PrivateKeyAlgorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"cert-manager private key rotationPolicy.",
        SerializedName = @"rotationPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string PrivateKeyRotationPolicy { get; set; }
        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for 45 minutes.",
        SerializedName = @"renewBefore",
        PossibleTypes = new [] { typeof(string) })]
        string RenewBefore { get; set; }

    }
    /// Cert Manager Cert properties
    internal partial interface ICertManagerCertOptionsInternal

    {
        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        string Duration { get; set; }
        /// <summary>Configuration of certificate private key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey PrivateKey { get; set; }
        /// <summary>algorithm for private key.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string PrivateKeyAlgorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string PrivateKeyRotationPolicy { get; set; }
        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        string RenewBefore { get; set; }

    }
}