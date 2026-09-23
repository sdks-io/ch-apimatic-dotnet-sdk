using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSqlSavedFilterValue
{
    /// <summary>
    /// Filter type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type18? Type { get; init; }

    /// <summary>
    /// SQL filter condition. For example use expressions in the form "column IN ('value')".
    /// </summary>
    [JsonPropertyName("condition")]
    public required string Condition { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
