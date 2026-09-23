
# Click Stack Webhook

## Class Name

`ClickStackWebhook`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackSlackWebhook`](../../../doc/models/click-stack-slack-webhook.md) | ClickStackWebhook.FromClickStackSlackWebhook(ClickStackSlackWebhook clickStackSlackWebhook) |
| [`ClickStackIncidentIoWebhook`](../../../doc/models/click-stack-incident-io-webhook.md) | ClickStackWebhook.FromClickStackIncidentIOWebhook(ClickStackIncidentIoWebhook clickStackIncidentIoWebhook) |
| [`ClickStackGenericWebhook`](../../../doc/models/click-stack-generic-webhook.md) | ClickStackWebhook.FromClickStackGenericWebhook(ClickStackGenericWebhook clickStackGenericWebhook) |
| [`ClickStackSlackApiWebhook`](../../../doc/models/click-stack-slack-api-webhook.md) | ClickStackWebhook.FromClickStackSlackAPIWebhook(ClickStackSlackApiWebhook clickStackSlackApiWebhook) |
| [`ClickStackPagerDutyApiWebhook`](../../../doc/models/click-stack-pager-duty-api-webhook.md) | ClickStackWebhook.FromClickStackPagerDutyAPIWebhook(ClickStackPagerDutyApiWebhook clickStackPagerDutyApiWebhook) |

## ClickStackSlackWebhook

### Initialization Code

#### Example

```csharp
ClickStackWebhook value = ClickStackWebhook.FromClickStackSlackWebhook(
    new ClickStackSlackWebhook
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
    }
);
```

## ClickStackIncidentIoWebhook

### Initialization Code

#### Example

```csharp
ClickStackWebhook value = ClickStackWebhook.FromClickStackIncidentIOWebhook(
    new ClickStackIncidentIoWebhook
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
    }
);
```

## ClickStackGenericWebhook

### Initialization Code

#### Example

```csharp
ClickStackWebhook value = ClickStackWebhook.FromClickStackGenericWebhook(
    new ClickStackGenericWebhook
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
    }
);
```

## ClickStackSlackApiWebhook

### Initialization Code

#### Example

```csharp
ClickStackWebhook value = ClickStackWebhook.FromClickStackSlackAPIWebhook(
    new ClickStackSlackApiWebhook
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
    }
);
```

## ClickStackPagerDutyApiWebhook

### Initialization Code

#### Example

```csharp
ClickStackWebhook value = ClickStackWebhook.FromClickStackPagerDutyAPIWebhook(
    new ClickStackPagerDutyApiWebhook
    {
        Id = "65f5e4a3b9e77c001a789013",
        Name = "PagerDuty Alerts",
        Service = "pagerduty_api",
        UpdatedAt = DateTime.ParseExact("2025-01-15T12:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Url = "https://events.pagerduty.com/v2/enqueue",
        Description = "Sends critical alerts to PagerDuty",
    }
);
```

