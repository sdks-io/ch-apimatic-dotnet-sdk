
# Current Scaling

*This model accepts additional fields of type object.*

## Structure

`CurrentScaling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EffectiveAutoscalingMode` | [`EffectiveAutoscalingMode?`](../../doc/models/effective-autoscaling-mode.md) | Optional | Autoscaling mode currently in effect on the running service. May diverge from the configured baseline mode while a schedule entry is active. |
| `EffectiveMinReplicaMemoryGb` | `double?` | Optional | Minimum memory per replica (Gb) currently applied to the running service. May diverge from the top-level `minReplicaMemoryGb` baseline while a schedule entry is active. |
| `EffectiveMaxReplicaMemoryGb` | `double?` | Optional | Maximum memory per replica (Gb) currently applied to the running service. May diverge from the top-level `maxReplicaMemoryGb` baseline while a schedule entry is active. Reflects the stored value: normally equal to `effectiveMinReplicaMemoryGb` in horizontal mode, but a legacy service stored with an unequal memory range reports the stored bounds as-is. |
| `EffectiveMinReplicas` | `int?` | Optional | Minimum number of replicas currently applied to the running service. May diverge from the baseline while a schedule entry is active. Reflects the stored value: normally equal to `effectiveMaxReplicas` in vertical mode (a fixed replica count), but a legacy service stored with an unequal replica range reports the stored bounds as-is. |
| `EffectiveMaxReplicas` | `int?` | Optional | Maximum number of replicas currently applied to the running service. May diverge from the baseline while a schedule entry is active. |
| `EffectiveIdleScaling` | `bool?` | Optional | Whether idle scaling is currently in effect on the service. May diverge from the top-level `idleScaling` baseline while a schedule entry is active. |
| `EffectiveIdleTimeoutMinutes` | `int?` | Optional | Idle timeout in minutes currently in effect on the service. May diverge from the top-level `idleTimeoutMinutes` baseline while a schedule entry is active. |
| `ActiveEntryId` | `Guid?` | Optional | ID of the schedule entry whose values are currently applied to the service. Absent when no entry is active. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

CurrentScaling currentScaling = new CurrentScaling
{
    EffectiveAutoscalingMode = EffectiveAutoscalingMode.Vertical,
    EffectiveMinReplicaMemoryGb = 39.2,
    EffectiveMaxReplicaMemoryGb = 21.08,
    EffectiveMinReplicas = 124,
    EffectiveMaxReplicas = 40,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

