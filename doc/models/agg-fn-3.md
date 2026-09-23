
# Agg Fn 3

Aggregation function to apply. "count" does not require a valueExpression; "quantile" requires a level field indicating the desired percentile (e.g., 0.95).

## Enumeration

`AggFn3`

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

AggFn3 aggFn3 = AggFn3.Quantile;
```

