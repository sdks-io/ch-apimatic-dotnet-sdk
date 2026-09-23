using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackNumericColorCondition
{
    /// <summary>
    /// Numeric comparison operator.
    /// </summary>
    [JsonPropertyName("operator")]
    public required Operator Operator { get; init; }

    /// <summary>
    /// Numeric bound the displayed value is compared against. Only finite numbers are accepted (Infinity and NaN are rejected).
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    /// <summary>
    /// Color applied when the rule matches.
    /// </summary>
    [JsonPropertyName("color")]
    public required Color1 Color { get; init; }

    /// <summary>
    /// Optional label describing the rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
