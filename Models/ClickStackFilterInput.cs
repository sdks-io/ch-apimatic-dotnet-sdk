using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackFilterInput
{
    /// <summary>
    /// Filter type. Must be "QUERY_EXPRESSION".
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "QUERY_EXPRESSION";

    /// <summary>
    /// Display name for the dashboard filter key
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// SQL expression used when querying values for this filter, and when applying this dashboard filter to tiles.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; init; }

    /// <summary>
    /// Source ID this dashboard filter key applies to
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Metric type when source is metrics
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceMetricType")]
    public SourceMetricType? SourceMetricType { get; init; }

    /// <summary>
    /// Optional WHERE condition to scope which rows this filter key reads values from
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("where")]
    public string? Where { get; init; }

    /// <summary>
    /// Language of the where condition
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereLanguage")]
    public WhereLanguage10? WhereLanguage { get; init; }

    /// <summary>
    /// Optional list of source IDs this filter applies to. Omit or provide an empty array to apply the filter to ALL tiles regardless of source. A non-empty array restricts the filter to only tiles whose source ID is in the list; tiles using other sources are not affected by the selected filter value(s). Scopes the broadcast condition only, so a non-empty array is rejected when isBroadcastEnabled is false, and is omitted from responses for such a filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appliesToSourceIds")]
    public IReadOnlyList<string>? AppliesToSourceIds { get; init; }

    /// <summary>
    /// Whether the selected value is applied as a filter condition on every builder tile this filter applies to (see appliesToSourceIds), and every raw sql tile using the $__filters macro. Omitting the field means enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isBroadcastEnabled")]
    public bool? IsBroadcastEnabled { get; init; }

    /// <summary>
    /// Whether the selected value is exposed to tile queries as a dashboard variable named by variableName. Tiles may reference it as <c>$variableName</c> or using the (preferred) <c>$__filter($&lt;variableName&gt;)</c> and <c>$__conditionalAll(&lt;condition&gt;, $&lt;variableName&gt;)</c> macros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isVariableEnabled")]
    public bool? IsVariableEnabled { get; init; }

    /// <summary>
    /// Token tiles reference this filter's selected value by, as <c>$variableName</c>. Must start with a letter and may contain only letters, numbers, and underscores. Defaults to the display name with whitespace replaced by underscores and remaining illegal characters removed, so a variable-enabled filter whose name derives nothing usable must send this field explicitly. Variable names must be unique across a dashboard's variable-enabled filters. Names the variable only, so the field is rejected when isVariableEnabled is not true, and is omitted from responses for such a filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variableName")]
    public string? VariableName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
