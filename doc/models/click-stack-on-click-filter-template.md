
# Click Stack on Click Filter Template

*This model accepts additional fields of type object.*

## Structure

`ClickStackOnClickFilterTemplate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required, Constant | Filter template kind. Currently only "expressionTemplate" is supported.<br><br>**Value**: `"expressionTemplate"` |
| `Expression` | `string` | Required | The column/expression to filter the destination by (e.g. "ServiceName"). |
| `Template` | `string` | Required | Value template rendered against the clicked row; supports row column variables in `{{column}}` form (e.g. `{{ServiceName}}`). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackOnClickFilterTemplate clickStackOnClickFilterTemplate = new ClickStackOnClickFilterTemplate
{
    Kind = "expressionTemplate",
    Expression = "ServiceName",
    Template = "{{ServiceName}}",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

