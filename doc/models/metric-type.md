
# Metric Type

Metric type; only applicable when the source is a metrics source.

## Enumeration

`MetricType`

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

MetricType metricType = MetricType.Gauge;
```

