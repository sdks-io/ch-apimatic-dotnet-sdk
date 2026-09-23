
# Click Stack Number Builder Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackNumberBuilderChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "number" for single big-number charts.<br><br>**Value**: `"number"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | [`List<ClickStackSelectItem>`](../../doc/models/click-stack-select-item.md) | Required | Exactly one aggregated value to display as a single number — unless "formulas" is set, in which case the select items are the formula's operands and the (single) formula value is displayed instead. |
| `Formulas` | [`List<ClickStackFormula>`](../../doc/models/click-stack-formula.md) | Optional | A single derived value computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Number tiles display the formula value and always hide the operand series. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `Color` | [`Color4?`](../../doc/models/color-4.md) | Optional | Optional static color applied to the displayed number. |
| `ColorRules` | [`List<ClickStackNumberTileColorCondition>`](../../doc/models/containers/click-stack-number-tile-color-condition.md) | Optional | Ordered conditional color rules evaluated against the displayed value (last match wins). Falls back to color, then the default text color when no rule matches. |
| `BackgroundChart` | [`ClickStackBackgroundChart`](../../doc/models/click-stack-background-chart.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackNumberBuilderChartConfig clickStackNumberBuilderChartConfig = new ClickStackNumberBuilderChartConfig
{
    DisplayType = "number",
    SourceId = "65f5e4a3b9e77c001a111111",
    MSelect = new List<ClickStackSelectItem>
    {
        new ClickStackSelectItem
        {
            AggFn = AggFn3.Count,
            ValueExpression = "Duration",
            MAlias = "Request Duration",
            Level = Level.P50,
            MWhere = "service:api",
            WhereLanguage = WhereLanguage4.Sql,
            MetricName = "http.server.duration",
            PeriodAggFn = PeriodAggFn.Delta,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Formulas = new List<ClickStackFormula>
    {
        new ClickStackFormula
        {
            Expression = "expression2",
            MAlias = "alias2",
            NumberFormat = new ClickStackNumberFormat
            {
                Output = Output.Currency,
                Mantissa = 170,
                ThousandSeparated = false,
                Average = false,
                DecimalBytes = false,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackFormula
        {
            Expression = "expression2",
            MAlias = "alias2",
            NumberFormat = new ClickStackNumberFormat
            {
                Output = Output.Currency,
                Mantissa = 170,
                ThousandSeparated = false,
                Average = false,
                DecimalBytes = false,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Color = Color4.Chartorange,
    ColorRules = new List<ClickStackNumberTileColorCondition>
    {
        ClickStackNumberTileColorCondition.FromClickStackNumericColorCondition(
            new ClickStackNumericColorCondition
            {
                MOperator = Operator.Gt,
                MValue = 38.3,
                Color = Color1.Chartgreen,
                Label = "label8",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            }
        ),
        ClickStackNumberTileColorCondition.FromClickStackNumericColorCondition(
            new ClickStackNumericColorCondition
            {
                MOperator = Operator.Gt,
                MValue = 38.3,
                Color = Color1.Chartgreen,
                Label = "label8",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            }
        ),
    },
    BackgroundChart = new ClickStackBackgroundChart
    {
        Type = Type19.Line,
        Color = Color.Charterror,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

