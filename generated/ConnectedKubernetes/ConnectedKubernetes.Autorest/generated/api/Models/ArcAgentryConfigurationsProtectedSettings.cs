// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Extensions;

    /// <summary>
    /// The configuration settings for the feature that contain any sensitive or secret information.
    /// </summary>
    public partial class ArcAgentryConfigurationsProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IArcAgentryConfigurationsProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IArcAgentryConfigurationsProtectedSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ArcAgentryConfigurationsProtectedSettings" /> instance.
        /// </summary>
        public ArcAgentryConfigurationsProtectedSettings()
        {

        }
    }
    /// The configuration settings for the feature that contain any sensitive or secret information.
    public partial interface IArcAgentryConfigurationsProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.IAssociativeArray<string>
    {

    }
    /// The configuration settings for the feature that contain any sensitive or secret information.
    internal partial interface IArcAgentryConfigurationsProtectedSettingsInternal

    {

    }
}