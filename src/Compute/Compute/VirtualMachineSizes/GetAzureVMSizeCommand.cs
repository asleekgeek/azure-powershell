﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using AutoMapper;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Rest.Azure;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute
{
    [GenericBreakingChangeWithVersion("The \"ListVirtualMachineSize\" parameter set will be deprecated as its API: \"Virtual Machine Sizes - List\" is deprecated. For listing available VM sizes by subscription or location, please use instead \"Get-AzComputeResourceSku\". Other parameter sets: \"List Available Sizes for Availability Set\" and \"List Available Sizes for Virtual Machine\" will continue to be supported.", "14.0.0", "10.0.0")]
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VMSize", DefaultParameterSetName = ListVirtualMachineSizeParamSet)]
    [OutputType(typeof(PSVirtualMachineSize))]
    public class GetAzureVMSizeCommand : VirtualMachineSizeBaseCmdlet
    {
        protected const string ListVirtualMachineSizeParamSet = "ListVirtualMachineSizeParamSet";
        protected const string ListAvailableSizesForAvailabilitySet = "ListAvailableSizesForAvailabilitySet";
        protected const string ListAvailableSizesForVirtualMachine = "ListAvailableSizesForVirtualMachine";

        [Parameter(
           Mandatory = true,
           Position = 0,
           ParameterSetName = ListVirtualMachineSizeParamSet,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The location name.")]
        [LocationCompleter("Microsoft.Compute/locations/vmSizes")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(
           Mandatory = true,
           Position = 0,
           ParameterSetName = ListAvailableSizesForAvailabilitySet,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name.")]
        [Parameter(
           Mandatory = true,
           Position = 0,
           ParameterSetName = ListAvailableSizesForVirtualMachine,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = ListAvailableSizesForAvailabilitySet,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The availability set name.")]
        [ResourceNameCompleter("Microsoft.Compute/availabilitySets", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string AvailabilitySetName { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = ListAvailableSizesForVirtualMachine,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The virtual machine name.")]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachines", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string VMName { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            ExecuteClientAction(() =>
            {
                AzureOperationResponse<IEnumerable<VirtualMachineSize>> result = null;

                if (!string.IsNullOrEmpty(this.VMName))
                {
                    result = this.VirtualMachineClient.ListAvailableSizesWithHttpMessagesAsync(
                        this.ResourceGroupName,
                        this.VMName).GetAwaiter().GetResult();
                }
                else if (!string.IsNullOrEmpty(this.AvailabilitySetName))
                {
                    result = this.AvailabilitySetClient.ListAvailableSizesWithHttpMessagesAsync(
                        this.ResourceGroupName,
                        this.AvailabilitySetName).GetAwaiter().GetResult();
                }
                else
                {
                    result = this.VirtualMachineSizeClient.ListWithHttpMessagesAsync(this.Location.Canonicalize()).GetAwaiter().GetResult();
                }

                List<PSVirtualMachineSize> psResultList = new List<PSVirtualMachineSize>();
                foreach (var item in result.Body)
                {
                    var psItem = ComputeAutoMapperProfile.Mapper.Map<PSVirtualMachineSize>(result);
                    psItem = ComputeAutoMapperProfile.Mapper.Map(item, psItem);
                    psResultList.Add(psItem);
                }

                WriteObject(psResultList, true);
            });
        }
    }
}
