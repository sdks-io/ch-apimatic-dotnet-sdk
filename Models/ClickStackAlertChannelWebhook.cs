using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackAlertChannelWebhook
{
    /// <summary>
    /// Channel type. Must be "webhook" for webhook alerts.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type17 Type { get; init; }

    /// <summary>
    /// Webhook destination ID.
    /// </summary>
    [JsonPropertyName("webhookId")]
    public required string WebhookId { get; init; }

    /// <summary>
    /// Webhook service type (e.g., slack_api).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhookService")]
    public string? WebhookService { get; init; }

    /// <summary>
    /// Slack channel ID for Slack webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slackChannelId")]
    public string? SlackChannelId { get; init; }

    /// <summary>
    /// Severity label used by PagerDuty API webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public Severity? Severity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
