
# Click Stack Formula

*This model accepts additional fields of type object.*

## Structure

`ClickStackFormula`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Expression` | `string` | Required | Arithmetic expression over the select items by position, e.g. "A / (A + B) * 100" for a success-rate percentage. |
| `Alias` | `string` | Optional | Display label for the formula series in chart legends and column headers. Falls back to the raw expression text when unset. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackFormula clickStackFormula = new ClickStackFormula
{
    Expression = "A / (A + B) * 100",
    MAlias = "Success rate %",
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
};
```

