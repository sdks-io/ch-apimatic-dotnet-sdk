
# Click Stack Number Raw Sql Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackNumberRawSqlChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConfigType` | `string` | Required, Constant | Must be "sql" to use the Raw SQL chart config variant.<br><br>**Value**: `"sql"` |
| `ConnectionId` | `string` | Required | ID of the ClickHouse connection to execute the query against. |
| `SqlTemplate` | `string` | Required | SQL query template to execute. Supports HyperDX template variables. |
| `SourceId` | `string` | Optional | Optional ID of the data source associated with this Raw SQL chart. Used for applying dashboard filters. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `DisplayType` | `string` | Required, Constant | Display as a single big-number chart.<br><br>**Value**: `"number"` |
| `Color` | [`Color5?`](../../doc/models/color-5.md) | Optional | Optional static color applied to the displayed number. Raw SQL number tiles do not support conditional colorRules. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackNumberRawSqlChartConfig clickStackNumberRawSqlChartConfig = new ClickStackNumberRawSqlChartConfig
{
    ConfigType = "sql",
    ConnectionId = "65f5e4a3b9e77c001a567890",
    SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
    DisplayType = "number",
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
    Color = Color5.Chartblue,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

