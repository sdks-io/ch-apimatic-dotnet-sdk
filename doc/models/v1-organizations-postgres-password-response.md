
# V1 Organizations Postgres Password Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresPasswordResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresServicePasswordResource`](../../doc/models/postgres-service-password-resource.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsPostgresPasswordResponse v1OrganizationsPostgresPasswordResponse = new V1OrganizationsPostgresPasswordResponse
{
    Status = 200,
    RequestId = new Guid("0000083a-0000-0000-0000-000000000000"),
    Result = new PostgresServicePasswordResource
    {
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

