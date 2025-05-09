// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>The environment variables for this build</summary>
    public partial class BuildPropertiesEnv :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IBuildPropertiesEnv,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IBuildPropertiesEnvInternal
    {

        /// <summary>Creates an new <see cref="BuildPropertiesEnv" /> instance.</summary>
        public BuildPropertiesEnv()
        {

        }
    }
    /// The environment variables for this build
    public partial interface IBuildPropertiesEnv :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IAssociativeArray<string>
    {

    }
    /// The environment variables for this build
    internal partial interface IBuildPropertiesEnvInternal

    {

    }
}