
# Plain

*This model accepts additional fields of type object.*

## Structure

`Plain`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Optional | Database username. |
| `Password` | `string` | Optional | Database password. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

Plain plain = new Plain
{
    Username = "postgres_user",
    Password = "your_secure_password",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

