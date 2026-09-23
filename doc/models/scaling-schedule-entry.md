
# Scaling Schedule Entry

*This model accepts additional fields of type object.*

## Structure

`ScalingScheduleEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique identifier for this schedule entry. |
| `Name` | `string` | Required | Human-readable label for this schedule entry. |
| `Weekdays` | `List<int>` | Required | Days of the week this entry applies to. 0 = Sunday, 1 = Monday, …, 6 = Saturday.<br><br>**Constraints**: *Minimum Items*: `1` |
| `StartHourUtc` | `int` | Required | UTC hour (0–23) when this entry becomes active (inclusive).<br><br>**Constraints**: `>= 0`, `<= 23` |
| `EndHourUtc` | `int` | Required | UTC hour (1–24) when this entry deactivates (exclusive). Must differ from startHourUtc. Set to 24 to end at midnight. Values less than startHourUtc create an overnight window spanning midnight.<br><br>**Constraints**: `>= 1`, `<= 24` |
| `AutoscalingMode` | [`AutoscalingMode`](../../doc/models/autoscaling-mode.md) | Required | Autoscaling mode for this entry. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory. Defaults to "vertical" for entries persisted before the mode was exposed. |
| `MinReplicaMemoryGb` | `double?` | Optional | Minimum memory per replica (Gb) during this window. A range in vertical; in horizontal it equals maxReplicaMemoryGb (memory is fixed while the replica count scales). |
| `MaxReplicaMemoryGb` | `double?` | Optional | Maximum memory per replica (Gb) during this window. A range in vertical; in horizontal it equals minReplicaMemoryGb (memory is fixed while the replica count scales). |
| `MinReplicas` | `int?` | Optional | Minimum number of replicas during this window. For a horizontal entry the replica count scales between minReplicas and maxReplicas; for a vertical entry minReplicas and maxReplicas are equal and report the fixed replica count (both omitted when the entry stored no count). |
| `MaxReplicas` | `int?` | Optional | Maximum number of replicas during this window. For a horizontal entry the replica count scales between minReplicas and maxReplicas; for a vertical entry minReplicas and maxReplicas are equal and report the fixed replica count (both omitted when the entry stored no count). |
| `IdleScaling` | `bool?` | Optional | Whether idle scaling is enabled during this window. |
| `IdleTimeoutMinutes` | `int?` | Optional | Idle timeout in minutes during this window. |
| `IsActiveNow` | `bool` | Required | Whether this entry is currently active. Scheduled times are indicative — actions are applied on a best-effort basis and may be delayed by a few minutes. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScalingScheduleEntry scalingScheduleEntry = new ScalingScheduleEntry
{
    Id = new Guid("0000064a-0000-0000-0000-000000000000"),
    Name = "name0",
    Weekdays = new List<int>
    {
        240,
        241,
        242,
    },
    StartHourUtc = 23,
    EndHourUtc = 24,
    AutoscalingMode = AutoscalingMode.Vertical,
    IsActiveNow = false,
    MinReplicaMemoryGb = 42.2,
    MaxReplicaMemoryGb = 7.64,
    MinReplicas = 224,
    MaxReplicas = 98,
    IdleScaling = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

