
# V1 Organizations Services Password Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesPasswordResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServicePasswordPatchResponse`](../../doc/models/service-password-patch-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesPasswordResponse v1OrganizationsServicesPasswordResponse = new V1OrganizationsServicesPasswordResponse
{
    Status = 200,
    RequestId = new Guid("00001434-0000-0000-0000-000000000000"),
    Result = new ServicePasswordPatchResponse
    {
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

