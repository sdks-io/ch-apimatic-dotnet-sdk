using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackVariableSavedFilterValue
{
    /// <summary>
    /// Filter type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "variable";

    /// <summary>
    /// The variableName of the dashboard variable this selection belongs to. Only allowed for variable-enabled filters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Selected values
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyList<string> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
