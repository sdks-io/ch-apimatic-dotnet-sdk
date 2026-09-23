using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackOnClickFilterTemplate
{
    /// <summary>
    /// Filter template kind. Currently only "expressionTemplate" is supported.
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; } = "expressionTemplate";

    /// <summary>
    /// The column/expression to filter the destination by (e.g. "ServiceName").
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; init; }

    /// <summary>
    /// Value template rendered against the clicked row; supports row column variables in <c>{{column}}</c> form (e.g. <c>{{ServiceName}}</c>).
    /// </summary>
    [JsonPropertyName("template")]
    public required string Template { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
