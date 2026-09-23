
# Click Stack Event Patterns Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackEventPatternsChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "event_patterns" for pattern mining tiles.<br><br>**Value**: `"event_patterns"` |
| `SourceId` | `string` | Required | ID of the data source to mine patterns from. |
| `Select` | `string` | Optional | Column or expression to mine patterns from. Leave empty to use the source default (Body for logs, SpanName for traces). |
| `Where` | `string` | Optional | Filter condition for the pattern mining query (syntax depends on whereLanguage). |
| `WhereLanguage` | [`WhereLanguage4?`](../../doc/models/where-language-4.md) | Optional | Query language for the where clause. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackEventPatternsChartConfig clickStackEventPatternsChartConfig = new ClickStackEventPatternsChartConfig
{
    DisplayType = "event_patterns",
    SourceId = "65f5e4a3b9e77c001a111111",
    MSelect = "Body",
    MWhere = "level:error",
    WhereLanguage = WhereLanguage4.Sql,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

