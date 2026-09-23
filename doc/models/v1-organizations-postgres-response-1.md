
# V1 Organizations Postgres Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<PostgresServiceListItem>`](../../doc/models/postgres-service-list-item.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsPostgresResponse1 v1OrganizationsPostgresResponse1 = new V1OrganizationsPostgresResponse1
{
    Status = 200,
    RequestId = new Guid("00002118-0000-0000-0000-000000000000"),
    Result = new List<PostgresServiceListItem>
    {
        new PostgresServiceListItem
        {
            Name = "name6",
            Provider = CloudProvider.Aws,
            Region = "region2",
            PostgresVersion = PostgresMajorVersion.Postgres18,
            Size = VmSize.EnumI7Ie6Xlarge,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

