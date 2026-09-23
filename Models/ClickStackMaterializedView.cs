using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackMaterializedView
{
    /// <summary>
    /// Database name for the materialized view
    /// </summary>
    [JsonPropertyName("databaseName")]
    public required string DatabaseName { get; init; }

    /// <summary>
    /// Table name for the materialized view
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; init; }

    /// <summary>
    /// Columns which are not pre-aggregated in the materialized view and can be used for filtering and grouping.
    /// </summary>
    [JsonPropertyName("dimensionColumns")]
    public required string DimensionColumns { get; init; }

    /// <summary>
    /// The granularity of the timestamp column: a positive integer followed by a unit (s, m, h, d). Common values: 1s, 15s, 30s, 1m, 5m, 15m, 30m, 1h, 2h, 6h, 12h, 1d, 2d, 7d, 30d.
    /// </summary>
    [JsonPropertyName("minGranularity")]
    public required string MinGranularity { get; init; }

    /// <summary>
    /// (Optional) The earliest date and time for which the materialized view contains data. If not provided, then HyperDX will assume that the materialized view contains data for all dates for which the source table contains data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minDate")]
    public DateTimeOffset? MinDate { get; init; }

    /// <summary>
    /// Timestamp column name
    /// </summary>
    [JsonPropertyName("timestampColumn")]
    public required string TimestampColumn { get; init; }

    /// <summary>
    /// Columns which are pre-aggregated by the materialized view
    /// </summary>
    [JsonPropertyName("aggregatedColumns")]
    public required IReadOnlyList<ClickStackAggregatedColumn> AggregatedColumns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
