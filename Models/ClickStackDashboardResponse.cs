using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackDashboardResponse
{
    /// <summary>
    /// Dashboard ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Dashboard name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// List of tiles/charts in the dashboard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tiles")]
    public IReadOnlyList<ClickStackTileOutput>? Tiles { get; init; }

    /// <summary>
    /// Tags for organizing and filtering dashboards
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    /// <summary>
    /// Dropdown filters added to the dashboard. Each one broadcasts its selected value as a condition, acts as a variable which can be referenced in tile queries, or both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filters")]
    public IReadOnlyList<ClickStackFilter>? Filters { get; init; }

    /// <summary>
    /// Optional default dashboard query restored when loading the dashboard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("savedQuery")]
    public string? SavedQuery { get; init; }

    /// <summary>
    /// Query language used by savedQuery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("savedQueryLanguage")]
    public SavedQueryLanguage? SavedQueryLanguage { get; init; }

    /// <summary>
    /// Optional default dashboard filter values restored when loading the dashboard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("savedFilterValues")]
    public IReadOnlyList<ClickStackSavedFilterValue>? SavedFilterValues { get; init; }

    /// <summary>
    /// Optional grouping containers. Each tile may join a container via tile.containerId, and a tab inside it via tile.tabId.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("containers")]
    public IReadOnlyList<ClickStackDashboardContainer>? Containers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
