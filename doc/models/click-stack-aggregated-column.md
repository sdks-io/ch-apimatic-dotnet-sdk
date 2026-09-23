
# Click Stack Aggregated Column

*This model accepts additional fields of type object.*

## Structure

`ClickStackAggregatedColumn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceColumn` | `string` | Optional | Source column name |
| `AggFn` | `string` | Required | Aggregation function (e.g., count, sum, avg) |
| `MvColumn` | `string` | Required | Materialized view column name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackAggregatedColumn clickStackAggregatedColumn = new ClickStackAggregatedColumn
{
    AggFn = "sum",
    MvColumn = "sum__Duration",
    SourceColumn = "Duration",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

