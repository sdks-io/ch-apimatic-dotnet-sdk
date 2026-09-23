
# Effective Autoscaling Mode

Autoscaling mode currently in effect on the running service. May diverge from the configured baseline mode while a schedule entry is active.

## Enumeration

`EffectiveAutoscalingMode`

## Fields

| Name |
|  --- |
| `Vertical` |
| `Horizontal` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

EffectiveAutoscalingMode effectiveAutoscalingMode = EffectiveAutoscalingMode.Vertical;
```

