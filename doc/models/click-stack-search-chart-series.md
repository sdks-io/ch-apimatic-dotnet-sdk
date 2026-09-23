
# Click Stack Search Chart Series

*This model accepts additional fields of type object.*

## Structure

`ClickStackSearchChartSeries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Series type discriminator. Must be "search" for search/log viewer charts.<br><br>**Value**: `"search"` |
| `SourceId` | `string` | Required | ID of the data source to query |
| `Fields` | `List<string>` | Required | List of field names to display in the search results table |
| `Where` | `string` | Required | Filter query for the data (syntax depends on whereLanguage) |
| `WhereLanguage` | [`WhereLanguage`](../../doc/models/where-language.md) | Required | Query language for the where clause |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackSearchChartSeries clickStackSearchChartSeries = new ClickStackSearchChartSeries
{
    Type = "search",
    SourceId = "65f5e4a3b9e77c001a567890",
    Fields = new List<string>
    {
        "timestamp",
        "level",
        "message",
    },
    MWhere = "level:error",
    WhereLanguage = WhereLanguage.Lucene,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

