
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
Updates a data connection.
.Description
Updates a data connection.
.Example
Update-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myeventhubdc" -Location "East US" -Kind "EventHub" -EventHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.EventHub/namespaces/myeventhubns/eventhubs/myeventhub" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -Compression "None" -TableName "Events" -MappingRuleName "NewEventsMapping"
.Example
Update-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myeventgriddc" -Location "East US" -Kind "EventGrid" -EventHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.EventHub/namespaces/myeventhubns/eventhubs/myeventhub" -StorageAccountResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.Storage/storageAccounts/mystorage" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "NewEventsMapping"
.Example
Update-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myiothubdc" -Location "East US" -Kind "IotHub" -IotHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.Devices/IotHubs/myiothub" -SharedAccessPolicyName "myiothubpolicy" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "NewEventsMapping"
.Example
$dataConnection = Get-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myeventhubdc" 
Update-AzKustoDataConnection -InputObject $dataConnection -Location "East US" -Kind "EventHub" -EventHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.EventHub/namespaces/myeventhubns/eventhubs/myeventhub" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -Compression "None" -TableName "Events" -MappingRuleName "NewEventsMapping"
.Example
$dataConnection = Get-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myeventgriddc" 
Update-AzKustoDataConnection -InputObject $dataConnection -Location "East US" -Kind "EventGrid" -EventHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.EventHub/namespaces/myeventhubns/eventhubs/myeventhub" -StorageAccountResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.Storage/storageAccounts/mystorage" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "NewEventsMapping"
.Example
$dataConnection = Get-AzKustoDataConnection -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -DatabaseName "mykustodatabase" -DataConnectionName "myiothubdc" 
Update-AzKustoDataConnection -InputObject $dataConnection -Location "East US" -Kind "IotHub" -IotHubResourceId "/subscriptions/$subscriptionId/resourcegroups/testrg/providers/Microsoft.Devices/IotHubs/myiothub" -SharedAccessPolicyName "myiothubpolicy" -DataFormat "MULTIJSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "NewEventsMapping"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IKustoIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IKustoIdentity>: Identity Parameter
  [AttachedDatabaseConfigurationName <String>]: The name of the attached database configuration.
  [ClusterName <String>]: The name of the Kusto cluster.
  [DataConnectionName <String>]: The name of the data connection.
  [DatabaseName <String>]: The name of the database in the Kusto cluster.
  [Id <String>]: Resource identity path
  [Location <String>]: The name of Azure region.
  [ManagedPrivateEndpointName <String>]: The name of the managed private endpoint.
  [OperationId <String>]: The ID of an ongoing async operation.
  [PrincipalAssignmentName <String>]: The name of the Kusto principalAssignment.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [PrivateLinkResourceName <String>]: The name of the private link resource.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SandboxCustomImageName <String>]: The name of the sandbox custom image.
  [ScriptName <String>]: The name of the Kusto database script.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://learn.microsoft.com/powershell/module/az.kusto/update-azkustodataconnection
#>
function Update-AzKustoDataConnection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection])]
[CmdletBinding(DefaultParameterSetName='UpdateExpandedEventHub', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [System.String]
    # The name of the Kusto cluster.
    ${ClusterName},

    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [System.String]
    # The name of the database in the Kusto cluster.
    ${DatabaseName},

    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Alias('DataConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [System.String]
    # The name of the data connection.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [System.String]
    # The name of the resource group containing the Kusto cluster.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb')]
    [Parameter(ParameterSetName='UpdateExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IKustoIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory)]
    [ArgumentCompleter({ param ( $CommandName, $ParameterName, $WordToComplete, $CommandAst, $FakeBoundParameters ) return @('EventHub', 'EventGrid', 'IotHub', 'CosmosDb') })]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind]
    # Kind of the endpoint for the data connection
    ${Kind},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The table where the data should be ingested.
    # Optionally the table information can be added to each message.
    ${TableName},

    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of the event hub to be used to create a data connection / event grid is configured to send events.
    ${EventHubResourceId},

    [Parameter(ParameterSetName='UpdateExpandedEventHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The event/iot hub consumer group.
    ${ConsumerGroup},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The data format of the message.
    # Optionally the data format can be added to each message.
    ${DataFormat},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String[]]
    # System properties of the event/iot hub.
    ${EventSystemProperty},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The mapping rule to be used to ingest the data.
    # Optionally the mapping information can be added to each message.
    ${MappingRuleName},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression]
    # The event hub messages compression type.
    ${Compression},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of a managed identity (system or user assigned) to be used to authenticate with external resources.
    ${ManagedIdentityResourceId},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting]
    # Indication for database routing information from the data connection, by default only database routing information is allowed.
    ${DatabaseRouting},

    [Parameter(ParameterSetName='UpdateExpandedEventHub')]
    [Parameter(ParameterSetName='UpdateExpandedCosmosDb')]
    [Parameter(ParameterSetName='UpdateExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.DateTime]
    # When defined, the data connection retrieves existing Event hub events created since the Retrieval start date.
    # It can only retrieve events retained by the Event hub, based on its retention period.
    ${RetrievalStartDate},

    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of the Cosmos DB account used to create the data connection.
    ${CosmosDbAccountResourceId},

    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The name of an existing database in the Cosmos DB account.
    ${CosmosDbDatabase},

    [Parameter(ParameterSetName='UpdateExpandedCosmosDb', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedCosmosDb', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The name of an existing container in the Cosmos DB database.
    ${CosmosDbContainer},

    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of the Iot hub to be used to create a data connection.
    ${IotHubResourceId},

    [Parameter(ParameterSetName='UpdateExpandedIotHub', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedIotHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The name of the share access policy.
    ${SharedAccessPolicyName},

    [Parameter(ParameterSetName='UpdateExpandedEventGrid', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of the storage account where the data resides.
    ${StorageAccountResourceId},

    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType]
    # The name of blob storage event type to process.
    ${BlobStorageEventType},

    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # If set to true, indicates that ingestion should ignore the first record of every file.
    ${IgnoreFirstRecord},

    [Parameter(ParameterSetName='UpdateExpandedEventGrid')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpandedEventGrid')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Body')]
    [System.String]
    # The resource ID of the event grid that is subscribed to the storage account events.
    ${EventGridResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Category('Runtime')]
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

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Kusto.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpandedEventHub = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateExpandedCosmosDb = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateExpandedIotHub = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateExpandedEventGrid = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateViaIdentityExpandedCosmosDb = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateViaIdentityExpandedIotHub = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateViaIdentityExpandedEventGrid = 'Az.Kusto.custom\Update-AzKustoDataConnection';
            UpdateViaIdentityExpandedEventHub = 'Az.Kusto.custom\Update-AzKustoDataConnection';
        }
        if (('UpdateExpandedEventHub', 'UpdateExpandedCosmosDb', 'UpdateExpandedIotHub', 'UpdateExpandedEventGrid') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Kusto.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
