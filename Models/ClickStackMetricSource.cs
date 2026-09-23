using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackMetricSource
{
    /// <summary>
    /// Unique source ID. Server-generated; ignored if sent in create/update requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Display name for the source.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("section")]
    public string? Section { get; init; }

    /// <summary>
    /// When true, the source is hidden from source selectors in the UI. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// Source kind discriminator. Must be "metric" for metric sources.
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; } = "metric";

    /// <summary>
    /// ID of the ClickHouse connection used by this source.
    /// </summary>
    [JsonPropertyName("connection")]
    public required string Connection { get; init; }

    [JsonPropertyName("from")]
    public required ClickStackMetricSourceFrom From { get; init; }

    /// <summary>
    /// Optional ClickHouse query settings applied when querying this source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("querySettings")]
    public IReadOnlyList<ClickStackQuerySetting>? QuerySettings { get; init; }

    [JsonPropertyName("metricTables")]
    public required ClickStackMetricTables MetricTables { get; init; }

    /// <summary>
    /// DateTime column or expression that is part of your table's primary key.
    /// </summary>
    [JsonPropertyName("timestampValueExpression")]
    public required string TimestampValueExpression { get; init; }

    /// <summary>
    /// Column containing resource attributes for metrics
    /// </summary>
    [JsonPropertyName("resourceAttributesExpression")]
    public required string ResourceAttributesExpression { get; init; }

    /// <summary>
    /// HyperDX Source for logs associated with metrics. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logSourceId")]
    public string? LogSourceId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
