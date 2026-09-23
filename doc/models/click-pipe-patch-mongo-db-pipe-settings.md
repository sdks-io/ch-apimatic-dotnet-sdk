
# Click Pipe Patch Mongo Db Pipe Settings

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchMongoDbPipeSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SyncIntervalSeconds` | `int?` | Optional | Interval in seconds to sync data from MongoDB during CDC replication.<br><br>**Constraints**: `>= 1` |
| `PullBatchSize` | `int?` | Optional | Number of rows to pull in each batch during CDC replication.<br><br>**Constraints**: `>= 1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchMongoDbPipeSettings clickPipePatchMongoDbPipeSettings = new ClickPipePatchMongoDbPipeSettings
{
    SyncIntervalSeconds = 60,
    PullBatchSize = 100000,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

