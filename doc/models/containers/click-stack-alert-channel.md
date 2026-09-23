
# Click Stack Alert Channel

## Class Name

`ClickStackAlertChannel`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackAlertChannelEmail`](../../../doc/models/click-stack-alert-channel-email.md) | ClickStackAlertChannel.FromClickStackAlertChannelEmail(ClickStackAlertChannelEmail clickStackAlertChannelEmail) |
| [`ClickStackAlertChannelWebhook`](../../../doc/models/click-stack-alert-channel-webhook.md) | ClickStackAlertChannel.FromClickStackAlertChannelWebhook(ClickStackAlertChannelWebhook clickStackAlertChannelWebhook) |

## ClickStackAlertChannelEmail

### Initialization Code

#### Example

```csharp
ClickStackAlertChannel value = ClickStackAlertChannel.FromClickStackAlertChannelEmail(
    new ClickStackAlertChannelEmail
    {
        Type = Type16.Webhook,
        EmailRecipients = new List<string>
        {
            "emailRecipients1",
            "emailRecipients2",
            "emailRecipients3",
        },
    }
);
```

## ClickStackAlertChannelWebhook

### Initialization Code

#### Example

```csharp
ClickStackAlertChannel value = ClickStackAlertChannel.FromClickStackAlertChannelWebhook(
    new ClickStackAlertChannelWebhook
    {
        Type = Type17.Webhook,
        WebhookId = "65f5e4a3b9e77c001a789012",
        WebhookService = "slack_api",
        SlackChannelId = "C01ABCDEF23",
    }
);
```

