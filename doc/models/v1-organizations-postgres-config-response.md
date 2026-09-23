
# V1 Organizations Postgres Config Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresConfigResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresInstanceConfig`](../../doc/models/postgres-instance-config.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsPostgresConfigResponse v1OrganizationsPostgresConfigResponse = new V1OrganizationsPostgresConfigResponse
{
    Status = 200,
    RequestId = new Guid("00001f5c-0000-0000-0000-000000000000"),
    Result = new PostgresInstanceConfig
    {
        PgConfig = null,
        PgBouncerConfig = new Dictionary<string, string>
        {
            ["key0"] = "pgBouncerConfig1",
            ["key1"] = "pgBouncerConfig0",
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

