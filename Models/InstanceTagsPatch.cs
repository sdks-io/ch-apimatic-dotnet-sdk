using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record InstanceTagsPatch
{
    /// <summary>
    /// Elements to add. Executed after "remove" part is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    [MaxLength(50)]
    public IReadOnlyList<ResourceTagsV1>? Add { get; init; }

    /// <summary>
    /// Elements to remove. Executed before "add" part is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remove")]
    [MaxLength(50)]
    public IReadOnlyList<ResourceTagsV1>? Remove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
