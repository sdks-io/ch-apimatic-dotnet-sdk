
# Click Stack Alert Execution Error

*This model accepts additional fields of type object.*

## Structure

`ClickStackAlertExecutionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime` | Required | When the error occurred. |
| `Type` | [`Type15`](../../doc/models/type-15.md) | Required | Category of the error. |
| `Message` | `string` | Required | Human-readable error message. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackAlertExecutionError clickStackAlertExecutionError = new ClickStackAlertExecutionError
{
    Timestamp = DateTime.ParseExact("2026-04-17T12:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Type = Type15.QueryError,
    Message = "Query timed out after 30s",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

