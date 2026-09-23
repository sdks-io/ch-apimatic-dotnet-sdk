
# Autoscaling Mode 3

Configured autoscaling mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory. This is the baseline configuration; the mode currently applied (which may differ while a schedule entry is active) is currentScaling.effectiveAutoscalingMode.

## Enumeration

`AutoscalingMode3`

## Fields

| Name |
|  --- |
| `Vertical` |
| `Horizontal` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

AutoscalingMode3 autoscalingMode3 = AutoscalingMode3.Vertical;
```

