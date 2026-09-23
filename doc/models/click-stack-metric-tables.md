
# Click Stack Metric Tables

*This model accepts additional fields of type object.*

## Structure

`ClickStackMetricTables`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Gauge` | `string` | Optional | Table containing gauge metrics data |
| `Histogram` | `string` | Optional | Table containing histogram metrics data |
| `Sum` | `string` | Optional | Table containing sum metrics data |
| `Summary` | `string` | Optional | Table containing summary metrics data. Note - not yet fully supported by HyperDX |
| `ExponentialHistogram` | `string` | Optional | Table containing exponential histogram metrics data. Note - not yet fully supported by HyperDX |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackMetricTables clickStackMetricTables = new ClickStackMetricTables
{
    Gauge = "otel_metrics_gauge",
    Histogram = "otel_metrics_histogram",
    Sum = "otel_metrics_sum",
    Summary = "otel_metrics_summary",
    ExponentialHistogram = "otel_metrics_exponential_histogram",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

