using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ResourceTagsV1
{
    /// <summary>
    /// Tag key. Must be alphanumeric with dashes, underscores and dots.
    /// </summary>
    [JsonPropertyName("key")]
    [StringLength(128, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9._-]+$")]
    public required string Key { get; init; }

    /// <summary>
    /// Tag value. Must be alphanumeric with dashes, underscores and dots.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(256)]
    [RegularExpression("^[a-zA-Z0-9._-]+$")]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
