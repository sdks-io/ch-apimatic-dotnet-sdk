
# Metric Data Type

Metric data type, only for metrics data sources.

## Enumeration

`MetricDataType`

## Fields

| Name |
|  --- |
| `Sum` |
| `Gauge` |
| `Histogram` |
| `Summary` |
| `EnumExponentialHistogram` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

MetricDataType metricDataType = MetricDataType.Summary;
```

