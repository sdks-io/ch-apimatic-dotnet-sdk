
# Click Stack on Click External

*This model accepts additional fields of type object.*

## Structure

`ClickStackOnClickExternal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | OnClick variant discriminator. Must be "external" for external link-outs.<br><br>**Value**: `"external"` |
| `UrlTemplate` | `string` | Required | Handlebars template rendered against the clicked row; supports `{{column}}` variables. The rendered value must be an absolute http(s) URL. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackOnClickExternal clickStackOnClickExternal = new ClickStackOnClickExternal
{
    Type = "external",
    UrlTemplate = "https://example.com/d/abc?var-service={{ServiceName}}",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

