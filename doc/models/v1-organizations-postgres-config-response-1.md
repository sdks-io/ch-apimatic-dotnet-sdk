
# V1 Organizations Postgres Config Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresConfigResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresInstanceUpdateConfigResponse`](../../doc/models/postgres-instance-update-config-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsPostgresConfigResponse1 v1OrganizationsPostgresConfigResponse1 = new V1OrganizationsPostgresConfigResponse1
{
    Status = 200,
    RequestId = new Guid("00001442-0000-0000-0000-000000000000"),
    Result = new PostgresInstanceUpdateConfigResponse
    {
        PgConfig = null,
        PgBouncerConfig = new Dictionary<string, string>
        {
            ["key0"] = "pgBouncerConfig1",
            ["key1"] = "pgBouncerConfig0",
        },
        Message = "message6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

