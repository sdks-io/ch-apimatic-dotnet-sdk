
# Click Pipe Patch My Sql Pipe Remove Table Mapping

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchMySqlPipeRemoveTableMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceSchemaName` | `string` | Required | MySQL source database name. |
| `SourceTable` | `string` | Required | MySQL source table name. |
| `TargetTable` | `string` | Required | ClickHouse target table name, optionally prefixed with schema name (e.g., "my_database_my_table"). The table will be created automatically if it does not exist. For snapshot mode, the target table must be empty. |
| `TableEngine` | [`TableEngine?`](../../doc/models/table-engine.md) | Optional | ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it). |
| `PartitionKey` | `string` | Optional | Custom partitioning column used for parallel snapshotting. Must be an indexed column of an integer, date, datetime or timestamp type. Unrelated to ClickHouse partitioning. |
| `PartitionByExpr` | `string` | Optional | ClickHouse PARTITION BY expression applied to the destination table when ClickPipes creates it. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchMySqlPipeRemoveTableMapping clickPipePatchMySqlPipeRemoveTableMapping = new ClickPipePatchMySqlPipeRemoveTableMapping
{
    SourceSchemaName = "my_database",
    SourceTable = "users",
    TargetTable = "my_database_users",
    TableEngine = TableEngine.ReplacingMergeTree,
    PartitionKey = "id",
    PartitionByExpr = "toYYYYMM(created_at)",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

