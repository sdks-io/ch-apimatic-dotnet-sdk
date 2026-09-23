
# Click Stack Markdown Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackMarkdownChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "markdown" for markdown text tiles.<br><br>**Value**: `"markdown"` |
| `Markdown` | `string` | Optional | Markdown content to render inside the tile. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackMarkdownChartConfig clickStackMarkdownChartConfig = new ClickStackMarkdownChartConfig
{
    DisplayType = "markdown",
    Markdown = "# Dashboard Title\n\nThis is a markdown widget.",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

