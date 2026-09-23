using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresMetricDataPoint
{
    /// <summary>
    /// Bucket start time as a Unix timestamp in seconds.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required int Timestamp { get; init; }

    /// <summary>
    /// Metric value for the bucket.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
