
# Click Pipe Post Request

*This model accepts additional fields of type object.*

## Structure

`ClickPipePostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the ClickPipe. |
| `Source` | [`ClickPipePostSource`](../../doc/models/click-pipe-post-source.md) | Optional | - |
| `Destination` | [`ClickPipeMutateDestination`](../../doc/models/click-pipe-mutate-destination.md) | Optional | - |
| `FieldMappings` | [`List<ClickPipeFieldMapping>`](../../doc/models/click-pipe-field-mapping.md) | Optional | Field mappings of the ClickPipe. Note that all destination columns must be included in the mappings. |
| `Scaling` | [`ClickPipeScaling`](../../doc/models/click-pipe-scaling.md) | Optional | - |
| `Settings` | [`ClickPipeSettings`](../../doc/models/click-pipe-settings.md) | Optional | - |
| `StartPaused` | `bool?` | Optional | Create the ClickPipe in the Stopped state instead of starting ingestion immediately. Start it later with the state endpoint. Not supported for database ClickPipes. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePostRequest clickPipePostRequest = new ClickPipePostRequest
{
    Name = "name6",
    Source = new ClickPipePostSource
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
    },
    Destination = new ClickPipeMutateDestination
    {
        Database = "database4",
        Table = "table2",
        ManagedTable = false,
        TableDefinition = new ClickPipeDestinationTableDefinition
        {
            Engine = new ClickPipeDestinationTableEngine
            {
                Type = Type11.MergeTree,
                VersionColumnId = "versionColumnId2",
                ColumnIds = new List<string>
                {
                    "columnIds0",
                },
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            SortingKey = new List<string>
            {
                "sortingKey0",
            },
            PartitionBy = "partitionBy0",
            PrimaryKey = "primaryKey2",
            Ttl = "ttl2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Columns = new List<ClickPipeDestinationColumn>
        {
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    FieldMappings = new List<ClickPipeFieldMapping>
    {
        new ClickPipeFieldMapping
        {
            SourceField = "sourceField4",
            DestinationField = "destinationField6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeFieldMapping
        {
            SourceField = "sourceField4",
            DestinationField = "destinationField6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Scaling = new ClickPipeScaling
    {
        Replicas = 40,
        Concurrency = 26,
        ReplicaCpuMillicores = 196,
        ReplicaMemoryGb = 8,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

