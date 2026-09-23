
# Click Stack Log Source Metadata Materialized Views

*This model accepts additional fields of type object.*

## Structure

`ClickStackLogSourceMetadataMaterializedViews`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `KeyRollupTable` | `string` | Optional | ClickHouse table name for the key rollup (field discovery). |
| `KvRollupTable` | `string` | Optional | ClickHouse table name for the key-value rollup (value autocomplete). |
| `Granularity` | `string` | Optional | The time granularity of the rollup tables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackLogSourceMetadataMaterializedViews clickStackLogSourceMetadataMaterializedViews = new ClickStackLogSourceMetadataMaterializedViews
{
    KeyRollupTable = "otel_logs_key_rollup_15m",
    KvRollupTable = "otel_logs_kv_rollup_15m",
    Granularity = "15m",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

