using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackDashboardContainer
{
    /// <summary>
    /// Unique identifier for the container within the dashboard.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Display title for the container.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// Persisted default collapse state. Per-viewer state lives in the URL.
    /// </summary>
    [JsonPropertyName("collapsed")]
    public required bool Collapsed { get; init; }

    /// <summary>
    /// Whether the user can collapse the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collapsible")]
    public bool? Collapsible { get; init; }

    /// <summary>
    /// Whether to show a visual border around the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bordered")]
    public bool? Bordered { get; init; }

    /// <summary>
    /// Optional tabs. 2+ entries renders a tab bar; 0-1 entries renders a plain group header. Tiles join a tab via tabId.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tabs")]
    public IReadOnlyList<ClickStackDashboardContainerTab>? Tabs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
