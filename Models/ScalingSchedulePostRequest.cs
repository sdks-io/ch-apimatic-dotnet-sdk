using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScalingSchedulePostRequest
{
    /// <summary>
    /// List of schedule entries. Pass an empty array to clear the schedule.
    /// </summary>
    [JsonPropertyName("entries")]
    public required IReadOnlyList<ScalingScheduleEntryRequest> Entries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
