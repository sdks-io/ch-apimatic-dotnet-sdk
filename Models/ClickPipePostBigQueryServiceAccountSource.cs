using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostBigQueryServiceAccountSource
{
    /// <summary>
    /// GCS bucket path for staging snapshot data (e.g., gs://my-bucket/staging/). Data will be automatically cleaned up after initial load.
    /// </summary>
    [JsonPropertyName("snapshotStagingPath")]
    public required string SnapshotStagingPath { get; init; }

    [JsonPropertyName("settings")]
    public required ClickPipeBigQueryPipeSettings Settings { get; init; }

    /// <summary>
    /// Table mappings for BigQuery pipe.
    /// </summary>
    [JsonPropertyName("tableMappings")]
    public required IReadOnlyList<ClickPipeBigQueryPipeTableMapping> TableMappings { get; init; }

    /// <summary>
    /// Authenticate with a Google Cloud service account JSON key. Defaults to SERVICE_ACCOUNT when omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication16? Authentication { get; init; }

    /// <summary>
    /// GCP project ID that owns the BigQuery resources.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; init; }

    [JsonPropertyName("credentials")]
    public required ServiceAccount Credentials { get; init; }
}
