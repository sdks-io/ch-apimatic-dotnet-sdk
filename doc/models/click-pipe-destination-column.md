
# Click Pipe Destination Column

*This model accepts additional fields of type object.*

## Structure

`ClickPipeDestinationColumn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the column. |
| `Type` | `string` | Optional | Type of the column. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeDestinationColumn clickPipeDestinationColumn = new ClickPipeDestinationColumn
{
    Name = "name0",
    Type = "type0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

