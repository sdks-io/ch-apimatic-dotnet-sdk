
# Click Stack Search Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackSearchChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "search" for search/log viewer tiles.<br><br>**Value**: `"search"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | `string` | Required | Comma-separated list of expressions to display. |
| `Where` | `string` | Optional | Filter condition for the search (syntax depends on whereLanguage). |
| `WhereLanguage` | [`WhereLanguage4`](../../doc/models/where-language-4.md) | Required | Query language for the where clause. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackSearchChartConfig clickStackSearchChartConfig = new ClickStackSearchChartConfig
{
    DisplayType = "search",
    SourceId = "65f5e4a3b9e77c001a111111",
    MSelect = "timestamp, level, message",
    WhereLanguage = WhereLanguage4.Sql,
    MWhere = "level:error",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

