
# Postgres Metric

*This model accepts additional fields of type object.*

## Structure

`PostgresMetric`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Required | Stable metric identifier (for example cpu_usage, connection_count, cache_hit_ratio). |
| `Name` | `string` | Required | Human-readable metric name. |
| `Unit` | `string` | Required | Unit of the metric values (for example %, IOPS, bytes/s, count). |
| `Description` | `string` | Required | Human-readable description of what the metric measures. |
| `Series` | [`List<PostgresMetricSeries>`](../../doc/models/postgres-metric-series.md) | Required | One series per label dimension of the metric. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresMetric postgresMetric = new PostgresMetric
{
    Key = "key6",
    Name = "name6",
    Unit = "unit4",
    Description = "description4",
    Series = new List<PostgresMetricSeries>
    {
        new PostgresMetricSeries
        {
            Label = "label4",
            DataPoints = new List<PostgresMetricDataPoint>
            {
                new PostgresMetricDataPoint
                {
                    Timestamp = 4,
                    MValue = 27.1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

