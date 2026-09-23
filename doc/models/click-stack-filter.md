
# Click Stack Filter

*This model accepts additional fields of type object.*

## Structure

`ClickStackFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Filter type. Must be "QUERY_EXPRESSION".<br><br>**Value**: `"QUERY_EXPRESSION"` |
| `Name` | `string` | Required | Display name for the dashboard filter key |
| `Expression` | `string` | Required | SQL expression used when querying values for this filter, and when applying this dashboard filter to tiles. |
| `SourceId` | `string` | Required | Source ID this dashboard filter key applies to |
| `SourceMetricType` | [`SourceMetricType?`](../../doc/models/source-metric-type.md) | Optional | Metric type when source is metrics |
| `Where` | `string` | Optional | Optional WHERE condition to scope which rows this filter key reads values from |
| `WhereLanguage` | [`WhereLanguage10?`](../../doc/models/where-language-10.md) | Optional | Language of the where condition |
| `AppliesToSourceIds` | `List<string>` | Optional | Optional list of source IDs this filter applies to. Omit or provide an empty array to apply the filter to ALL tiles regardless of source. A non-empty array restricts the filter to only tiles whose source ID is in the list; tiles using other sources are not affected by the selected filter value(s). Scopes the broadcast condition only, so a non-empty array is rejected when isBroadcastEnabled is false, and is omitted from responses for such a filter. |
| `IsBroadcastEnabled` | `bool?` | Optional | Whether the selected value is applied as a filter condition on every builder tile this filter applies to (see appliesToSourceIds), and every raw sql tile using the $__filters macro. Omitting the field means enabled. |
| `IsVariableEnabled` | `bool?` | Optional | Whether the selected value is exposed to tile queries as a dashboard variable named by variableName. Tiles may reference it as `$variableName` or using the (preferred) `$__filter($<variableName>)` and `$__conditionalAll(<condition>, $<variableName>)` macros. |
| `VariableName` | `string` | Optional | Token tiles reference this filter's selected value by, as `$variableName`. Must start with a letter and may contain only letters, numbers, and underscores. Defaults to the display name with whitespace replaced by underscores and remaining illegal characters removed, so a variable-enabled filter whose name derives nothing usable must send this field explicitly. Variable names must be unique across a dashboard's variable-enabled filters. Names the variable only, so the field is rejected when isVariableEnabled is not true, and is omitted from responses for such a filter. |
| `Id` | `string` | Required | Unique dashboard filter key ID |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackFilter clickStackFilter = new ClickStackFilter
{
    Type = "QUERY_EXPRESSION",
    Name = "Environment",
    Expression = "environment",
    SourceId = "65f5e4a3b9e77c001a111111",
    Id = "id4",
    SourceMetricType = SourceMetricType.Gauge,
    MWhere = "ServiceName:api",
    WhereLanguage = WhereLanguage10.Lucene,
    AppliesToSourceIds = new List<string>
    {
        "65f5e4a3b9e77c001a111111",
    },
    IsBroadcastEnabled = false,
    IsVariableEnabled = true,
    VariableName = "environment",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

