
# Click Pipe Field Mapping

*This model accepts additional fields of type object.*

## Structure

`ClickPipeFieldMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceField` | `string` | Optional | Source field name. |
| `DestinationField` | `string` | Optional | Destination field name. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeFieldMapping clickPipeFieldMapping = new ClickPipeFieldMapping
{
    SourceField = "sourceField2",
    DestinationField = "destinationField4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

