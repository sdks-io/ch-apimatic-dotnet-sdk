using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackFormula
{
    /// <summary>
    /// Arithmetic expression over the select items by position, e.g. "A / (A + B) * 100" for a success-rate percentage.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; init; }

    /// <summary>
    /// Display label for the formula series in chart legends and column headers. Falls back to the raw expression text when unset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
