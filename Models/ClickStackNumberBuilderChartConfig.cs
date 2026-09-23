using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackNumberBuilderChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "number" for single big-number charts.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "number";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Exactly one aggregated value to display as a single number — unless "formulas" is set, in which case the select items are the formula's operands and the (single) formula value is displayed instead.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackSelectItem> Select { get; init; }

    /// <summary>
    /// A single derived value computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Number tiles display the formula value and always hide the operand series.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formulas")]
    public IReadOnlyList<ClickStackFormula>? Formulas { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Optional static color applied to the displayed number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public Color4? Color { get; init; }

    /// <summary>
    /// Ordered conditional color rules evaluated against the displayed value (last match wins). Falls back to color, then the default text color when no rule matches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("colorRules")]
    public IReadOnlyList<ClickStackNumberTileColorCondition>? ColorRules { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backgroundChart")]
    public ClickStackBackgroundChart? BackgroundChart { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
