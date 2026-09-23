using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostSource
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kafka")]
    public ClickPipePostKafkaSource? Kafka { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objectStorage")]
    public ClickPipePostObjectStorageSource? ObjectStorage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kinesis")]
    public ClickPipePostKinesisSource? Kinesis { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pubsub")]
    public object? Pubsub { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postgres")]
    public ClickPipeMutatePostgresSource? Postgres { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mysql")]
    public ClickPipeMutateMySqlSource? Mysql { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bigquery")]
    public object? Bigquery { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mongodb")]
    public ClickPipeMutateMongoDbSource? Mongodb { get; init; }

    /// <summary>
    /// Validate data samples received from data source. It will validate the connection and data availability and correctness. If not enabled, only connection will be validated. This has no effect on Postgres or MySQL pipes, they always only validate the connection and table definitions. This is experimental and can be removed in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validateSamples")]
    public bool? ValidateSamples { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
