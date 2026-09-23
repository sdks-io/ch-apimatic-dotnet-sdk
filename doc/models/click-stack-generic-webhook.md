
# Click Stack Generic Webhook

*This model accepts additional fields of type object.*

## Structure

`ClickStackGenericWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Webhook ID |
| `Name` | `string` | Required | Webhook name |
| `Service` | `string` | Required, Constant | Webhook service type<br><br>**Value**: `"generic"` |
| `Url` | `string` | Optional | Webhook destination URL |
| `Description` | `string` | Optional | Webhook description, shown in the UI |
| `Body` | `string` | Optional | Optional request body template |
| `UpdatedAt` | `DateTime` | Required | Last update timestamp |
| `CreatedAt` | `DateTime` | Required | Creation timestamp |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackGenericWebhook clickStackGenericWebhook = new ClickStackGenericWebhook
{
    Id = "507f1f77bcf86cd799439013",
    Name = "PagerDuty Integration",
    Service = "generic",
    UpdatedAt = DateTime.ParseExact("2025-06-15T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Url = "https://example.com/webhooks/alerts",
    Description = "Forwards alert payloads to an external monitoring service",
    Body = "{\"alert\": \"{{title}}\", \"severity\": \"{{level}}\"}",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

