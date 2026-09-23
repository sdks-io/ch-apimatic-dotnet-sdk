
# Postgres Service Password Resource

*This model accepts additional fields of type object.*

## Structure

`PostgresServicePasswordResource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Password` | `string` | Optional | New Postgres superuser password. Provided only if there was no 'password' in the request. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PostgresServicePasswordResource postgresServicePasswordResource = new PostgresServicePasswordResource
{
    Password = "password8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

