using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSavedSearchFilter
{
    /// <summary>
    /// Always <c>sql</c>. Only SQL predicate filters render in the sidebar.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type20? Type { get; init; }

    /// <summary>
    /// SQL predicate applied to the search, in <c>&lt;column&gt; IN (...)</c> form.
    /// </summary>
    [JsonPropertyName("condition")]
    public required string Condition { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
