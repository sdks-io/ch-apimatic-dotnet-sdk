using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackHighlightedAttributeExpression
{
    /// <summary>
    /// SQL expression for the attribute
    /// </summary>
    [JsonPropertyName("sqlExpression")]
    public required string SqlExpression { get; init; }

    /// <summary>
    /// An optional, Lucene version of the sqlExpression expression. If provided, it is used when searching for this attribute value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("luceneExpression")]
    public string? LuceneExpression { get; init; }

    /// <summary>
    /// Optional alias for the attribute
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
