using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record Backup
{
    /// <summary>
    /// Unique backup ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

    /// <summary>
    /// Status of the backup: 'done', 'error', 'in_progress'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status1? Status { get; init; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// Backup start timestamp. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// Backup finish timestamp. ISO-8601. Available only for finished backups
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; init; }

    /// <summary>
    /// Size of the backup in bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sizeInBytes")]
    public double? SizeInBytes { get; init; }

    /// <summary>
    /// Time in seconds it took to perform the backup. If the status still in_progress, this is the time in seconds since the backup started until now.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("durationInSeconds")]
    public double? DurationInSeconds { get; init; }

    /// <summary>
    /// Backup type ("full" or "incremental").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type13? Type { get; init; }

    /// <summary>
    /// Backup name on the external backup bucket.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupName")]
    public string? BackupName { get; init; }

    /// <summary>
    /// Backup bucket where the backup is stored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bucket")]
    public Bucket? Bucket { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
