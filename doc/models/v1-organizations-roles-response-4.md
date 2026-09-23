
# V1 Organizations Roles Response 4

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsRolesResponse4`

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

V1OrganizationsRolesResponse4 v1OrganizationsRolesResponse4 = new V1OrganizationsRolesResponse4
{
    Status = 200,
    RequestId = new Guid("00001732-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

