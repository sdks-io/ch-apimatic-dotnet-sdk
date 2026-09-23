using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record OrganizationQuota
{
    /// <summary>
    /// Stable identifier of the quota. Use it to request a single quota by code.
    /// </summary>
    [JsonPropertyName("quotaCode")]
    public required QuotaCode QuotaCode { get; init; }

    /// <summary>
    /// Human-readable name of the quota.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Explanation of the resource the quota limits and how the limit is applied.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Granularity at which the limit is applied. For example, <c>replicas-per-warehouse</c> is an organization-wide setting that limits each warehouse individually.
    /// </summary>
    [JsonPropertyName("scope")]
    public required Scope Scope { get; init; }

    /// <summary>
    /// Limit currently applied to the organization, including any adjustments made for the organization. The value can change when the billing status of the organization changes.
    /// </summary>
    [JsonPropertyName("value")]
    [Minimum(0)]
    public required int Value { get; init; }

    /// <summary>
    /// Current consumption of the quota. Omitted for quotas that do not report usage. Usage can exceed <c>value</c> when a limit was lowered after resources were created; existing resources are not affected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    [Minimum(0)]
    public int? Usage { get; init; }

    /// <summary>
    /// Whether the limit can be raised for the organization by contacting ClickHouse support.
    /// </summary>
    [JsonPropertyName("adjustable")]
    public required bool Adjustable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
