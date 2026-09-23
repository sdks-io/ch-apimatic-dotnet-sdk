
# Click Stack Number Format

*This model accepts additional fields of type object.*

## Structure

`ClickStackNumberFormat`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Output` | [`Output?`](../../doc/models/output.md) | Optional | Output format applied to the number. |
| `Mantissa` | `int?` | Optional | Number of decimal places. |
| `ThousandSeparated` | `bool?` | Optional | Whether to use thousand separators. |
| `Average` | `bool?` | Optional | Whether to show as average. |
| `DecimalBytes` | `bool?` | Optional | Use decimal bytes (1000) vs binary bytes (1024). |
| `Factor` | `double?` | Optional | Multiplication factor. |
| `CurrencySymbol` | `string` | Optional | Currency symbol for currency format. |
| `NumericUnit` | [`NumericUnit?`](../../doc/models/numeric-unit.md) | Optional | Numeric unit for data, data rate, or throughput formats. |
| `Unit` | `string` | Optional | Custom unit label. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackNumberFormat clickStackNumberFormat = new ClickStackNumberFormat
{
    Output = Output.Number,
    Mantissa = 2,
    ThousandSeparated = true,
    Average = false,
    DecimalBytes = false,
    Factor = 1,
    CurrencySymbol = "$",
    NumericUnit = NumericUnit.BytesIec,
    Unit = "ms",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

