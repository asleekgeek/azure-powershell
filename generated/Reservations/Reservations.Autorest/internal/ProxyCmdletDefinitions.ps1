
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
List all the operations.
.Description
List all the operations.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IOperationResponse
.Link
https://learn.microsoft.com/powershell/module/az.reservations/get-azreservationsoperation
#>
function Get-AzReservationsOperation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IOperationResponse])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            List = 'Az.Reservations.private\Get-AzReservationsOperation_List';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Return a reservation and get refund information.
.Description
Return a reservation and get refund information.
.Example
$orderId = "50000000-aaaa-bbbb-cccc-100000000003"
$fullyQualifiedId = "/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000003/reservations/30000000-aaaa-bbbb-cccc-100000000003"
$fullyQualifiedOrderId = "/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000003"

Invoke-AzReservationCalculateRefund -ReservationOrderId $orderId -ReservationToReturnQuantity 1 -ReservationToReturnReservationId $fullyQualifiedId  -Id $fullyQualifiedOrderId -Scope "Reservation"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IReservationsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationId <String>]: Id of the reservation item
  [ReservationOrderId <String>]: Order Id of the reservation
  [SubscriptionId <String>]: Id of the subscription
.Link
https://learn.microsoft.com/powershell/module/az.reservations/invoke-azreservationreturn
#>
function Invoke-AzReservationReturn {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Parameter(ParameterSetName='PostViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='PostViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [System.String]
    # Order Id of the reservation
    ${ReservationOrderId},

    [Parameter(ParameterSetName='PostViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.Int32]
    # Quantity to be returned.
    # Must be greater than zero.
    ${ReservationToReturnQuantity},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Fully qualified identifier of the reservation being returned
    ${ReservationToReturnReservationId},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The reason of returning the reservation
    ${ReturnReason},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The scope of the refund, e.g.
    # Reservation
    ${Scope},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # SessionId that was returned by CalculateRefund API.
    ${SessionId},

    [Parameter(ParameterSetName='PostViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Post operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='PostViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Json string supplied to the Post operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            PostExpanded = 'Az.Reservations.private\Invoke-AzReservationReturn_PostExpanded';
            PostViaIdentityExpanded = 'Az.Reservations.private\Invoke-AzReservationReturn_PostViaIdentityExpanded';
            PostViaJsonFilePath = 'Az.Reservations.private\Invoke-AzReservationReturn_PostViaJsonFilePath';
            PostViaJsonString = 'Az.Reservations.private\Invoke-AzReservationReturn_PostViaJsonString';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Merge the specified `Reservation`s into a new `Reservation`.
The two `Reservation`s being merged must have same properties.
.Description
Merge the specified `Reservation`s into a new `Reservation`.
The two `Reservation`s being merged must have same properties.
.Example
$arr=@("72bc398d-b201-4a2e-a1fa-60fb48a85b23", "34f2474f-b4d7-41ec-a96d-d4bb7c2f85b6")
Merge-AzReservation -ReservationOrderId "79ebddac-4030-4296-ab93-1ad90f032058" -ReservationId $arr

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IMergeRequest>: The request for reservation merge
  [Source <List<String>>]: Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}

INPUTOBJECT <IReservationsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationId <String>]: Id of the reservation item
  [ReservationOrderId <String>]: Order Id of the reservation
  [SubscriptionId <String>]: Id of the subscription
.Link
https://learn.microsoft.com/powershell/module/az.reservations/merge-azreservation
#>
function Merge-AzReservation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse])]
[CmdletBinding(DefaultParameterSetName='MergeExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Merge', Mandatory)]
    [Parameter(ParameterSetName='MergeExpanded', Mandatory)]
    [Parameter(ParameterSetName='MergeViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='MergeViaJsonString', Mandatory)]
    [Alias('ReservationOrderId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [System.String]
    # Order Id of the reservation
    ${OrderId},

    [Parameter(ParameterSetName='MergeViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='MergeViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='Merge', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='MergeViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeRequest]
    # The request for reservation merge
    ${Body},

    [Parameter(ParameterSetName='MergeExpanded')]
    [Parameter(ParameterSetName='MergeViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String[]]
    # Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
    ${ReservationId},

    [Parameter(ParameterSetName='MergeViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Merge operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='MergeViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Json string supplied to the Merge operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            Merge = 'Az.Reservations.private\Merge-AzReservation_Merge';
            MergeExpanded = 'Az.Reservations.private\Merge-AzReservation_MergeExpanded';
            MergeViaIdentity = 'Az.Reservations.private\Merge-AzReservation_MergeViaIdentity';
            MergeViaIdentityExpanded = 'Az.Reservations.private\Merge-AzReservation_MergeViaIdentityExpanded';
            MergeViaJsonFilePath = 'Az.Reservations.private\Merge-AzReservation_MergeViaJsonFilePath';
            MergeViaJsonString = 'Az.Reservations.private\Merge-AzReservation_MergeViaJsonString';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}

<#
.Synopsis
Split a `Reservation` into two `Reservation`s with specified quantity distribution.
.Description
Split a `Reservation` into two `Reservation`s with specified quantity distribution.
.Example
Split-AzReservation -ReservationOrderId "c615c897-aaaa-4123-8527-c42cc0da41e0" -ReservationId "1bdfaf4a-159d-46ec-be3a-f4aa527d423c" -Quantity @(2,8)


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IReservationsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationId <String>]: Id of the reservation item
  [ReservationOrderId <String>]: Order Id of the reservation
  [SubscriptionId <String>]: Id of the subscription
.Link
https://learn.microsoft.com/powershell/module/az.reservations/split-azreservation
#>
function Split-AzReservation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse])]
[CmdletBinding(DefaultParameterSetName='SplitExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='SplitExpanded', Mandatory)]
    [Parameter(ParameterSetName='SplitViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='SplitViaJsonString', Mandatory)]
    [Alias('ReservationOrderId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [System.String]
    # Order Id of the reservation
    ${OrderId},

    [Parameter(ParameterSetName='SplitViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='SplitExpanded')]
    [Parameter(ParameterSetName='SplitViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.Int32[]]
    # List of the quantities in the new reservations to create.
    ${Quantity},

    [Parameter(ParameterSetName='SplitExpanded')]
    [Parameter(ParameterSetName='SplitViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Resource id of the reservation to be split.
    # Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
    ${ReservationId},

    [Parameter(ParameterSetName='SplitViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Split operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='SplitViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Json string supplied to the Split operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            SplitExpanded = 'Az.Reservations.private\Split-AzReservation_SplitExpanded';
            SplitViaIdentityExpanded = 'Az.Reservations.private\Split-AzReservation_SplitViaIdentityExpanded';
            SplitViaJsonFilePath = 'Az.Reservations.private\Split-AzReservation_SplitViaJsonFilePath';
            SplitViaJsonString = 'Az.Reservations.private\Split-AzReservation_SplitViaJsonString';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
