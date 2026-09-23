using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackBetweenColorCondition
{
    /// <summary>
    /// Range comparison operator.
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; } = "between";

    /// <summary>
    /// Inclusive [min, max] range. Both bounds must be finite numbers.
    /// </summary>
    [JsonPropertyName("value")]
    public required IReadOnlyList<double> Value { get; init; }

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
