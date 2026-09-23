using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostBigQueryWorkloadIdentitySource
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
    /// Authenticate with the ClickPipes service tenant identity. Customer credentials must not be provided. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.
    /// </summary>
    [JsonPropertyName("authentication")]
    public string Authentication { get; } = "SERVICE_ACCOUNT_WORKLOAD_IDENTITY";

    /// <summary>
    /// GCP project ID that owns the BigQuery resources.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }
}
