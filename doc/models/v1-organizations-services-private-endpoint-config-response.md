
# V1 Organizations Services Private Endpoint Config Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesPrivateEndpointConfigResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PrivateEndpointConfig`](../../doc/models/private-endpoint-config.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesPrivateEndpointConfigResponse v1OrganizationsServicesPrivateEndpointConfigResponse = new V1OrganizationsServicesPrivateEndpointConfigResponse
{
    Status = 200,
    RequestId = new Guid("00001490-0000-0000-0000-000000000000"),
    Result = new PrivateEndpointConfig
    {
        EndpointServiceId = "endpointServiceId4",
        PrivateDnsHostname = "privateDnsHostname2",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

