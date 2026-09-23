
# Postgres Metrics

*This model accepts additional fields of type object.*

## Structure

`PostgresMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metrics` | [`List<PostgresMetric>`](../../doc/models/postgres-metric.md) | Required | Available metrics, each with its bucketed time series. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresMetrics postgresMetrics = new PostgresMetrics
{
    Metrics = new List<PostgresMetric>
    {
        new PostgresMetric
        {
            Key = "key8",
            Name = "name8",
            Unit = "unit6",
            Description = "description8",
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
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

