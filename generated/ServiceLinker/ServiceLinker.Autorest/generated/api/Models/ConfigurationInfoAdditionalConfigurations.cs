// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>
    /// A dictionary of additional configurations to be added. Service will auto generate a set of basic configurations and this
    /// property is to full fill more customized configurations
    /// </summary>
    public partial class ConfigurationInfoAdditionalConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.IConfigurationInfoAdditionalConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.IConfigurationInfoAdditionalConfigurationsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ConfigurationInfoAdditionalConfigurations" /> instance.
        /// </summary>
        public ConfigurationInfoAdditionalConfigurations()
        {

        }
    }
    /// A dictionary of additional configurations to be added. Service will auto generate a set of basic configurations and this
    /// property is to full fill more customized configurations
    public partial interface IConfigurationInfoAdditionalConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IAssociativeArray<string>
    {

    }
    /// A dictionary of additional configurations to be added. Service will auto generate a set of basic configurations and this
    /// property is to full fill more customized configurations
    internal partial interface IConfigurationInfoAdditionalConfigurationsInternal

    {

    }
}