
# Click Pipe Patch My Sql Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchMySqlPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SyncIntervalSeconds` | `int?` | Optional | Interval in seconds to sync data from MySQL during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PullBatchSize` | `int?` | Optional | Number of rows to pull in each batch during CDC replication.<br><br>**Constraints**: `>= 1` |
| `UseCompression` | `bool?` | Optional | Enable compression for the MySQL connection. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchMySqlPipeSettings clickPipePatchMySqlPipeSettings = new ClickPipePatchMySqlPipeSettings
{
    SyncIntervalSeconds = 60,
    PullBatchSize = 1000,
    UseCompression = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

