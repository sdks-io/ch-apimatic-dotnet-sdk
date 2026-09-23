using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeKafkaSource
{
    /// <summary>
    /// Type of the Kafka source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type3? Type { get; init; }

    /// <summary>
    /// Format of the Kafka source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("format")]
    public Format? Format { get; init; }

    /// <summary>
    /// Brokers of the Kafka source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brokers")]
    public string? Brokers { get; init; }

    /// <summary>
    /// Topics of the Kafka source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topics")]
    public string? Topics { get; init; }

    /// <summary>
    /// Consumer group of the Kafka source. If not provided "clickpipes-&lt;&lt;ID&gt;&gt;" will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; init; }

    /// <summary>
    /// Authentication method of the Kafka source. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. Supported authentication methods: kafka: PLAIN, SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, msk: SCRAM-SHA-512, IAM_ROLE, IAM_USER, MUTUAL_TLS, gcmk: PLAIN, MUTUAL_TLS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY, confluent: PLAIN, MUTUAL_TLS, warpstream: PLAIN, azureeventhub: PLAIN, redpanda: SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, dokafka: SCRAM-SHA-256, MUTUAL_TLS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication2? Authentication { get; init; }

    /// <summary>
    /// IAM role for the Kafka source. Use with IAM role authentication. Read more in ClickPipes documentation: https://clickhouse.com/docs/en/integrations/clickpipes/kafka#iam
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    public ClickPipeKafkaOffset? Offset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schemaRegistry")]
    public ClickPipeKafkaSchemaRegistry? SchemaRegistry { get; init; }

    /// <summary>
    /// PEM encoded CA certificates to validate the broker's certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; init; }

    /// <summary>
    /// Reverse private endpoint UUIDs used for a secure private connection to the Kafka source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reversePrivateEndpointIds")]
    public IReadOnlyList<string>? ReversePrivateEndpointIds { get; init; }

    /// <summary>
    /// Enable exactly-once delivery. Guarantees every Kafka record is inserted exactly once across restarts and rebalances. Can only be set at pipe creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exactlyOnce")]
    public bool? ExactlyOnce { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
