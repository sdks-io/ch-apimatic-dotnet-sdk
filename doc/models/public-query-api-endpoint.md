
# Public Query Api Endpoint

## Structure

`PublicQueryApiEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | Unique ID of the Query API endpoint. |
| `Name` | `string` | Required | Name of the Query API endpoint. |
| `Sql` | `string` | Required | SQL executed by the endpoint.<br><br>**Constraints**: *Maximum Length*: `4194304` |
| `Database` | `string` | Required | Database used by the Query API endpoint. |
| `Parameters` | `Dictionary<string, string>` | Required | Query parameters. |
| `ApiKeyIds` | `List<Guid>` | Required | API key IDs allowed to call the endpoint. |
| `Roles` | `List<string>` | Required | Database roles used by the endpoint. |
| `AllowedOrigins` | `List<string>` | Required | Origins allowed by the endpoint CORS policy. |
| `Url` | `string` | Required | Public URL used to execute the endpoint. |
| `OwnerType` | [`OwnerType`](../../doc/models/owner-type.md) | Required | Owner type of the Query API endpoint. Endpoints with a user owned query cannot be updated or deleted through this API. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using System.Collections.Generic;

PublicQueryApiEndpoint publicQueryApiEndpoint = new PublicQueryApiEndpoint
{
    Id = new Guid("00001fc8-0000-0000-0000-000000000000"),
    Name = "name6",
    Sql = "sql4",
    Database = "database6",
    Parameters = new Dictionary<string, string>
    {
        ["key0"] = "parameters2",
    },
    ApiKeyIds = new List<Guid>
    {
        new Guid("00002042-0000-0000-0000-000000000000"),
        new Guid("00002041-0000-0000-0000-000000000000"),
        new Guid("00002040-0000-0000-0000-000000000000"),
    },
    Roles = new List<string>
    {
        "roles0",
        "roles9",
    },
    AllowedOrigins = new List<string>
    {
        "allowedOrigins0",
        "allowedOrigins9",
        "allowedOrigins8",
    },
    Url = "https://queries.clickhouse.cloud/run/00000000-0000-0000-0000-000000000000",
    OwnerType = OwnerType.User,
};
```

