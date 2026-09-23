using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackEventPatternsChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "event_patterns" for pattern mining tiles.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "event_patterns";

    /// <summary>
    /// ID of the data source to mine patterns from.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Column or expression to mine patterns from. Leave empty to use the source default (Body for logs, SpanName for traces).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("select")]
    public string? Select { get; init; }

    /// <summary>
    /// Filter condition for the pattern mining query (syntax depends on whereLanguage).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("where")]
    public string? Where { get; init; }

    /// <summary>
    /// Query language for the where clause.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereLanguage")]
    public WhereLanguage4? WhereLanguage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
