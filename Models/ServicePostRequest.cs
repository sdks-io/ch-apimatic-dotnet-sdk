using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServicePostRequest
{
    /// <summary>
    /// Name of the service. Alphanumerical string with whitespaces up to 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(50, MinimumLength = 1)]
    public string? Name { get; init; }

    /// <summary>
    /// Cloud provider
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provider")]
    public Provider? Provider { get; init; }

    /// <summary>
    /// Service region.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public Region? Region { get; init; }

    /// <summary>
    /// DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use <c>minReplicaMemoryGb</c>, <c>maxReplicaMemoryGb</c>, and <c>numReplicas</c> instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tier")]
    public Tier? Tier { get; init; }

    /// <summary>
    /// List of IP addresses allowed to access the service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAccessList")]
    public IReadOnlyList<IpAccessListEntry>? IpAccessList { get; init; }

    /// <summary>
    /// DEPRECATED - inaccurate for services with non-default numbers of replicas. Use <c>minReplicaMemoryGb</c> instead. Minimum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and greater than or equal to 24. Always absent for horizontal-autoscaling services (replica count is variable).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minTotalMemoryGb")]
    [Minimum(24.0)]
    [Maximum(1068.0)]
    [MultipleOf(12)]
    public double? MinTotalMemoryGb { get; init; }

    /// <summary>
    /// DEPRECATED - inaccurate for services with non-default numbers of replicas. Use <c>maxReplicaMemoryGb</c> instead. Maximum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and lower than or equal to 360 for non paid services or 1068 for paid services. Always absent for horizontal-autoscaling services (replica count is variable).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTotalMemoryGb")]
    [Minimum(24.0)]
    [Maximum(1068.0)]
    [MultipleOf(12)]
    public double? MaxTotalMemoryGb { get; init; }

    /// <summary>
    /// Autoscaling mode. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscalingMode")]
    public AutoscalingMode4? AutoscalingMode { get; init; }

    /// <summary>
    /// Minimum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to maxReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and greater than or equal to 8.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to minReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and lower than or equal to 120* for non paid services or 356* for paid services.* - maximum replica size subject to cloud provider hardware availability in your selected region.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Fixed replica count for vertical autoscaling (autoscalingMode "vertical" or omitted). Mutually exclusive with minReplicas/maxReplicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? NumReplicas { get; init; }

    /// <summary>
    /// Minimum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with maxReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the organization, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with minReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the organization, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// When set to true the service is allowed to scale down to zero when idle. True by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleScaling")]
    public bool? IdleScaling { get; init; }

    /// <summary>
    /// Set minimum idling timeout (in minutes). Must be &gt;= 5 minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; init; }

    /// <summary>
    /// True if this service is read-only. It can only be read-only if a dataWarehouseId is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isReadonly")]
    public bool? IsReadonly { get; init; }

    /// <summary>
    /// Data warehouse containing this service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataWarehouseId")]
    public string? DataWarehouseId { get; init; }

    /// <summary>
    /// Optional backup ID used as an initial state for the new service. When used the region and the tier of the new instance must be the same as the values of the original instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupId")]
    public Guid? BackupId { get; init; }

    /// <summary>
    /// Optional customer provided disk encryption key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; init; }

    /// <summary>
    /// Optional role to use for disk encryption
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionAssumedRoleIdentifier")]
    public string? EncryptionAssumedRoleIdentifier { get; init; }

    /// <summary>
    /// DEPRECATED. To associate the service with private endpoints, first create the service, then use the <c>Update Service Basic Details</c> endpoint with the <c>privateEndpointIds</c> field to modify private endpoints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privateEndpointIds")]
    public IReadOnlyList<string>? PrivateEndpointIds { get; init; }

    /// <summary>
    /// Accept the private preview terms and conditions. It is only needed when creating the first service in the organization in case of a private preview
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privatePreviewTermsChecked")]
    public bool? PrivatePreviewTermsChecked { get; init; }

    /// <summary>
    /// Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseChannel")]
    public ReleaseChannel? ReleaseChannel { get; init; }

    /// <summary>
    /// This is the ID returned after setting up a region for Bring Your Own Cloud (BYOC). When the byocId parameter is specified, the minReplicaMemoryGb and the maxReplicaGb parameters are required too, with values included among the following sizes: 48, 116, 172, 232.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("byocId")]
    public string? ByocId { get; init; }

    /// <summary>
    /// True if the service should have the Transparent Data Encryption (TDE) enabled. TDE is only available for ENTERPRISE organizations tiers and can only be enabled at service creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasTransparentDataEncryption")]
    public bool? HasTransparentDataEncryption { get; init; }

    /// <summary>
    /// List of service endpoints to enable or disable
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpoints")]
    public IReadOnlyList<ServiceEndpointChange>? Endpoints { get; init; }

    /// <summary>
    /// Custom instance profile. Only available for ENTERPRISE and BYOC organization tiers. Standard values: 'v1-default', 'v1-highmem-xs', 'v1-highmem-s', 'v1-highmem-m', 'v1-highmem-l', 'v1-highmem-xl'. BYOC services may instead use a dynamic BYOC profile configured for their infrastructure (e.g. 'v1-standard-byoc-4'); it requires byocId, and minReplicaMemoryGb and maxReplicaMemoryGb must both equal the profile's memory size. Use the serviceProfiles endpoint to list the profiles available to the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    /// <summary>
    /// Type of regulatory compliance for service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("complianceType")]
    public ComplianceType? ComplianceType { get; init; }

    /// <summary>
    /// Tags associated with the service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    [MaxLength(50)]
    public IReadOnlyList<ResourceTagsV1>? Tags { get; init; }

    /// <summary>
    /// Enables the underlying infra for collecting core dumps. Default is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableCoreDumps")]
    public bool? EnableCoreDumps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
