
# Click Pipe Mongo Db Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMongoDbPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SyncIntervalSeconds` | `int?` | Optional | Interval in seconds to sync data from MongoDB during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PullBatchSize` | `int?` | Optional | Number of rows to pull in each batch during CDC replication.<br><br>**Constraints**: `>= 1` |
| `ReplicationMode` | [`ReplicationMode`](../../doc/models/replication-mode.md) | Required | Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot). |
| `InitialLoadParallelism` | `int?` | Optional | Number of parallel workers to use per collection in the initial snapshot phase.<br><br>**Constraints**: `>= 1` |
| `SnapshotNumRowsPerPartition` | `int?` | Optional | Number of rows per partition during the snapshot phase.<br><br>**Constraints**: `>= 1000` |
| `SnapshotNumberOfParallelTables` | `int?` | Optional | Number of collections to snapshot in parallel during the initial load phase.<br><br>**Constraints**: `>= 1` |
| `DeleteOnMerge` | `bool?` | Optional | Enable hard delete behavior in ReplacingMergeTree for MongoDB DELETE operations. |
| `UseJsonNativeFormat` | `bool?` | Optional | Store JSON values in native ClickHouse JSON format. When disabled, JSON data is stored as String. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeMongoDbPipeSettings clickPipeMongoDbPipeSettings = new ClickPipeMongoDbPipeSettings
{
    ReplicationMode = ReplicationMode.Cdc,
    SyncIntervalSeconds = 60,
    PullBatchSize = 100000,
    InitialLoadParallelism = 1,
    SnapshotNumRowsPerPartition = 100000,
    SnapshotNumberOfParallelTables = 1,
    DeleteOnMerge = false,
    UseJsonNativeFormat = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

