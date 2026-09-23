using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSavedSearch
{
    /// <summary>
    /// Unique saved search ID. Server-generated.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Display name for the saved search.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// ID of the source this saved search queries.
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

    /// <summary>
    /// ID of the team that owns the saved search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("teamId")]
    public string? TeamId { get; init; }

    /// <summary>
    /// Creation timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Last update timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
