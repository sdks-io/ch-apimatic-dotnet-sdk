using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresMetricSeries
{
    /// <summary>
    /// Distinguishing label for this series within the metric (for example a CPU mode, a database name, or "Reads").
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; init; }

    /// <summary>
    /// Time-ordered data points, one per bucket.
    /// </summary>
    [JsonPropertyName("dataPoints")]
    public required IReadOnlyList<PostgresMetricDataPoint> DataPoints { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
