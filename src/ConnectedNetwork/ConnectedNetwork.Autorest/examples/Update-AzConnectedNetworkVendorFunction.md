### Example 1: Update-AzConnectedNetworkVendorFunction
```powershell
$ipconf1 = New-AzConnectedNetworkInterfaceIPConfigurationObject -IPAllocationMethod "Dynamic" -IPVersion "IPv4"
$ipconf2 = New-AzConnectedNetworkInterfaceIPConfigurationObject -IPAllocationMethod "Dynamic" -IPVersion "IPv4"
$ip1 = New-AzConnectedNetworkInterfaceObject -IPConfiguration $ipconf1 -Name "mrmmanagementnic1" -VMSwitchType "Management"
$ip2 = New-AzConnectedNetworkInterfaceObject -IPConfiguration $ipconf2 -Name "mrmlannic1" -VMSwitchType "Lan"
$keyData = @{keyData = "ssh-rsa\AAAAB3NzaC1yc2EAAAADAQABAAABAQCyMpVbBgu0kftv1k+z1c3NtcB5CVDoo/X9X1LE2JUjlLlo0luEkFGJk61i53BhiTSTeRmQXN8hAZ7sn4MDUmZK7fWcHouZ2fsJo+ehses3wQPLubWBFw2L/hoSTyXifXMbEBu9SxHgqf1CEKQcvdNiWf4U7npXwjweXW9DtsF5E7h4kxhKJKFI4sNFTIX0IwUB15QEVHoBs92kDwH3fBH3kZZCMBJE/u6kT+XB22crRKkIGlp3a9gcogtOCvP+3xmsP7hjw5+nHxMUwkc/6kYyfTeLwvfI4xrTWpnB5xufts5LW5/U5GOXVg97ix9EXgiV0czThowG5K2xQ649UlJb redmond\user@n1-azuredev1"; path = $Null}
$keys = @{ }
$key += $keyData
$vendorconf = New-AzConnectedNetworkFunctionVendorConfigurationObject -NetworkInterface $ip1,$ip2 -RoleName hpehss -OSProfileAdminUsername MecUser -OSProfileCustomData $customData -OSProfileCustomDataRequired $True -SshPublicKey $key
$vendorvnf1 = Update-AzConnectedNetworkVendorFunction -LocationName eastus2euap -ServiceKey b78d39-xxxx-xxxx-00946c5 -SubscriptionId xxxx-4444-xxxx-4444 -VendorName myVendor -VendorConfiguration $vendorconf -SkuType EvolvedPacketCore -VendorProvisioningState Provisioning
```

Update network interfaces with dynamic method allocation and ip version to IPv4. And using these to create two network configuration objects with vm switch type. Update a ssh key identity, Then using those to create vendor configuration object with role name hpehss, custom data, keyData and network interface array. Using this to create vendor NF with the specified service key, vendor subscription, location eastus2euap, vendor name myVendor, sku type EvolvedPacketCore, vendor provisioning state Provisioning.