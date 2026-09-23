
# Click Pipe Postgres Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipePostgresPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SyncIntervalSeconds` | `int?` | Optional | Interval in seconds to sync data from Postgres during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PullBatchSize` | `int?` | Optional | Number of rows to pull in each batch during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PublicationName` | `string` | Optional | PostgreSQL publication name to use for CDC replication. If not provided, ClickPipes will create one automatically. |
| `ReplicationMode` | [`ReplicationMode?`](../../doc/models/replication-mode.md) | Optional | Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot). |
| `ReplicationSlotName` | `string` | Optional | PostgreSQL replication slot name. Only valid for "cdc_only" mode. For "cdc" mode, ClickPipes creates the slot automatically. |
| `AllowNullableColumns` | `bool?` | Optional | Preserve nullability from Postgres in the destination ClickHouse table. When true, columns without NOT NULL constraints are created as Nullable(...). When false, all columns are non-nullable and NULL values are replaced with the default value for the type. Note: Nullable types have performance overhead in ClickHouse. |
| `InitialLoadParallelism` | `int?` | Optional | Number of parallel workers to use per table in the initial snapshot phase.<br><br>**Constraints**: `>= 1` |
| `SnapshotNumRowsPerPartition` | `int?` | Optional | Number of rows per partition during the snapshot phase.<br><br>**Constraints**: `>= 1000` |
| `SnapshotNumberOfParallelTables` | `int?` | Optional | Number of tables to snapshot in parallel during the initial load phase.<br><br>**Constraints**: `>= 1` |
| `EnableFailoverSlots` | `bool?` | Optional | Enable failover support for the replication slot on PG17 and newer. Only applicable when ClickPipes creates the replication slot (i.e., replicationSlotName is NOT provided). |
| `DeleteOnMerge` | `bool?` | Optional | Enable hard delete behavior in ReplacingMergeTree for PostgreSQL DELETE operations. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePostgresPipeSettings clickPipePostgresPipeSettings = new ClickPipePostgresPipeSettings
{
    SyncIntervalSeconds = 60,
    PullBatchSize = 1000,
    PublicationName = "clickpipes_publication",
    ReplicationMode = ReplicationMode.Cdc,
    ReplicationSlotName = "clickpipes_slot",
    AllowNullableColumns = false,
    InitialLoadParallelism = 1,
    SnapshotNumRowsPerPartition = 100000,
    SnapshotNumberOfParallelTables = 1,
    EnableFailoverSlots = false,
    DeleteOnMerge = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

