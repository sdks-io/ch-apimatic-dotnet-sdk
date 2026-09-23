
# Click Stack Incident Io Webhook

*This model accepts additional fields of type object.*

## Structure

`ClickStackIncidentIoWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Webhook ID |
| `Name` | `string` | Required | Webhook name |
| `Service` | `string` | Required, Constant | Webhook service type<br><br>**Value**: `"incidentio"` |
| `Url` | `string` | Optional | incident.io alert event HTTP source URL |
| `Description` | `string` | Optional | Webhook description, shown in the UI |
| `UpdatedAt` | `DateTime` | Required | Last update timestamp |
| `CreatedAt` | `DateTime` | Required | Creation timestamp |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackIncidentIoWebhook clickStackIncidentIoWebhook = new ClickStackIncidentIoWebhook
{
    Id = "507f1f77bcf86cd799439012",
    Name = "Incident Response",
    Service = "incidentio",
    UpdatedAt = DateTime.ParseExact("2025-06-15T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Url = "https://api.incident.io/v2/alert_events/http/abc123",
    Description = "Routes alerts to incident.io for on-call escalation",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

