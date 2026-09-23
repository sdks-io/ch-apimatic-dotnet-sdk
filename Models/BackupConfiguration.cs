using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record BackupConfiguration
{
    /// <summary>
    /// The interval in hours between each backup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupPeriodInHours")]
    public double? BackupPeriodInHours { get; init; }

    /// <summary>
    /// The minimum duration in hours for which the backups are available. Must be a whole number of days between 24 (1 day) and 1080 (45 days) — i.e. a multiple of 24.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupRetentionPeriodInHours")]
    public double? BackupRetentionPeriodInHours { get; init; }

    /// <summary>
    /// The time in HH:MM format for the backups to be performed (evaluated in UTC timezone). When defined the backup period resets to every 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupStartTime")]
    public string? BackupStartTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
