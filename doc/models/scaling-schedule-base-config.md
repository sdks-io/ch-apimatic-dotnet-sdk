
# Scaling Schedule Base Config

*This model accepts additional fields of type object.*

## Structure

`ScalingScheduleBaseConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoscalingMode` | [`AutoscalingMode1?`](../../doc/models/autoscaling-mode-1.md) | Optional | Autoscaling mode applied when no schedule entry is active. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory. |
| `MinReplicaMemoryGb` | `double?` | Optional | Minimum memory per replica (Gb) when no schedule entry is active. Absent for services that do not autoscale memory. |
| `MaxReplicaMemoryGb` | `double?` | Optional | Maximum memory per replica (Gb) when no schedule entry is active. Absent for services that do not autoscale memory. |
| `MinReplicas` | `int?` | Optional | Minimum number of replicas when no schedule entry is active. |
| `MaxReplicas` | `int?` | Optional | Maximum number of replicas when no schedule entry is active. |
| `IdleScaling` | `bool?` | Optional | Whether idle scaling is enabled when no schedule entry is active. |
| `IdleTimeoutMinutes` | `int?` | Optional | Idle timeout in minutes when no schedule entry is active. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScalingScheduleBaseConfig scalingScheduleBaseConfig = new ScalingScheduleBaseConfig
{
    AutoscalingMode = AutoscalingMode1.Vertical,
    MinReplicaMemoryGb = 127.18,
    MaxReplicaMemoryGb = 178.66,
    MinReplicas = 18,
    MaxReplicas = 108,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

