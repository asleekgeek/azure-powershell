// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>
    /// Describes the credentials that will be used to access a custom registry during a run.
    /// </summary>
    public partial class CustomRegistryCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICustomRegistryCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICustomRegistryCredentialsInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private string _identity;

        /// <summary>
        /// Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        /// this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        /// the case of a system-assigned identity, the Client ID will be determined by the runner. This
        /// identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        /// source of authentication used for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Identity { get => this._identity; set => this._identity = value; }

        /// <summary>Internal Acessors for Password</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICustomRegistryCredentialsInternal.Password { get => (this._password = this._password ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SecretObject()); set { {_password = value;} } }

        /// <summary>Internal Acessors for UserName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICustomRegistryCredentialsInternal.UserName { get => (this._userName = this._userName ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SecretObject()); set { {_userName = value;} } }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject _password;

        /// <summary>
        /// The password for logging into the custom registry. The password is a secret
        /// object that allows multiple ways of providing the value for it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject Password { get => (this._password = this._password ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SecretObject()); set => this._password = value; }

        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? PasswordType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)Password).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)Password).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType)""); }

        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string PasswordValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)Password).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)Password).Value = value ?? null; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject _userName;

        /// <summary>The username for logging into the custom registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject UserName { get => (this._userName = this._userName ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SecretObject()); set => this._userName = value; }

        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? UserNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)UserName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)UserName).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType)""); }

        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string UserNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)UserName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObjectInternal)UserName).Value = value ?? null; }

        /// <summary>Creates an new <see cref="CustomRegistryCredentials" /> instance.</summary>
        public CustomRegistryCredentials()
        {

        }
    }
    /// Describes the credentials that will be used to access a custom registry during a run.
    public partial interface ICustomRegistryCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        /// this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        /// the case of a system-assigned identity, the Client ID will be determined by the runner. This
        /// identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        /// source of authentication used for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        the case of a system-assigned identity, the Client ID will be determined by the runner. This
        identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        source of authentication used for accessing the registry.",
        SerializedName = @"identity",
        PossibleTypes = new [] { typeof(string) })]
        string Identity { get; set; }
        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the secret object which determines how the value of the secret object has to be
        interpreted.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? PasswordType { get; set; }
        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the secret. The format of this value will be determined
        based on the type of the secret object. If the type is Opaque, the value will be
        used as is without any modification.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordValue { get; set; }
        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the secret object which determines how the value of the secret object has to be
        interpreted.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? UserNameType { get; set; }
        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the secret. The format of this value will be determined
        based on the type of the secret object. If the type is Opaque, the value will be
        used as is without any modification.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string UserNameValue { get; set; }

    }
    /// Describes the credentials that will be used to access a custom registry during a run.
    internal partial interface ICustomRegistryCredentialsInternal

    {
        /// <summary>
        /// Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        /// this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        /// the case of a system-assigned identity, the Client ID will be determined by the runner. This
        /// identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        /// source of authentication used for accessing the registry.
        /// </summary>
        string Identity { get; set; }
        /// <summary>
        /// The password for logging into the custom registry. The password is a secret
        /// object that allows multiple ways of providing the value for it.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject Password { get; set; }
        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? PasswordType { get; set; }
        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        string PasswordValue { get; set; }
        /// <summary>The username for logging into the custom registry.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISecretObject UserName { get; set; }
        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SecretObjectType? UserNameType { get; set; }
        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        string UserNameValue { get; set; }

    }
}