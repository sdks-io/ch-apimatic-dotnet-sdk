using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfArgument
{
    /// <summary>
    /// Name of the argument. Required for Native and JSONEachRow formats.
    /// </summary>
    [JsonPropertyName("name")]
    [RegularExpression("^[A-Za-z][A-Za-z0-9_]*$")]
    public required string Name { get; init; }

    /// <summary>
    /// ClickHouse data type of the argument.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
