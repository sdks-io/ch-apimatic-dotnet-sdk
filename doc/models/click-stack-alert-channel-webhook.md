
# Click Stack Alert Channel Webhook

*This model accepts additional fields of type object.*

## Structure

`ClickStackAlertChannelWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type17`](../../doc/models/type-17.md) | Required | Channel type. Must be "webhook" for webhook alerts. |
| `WebhookId` | `string` | Required | Webhook destination ID. |
| `WebhookService` | `string` | Optional | Webhook service type (e.g., slack_api). |
| `SlackChannelId` | `string` | Optional | Slack channel ID for Slack webhooks. |
| `Severity` | [`Severity?`](../../doc/models/severity.md) | Optional | Severity label used by PagerDuty API webhooks. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackAlertChannelWebhook clickStackAlertChannelWebhook = new ClickStackAlertChannelWebhook
{
    Type = Type17.Webhook,
    WebhookId = "65f5e4a3b9e77c001a789012",
    WebhookService = "slack_api",
    SlackChannelId = "C01ABCDEF23",
    Severity = Severity.Critical,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

