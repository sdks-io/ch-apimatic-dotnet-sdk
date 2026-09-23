using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackQuerySetting
{
    /// <summary>
    /// ClickHouse setting name
    /// </summary>
    [JsonPropertyName("setting")]
    public required string Setting { get; init; }

    /// <summary>
    /// Setting value
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
