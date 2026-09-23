
# Click Pipe My Sql Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMySqlPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SyncIntervalSeconds` | `int?` | Optional | Interval in seconds to sync data from MySQL during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PullBatchSize` | `int?` | Optional | Number of rows to pull in each batch during CDC replication.<br><br>**Constraints**: `>= 1` |
| `ReplicationMode` | [`ReplicationMode`](../../doc/models/replication-mode.md) | Required | Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot). |
| `ReplicationMechanism` | [`ReplicationMechanism?`](../../doc/models/replication-mechanism.md) | Optional | MySQL replication mechanism: "GTID" (Global Transaction Identifier) or "FILE_POS" (binary log file and position). Defaults to "GTID" if not specified. MariaDB supports "GTID" only. For "FILE_POS" on MySQL, contact support. |
| `UseCompression` | `bool?` | Optional | Enable compression for the MySQL connection. |
| `AllowNullableColumns` | `bool?` | Optional | Preserve nullability from MySQL in the destination ClickHouse table. When true, columns without NOT NULL constraints are created as Nullable(...). When false, all columns are non-nullable and NULL values are replaced with the default value for the type. Note: Nullable types have performance overhead in ClickHouse. |
| `InitialLoadParallelism` | `int?` | Optional | Number of parallel workers to use per table in the initial snapshot phase.<br><br>**Constraints**: `>= 1` |
| `SnapshotNumRowsPerPartition` | `int?` | Optional | Number of rows per partition during the snapshot phase.<br><br>**Constraints**: `>= 1000` |
| `SnapshotNumberOfParallelTables` | `int?` | Optional | Number of tables to snapshot in parallel during the initial load phase.<br><br>**Constraints**: `>= 1` |
| `DeleteOnMerge` | `bool?` | Optional | Enable hard delete behavior in ReplacingMergeTree for MySQL DELETE operations. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeMySqlPipeSettings clickPipeMySqlPipeSettings = new ClickPipeMySqlPipeSettings
{
    ReplicationMode = ReplicationMode.Cdc,
    SyncIntervalSeconds = 60,
    PullBatchSize = 1000,
    ReplicationMechanism = ReplicationMechanism.Gtid,
    UseCompression = false,
    AllowNullableColumns = false,
    InitialLoadParallelism = 1,
    SnapshotNumRowsPerPartition = 100000,
    SnapshotNumberOfParallelTables = 1,
    DeleteOnMerge = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

