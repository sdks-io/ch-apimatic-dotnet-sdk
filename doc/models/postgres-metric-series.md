
# Postgres Metric Series

*This model accepts additional fields of type object.*

## Structure

`PostgresMetricSeries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Label` | `string` | Required | Distinguishing label for this series within the metric (for example a CPU mode, a database name, or "Reads"). |
| `DataPoints` | [`List<PostgresMetricDataPoint>`](../../doc/models/postgres-metric-data-point.md) | Required | Time-ordered data points, one per bucket. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresMetricSeries postgresMetricSeries = new PostgresMetricSeries
{
    Label = "label8",
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
};
```

