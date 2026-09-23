
# Click Pipe Mongo Db Pipe Table Mapping

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMongoDbPipeTableMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceDatabaseName` | `string` | Required | MongoDB source database name. |
| `SourceCollection` | `string` | Required | MongoDB source collection name. |
| `TargetTable` | `string` | Required | ClickHouse target table name. The table will be created automatically if it does not exist. |
| `TableEngine` | [`TableEngine?`](../../doc/models/table-engine.md) | Optional | ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeMongoDbPipeTableMapping clickPipeMongoDbPipeTableMapping = new ClickPipeMongoDbPipeTableMapping
{
    SourceDatabaseName = "mydb",
    SourceCollection = "users",
    TargetTable = "mydb_users",
    TableEngine = TableEngine.ReplacingMergeTree,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

