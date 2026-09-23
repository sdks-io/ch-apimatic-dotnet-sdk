
# V1 Organizations Postgres State Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresStateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresService`](../../doc/models/postgres-service.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsPostgresStateResponse v1OrganizationsPostgresStateResponse = new V1OrganizationsPostgresStateResponse
{
    Status = 200,
    RequestId = new Guid("00001f76-0000-0000-0000-000000000000"),
    Result = new PostgresService
    {
        Name = "name6",
        Provider = CloudProvider.Aws,
        Region = "region2",
        PostgresVersion = PostgresMajorVersion.Postgres18,
        Size = VmSize.EnumI7Ie6Xlarge,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

