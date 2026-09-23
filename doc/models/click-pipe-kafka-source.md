
# Click Pipe Kafka Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeKafkaSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type3?`](../../doc/models/type-3.md) | Optional | Type of the Kafka source. |
| `Format` | [`Format?`](../../doc/models/format.md) | Optional | Format of the Kafka source. |
| `Brokers` | `string` | Optional | Brokers of the Kafka source. |
| `Topics` | `string` | Optional | Topics of the Kafka source. |
| `ConsumerGroup` | `string` | Optional | Consumer group of the Kafka source. If not provided "clickpipes-<<ID>>" will be used. |
| `Authentication` | [`Authentication2?`](../../doc/models/authentication-2.md) | Optional | Authentication method of the Kafka source. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. Supported authentication methods: kafka: PLAIN, SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, msk: SCRAM-SHA-512, IAM_ROLE, IAM_USER, MUTUAL_TLS, gcmk: PLAIN, MUTUAL_TLS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY, confluent: PLAIN, MUTUAL_TLS, warpstream: PLAIN, azureeventhub: PLAIN, redpanda: SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, dokafka: SCRAM-SHA-256, MUTUAL_TLS |
| `IamRole` | `string` | Optional | IAM role for the Kafka source. Use with IAM role authentication. Read more in ClickPipes documentation: https://clickhouse.com/docs/en/integrations/clickpipes/kafka#iam |
| `Offset` | [`ClickPipeKafkaOffset`](../../doc/models/click-pipe-kafka-offset.md) | Optional | - |
| `SchemaRegistry` | [`ClickPipeKafkaSchemaRegistry`](../../doc/models/click-pipe-kafka-schema-registry.md) | Optional | - |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificates to validate the broker's certificate. |
| `ReversePrivateEndpointIds` | `List<string>` | Optional | Reverse private endpoint UUIDs used for a secure private connection to the Kafka source. |
| `ExactlyOnce` | `bool?` | Optional | Enable exactly-once delivery. Guarantees every Kafka record is inserted exactly once across restarts and rebalances. Can only be set at pipe creation. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeKafkaSource clickPipeKafkaSource = new ClickPipeKafkaSource
{
    Type = Type3.Kafka,
    Format = Format.JsonEachRow,
    Brokers = "brokers8",
    Topics = "topics0",
    ConsumerGroup = "my-clickpipe-consumer-group",
    IamRole = "arn:aws:iam::123456789012:role/MyRole",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

