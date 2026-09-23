
# Click Stack Metric Source From

*This model accepts additional fields of type object.*

## Structure

`ClickStackMetricSourceFrom`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatabaseName` | `string` | Required | ClickHouse database name |
| `TableName` | `string` | Optional | ClickHouse table name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackMetricSourceFrom clickStackMetricSourceFrom = new ClickStackMetricSourceFrom
{
    DatabaseName = "otel",
    TableName = "otel_metrics_gauge",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

