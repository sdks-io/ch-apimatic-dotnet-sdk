using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record CreditBalances
{
    /// <summary>
    /// Total remaining credits across all active balances, in ClickHouse Credits (CHCs).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalRemainingCredits")]
    public double? TotalRemainingCredits { get; init; }

    /// <summary>
    /// List of active balances for the organization. Empty when the organization has none.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balances")]
    public IReadOnlyList<CreditBalance>? Balances { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
