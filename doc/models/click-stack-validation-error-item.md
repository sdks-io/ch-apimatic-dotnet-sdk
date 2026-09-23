
# Click Stack Validation Error Item

*This model accepts additional fields of type object.*

## Structure

`ClickStackValidationErrorItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Request part that failed validation. |
| `Errors` | `object` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackValidationErrorItem clickStackValidationErrorItem = new ClickStackValidationErrorItem
{
    Type = "Body",
    Errors = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

