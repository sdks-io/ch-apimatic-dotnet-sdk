
# Udf Argument

*This model accepts additional fields of type object.*

## Structure

`UdfArgument`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the argument. Required for Native and JSONEachRow formats.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `Type` | `string` | Required | ClickHouse data type of the argument. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

UdfArgument udfArgument = new UdfArgument
{
    Name = "name0",
    Type = "type0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

