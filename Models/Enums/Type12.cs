using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the activity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : StringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 CreateOrganization = new("create_organization");

    public static readonly Type12 DeleteOrganization = new("delete_organization");

    public static readonly Type12 OrganizationUpdateName = new("organization_update_name");

    public static readonly Type12 TransferServiceIn = new("transfer_service_in");

    public static readonly Type12 TransferServiceOut = new("transfer_service_out");

    public static readonly Type12 SavePaymentMethod = new("save_payment_method");

    public static readonly Type12 MarketplaceSubscription = new("marketplace_subscription");

    public static readonly Type12 MigrateMarketplaceBillingDetailsIn = new("migrate_marketplace_billing_details_in");

    public static readonly Type12 MigrateMarketplaceBillingDetailsOut = new("migrate_marketplace_billing_details_out");

    public static readonly Type12 OrganizationUpdateTier = new("organization_update_tier");

    public static readonly Type12 OrganizationInviteCreate = new("organization_invite_create");

    public static readonly Type12 OrganizationInviteDelete = new("organization_invite_delete");

    public static readonly Type12 OrganizationMemberJoin = new("organization_member_join");

    public static readonly Type12 OrganizationMemberAdd = new("organization_member_add");

    public static readonly Type12 OrganizationMemberLeave = new("organization_member_leave");

    public static readonly Type12 OrganizationMemberDelete = new("organization_member_delete");

    public static readonly Type12 OrganizationMemberUpdateRole = new("organization_member_update_role");

    public static readonly Type12 OrganizationMemberUpdateRoles = new("organization_member_update_roles");

    public static readonly Type12 OrganizationMemberUpdateMfaMethod = new("organization_member_update_mfa_method");

    public static readonly Type12 OrganizationSamlConnectionCreate = new("organization_saml_connection_create");

    public static readonly Type12 OrganizationSamlConnectionUpdate = new("organization_saml_connection_update");

    public static readonly Type12 UserLogin = new("user_login");

    public static readonly Type12 UserLoginFailed = new("user_login_failed");

    public static readonly Type12 UserLogout = new("user_logout");

    public static readonly Type12 KeyCreate = new("key_create");

    public static readonly Type12 KeyDelete = new("key_delete");

    public static readonly Type12 OpenapiKeyUpdate = new("openapi_key_update");

    public static readonly Type12 ServiceCreate = new("service_create");

    public static readonly Type12 ServiceStart = new("service_start");

    public static readonly Type12 ServiceStop = new("service_stop");

    public static readonly Type12 ServiceAwaken = new("service_awaken");

    public static readonly Type12 ServiceIdle = new("service_idle");

    public static readonly Type12 ServiceRunning = new("service_running");

    public static readonly Type12 ServicePartiallyRunning = new("service_partially_running");

    public static readonly Type12 ServiceDelete = new("service_delete");

    public static readonly Type12 ServiceUpdateName = new("service_update_name");

    public static readonly Type12 ServiceUpdateIpAccessList = new("service_update_ip_access_list");

    public static readonly Type12 ServiceUpdateAutoscalingMemory = new("service_update_autoscaling_memory");

    public static readonly Type12 ServiceUpdateAutoscalingIdling = new("service_update_autoscaling_idling");

    public static readonly Type12 ServiceUpdatePassword = new("service_update_password");

    public static readonly Type12 ServiceUpdateAutoscalingReplicas = new("service_update_autoscaling_replicas");

    public static readonly Type12 ServiceUpdateMaxAllowableReplicas = new("service_update_max_allowable_replicas");

    public static readonly Type12 ServiceUpdateBackupConfiguration = new("service_update_backup_configuration");

    public static readonly Type12 ServiceRestoreBackup = new("service_restore_backup");

    public static readonly Type12 ServiceUpdateReleaseChannel = new("service_update_release_channel");

    public static readonly Type12 ServiceUpdateGptUsageConsent = new("service_update_gpt_usage_consent");

    public static readonly Type12 ServiceUpdatePrivateEndpoints = new("service_update_private_endpoints");

    public static readonly Type12 ServiceImportToOrganization = new("service_import_to_organization");

    public static readonly Type12 ServiceExportFromOrganization = new("service_export_from_organization");

    public static readonly Type12 ServiceMaintenanceStart = new("service_maintenance_start");

    public static readonly Type12 ServiceMaintenanceEnd = new("service_maintenance_end");

    public static readonly Type12 ServiceUpdateCoreDump = new("service_update_core_dump");

    public static readonly Type12 ServiceUpdateAutoscalingSchedule = new("service_update_autoscaling_schedule");

    public static readonly Type12 ServiceUpdateQueryEndpoints = new("service_update_query_endpoints");

    public static readonly Type12 ServiceUpdateDirectConnection = new("service_update_direct_connection");

    public static readonly Type12 ServiceUpdateSqlConsoleJwtAuth = new("service_update_sql_console_jwt_auth");

    public static readonly Type12 ServiceUpdateSnapshotConfiguration = new("service_update_snapshot_configuration");

    public static readonly Type12 ServiceUpdateCollectorIpAccessList = new("service_update_collector_ip_access_list");

    public static readonly Type12 ServiceUpdateMysqlInterface = new("service_update_mysql_interface");

    public static readonly Type12 ServiceUpdateUpgradeWindow = new("service_update_upgrade_window");

    public static readonly Type12 ServiceDeleteUpgradeWindow = new("service_delete_upgrade_window");

    public static readonly Type12 ServiceTriggerFailover = new("service_trigger_failover");

    public static readonly Type12 ServiceTriggerRecovery = new("service_trigger_recovery");

    public static readonly Type12 ServiceMcpEnabled = new("service_mcp_enabled");

    public static readonly Type12 ServiceMcpDisabled = new("service_mcp_disabled");

    public static readonly Type12 ServiceUpgrade = new("service_upgrade");

    public static readonly Type12 ServiceScaledDownForTierChange = new("service_scaled_down_for_tier_change");

    public static readonly Type12 ServiceEncryptionKeyCheckFailed = new("service_encryption_key_check_failed");

    public static readonly Type12 ServiceEncryptionKeyRotationFailed = new("service_encryption_key_rotation_failed");

    public static readonly Type12 ServiceEncryptionKeyRotated = new("service_encryption_key_rotated");

    public static readonly Type12 ServiceStopEncryptionKeyInaccessible = new("service_stop_encryption_key_inaccessible");

    public static readonly Type12 ServiceRestartEncryptionKeyRotation = new("service_restart_encryption_key_rotation");

    public static readonly Type12 BackupDelete = new("backup_delete");

    public static readonly Type12 BackupBucketCreate = new("backup_bucket_create");

    public static readonly Type12 BackupBucketUpdate = new("backup_bucket_update");

    public static readonly Type12 BackupBucketDelete = new("backup_bucket_delete");

    public static readonly Type12 BackupBucketArchive = new("backup_bucket_archive");

    public static readonly Type12 WarehouseUpdateName = new("warehouse_update_name");

    public static readonly Type12 WarehouseUpdateReleaseChannel = new("warehouse_update_release_channel");

    public static readonly Type12 RoleCreate = new("role_create");

    public static readonly Type12 RoleUpdate = new("role_update");

    public static readonly Type12 RoleDelete = new("role_delete");

    public static readonly Type12 RoleResourcesDelete = new("role_resources_delete");

    public static readonly Type12 OrganizationMemberRemoveRoles = new("organization_member_remove_roles");

    public static readonly Type12 ScimUserProfileUpdate = new("scim_user_profile_update");

    public static readonly Type12 ScimGroupCreate = new("scim_group_create");

    public static readonly Type12 ScimGroupUpdate = new("scim_group_update");

    public static readonly Type12 ScimGroupDelete = new("scim_group_delete");

    public static readonly Type12 OrganizationSamlConnectionDelete = new("organization_saml_connection_delete");

    public static readonly Type12 DatadogIntegrationCreate = new("datadog_integration_create");

    public static readonly Type12 DatadogIntegrationDelete = new("datadog_integration_delete");

    public static readonly Type12 OrganizationUpdateSpendAlert = new("organization_update_spend_alert");

    public static readonly Type12 OrganizationUpdateCoreDumps = new("organization_update_core_dumps");

    public static readonly Type12 OrganizationUpdatePrivateEndpoints = new("organization_update_private_endpoints");

    public static readonly Type12 OrganizationUpdatePciCompliance = new("organization_update_pci_compliance");

    public static readonly Type12 OrganizationUpdateHipaaStatus = new("organization_update_hipaa_status");

    public static readonly Type12 TransferCreditsIn = new("transfer_credits_in");

    public static readonly Type12 TransferCreditsOut = new("transfer_credits_out");

    public static readonly Type12 PromoCodeClaim = new("promo_code_claim");

    public static readonly Type12 SchemaAdvisorSeed = new("schema_advisor_seed");

    public static readonly Type12 SchemaAdvisorGeneratePlan = new("schema_advisor_generate_plan");

    public static readonly Type12 SchemaAdvisorApprovePlan = new("schema_advisor_approve_plan");

    public static readonly Type12 SchemaAdvisorStartDeployment = new("schema_advisor_start_deployment");

    public static readonly Type12 SchemaAdvisorStartBenchmark = new("schema_advisor_start_benchmark");

    public static readonly Type12 SchemaAdvisorRunBenchmark = new("schema_advisor_run_benchmark");

    public static readonly Type12 SchemaAdvisorStartPromotion = new("schema_advisor_start_promotion");

    public static readonly Type12 SchemaAdvisorExchangeTables = new("schema_advisor_exchange_tables");

    public static readonly Type12 SchemaAdvisorDropSandbox = new("schema_advisor_drop_sandbox");

    public static readonly Type12 UdfCreate = new("udf_create");

    public static readonly Type12 UdfUpdate = new("udf_update");

    public static readonly Type12 UdfDelete = new("udf_delete");

    public static readonly Type12 UdfVersionCreate = new("udf_version_create");

    public static readonly Type12 UdfVersionDelete = new("udf_version_delete");

    public static readonly Type12 UdfAttach = new("udf_attach");

    public static readonly Type12 UdfDetach = new("udf_detach");

    public static readonly Type12 UdfUpdateServices = new("udf_update_services");

    public static readonly Type12 UdfRedeploy = new("udf_redeploy");

    public static readonly Type12 UdfRebuild = new("udf_rebuild");

    public static Type12 FromValue(string value) => FromValueCore(value);
}
