
# V1 Organizations Services Clickpipes Click Pipe Id Scaling Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesClickPipeIdScalingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickPipe`](../../doc/models/click-pipe.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickpipesClickPipeIdScalingResponse v1OrganizationsServicesClickpipesClickPipeIdScalingResponse = new V1OrganizationsServicesClickpipesClickPipeIdScalingResponse
{
    Status = 200,
    RequestId = new Guid("0000237a-0000-0000-0000-000000000000"),
    Result = new ClickPipe
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

