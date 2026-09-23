
# Click Stack Slack Webhook

*This model accepts additional fields of type object.*

## Structure

`ClickStackSlackWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Webhook ID |
| `Name` | `string` | Required | Webhook name |
| `Service` | `string` | Required, Constant | Webhook service type<br><br>**Value**: `"slack"` |
| `Url` | `string` | Optional | Slack incoming webhook URL |
| `Description` | `string` | Optional | Webhook description, shown in the UI |
| `UpdatedAt` | `DateTime` | Required | Last update timestamp |
| `CreatedAt` | `DateTime` | Required | Creation timestamp |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackSlackWebhook clickStackSlackWebhook = new ClickStackSlackWebhook
{
    Id = "507f1f77bcf86cd799439011",
    Name = "Production Alerts",
    Service = "slack",
    UpdatedAt = DateTime.ParseExact("2025-06-15T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Url = "https://hooks.slack.com/services/EXAMPLE/WEBHOOK/URL",
    Description = "Sends critical alerts to the #incidents channel",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

