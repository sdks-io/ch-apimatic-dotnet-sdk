using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeObjectStorageSource
{
    /// <summary>
    /// Type of the ObjectStorage source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type5? Type { get; init; }

    /// <summary>
    /// Format of the files.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("format")]
    public Format4? Format { get; init; }

    /// <summary>
    /// Provide a path to the file(s) you want to ingest. You can specify multiple files using bash-like wildcards. For more information, see the documentation on using wildcards in path: https://clickhouse.com/docs/en/integrations/clickpipes/object-storage#limitations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Delimiter used in the files.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; init; }

    /// <summary>
    /// Compression algorithm used for the files.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compression")]
    public Compression? Compression { get; init; }

    /// <summary>
    /// If set to true, the pipe will continuously read new files from the source. If set to false, the pipe will read the files only once. New files have to be uploaded lexically order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isContinuous")]
    public bool? IsContinuous { get; init; }

    /// <summary>
    /// Queue URL for event-based continuous ingestion. For S3, provide an SQS queue URL. For GCS, provide a Pub/Sub subscription (e.g. projects/{project}/subscriptions/{name}). When provided, files are ingested based on event notifications rather than lexicographical order. Only applicable when isContinuous is true and authentication is not public.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; init; }

    /// <summary>
    /// If set to true, skips the initial load and only ingests files delivered by queue notifications. Only applicable when queueUrl is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipInitialLoad")]
    public bool? SkipInitialLoad { get; init; }

    /// <summary>
    /// Skip all files up to and including this object key during the initial load. Cannot be provided when skipInitialLoad is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startAfter")]
    public string? StartAfter { get; init; }

    /// <summary>
    /// Authentication method. IAM_USER is for S3, GCS, and DigitalOcean Spaces. IAM_ROLE is for S3 only. SERVICE_ACCOUNT is for GCS only. For GCS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. CONNECTION_STRING is for Azure Blob Storage. PUBLIC uses no authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication8? Authentication { get; init; }

    /// <summary>
    /// IAM role to be used with IAM role authentication. Read more in ClickPipes documentation: https://clickhouse.com/docs/en/integrations/clickpipes/object-storage#authentication
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; init; }

    /// <summary>
    /// Connection string for Azure Blob Storage authentication. Required when authentication is CONNECTION_STRING.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; init; }

    /// <summary>
    /// Path to the file(s) within the Azure container. Used for Azure Blob Storage sources. You can specify multiple files using bash-like wildcards. For more information, see the documentation on using wildcards in path: https://clickhouse.com/docs/en/integrations/clickpipes/object-storage#limitations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("path")]
    public string? Path { get; init; }

    /// <summary>
    /// Container name for Azure Blob Storage. Required when type is azureblobstorage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("azureContainerName")]
    public string? AzureContainerName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
