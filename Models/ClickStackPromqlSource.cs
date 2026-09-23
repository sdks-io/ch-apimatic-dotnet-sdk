using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackPromqlSource
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
    /// Source kind discriminator. Must be "promql" for PromQL sources.
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; } = "promql";

    /// <summary>
    /// ID of the connection used by this source. Should reference a Prometheus-compatible connection.
    /// </summary>
    [JsonPropertyName("connection")]
    public required string Connection { get; init; }

    [JsonPropertyName("from")]
    public required ClickStackSourceFrom From { get; init; }

    /// <summary>
    /// Optional ClickHouse query settings applied when querying this source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("querySettings")]
    public IReadOnlyList<ClickStackQuerySetting>? QuerySettings { get; init; }

    /// <summary>
    /// Required by the API for all source kinds; not used when querying a Prometheus endpoint.
    /// </summary>
    [JsonPropertyName("timestampValueExpression")]
    public required string TimestampValueExpression { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
