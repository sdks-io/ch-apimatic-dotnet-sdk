
# Click Stack on Click Target Id Variant

*This model accepts additional fields of type object.*

## Structure

`ClickStackOnClickTargetIdVariant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | `string` | Required, Constant | Target is a single dashboard or log/trace source<br><br>**Value**: `"id"` |
| `Id` | `string` | Required | ID of the target source (for search) or dashboard (for dashboard). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackOnClickTargetIdVariant clickStackOnClickTargetIdVariant = new ClickStackOnClickTargetIdVariant
{
    Mode = "id",
    Id = "65f5e4a3b9e77c001a567890",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

