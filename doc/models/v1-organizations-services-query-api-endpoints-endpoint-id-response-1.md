
# V1 Organizations Services Query Api Endpoints Endpoint Id Response 1

## Structure

`V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PublicQueryApiEndpoint`](../../doc/models/public-query-api-endpoint.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using System.Collections.Generic;

V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1 v1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1 = new V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1
{
    Status = 200,
    RequestId = new Guid("00002334-0000-0000-0000-000000000000"),
    Result = new PublicQueryApiEndpoint
    {
        Id = new Guid("000002b8-0000-0000-0000-000000000000"),
        Name = "name6",
        Sql = "sql4",
        Database = "database6",
        Parameters = new Dictionary<string, string>
        {
            ["key0"] = "parameters2",
            ["key1"] = "parameters3",
            ["key2"] = "parameters4",
        },
        ApiKeyIds = new List<Guid>
        {
            new Guid("00000332-0000-0000-0000-000000000000"),
        },
        Roles = new List<string>
        {
            "roles0",
            "roles9",
            "roles8",
        },
        AllowedOrigins = new List<string>
        {
            "allowedOrigins0",
            "allowedOrigins1",
        },
        Url = "https://queries.clickhouse.cloud/run/00000000-0000-0000-0000-000000000000",
        OwnerType = OwnerType.User,
    },
};
```

