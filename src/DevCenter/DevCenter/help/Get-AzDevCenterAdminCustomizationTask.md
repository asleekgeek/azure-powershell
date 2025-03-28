---
external help file: Az.DevCenter-help.xml
Module Name: Az.DevCenter
online version: https://learn.microsoft.com/powershell/module/az.devcenter/get-azdevcenteradmincustomizationtask
schema: 2.0.0
---

# Get-AzDevCenterAdminCustomizationTask

## SYNOPSIS
Gets a Task from the catalog

## SYNTAX

### List (Default)
```
Get-AzDevCenterAdminCustomizationTask -CatalogName <String> -DevCenterName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzDevCenterAdminCustomizationTask -CatalogName <String> -DevCenterName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] -TaskName <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzDevCenterAdminCustomizationTask -InputObject <IDevCenterIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets a Task from the catalog

## EXAMPLES

### Example 1: List customization tasks in a catalog
```powershell
Get-AzDevCenterAdminCustomizationTask -CatalogName CentralCatalog -DevCenterName Contoso -ResourceGroupName testRg
```

This command lists the customization tasks in the catalog named "CentralCatalog" under the dev center "Contoso".

### Example 2: Get a customization task in a catalog
```powershell
Get-AzDevCenterAdminCustomizationTask -CatalogName CentralCatalog -DevCenterName Contoso -ResourceGroupName testRg -TaskName SampleTask
```

This command gets the customization task "SampleTask" in the catalog named "CentralCatalog" under the dev center "Contoso".

### Example 3: Get a customization task in a catalog using InputObject
```powershell
$customizationTask = @{"ResourceGroupName" = "testRg"; "DevCenterName" = "Contoso"; "CatalogName" = "CentralCatalog"; "SubscriptionId" = "0ac520ee-14c0-480f-b6c9-0a90c58ffff"; "TaskName" = "SampleTask"}
$customizationTask = Get-AzDevCenterAdminCustomizationTask -InputObject $customizationTask
```

This command gets the customization task "SampleTask" in the catalog named "CentralCatalog" under the dev center "Contoso".

## PARAMETERS

### -CatalogName
The name of the Catalog.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DevCenterName
The name of the devcenter.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: List, Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskName
The name of the Task.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICustomizationTask

## NOTES

## RELATED LINKS
