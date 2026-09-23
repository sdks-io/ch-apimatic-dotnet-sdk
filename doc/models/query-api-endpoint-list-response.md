
# Query Api Endpoint List Response

## Structure

`QueryApiEndpointListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<PublicQueryApiEndpointListItem>`](../../doc/models/public-query-api-endpoint-list-item.md) | Required | Active Query API endpoints for the service, including both owner types. |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;

QueryApiEndpointListResponse queryApiEndpointListResponse = new QueryApiEndpointListResponse
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
};
```

