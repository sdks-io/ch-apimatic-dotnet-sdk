
# Click Stack Markdown Chart Series

*This model accepts additional fields of type object.*

## Structure

`ClickStackMarkdownChartSeries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Series type discriminator. Must be "markdown" for markdown text widgets.<br><br>**Value**: `"markdown"` |
| `Content` | `string` | Required | Markdown content to render inside the widget. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackMarkdownChartSeries clickStackMarkdownChartSeries = new ClickStackMarkdownChartSeries
{
    Type = "markdown",
    Content = "# Dashboard Title\n\nThis is a markdown widget.",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

