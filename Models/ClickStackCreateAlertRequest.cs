using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackCreateAlertRequest
{
    /// <summary>
    /// Dashboard ID for tile-based alerts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; init; }

    /// <summary>
    /// Tile ID for tile-based alerts. Must be a line, stacked bar, or number type tile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tileId")]
    public string? TileId { get; init; }

    /// <summary>
    /// Saved search ID for saved_search alerts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("savedSearchId")]
    public string? SavedSearchId { get; init; }

    /// <summary>
    /// Group-by key for saved search alerts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupBy")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Threshold value for triggering the alert. For between and not_between threshold types, this is the lower bound.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public double? Threshold { get; init; }

    /// <summary>
    /// Upper bound for between and not_between threshold types. Required when thresholdType is between or not_between, must be &gt;= threshold.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thresholdMax")]
    public double? ThresholdMax { get; init; }

    /// <summary>
    /// Evaluation interval for the alert. <c>30s</c> requires the 30s alert interval feature to be enabled for your team.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interval")]
    public Interval? Interval { get; init; }

    /// <summary>
    /// Offset from the interval boundary in minutes. For example, 2 with a 5m interval evaluates windows at :02, :07, :12, etc. (UTC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduleOffsetMinutes")]
    public int? ScheduleOffsetMinutes { get; init; }

    /// <summary>
    /// Absolute UTC start time anchor. Alert windows start from this timestamp and repeat every interval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduleStartAt")]
    public DateTimeOffset? ScheduleStartAt { get; init; }

    /// <summary>
    /// Alert source type (tile-based or saved search).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public Source? Source { get; init; }

    /// <summary>
    /// Threshold comparison direction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thresholdType")]
    public ThresholdType? ThresholdType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public ClickStackAlertChannel? Channel { get; init; }

    /// <summary>
    /// Notification channels to trigger when the alert fires or resolves. Between 1 and 10 channels; duplicates are rejected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channels")]
    [MinLength(1)]
    [MaxLength(10)]
    public IReadOnlyList<ClickStackAlertChannel>? Channels { get; init; }

    /// <summary>
    /// Human-friendly alert name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Alert message template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Freeform note for the alert. Supports markdown formatting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    public string? Note { get; init; }

    /// <summary>
    /// Fire the alert only after its condition has been met for this many consecutive evaluation windows. While the condition is met but fewer than this many consecutive windows have violated, the alert is in the PENDING state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numConsecutiveWindows")]
    public int? NumConsecutiveWindows { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
