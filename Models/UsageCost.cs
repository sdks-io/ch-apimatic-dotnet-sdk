using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UsageCost
{
    /// <summary>
    /// Grand total cost of usage in ClickHouse Credits (CHCs).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grandTotalCHC")]
    public double? GrandTotalChc { get; init; }

    /// <summary>
    /// List of daily, per-entity usage cost records.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costs")]
    public IReadOnlyList<UsageCostRecord>? Costs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
