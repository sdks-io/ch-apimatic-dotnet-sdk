
# V1 Organizations Services Query Api Endpoints Response 1

## Structure

`V1OrganizationsServicesQueryApiEndpointsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`QueryApiEndpointListResponse`](../../doc/models/query-api-endpoint-list-response.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;

V1OrganizationsServicesQueryApiEndpointsResponse1 v1OrganizationsServicesQueryApiEndpointsResponse1 = new V1OrganizationsServicesQueryApiEndpointsResponse1
{
    Status = 200,
    RequestId = new Guid("00001464-0000-0000-0000-000000000000"),
    Result = new QueryApiEndpointListResponse
    {
        Items = new List<PublicQueryApiEndpointListItem>
        {
            new PublicQueryApiEndpointListItem
            {
                Id = new Guid("00000422-0000-0000-0000-000000000000"),
                Name = "name8",
                Database = "database2",
                ApiKeyIds = new List<Guid>
                {
                    new Guid("00002274-0000-0000-0000-000000000000"),
                    new Guid("00002275-0000-0000-0000-000000000000"),
                },
                Roles = new List<string>
                {
                    "roles8",
                },
                AllowedOrigins = new List<string>
                {
                    "allowedOrigins6",
                },
                Url = "https://queries.clickhouse.cloud/run/00000000-0000-0000-0000-000000000000",
                OwnerType = OwnerType.User,
            },
        },
        Pagination = new Pagination
        {
            TotalRecords = 72,
            CurrentCursor = PaginationCurrentCursor.FromString("String5"),
            NextCursor = PaginationNextCursor.FromString("String1"),
            Limit = 80,
        },
    },
};
```

