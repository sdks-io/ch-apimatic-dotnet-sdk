using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record IpAccessListPatch
{
    /// <summary>
    /// Elements to add. Executed after "remove" part is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    public IReadOnlyList<IpAccessListEntry>? Add { get; init; }

    /// <summary>
    /// Elements to remove. Executed before "add" part is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remove")]
    public IReadOnlyList<IpAccessListEntry>? Remove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
