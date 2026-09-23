
# Click Pipe Post Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePostSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kafka` | [`ClickPipePostKafkaSource`](../../doc/models/click-pipe-post-kafka-source.md) | Optional | - |
| `ObjectStorage` | [`ClickPipePostObjectStorageSource`](../../doc/models/click-pipe-post-object-storage-source.md) | Optional | - |
| `Kinesis` | [`ClickPipePostKinesisSource`](../../doc/models/click-pipe-post-kinesis-source.md) | Optional | - |
| `Pubsub` | `object` | Optional | - |
| `Postgres` | [`ClickPipeMutatePostgresSource`](../../doc/models/click-pipe-mutate-postgres-source.md) | Optional | - |
| `Mysql` | [`ClickPipeMutateMySqlSource`](../../doc/models/click-pipe-mutate-my-sql-source.md) | Optional | - |
| `Bigquery` | `object` | Optional | - |
| `Mongodb` | [`ClickPipeMutateMongoDbSource`](../../doc/models/click-pipe-mutate-mongo-db-source.md) | Optional | - |
| `ValidateSamples` | `bool?` | Optional | Validate data samples received from data source. It will validate the connection and data availability and correctness. If not enabled, only connection will be validated. This has no effect on Postgres or MySQL pipes, they always only validate the connection and table definitions. This is experimental and can be removed in the future. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePostSource clickPipePostSource = new ClickPipePostSource
{
    Kafka = new ClickPipePostKafkaSource
    {
        Type = Type3.Azureeventhub,
        Format = Format.AvroConfluent,
        Brokers = "brokers4",
        Topics = "topics8",
        ConsumerGroup = "consumerGroup8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ObjectStorage = new ClickPipePostObjectStorageSource
    {
        Type = Type5.S3,
        Format = Format4.Csv,
        Url = "url6",
        Delimiter = "delimiter4",
        Compression = Compression.Lzma,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Kinesis = new ClickPipePostKinesisSource
    {
        Format = Format2.JsonEachRow,
        StreamName = "streamName0",
        Region = "region2",
        UseEnhancedFanOut = false,
        IteratorType = IteratorType.TrimHorizon,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Pubsub = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    Postgres = new ClickPipeMutatePostgresSource
    {
        Type = Type7.Crunchybridge,
        Credentials = new Plain
        {
            Username = "username4",
            Password = "password0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Host = "host2",
        Port = 80,
        Database = "database0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

