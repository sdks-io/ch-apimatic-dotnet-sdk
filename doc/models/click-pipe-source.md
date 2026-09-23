
# Click Pipe Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kafka` | [`ClickPipeKafkaSource`](../../doc/models/click-pipe-kafka-source.md) | Optional | - |
| `ObjectStorage` | [`ClickPipeObjectStorageSource`](../../doc/models/click-pipe-object-storage-source.md) | Optional | - |
| `Kinesis` | [`ClickPipeKinesisSource`](../../doc/models/click-pipe-kinesis-source.md) | Optional | - |
| `Pubsub` | [`ClickPipePubSubSource`](../../doc/models/click-pipe-pub-sub-source.md) | Optional | - |
| `Postgres` | [`ClickPipePostgresSource`](../../doc/models/click-pipe-postgres-source.md) | Optional | - |
| `Mysql` | [`ClickPipeMySqlSource`](../../doc/models/click-pipe-my-sql-source.md) | Optional | - |
| `Bigquery` | `object` | Optional | - |
| `Mongodb` | [`ClickPipeMongoDbSource`](../../doc/models/click-pipe-mongo-db-source.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickPipeSource clickPipeSource = new ClickPipeSource
{
    Kafka = new ClickPipeKafkaSource
    {
        Type = Type3.Azureeventhub,
        Format = Format.AvroConfluent,
        Brokers = "brokers4",
        Topics = "topics8",
        ConsumerGroup = "consumerGroup8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ObjectStorage = new ClickPipeObjectStorageSource
    {
        Type = Type5.S3,
        Format = Format4.Csv,
        Url = "url6",
        Delimiter = "delimiter4",
        Compression = Compression.Lzma,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Kinesis = new ClickPipeKinesisSource
    {
        Format = Format2.JsonEachRow,
        StreamName = "streamName0",
        Region = "region2",
        UseEnhancedFanOut = false,
        IteratorType = IteratorType.TrimHorizon,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Pubsub = new ClickPipePubSubSource
    {
        Format = Format6.JsonEachRow,
        ProjectId = "projectId8",
        Topic = "topic0",
        Authentication = Authentication17.ServiceAccount,
        SeekType = SeekType.Latest,
        SeekTimestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Filter = "filter6",
        EnableOrdering = false,
        AckDeadline = 104,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Postgres = new ClickPipePostgresSource
    {
        Type = Type7.Crunchybridge,
        Host = "host2",
        Port = 80,
        Database = "database0",
        Authentication = Authentication11.Basic,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

