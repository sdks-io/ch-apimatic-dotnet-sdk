
# Type 12

Type of the activity.

## Enumeration

`Type12`

## Fields

| Name |
|  --- |
| `CreateOrganization` |
| `DeleteOrganization` |
| `OrganizationUpdateName` |
| `TransferServiceIn` |
| `TransferServiceOut` |
| `SavePaymentMethod` |
| `MarketplaceSubscription` |
| `MigrateMarketplaceBillingDetailsIn` |
| `MigrateMarketplaceBillingDetailsOut` |
| `OrganizationUpdateTier` |
| `OrganizationInviteCreate` |
| `OrganizationInviteDelete` |
| `OrganizationMemberJoin` |
| `OrganizationMemberAdd` |
| `OrganizationMemberLeave` |
| `OrganizationMemberDelete` |
| `OrganizationMemberUpdateRole` |
| `OrganizationMemberUpdateRoles` |
| `OrganizationMemberUpdateMfaMethod` |
| `OrganizationSamlConnectionCreate` |
| `OrganizationSamlConnectionUpdate` |
| `UserLogin` |
| `UserLoginFailed` |
| `UserLogout` |
| `KeyCreate` |
| `KeyDelete` |
| `OpenapiKeyUpdate` |
| `ServiceCreate` |
| `ServiceStart` |
| `ServiceStop` |
| `ServiceAwaken` |
| `ServiceIdle` |
| `ServiceRunning` |
| `ServicePartiallyRunning` |
| `ServiceDelete` |
| `ServiceUpdateName` |
| `ServiceUpdateIpAccessList` |
| `ServiceUpdateAutoscalingMemory` |
| `ServiceUpdateAutoscalingIdling` |
| `ServiceUpdatePassword` |
| `ServiceUpdateAutoscalingReplicas` |
| `ServiceUpdateMaxAllowableReplicas` |
| `ServiceUpdateBackupConfiguration` |
| `ServiceRestoreBackup` |
| `ServiceUpdateReleaseChannel` |
| `ServiceUpdateGptUsageConsent` |
| `ServiceUpdatePrivateEndpoints` |
| `ServiceImportToOrganization` |
| `ServiceExportFromOrganization` |
| `ServiceMaintenanceStart` |
| `ServiceMaintenanceEnd` |
| `ServiceUpdateCoreDump` |
| `ServiceUpdateAutoscalingSchedule` |
| `ServiceUpdateQueryEndpoints` |
| `ServiceUpdateDirectConnection` |
| `ServiceUpdateSqlConsoleJwtAuth` |
| `ServiceUpdateSnapshotConfiguration` |
| `ServiceUpdateCollectorIpAccessList` |
| `ServiceUpdateMysqlInterface` |
| `ServiceUpdateUpgradeWindow` |
| `ServiceDeleteUpgradeWindow` |
| `ServiceTriggerFailover` |
| `ServiceTriggerRecovery` |
| `ServiceMcpEnabled` |
| `ServiceMcpDisabled` |
| `ServiceUpgrade` |
| `ServiceScaledDownForTierChange` |
| `ServiceEncryptionKeyCheckFailed` |
| `ServiceEncryptionKeyRotationFailed` |
| `ServiceEncryptionKeyRotated` |
| `ServiceStopEncryptionKeyInaccessible` |
| `ServiceRestartEncryptionKeyRotation` |
| `BackupDelete` |
| `BackupBucketCreate` |
| `BackupBucketUpdate` |
| `BackupBucketDelete` |
| `BackupBucketArchive` |
| `WarehouseUpdateName` |
| `WarehouseUpdateReleaseChannel` |
| `RoleCreate` |
| `RoleUpdate` |
| `RoleDelete` |
| `RoleResourcesDelete` |
| `OrganizationMemberRemoveRoles` |
| `ScimUserProfileUpdate` |
| `ScimGroupCreate` |
| `ScimGroupUpdate` |
| `ScimGroupDelete` |
| `OrganizationSamlConnectionDelete` |
| `DatadogIntegrationCreate` |
| `DatadogIntegrationDelete` |
| `OrganizationUpdateSpendAlert` |
| `OrganizationUpdateCoreDumps` |
| `OrganizationUpdatePrivateEndpoints` |
| `OrganizationUpdatePciCompliance` |
| `OrganizationUpdateHipaaStatus` |
| `TransferCreditsIn` |
| `TransferCreditsOut` |
| `PromoCodeClaim` |
| `SchemaAdvisorSeed` |
| `SchemaAdvisorGeneratePlan` |
| `SchemaAdvisorApprovePlan` |
| `SchemaAdvisorStartDeployment` |
| `SchemaAdvisorStartBenchmark` |
| `SchemaAdvisorRunBenchmark` |
| `SchemaAdvisorStartPromotion` |
| `SchemaAdvisorExchangeTables` |
| `SchemaAdvisorDropSandbox` |
| `UdfCreate` |
| `UdfUpdate` |
| `UdfDelete` |
| `UdfVersionCreate` |
| `UdfVersionDelete` |
| `UdfAttach` |
| `UdfDetach` |
| `UdfUpdateServices` |
| `UdfRedeploy` |
| `UdfRebuild` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Type12 type12 = Type12.BackupBucketArchive;
```

