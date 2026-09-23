using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresMetric
{
    /// <summary>
    /// Stable metric identifier (for example cpu_usage, connection_count, cache_hit_ratio).
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// Human-readable metric name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Unit of the metric values (for example %, IOPS, bytes/s, count).
    /// </summary>
    [JsonPropertyName("unit")]
    public required string Unit { get; init; }

    /// <summary>
    /// Human-readable description of what the metric measures.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// One series per label dimension of the metric.
    /// </summary>
    [JsonPropertyName("series")]
    public required IReadOnlyList<PostgresMetricSeries> Series { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
