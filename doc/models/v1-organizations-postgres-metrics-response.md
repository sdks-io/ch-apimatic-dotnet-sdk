
# V1 Organizations Postgres Metrics Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresMetricsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresMetrics`](../../doc/models/postgres-metrics.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsPostgresMetricsResponse v1OrganizationsPostgresMetricsResponse = new V1OrganizationsPostgresMetricsResponse
{
    Status = 200,
    RequestId = new Guid("00002640-0000-0000-0000-000000000000"),
    Result = new PostgresMetrics
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
                            new PostgresMetricDataPoint
                            {
                                Timestamp = 4,
                                MValue = 27.1,
                                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                            },
                        },
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
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
                            new PostgresMetricDataPoint
                            {
                                Timestamp = 4,
                                MValue = 27.1,
                                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                            },
                        },
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
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
                            new PostgresMetricDataPoint
                            {
                                Timestamp = 4,
                                MValue = 27.1,
                                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                            },
                        },
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
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
                            new PostgresMetricDataPoint
                            {
                                Timestamp = 4,
                                MValue = 27.1,
                                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                            },
                        },
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
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
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

