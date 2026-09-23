
# Click Stack Metric Source

*This model accepts additional fields of type object.*

## Structure

`ClickStackMetricSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique source ID. Server-generated; ignored if sent in create/update requests. |
| `Name` | `string` | Required | Display name for the source. |
| `Section` | `string` | Optional | Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together. |
| `Disabled` | `bool?` | Optional | When true, the source is hidden from source selectors in the UI. Defaults to false. |
| `Kind` | `string` | Required, Constant | Source kind discriminator. Must be "metric" for metric sources.<br><br>**Value**: `"metric"` |
| `Connection` | `string` | Required | ID of the ClickHouse connection used by this source. |
| `From` | [`ClickStackMetricSourceFrom`](../../doc/models/click-stack-metric-source-from.md) | Required | - |
| `QuerySettings` | [`List<ClickStackQuerySetting>`](../../doc/models/click-stack-query-setting.md) | Optional | Optional ClickHouse query settings applied when querying this source. |
| `MetricTables` | [`ClickStackMetricTables`](../../doc/models/click-stack-metric-tables.md) | Required | - |
| `TimestampValueExpression` | `string` | Required | DateTime column or expression that is part of your table's primary key. |
| `ResourceAttributesExpression` | `string` | Required | Column containing resource attributes for metrics |
| `LogSourceId` | `string` | Optional | HyperDX Source for logs associated with metrics. Optional |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackMetricSource clickStackMetricSource = new ClickStackMetricSource
{
    Name = "Metrics",
    Kind = "metric",
    Connection = "507f1f77bcf86cd799439012",
    From = new ClickStackMetricSourceFrom
    {
        DatabaseName = "otel",
        TableName = "otel_metrics_gauge",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    MetricTables = new ClickStackMetricTables
    {
        Gauge = "otel_metrics_gauge",
        Histogram = "otel_metrics_histogram",
        Sum = "otel_metrics_sum",
        Summary = "otel_metrics_summary",
        ExponentialHistogram = "otel_metrics_exponential_histogram",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TimestampValueExpression = "TimeUnix",
    ResourceAttributesExpression = "ResourceAttributes",
    Id = "507f1f77bcf86cd799439041",
    Section = "Billing",
    Disabled = false,
    QuerySettings = new List<ClickStackQuerySetting>
    {
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    LogSourceId = "507f1f77bcf86cd799439011",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

