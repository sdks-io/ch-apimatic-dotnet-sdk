
# V1 Organizations Services Private Endpoint Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesPrivateEndpointResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`InstancePrivateEndpoint`](../../doc/models/instance-private-endpoint.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesPrivateEndpointResponse v1OrganizationsServicesPrivateEndpointResponse = new V1OrganizationsServicesPrivateEndpointResponse
{
    Status = 200,
    RequestId = new Guid("000008d6-0000-0000-0000-000000000000"),
    Result = new InstancePrivateEndpoint
    {
        Id = "id6",
        Description = "description6",
        CloudProvider = CloudProvider1.Azure,
        Region = Region1.Apsoutheast2,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

