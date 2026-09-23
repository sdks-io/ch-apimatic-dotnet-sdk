
# Click Stack Alert Silenced

*This model accepts additional fields of type object.*

## Structure

`ClickStackAlertSilenced`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `By` | `string` | Optional | User ID who silenced the alert. |
| `At` | `DateTime?` | Optional | Silence start timestamp. |
| `Until` | `DateTime?` | Optional | Silence end timestamp. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackAlertSilenced clickStackAlertSilenced = new ClickStackAlertSilenced
{
    By = "65f5e4a3b9e77c001a234567",
    At = DateTime.ParseExact("2026-03-19T08:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Until = DateTime.ParseExact("2026-03-20T08:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

