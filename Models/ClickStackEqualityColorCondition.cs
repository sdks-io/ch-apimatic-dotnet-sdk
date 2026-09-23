using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackEqualityColorCondition
{
    /// <summary>
    /// Equality comparison operator.
    /// </summary>
    [JsonPropertyName("operator")]
    public required Operator1 Operator { get; init; }

    /// <summary>
    /// A finite number, or a string up to 200 characters, to compare for equality.
    /// </summary>
    [JsonPropertyName("value")]
    public required Value Value { get; init; }

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
