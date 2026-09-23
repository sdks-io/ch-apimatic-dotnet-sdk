using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackFilterSettingsColumn
{
    /// <summary>
    /// Column of the source's table that selected filter values are matched against. Also the key the selection is persisted under in links, saved searches, and dashboards.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Display label for the column
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; init; }

    /// <summary>
    /// Optional SQL expression, evaluated against the filter-values table, that produces the available filter options. Use it when the options live in a differently-named column, or must be transformed to match the values stored in the source table. Defaults to reading <c>name</c> as a plain column when omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valueExpression")]
    public string? ValueExpression { get; init; }

    /// <summary>
    /// Whether to offer an "All" option that expands to every available value at query time. Best suited to low-cardinality columns. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
