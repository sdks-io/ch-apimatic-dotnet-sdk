
# Postgres Metric Data Point

*This model accepts additional fields of type object.*

## Structure

`PostgresMetricDataPoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `int` | Required | Bucket start time as a Unix timestamp in seconds. |
| `MValue` | `double` | Required | Metric value for the bucket. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PostgresMetricDataPoint postgresMetricDataPoint = new PostgresMetricDataPoint
{
    Timestamp = 170,
    MValue = 97.04,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

