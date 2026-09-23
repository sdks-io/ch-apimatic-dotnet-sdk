
# Scaling Schedule

*This model accepts additional fields of type object.*

## Structure

`ScalingSchedule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Entries` | [`List<ScalingScheduleEntry>`](../../doc/models/scaling-schedule-entry.md) | Required | List of schedule entries. |
| `BaseConfig` | [`ScalingScheduleBaseConfig`](../../doc/models/scaling-schedule-base-config.md) | Required | - |
| `ActiveEntryId` | `Guid?` | Optional | ID of the currently-active schedule entry. Absent when no entry is active and the base config is in effect. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScalingSchedule scalingSchedule = new ScalingSchedule
{
    Entries = new List<ScalingScheduleEntry>
    {
        new ScalingScheduleEntry
        {
            Id = new Guid("00000582-0000-0000-0000-000000000000"),
            Name = "name0",
            Weekdays = new List<int>
            {
                212,
            },
            StartHourUtc = 23,
            EndHourUtc = 24,
            AutoscalingMode = AutoscalingMode.Vertical,
            IsActiveNow = false,
            MinReplicaMemoryGb = 252.2,
            MaxReplicaMemoryGb = 53.64,
            MinReplicas = 232,
            MaxReplicas = 106,
            IdleScaling = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    BaseConfig = new ScalingScheduleBaseConfig
    {
        AutoscalingMode = AutoscalingMode1.Vertical,
        MinReplicaMemoryGb = 68.3,
        MaxReplicaMemoryGb = 237.54,
        MinReplicas = 18,
        MaxReplicas = 148,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ActiveEntryId = new Guid("000022d2-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

