
# Scaling Schedule Post Request

*This model accepts additional fields of type object.*

## Structure

`ScalingSchedulePostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Entries` | [`List<ScalingScheduleEntryRequest>`](../../doc/models/scaling-schedule-entry-request.md) | Required | List of schedule entries. Pass an empty array to clear the schedule. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScalingSchedulePostRequest scalingSchedulePostRequest = new ScalingSchedulePostRequest
{
    Entries = new List<ScalingScheduleEntryRequest>
    {
        new ScalingScheduleEntryRequest
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
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

