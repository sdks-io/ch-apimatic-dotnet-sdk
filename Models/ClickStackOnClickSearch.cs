using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackOnClickSearch
{
    /// <summary>
    /// OnClick variant discriminator. Must be "search" for search link-outs.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "search";

    [JsonPropertyName("target")]
    public required ClickStackOnClickTarget Target { get; init; }

    /// <summary>
    /// Optional WHERE clause template applied to the destination search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereTemplate")]
    public string? WhereTemplate { get; init; }

    /// <summary>
    /// Language of the rendered whereTemplate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereLanguage")]
    public WhereLanguage5? WhereLanguage { get; init; }

    /// <summary>
    /// Optional dashboard filter templates rendered against the clicked row.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filters")]
    public IReadOnlyList<ClickStackOnClickFilterTemplate>? Filters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
