
# Click Stack on Click Target Template Variant

*This model accepts additional fields of type object.*

## Structure

`ClickStackOnClickTargetTemplateVariant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | `string` | Required, Constant | Target is matched by name against the template.<br><br>**Value**: `"template"` |
| `Template` | `string` | Required | Name template rendered against the clicked row; supports `{{column}}` variables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackOnClickTargetTemplateVariant clickStackOnClickTargetTemplateVariant = new ClickStackOnClickTargetTemplateVariant
{
    Mode = "template",
    Template = "{{ServiceName}}",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

