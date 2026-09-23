
# Postgres Service Set Password

*This model accepts additional fields of type object.*

## Structure

`PostgresServiceSetPassword`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Password` | `string` | Optional | Optional password. If not provided a new password is generated and provided in the response. Must contain:<br><br>* At least one lowercase letter<br>* At least one uppercase letter<br>* At least one digit<br><br>**Constraints**: *Pattern*: `[a-z]` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PostgresServiceSetPassword postgresServiceSetPassword = new PostgresServiceSetPassword
{
    Password = "password4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

