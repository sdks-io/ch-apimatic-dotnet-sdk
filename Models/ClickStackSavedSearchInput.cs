using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSavedSearchInput
{
    /// <summary>
    /// Display name for the saved search.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// ID of the source to query. Must belong to the team.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Comma-separated list of column expressions to display. Empty uses the source default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("select")]
    public string? Select { get; init; }

    /// <summary>
    /// Row filter expression. The language is controlled by whereLanguage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("where")]
    public string? Where { get; init; }

    /// <summary>
    /// Language used for the where filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereLanguage")]
    public WhereLanguage12? WhereLanguage { get; init; }

    /// <summary>
    /// ORDER BY expression. Empty uses the source default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; init; }

    /// <summary>
    /// Tags used to organize saved searches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    /// <summary>
    /// Structured pinned filters applied to the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filters")]
    public IReadOnlyList<ClickStackSavedSearchFilter>? Filters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
