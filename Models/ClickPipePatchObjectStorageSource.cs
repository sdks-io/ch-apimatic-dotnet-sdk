using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchObjectStorageSource
{
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessKey")]
    public MskIamUser? AccessKey { get; init; }

    /// <summary>
    /// Base64-encoded GCP service account JSON key. Required when authentication is SERVICE_ACCOUNT.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceAccountKey")]
    public string? ServiceAccountKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
