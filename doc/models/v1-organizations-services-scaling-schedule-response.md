
# V1 Organizations Services Scaling Schedule Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesScalingScheduleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ScalingSchedule`](../../doc/models/scaling-schedule.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesScalingScheduleResponse v1OrganizationsServicesScalingScheduleResponse = new V1OrganizationsServicesScalingScheduleResponse
{
    Status = 200,
    RequestId = new Guid("000023e6-0000-0000-0000-000000000000"),
    Result = new ScalingSchedule
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
        ActiveEntryId = new Guid("00000204-0000-0000-0000-000000000000"),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

