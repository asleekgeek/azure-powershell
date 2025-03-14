Describe 'New-AzKustoScript' {
    BeforeAll{
        $kustoCommonPath = Join-Path $PSScriptRoot 'common.ps1'
        . ($kustoCommonPath)
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not(Test-Path -Path $loadEnvPath))
        {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzKustoScript.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not$mockingPath)
        {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }

    It 'CreateExpandedInline' {
        $continueOnErrors = $false
        $clusterName = $env.kustoClusterName
        $databaseName = "testdatabase" + $env.rstr4
        $databaseFullName = $clusterName + "/" + $databaseName
        $scriptContent = ".create table table3 (Level:string, Timestamp:datetime, UserId:string, TraceId:string, Message:string, ProcessId:int32)"
        $scriptName = "testScript"

        $databaseCreated = New-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $clusterName -Name $databaseName -Kind ReadWrite -Location $env.location

        $Script = New-AzKustoScript -ClusterName $clusterName -DatabaseName $databaseName -Name $scriptName -ResourceGroupName $env.resourceGroupName -SubscriptionId $env.SubscriptionId -ContinueOnError -ForceUpdateTag "tag1" -ScriptContent $scriptContent  -PrincipalPermissionsAction "RemovePermissionOnScriptCompletion" -ScriptLevel "Database"
        Validate_Inline_Script $Script "tag1" $continueOnErrors $clusterName $databaseName $scriptName -PrincipalPermissionsAction "RemovePermissionOnScriptCompletion" -ScriptLevel "Database"

        { Remove-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $env.kustoClusterName -Name $databaseName } | Should -Not -Throw
    }

    It 'CreateExpanded' {
        $continueOnErrors = $false
        $clusterName = $env.kustoClusterName
        $databaseName = "testdatabase" + $env.rstr4
        $databaseFullName = $clusterName + "/" + $databaseName
        $scriptContent = ".create table table3 (Level:string, Timestamp:datetime, UserId:string, TraceId:string, Message:string, ProcessId:int32)"
        $scriptName = "testScript"
        $databaseCreated = New-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $clusterName -Name $databaseName -Kind ReadWrite -Location $env.location

        $Script = New-AzKustoScript -ClusterName $clusterName -DatabaseName $databaseName -Name $scriptName -ResourceGroupName $env.resourceGroupName -SubscriptionId $env.SubscriptionId -ContinueOnError -ForceUpdateTag "tag1" -ScriptContent $scriptContent -PrincipalPermissionsAction "RemovePermissionOnScriptCompletion" -ScriptLevel "Database" 

        Validate_Script $Script "tag1" $continueOnErrors $clusterName $databaseName $scriptName -principalPermissionsAction "RemovePermissionOnScriptCompletion" -scriptLevel "Database"

        { Remove-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $env.kustoClusterName -Name $databaseName } | Should -Not -Throw
    }

    It 'Create' {
        $continueOnErrors = $false
        $clusterName = $env.kustoClusterName
        $databaseName = "testdatabase" + $env.rstr4
        $databaseFullName = $clusterName + "/" + $databaseName
        $scriptContent = ".create table table3 (Level:string, Timestamp:datetime, UserId:string, TraceId:string, Message:string, ProcessId:int32)"
        $scriptName = "testScript"
        $databaseCreated = New-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $clusterName -Name $databaseName -Kind ReadWrite -Location $env.location

        $Parameter = (@{ ForceUpdateTag = "tag1"; Content = $scriptContent; PrincipalPermissionsAction = "RemovePermissionOnScriptCompletion"; ScriptLevel = "Database" })

        $Script = New-AzKustoScript -ClusterName $clusterName -DatabaseName $databaseName -Name $scriptName -ResourceGroupName $env.resourceGroupName -SubscriptionId $env.SubscriptionId -Parameter $Parameter

        Validate_Script $Script "tag1" $continueOnErrors $clusterName $databaseName $scriptName -principalPermissionsAction "RemovePermissionOnScriptCompletion" -ScriptLevel "Database"

        { Remove-AzKustoDatabase -ResourceGroupName $env.resourceGroupName -ClusterName $env.kustoClusterName -Name $databaseName } | Should -Not -Throw
    }
}
