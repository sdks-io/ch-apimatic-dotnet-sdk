
# Click Pipe Schema Discovery Field

*This model accepts additional fields of type object.*

## Structure

`ClickPipeSchemaDiscoveryField`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the inferred field. |
| `Type` | `string` | Optional | Inferred ClickHouse data type of the field. |
| `Optional` | `bool?` | Optional | Whether the field is optional (nullable) in the source. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeSchemaDiscoveryField clickPipeSchemaDiscoveryField = new ClickPipeSchemaDiscoveryField
{
    Name = "user_id",
    Type = "Int64",
    Optional = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

