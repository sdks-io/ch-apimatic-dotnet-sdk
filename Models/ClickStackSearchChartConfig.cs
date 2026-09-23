using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSearchChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "search" for search/log viewer tiles.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "search";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Comma-separated list of expressions to display.
    /// </summary>
    [JsonPropertyName("select")]
    public required string Select { get; init; }

    /// <summary>
    /// Filter condition for the search (syntax depends on whereLanguage).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("where")]
    public string? Where { get; init; }

    /// <summary>
    /// Query language for the where clause.
    /// </summary>
    [JsonPropertyName("whereLanguage")]
    public required WhereLanguage4 WhereLanguage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
