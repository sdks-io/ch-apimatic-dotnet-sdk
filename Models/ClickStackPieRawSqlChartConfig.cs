using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackPieRawSqlChartConfig
{
    /// <summary>
    /// Must be "sql" to use the Raw SQL chart config variant.
    /// </summary>
    [JsonPropertyName("configType")]
    public string ConfigType { get; } = "sql";

    /// <summary>
    /// ID of the ClickHouse connection to execute the query against.
    /// </summary>
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; init; }

    /// <summary>
    /// SQL query template to execute. Supports HyperDX template variables.
    /// </summary>
    [JsonPropertyName("sqlTemplate")]
    public required string SqlTemplate { get; init; }

    /// <summary>
    /// Optional ID of the data source associated with this Raw SQL chart. Used for applying dashboard filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceId")]
    public string? SourceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Display as a pie chart.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "pie";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
