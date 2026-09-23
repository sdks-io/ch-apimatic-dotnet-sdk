using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScalingSchedule
{
    /// <summary>
    /// List of schedule entries.
    /// </summary>
    [JsonPropertyName("entries")]
    public required IReadOnlyList<ScalingScheduleEntry> Entries { get; init; }

    [JsonPropertyName("baseConfig")]
    public required ScalingScheduleBaseConfig BaseConfig { get; init; }

    /// <summary>
    /// ID of the currently-active schedule entry. Absent when no entry is active and the base config is in effect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeEntryId")]
    public Guid? ActiveEntryId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
