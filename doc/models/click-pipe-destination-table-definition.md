
# Click Pipe Destination Table Definition

*This model accepts additional fields of type object.*

## Structure

`ClickPipeDestinationTableDefinition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Engine` | [`ClickPipeDestinationTableEngine`](../../doc/models/click-pipe-destination-table-engine.md) | Optional | - |
| `SortingKey` | `List<string>` | Optional | Sorting key of the destination table. List of columns. |
| `PartitionBy` | `string` | Optional | Partition key SQL expression. |
| `PrimaryKey` | `string` | Optional | Primary key of SQL expression. |
| `Ttl` | `string` | Optional | TTL SQL expression of the destination table.<br><br>**Constraints**: *Minimum Length*: `1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeDestinationTableDefinition clickPipeDestinationTableDefinition = new ClickPipeDestinationTableDefinition
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
        "sortingKey4",
        "sortingKey5",
        "sortingKey6",
    },
    PartitionBy = "partitionBy4",
    PrimaryKey = "primaryKey6",
    Ttl = "toDateTime(event_time) + INTERVAL 30 DAY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

