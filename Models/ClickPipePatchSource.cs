using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchSource
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kafka")]
    public ClickPipePatchKafkaSource? Kafka { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objectStorage")]
    public ClickPipePatchObjectStorageSource? ObjectStorage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kinesis")]
    public ClickPipePatchKinesisSource? Kinesis { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pubsub")]
    public ClickPipePatchPubSubSource? Pubsub { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postgres")]
    public ClickPipePatchPostgresSource? Postgres { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mysql")]
    public ClickPipePatchMySqlSource? Mysql { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mongodb")]
    public ClickPipePatchMongoDbSource? Mongodb { get; init; }

    /// <summary>
    /// Validate data samples received from data source. It will validate the connection and data availability and correctness. If not enabled, only connection will be validated. This has no effect on Postgres or MySQL pipes, they always only validate the connection and table definitions. This is experimental and can be removed in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validateSamples")]
    public bool? ValidateSamples { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
