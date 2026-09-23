
# V1 Organizations Services Clickpipes Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ClickPipe>`](../../doc/models/click-pipe.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickpipesResponse v1OrganizationsServicesClickpipesResponse = new V1OrganizationsServicesClickpipesResponse
{
    Status = 200,
    RequestId = new Guid("0000213c-0000-0000-0000-000000000000"),
    Result = new List<ClickPipe>
    {
        new ClickPipe
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            ServiceId = new Guid("000011f8-0000-0000-0000-000000000000"),
            Name = "name6",
            State = State2.Pausing,
            Scaling = new ClickPipeScaling
            {
                Replicas = 40,
                Concurrency = 26,
                ReplicaCpuMillicores = 196,
                ReplicaMemoryGb = 8,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

