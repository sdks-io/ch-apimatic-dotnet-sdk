
# Scaling Schedule Entry Request

*This model accepts additional fields of type object.*

## Structure

`ScalingScheduleEntryRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Human-readable label for this schedule entry. |
| `Weekdays` | `List<int>` | Required | Days of the week this entry applies to. 0 = Sunday, 1 = Monday, …, 6 = Saturday.<br><br>**Constraints**: *Minimum Items*: `1` |
| `StartHourUtc` | `int` | Required | UTC hour (0–23) when this entry becomes active (inclusive).<br><br>**Constraints**: `>= 0`, `<= 23` |
| `EndHourUtc` | `int` | Required | UTC hour (1–24) when this entry deactivates (exclusive). Must differ from startHourUtc. Set to 24 to end at midnight. Values less than startHourUtc create an overnight window spanning midnight.<br><br>**Constraints**: `>= 1`, `<= 24` |
| `AutoscalingMode` | [`AutoscalingMode2?`](../../doc/models/autoscaling-mode-2.md) | Optional | Autoscaling mode for this entry. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization. |
| `MinReplicaMemoryGb` | `double?` | Optional | Minimum memory per replica (Gb). Optional for vertical entries — provide both bounds for a memory range, or omit both to inherit memory from the base scaling config. Required for horizontal (both bounds, equal to maxReplicaMemoryGb — memory is fixed while the replica count scales). The upper bound is tier-dependent (lower for non-paid organizations) and enforced when the entry is applied.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `MaxReplicaMemoryGb` | `double?` | Optional | Maximum memory per replica (Gb). Optional for vertical entries — provide both bounds for a memory range, or omit both to inherit memory from the base scaling config. Required for horizontal (both bounds, equal to minReplicaMemoryGb — memory is fixed while the replica count scales). The upper bound is tier-dependent (lower for non-paid organizations) and enforced when the entry is applied.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `NumReplicas` | `int?` | Optional | Fixed replica count for a vertical entry (autoscalingMode "vertical" or omitted). Mutually exclusive with minReplicas/maxReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.<br><br>**Constraints**: `>= 1` |
| `MinReplicas` | `int?` | Optional | Minimum number of replicas. A minReplicas/maxReplicas band scales the replica count in a horizontal entry (autoscalingMode "horizontal"); when autoscalingMode is omitted or "vertical", an equal band (minReplicas === maxReplicas) is instead an accepted vertical fixed count and needs no horizontal entitlement. Must be provided together with maxReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.<br><br>**Constraints**: `>= 1` |
| `MaxReplicas` | `int?` | Optional | Maximum number of replicas. A minReplicas/maxReplicas band scales the replica count in a horizontal entry (autoscalingMode "horizontal"); when autoscalingMode is omitted or "vertical", an equal band (minReplicas === maxReplicas) is instead an accepted vertical fixed count and needs no horizontal entitlement. Must be provided together with minReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.<br><br>**Constraints**: `>= 1` |
| `IdleScaling` | `bool?` | Optional | Whether idle scaling is enabled during this window. |
| `IdleTimeoutMinutes` | `int?` | Optional | Idle timeout in minutes during this window. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScalingScheduleEntryRequest scalingScheduleEntryRequest = new ScalingScheduleEntryRequest
{
    Name = "Business hours",
    Weekdays = new List<int>
    {
        1,
        2,
        3,
        4,
        5,
    },
    StartHourUtc = 9,
    EndHourUtc = 17,
    AutoscalingMode = AutoscalingMode2.Vertical,
    MinReplicaMemoryGb = 16,
    MaxReplicaMemoryGb = 16,
    NumReplicas = 3,
    MinReplicas = 2,
    MaxReplicas = 3,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

