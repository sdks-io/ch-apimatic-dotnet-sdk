
# Click Stack Saved Search

*This model accepts additional fields of type object.*

## Structure

`ClickStackSavedSearch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique saved search ID. Server-generated. |
| `Name` | `string` | Required | Display name for the saved search. |
| `SourceId` | `string` | Required | ID of the source this saved search queries. |
| `Select` | `string` | Optional | Comma-separated list of column expressions to display. Empty uses the source default. |
| `Where` | `string` | Optional | Row filter expression. The language is controlled by whereLanguage. |
| `WhereLanguage` | [`WhereLanguage12?`](../../doc/models/where-language-12.md) | Optional | Language used for the where filter. |
| `OrderBy` | `string` | Optional | ORDER BY expression. Empty uses the source default. |
| `Tags` | `List<string>` | Optional | Tags used to organize saved searches. |
| `Filters` | [`List<ClickStackSavedSearchFilter>`](../../doc/models/click-stack-saved-search-filter.md) | Optional | Structured pinned filters applied to the search. |
| `TeamId` | `string` | Optional | ID of the team that owns the saved search. |
| `CreatedAt` | `DateTime?` | Optional | Creation timestamp. |
| `UpdatedAt` | `DateTime?` | Optional | Last update timestamp. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ClickStackSavedSearch clickStackSavedSearch = new ClickStackSavedSearch
{
    Id = "507f1f77bcf86cd799439011",
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
    TeamId = "507f1f77bcf86cd799439013",
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("2025-06-15T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

