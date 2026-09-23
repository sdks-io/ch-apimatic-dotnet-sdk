
# V1 Organizations Services Service Query Endpoint Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesServiceQueryEndpointResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesServiceQueryEndpointResponse1 v1OrganizationsServicesServiceQueryEndpointResponse1 = new V1OrganizationsServicesServiceQueryEndpointResponse1
{
    Status = 200,
    RequestId = new Guid("000019a0-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

