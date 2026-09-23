using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackMetricTables
{
    /// <summary>
    /// Table containing gauge metrics data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gauge")]
    public string? Gauge { get; init; }

    /// <summary>
    /// Table containing histogram metrics data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("histogram")]
    public string? Histogram { get; init; }

    /// <summary>
    /// Table containing sum metrics data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sum")]
    public string? Sum { get; init; }

    /// <summary>
    /// Table containing summary metrics data. Note - not yet fully supported by HyperDX
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public string? Summary { get; init; }

    /// <summary>
    /// Table containing exponential histogram metrics data. Note - not yet fully supported by HyperDX
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exponential histogram")]
    public string? ExponentialHistogram { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
