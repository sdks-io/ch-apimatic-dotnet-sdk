
# Click Stack Slack Api Webhook

*This model accepts additional fields of type object.*

## Structure

`ClickStackSlackApiWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Webhook ID |
| `Name` | `string` | Required | Webhook name |
| `Service` | `string` | Required, Constant | Webhook service type<br><br>**Value**: `"slack_api"` |
| `Url` | `string` | Optional | Slack API endpoint URL |
| `Description` | `string` | Optional | Webhook description, shown in the UI |
| `UpdatedAt` | `DateTime` | Required | Last update timestamp |
| `CreatedAt` | `DateTime` | Required | Creation timestamp |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackSlackApiWebhook clickStackSlackApiWebhook = new ClickStackSlackApiWebhook
{
    Id = "65f5e4a3b9e77c001a789012",
    Name = "Slack Alerts",
    Service = "slack_api",
    UpdatedAt = DateTime.ParseExact("2025-01-15T12:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Url = "https://hooks.slack.com/services/EXAMPLE/WEBHOOK/URL",
    Description = "Sends alerts to #engineering channel",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

