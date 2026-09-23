
# Click Pipe Patch Postgres Pipe Remove Table Mapping

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchPostgresPipeRemoveTableMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceSchemaName` | `string` | Optional | PostgreSQL source schema name. |
| `SourceTable` | `string` | Optional | PostgreSQL source table name. |
| `TargetTable` | `string` | Optional | ClickHouse target table name, optionally prefixed with schema name (e.g., "my_schema_my_table"). The table will be created automatically if it does not exist. For snapshot mode, the target table must be empty. |
| `TableEngine` | [`TableEngine?`](../../doc/models/table-engine.md) | Optional | ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it). |
| `PartitionKey` | `string` | Optional | Custom partitioning column used for parallel snapshotting. Only beneficial for PostgreSQL 13 (no benefit for PG14+, which supports indexed ctid scans). Must be an indexed column of type: `smallint`, `integer`, `bigint`, `timestamp without time zone`, or `timestamp with time zone`. Unrelated to ClickHouse partitioning. |
| `PartitionByExpr` | `string` | Optional | ClickHouse PARTITION BY expression applied to the destination table when ClickPipes creates it. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchPostgresPipeRemoveTableMapping clickPipePatchPostgresPipeRemoveTableMapping = new ClickPipePatchPostgresPipeRemoveTableMapping
{
    SourceSchemaName = "public",
    SourceTable = "users",
    TargetTable = "public_users",
    TableEngine = TableEngine.ReplacingMergeTree,
    PartitionKey = "id",
    PartitionByExpr = "toYYYYMM(created_at)",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

