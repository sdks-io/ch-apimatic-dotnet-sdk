
# Public Query Api Endpoint Request

*This model accepts additional fields of type object.*

## Structure

`PublicQueryApiEndpointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the Query API endpoint.<br><br>**Constraints**: *Minimum Length*: `1`, *Pattern*: `\S` |
| `Sql` | `string` | Required | SQL executed by the endpoint.<br><br>**Constraints**: *Maximum Length*: `4194304`, *Pattern*: `\S` |
| `Database` | `string` | Required | Database used by the Query API endpoint.<br><br>**Constraints**: *Pattern*: `\S` |
| `Parameters` | `Dictionary<string, string>` | Optional | Default query parameters. |
| `ApiKeyIds` | `List<Guid>` | Required | API key IDs allowed to call the endpoint.<br><br>**Constraints**: *Minimum Items*: `1` |
| `Roles` | `List<string>` | Required | Database roles used by the endpoint.<br><br>**Constraints**: *Minimum Items*: `1`, *Minimum Length*: `1` |
| `AllowedOrigins` | `List<string>` | Optional | Origins allowed by the endpoint CORS policy. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PublicQueryApiEndpointRequest publicQueryApiEndpointRequest = new PublicQueryApiEndpointRequest
{
    Name = "name2",
    Sql = "sql0",
    Database = "database2",
    ApiKeyIds = new List<Guid>
    {
        new Guid("0000147c-0000-0000-0000-000000000000"),
        new Guid("0000147b-0000-0000-0000-000000000000"),
    },
    Roles = new List<string>
    {
        "roles6",
    },
    Parameters = new Dictionary<string, string>
    {
        ["key0"] = "parameters8",
        ["key1"] = "parameters9",
    },
    AllowedOrigins = new List<string>
    {
        "allowedOrigins4",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

