using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceScalingPatchResponse
{
    /// <summary>
    /// Unique service ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

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
    /// Current state of the service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State? State { get; init; }

    /// <summary>
    /// ClickHouse version of the service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouseVersion")]
    public string? ClickhouseVersion { get; init; }

    /// <summary>
    /// List of all service endpoints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpoints")]
    public IReadOnlyList<ServiceEndpoint>? Endpoints { get; init; }

    /// <summary>
    /// DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use <c>minReplicaMemoryGb</c>, <c>maxReplicaMemoryGb</c>, and <c>numReplicas</c> instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tier")]
    public Tier? Tier { get; init; }

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
    /// Minimum auto-scaling memory in Gb for a single replica. Available only for 'production' services. Must be a multiple of 4 and greater than or equal to 8. A range in vertical autoscaling; equal to maxReplicaMemoryGb in horizontal (memory is fixed while the replica count scales).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum auto-scaling memory in Gb for a single replica. Available only for 'production' services. Must be a multiple of 4 and lower than or equal to 120 for non paid services or 356 for paid services. A range in vertical autoscaling; equal to minReplicaMemoryGb in horizontal (memory is fixed while the replica count scales).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Number of replicas for the service. The number of replicas must be between 2 and 50 for the first service in a warehouse. Services that are created in an existing warehouse can have a number of replicas as low as 1. Further restrictions may apply based on your organization's tier and its per-warehouse replica limit. It defaults to 1 for the BASIC tier and 3 for the SCALE and ENTERPRISE tiers. Present only when the service uses vertical autoscaling. For horizontal autoscaling, use minReplicas and maxReplicas instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? NumReplicas { get; init; }

    /// <summary>
    /// Minimum number of replicas for horizontal autoscaling. Present only when the service uses horizontal autoscaling.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas for horizontal autoscaling. Present only when the service uses horizontal autoscaling.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Configured autoscaling mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory. This is the baseline configuration; the mode currently applied (which may differ while a schedule entry is active) is currentScaling.effectiveAutoscalingMode.
    /// </summary>
    [JsonPropertyName("autoscalingMode")]
    public required AutoscalingMode3 AutoscalingMode { get; init; }

    /// <summary>
    /// Fixed memory per replica in Gb for horizontal autoscaling. Present only when the service uses horizontal autoscaling. Must be a multiple of 4, at least 8 Gb, and at most 120 Gb for non paid services or 356 Gb for paid services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? ReplicaMemoryGb { get; init; }

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
    /// List of IP addresses allowed to access the service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAccessList")]
    public IReadOnlyList<IpAccessListEntry>? IpAccessList { get; init; }

    /// <summary>
    /// Service creation timestamp. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

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
    /// IAM role used for accessing objects in s3
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; init; }

    /// <summary>
    /// List of private endpoints
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privateEndpointIds")]
    public IReadOnlyList<string>? PrivateEndpointIds { get; init; }

    /// <summary>
    /// List of available private endpoints ids that can be attached to the service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availablePrivateEndpointIds")]
    public IReadOnlyList<string>? AvailablePrivateEndpointIds { get; init; }

    /// <summary>
    /// Data warehouse containing this service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataWarehouseId")]
    public string? DataWarehouseId { get; init; }

    /// <summary>
    /// True if this service is the primary service in the data warehouse
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; init; }

    /// <summary>
    /// True if this service is read-only. It can only be read-only if a dataWarehouseId is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isReadonly")]
    public bool? IsReadonly { get; init; }

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
    /// Custom instance profile. Only available for ENTERPRISE and BYOC organization tiers. Standard values: 'v1-default', 'v1-highmem-xs', 'v1-highmem-s', 'v1-highmem-m', 'v1-highmem-l', 'v1-highmem-xl'. BYOC services may instead use a dynamic BYOC profile configured for their infrastructure (e.g. 'v1-standard-byoc-4'); it requires byocId, and minReplicaMemoryGb and maxReplicaMemoryGb must both equal the profile's memory size. Use the serviceProfiles endpoint to list the profiles available to the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    /// <summary>
    /// The ID of the Transparent Data Encryption key used for the service. This is only available if hasTransparentDataEncryption is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transparentDataEncryptionKeyId")]
    public string? TransparentDataEncryptionKeyId { get; init; }

    /// <summary>
    /// The ID of the IAM role used for encryption. This is only available if hasTransparentDataEncryption is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionRoleId")]
    public string? EncryptionRoleId { get; init; }

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
    /// True if the service's underline infra is enabled for collecting core dumps. This is an experimental feature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableCoreDumps")]
    public bool? EnableCoreDumps { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scalingSchedule")]
    public ScalingSchedule? ScalingSchedule { get; init; }

    [JsonPropertyName("currentScaling")]
    public required CurrentScaling CurrentScaling { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
