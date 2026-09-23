
# Public Query Api Endpoint List Item

## Structure

`PublicQueryApiEndpointListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of the Query API endpoint. |
| `Name` | `string` | Required | Name of the Query API endpoint. |
| `Database` | `string` | Required | Database used by the Query API endpoint. |
| `ApiKeyIds` | `List<Guid>` | Required | API key IDs allowed to call the endpoint. |
| `Roles` | `List<string>` | Required | Database roles used by the endpoint. |
| `AllowedOrigins` | `List<string>` | Required | Origins allowed by the endpoint CORS policy. |
| `Url` | `string` | Required | Public URL used to execute the endpoint. |
| `OwnerType` | [`OwnerType`](../../doc/models/owner-type.md) | Required | Owner type of the Query API endpoint. Endpoints with a user owned query cannot be updated or deleted through this API. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using System.Collections.Generic;

PublicQueryApiEndpointListItem publicQueryApiEndpointListItem = new PublicQueryApiEndpointListItem
{
    Id = new Guid("00000f66-0000-0000-0000-000000000000"),
    Name = "name2",
    Database = "database8",
    ApiKeyIds = new List<Guid>
    {
        new Guid("00001730-0000-0000-0000-000000000000"),
        new Guid("00001731-0000-0000-0000-000000000000"),
    },
    Roles = new List<string>
    {
        "roles4",
    },
    AllowedOrigins = new List<string>
    {
        "allowedOrigins0",
    },
    Url = "https://queries.clickhouse.cloud/run/00000000-0000-0000-0000-000000000000",
    OwnerType = OwnerType.User,
};
```

