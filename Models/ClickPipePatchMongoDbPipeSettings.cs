using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchMongoDbPipeSettings
{
    /// <summary>
    /// Interval in seconds to sync data from MongoDB during CDC replication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("syncIntervalSeconds")]
    [Minimum(1)]
    public int? SyncIntervalSeconds { get; init; }

    /// <summary>
    /// Number of rows to pull in each batch during CDC replication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pullBatchSize")]
    [Minimum(1)]
    public int? PullBatchSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
