using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSearchChartSeries
{
    /// <summary>
    /// Series type discriminator. Must be "search" for search/log viewer charts.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "search";

    /// <summary>
    /// ID of the data source to query
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// List of field names to display in the search results table
    /// </summary>
    [JsonPropertyName("fields")]
    public required IReadOnlyList<string> Fields { get; init; }

    /// <summary>
    /// Filter query for the data (syntax depends on whereLanguage)
    /// </summary>
    [JsonPropertyName("where")]
    public required string Where { get; init; }

    /// <summary>
    /// Query language for the where clause
    /// </summary>
    [JsonPropertyName("whereLanguage")]
    public required WhereLanguage WhereLanguage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
