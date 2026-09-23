using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UsageCostRecord
{
    /// <summary>
    /// ID of the dataWarehouse this entity belongs to (or is).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataWarehouseId")]
    public Guid? DataWarehouseId { get; init; }

    /// <summary>
    /// ID of the service this entity belongs to (or is). Set to null for dataWarehouse entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceId")]
    public Guid? ServiceId { get; init; }

    /// <summary>
    /// Date of the usage. ISO-8601 date, based on the UTC timezone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// Type of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public EntityType? EntityType { get; init; }

    /// <summary>
    /// Unique ID of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityId")]
    public Guid? EntityId { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityName")]
    public string? EntityName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public UsageCostMetrics? Metrics { get; init; }

    /// <summary>
    /// Total cost of usage in ClickHouse Credits (CHCs) for this entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalCHC")]
    public double? TotalChc { get; init; }

    /// <summary>
    /// When true, the record is immutable. Unlocked records are subject to change until locked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locked")]
    public bool? Locked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
