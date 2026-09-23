
# Click Pipe Schema Discovery Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeSchemaDiscoverySource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kafka` | [`ClickPipePostKafkaSource`](../../doc/models/click-pipe-post-kafka-source.md) | Optional | - |
| `Kinesis` | [`ClickPipePostKinesisSource`](../../doc/models/click-pipe-post-kinesis-source.md) | Optional | - |
| `Pubsub` | `object` | Optional | - |
| `ObjectStorage` | [`ClickPipePostObjectStorageSource`](../../doc/models/click-pipe-post-object-storage-source.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeSchemaDiscoverySource clickPipeSchemaDiscoverySource = new ClickPipeSchemaDiscoverySource
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
    ObjectStorage = new ClickPipePostObjectStorageSource
    {
        Type = Type5.S3,
        Format = Format4.Csv,
        Url = "url6",
        Delimiter = "delimiter4",
        Compression = Compression.Lzma,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

