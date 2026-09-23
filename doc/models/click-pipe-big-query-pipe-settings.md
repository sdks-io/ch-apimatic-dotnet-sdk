
# Click Pipe Big Query Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipeBigQueryPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReplicationMode` | `string` | Required, Constant | Replication mode. BigQuery only supports snapshot mode.<br><br>**Value**: `"snapshot"` |
| `AllowNullableColumns` | `bool?` | Optional | Allow nullable columns in the destination table. |
| `InitialLoadParallelism` | `double?` | Optional | Number of parallel workers during initial load. |
| `SnapshotNumRowsPerPartition` | `double?` | Optional | Number of rows to snapshot per partition. |
| `SnapshotNumberOfParallelTables` | `double?` | Optional | Number of parallel tables to snapshot. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeBigQueryPipeSettings clickPipeBigQueryPipeSettings = new ClickPipeBigQueryPipeSettings
{
    ReplicationMode = "snapshot",
    AllowNullableColumns = false,
    InitialLoadParallelism = 80.78,
    SnapshotNumRowsPerPartition = 101.72,
    SnapshotNumberOfParallelTables = 73.4,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

