using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackAlertChannelEmail
{
    /// <summary>
    /// Channel type. Must be "email" for email alerts.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type16 Type { get; init; }

    /// <summary>
    /// Email recipients for email alerts.
    /// </summary>
    [JsonPropertyName("emailRecipients")]
    public required IReadOnlyList<string> EmailRecipients { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
