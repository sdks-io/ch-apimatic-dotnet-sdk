
# Click Stack Saved Search Input

*This model accepts additional fields of type object.*

## Structure

`ClickStackSavedSearchInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Display name for the saved search. |
| `SourceId` | `string` | Required | ID of the source to query. Must belong to the team. |
| `Select` | `string` | Optional | Comma-separated list of column expressions to display. Empty uses the source default. |
| `Where` | `string` | Optional | Row filter expression. The language is controlled by whereLanguage. |
| `WhereLanguage` | [`WhereLanguage12?`](../../doc/models/where-language-12.md) | Optional | Language used for the where filter. |
| `OrderBy` | `string` | Optional | ORDER BY expression. Empty uses the source default. |
| `Tags` | `List<string>` | Optional | Tags used to organize saved searches. |
| `Filters` | [`List<ClickStackSavedSearchFilter>`](../../doc/models/click-stack-saved-search-filter.md) | Optional | Structured pinned filters applied to the search. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackSavedSearchInput clickStackSavedSearchInput = new ClickStackSavedSearchInput
{
    Name = "Production Errors",
    SourceId = "507f1f77bcf86cd799439012",
    MSelect = "Timestamp, ServiceName, Body",
    MWhere = "SeverityText:ERROR",
    WhereLanguage = WhereLanguage12.Lucene,
    OrderBy = "Timestamp DESC",
    Tags = new List<string>
    {
        "production",
        "errors",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

