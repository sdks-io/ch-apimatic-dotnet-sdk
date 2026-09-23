
# Agg Fn

Aggregation function to apply to the field or metric value

## Enumeration

`AggFn`

## Fields

| Name |
|  --- |
| `Avg` |
| `Count` |
| `CountDistinct` |
| `LastValue` |
| `Max` |
| `Min` |
| `Quantile` |
| `Sum` |
| `Any` |
| `None` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

AggFn aggFn = AggFn.Quantile;
```

