using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record Snapshot
{
    /// <summary>
    /// Unique snapshot ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

    /// <summary>
    /// Status of the snapshot: 'done', 'error', 'in_progress', 'throttled'. 'throttled' means snapshot creation was rate-limited and will be retried.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status2? Status { get; init; }

    /// <summary>
    /// ID of the service the snapshot was created from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// Snapshot start timestamp. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// Snapshot finish timestamp. ISO-8601. Available only for finished snapshots
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; init; }

    /// <summary>
    /// Size of the snapshot in bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sizeInBytes")]
    public double? SizeInBytes { get; init; }

    /// <summary>
    /// Time in seconds it took to perform the snapshot. If the status is in_progress or throttled, this is the time in seconds since the snapshot started until now.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("durationInSeconds")]
    public double? DurationInSeconds { get; init; }

    /// <summary>
    /// Snapshot type. Always "full" — snapshots never chain off a parent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type14? Type { get; init; }

    /// <summary>
    /// Snapshot name on the external backup bucket.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backupName")]
    public string? BackupName { get; init; }

    /// <summary>
    /// Backup bucket where the snapshot is stored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bucket")]
    public Bucket1? Bucket { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
