
# Autoscaling Mode 1

Autoscaling mode applied when no schedule entry is active. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory.

## Enumeration

`AutoscalingMode1`

## Fields

| Name |
|  --- |
| `Vertical` |
| `Horizontal` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

AutoscalingMode1 autoscalingMode1 = AutoscalingMode1.Vertical;
```

