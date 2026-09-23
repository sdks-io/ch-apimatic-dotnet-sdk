using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresMetrics
{
    /// <summary>
    /// Available metrics, each with its bucketed time series.
    /// </summary>
    [JsonPropertyName("metrics")]
    public required IReadOnlyList<PostgresMetric> Metrics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
