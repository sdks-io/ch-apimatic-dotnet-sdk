using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackTileInput
{
    /// <summary>
    /// Display name for the tile
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Horizontal position in the grid (0-based)
    /// </summary>
    [JsonPropertyName("x")]
    public required int X { get; init; }

    /// <summary>
    /// Vertical position in the grid (0-based)
    /// </summary>
    [JsonPropertyName("y")]
    public required int Y { get; init; }

    /// <summary>
    /// Width in grid units
    /// </summary>
    [JsonPropertyName("w")]
    public required int W { get; init; }

    /// <summary>
    /// Height in grid units
    /// </summary>
    [JsonPropertyName("h")]
    public required int H { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("config")]
    public ClickStackTileConfig? Config { get; init; }

    /// <summary>
    /// References a DashboardContainer by id. Tiles without containerId render in the default ungrouped area.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; init; }

    /// <summary>
    /// References a tab inside the tile's container by id. Requires containerId to be set, and the container to declare a matching tab.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tabId")]
    public string? TabId { get; init; }

    /// <summary>
    /// Optional tile ID. Omit to generate a new ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Display two series as a ratio (series[0] / series[1]). Only applicable when providing "series". Deprecated in favor of "config.asRatio".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asRatio")]
    public bool? AsRatio { get; init; }

    /// <summary>
    /// Data series to display in this tile (all must be the same type). Deprecated; use "config" instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("series")]
    public IReadOnlyList<ClickStackDashboardChartSeries>? Series { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
