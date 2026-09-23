
# Click Stack Table Raw Sql Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackTableRawSqlChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConfigType` | `string` | Required, Constant | Must be "sql" to use the Raw SQL chart config variant.<br><br>**Value**: `"sql"` |
| `ConnectionId` | `string` | Required | ID of the ClickHouse connection to execute the query against. |
| `SqlTemplate` | `string` | Required | SQL query template to execute. Supports HyperDX template variables. |
| `SourceId` | `string` | Optional | Optional ID of the data source associated with this Raw SQL chart. Used for applying dashboard filters. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `DisplayType` | `string` | Required, Constant | Display as a table chart.<br><br>**Value**: `"table"` |
| `OnClick` | [`ClickStackOnClick`](../../doc/models/containers/click-stack-on-click.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTableRawSqlChartConfig clickStackTableRawSqlChartConfig = new ClickStackTableRawSqlChartConfig
{
    ConfigType = "sql",
    ConnectionId = "65f5e4a3b9e77c001a567890",
    SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
    DisplayType = "table",
    SourceId = "65f5e4a3b9e77c001a567890",
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    OnClick = ClickStackOnClick.FromClickStackOnClickSearch(
        new ClickStackOnClickSearch
        {
            Type = "type4",
            Target = ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(
                new ClickStackOnClickTargetIdVariant
                {
                    Mode = "mode2",
                    Id = "id0",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                }
            ),
            WhereTemplate = "whereTemplate8",
            WhereLanguage = WhereLanguage5.Sql,
            Filters = new List<ClickStackOnClickFilterTemplate>
            {
                new ClickStackOnClickFilterTemplate
                {
                    Kind = "kind8",
                    Expression = "expression2",
                    Template = "template4",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ClickStackOnClickFilterTemplate
                {
                    Kind = "kind8",
                    Expression = "expression2",
                    Template = "template4",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

