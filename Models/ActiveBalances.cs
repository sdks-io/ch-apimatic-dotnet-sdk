using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ActiveBalances
{
    /// <summary>
    /// Total remaining credits across all active prepaid balances, in ClickHouse Credits (CHCs).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalRemainingPrepaidCredits")]
    public double? TotalRemainingPrepaidCredits { get; init; }

    /// <summary>
    /// List of active prepaid balances for the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepaidBalances")]
    public IReadOnlyList<ActiveBalance>? PrepaidBalances { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
