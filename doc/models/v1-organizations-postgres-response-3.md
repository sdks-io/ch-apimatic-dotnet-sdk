
# V1 Organizations Postgres Response 3

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresResponse3`

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

V1OrganizationsPostgresResponse3 v1OrganizationsPostgresResponse3 = new V1OrganizationsPostgresResponse3
{
    Status = 200,
    RequestId = new Guid("0000262e-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

