using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record SnapshotConfigurationPatchRequest
{
    /// <summary>
    /// Whether scheduled snapshots are enabled for the service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// Interval between snapshots, in minutes. Set together with timeFrame; only supported preset pairs are accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gap")]
    public double? Gap { get; init; }

    /// <summary>
    /// Retention window the snapshots cover, in minutes. Set together with gap; only supported preset pairs are accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeFrame")]
    public double? TimeFrame { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
