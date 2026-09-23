
# V1 Organizations Services State Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesStateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`Service`](../../doc/models/service.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesStateResponse v1OrganizationsServicesStateResponse = new V1OrganizationsServicesStateResponse
{
    Status = 200,
    RequestId = new Guid("0000003a-0000-0000-0000-000000000000"),
    Result = new Service
    {
        AutoscalingMode = AutoscalingMode3.Vertical,
        CurrentScaling = new CurrentScaling
        {
            EffectiveAutoscalingMode = EffectiveAutoscalingMode.Vertical,
            EffectiveMinReplicaMemoryGb = 39.2,
            EffectiveMaxReplicaMemoryGb = 21.08,
            EffectiveMinReplicas = 124,
            EffectiveMaxReplicas = 40,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Id = new Guid("000002b8-0000-0000-0000-000000000000"),
        Name = "name6",
        Provider = Provider.Azure,
        Region = Region.Apsoutheast2,
        State = State.Provisioning,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

