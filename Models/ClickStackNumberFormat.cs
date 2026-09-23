using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackNumberFormat
{
    /// <summary>
    /// Output format applied to the number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public Output? Output { get; init; }

    /// <summary>
    /// Number of decimal places.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mantissa")]
    public int? Mantissa { get; init; }

    /// <summary>
    /// Whether to use thousand separators.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thousandSeparated")]
    public bool? ThousandSeparated { get; init; }

    /// <summary>
    /// Whether to show as average.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average")]
    public bool? Average { get; init; }

    /// <summary>
    /// Use decimal bytes (1000) vs binary bytes (1024).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decimalBytes")]
    public bool? DecimalBytes { get; init; }

    /// <summary>
    /// Multiplication factor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("factor")]
    public double? Factor { get; init; }

    /// <summary>
    /// Currency symbol for currency format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencySymbol")]
    public string? CurrencySymbol { get; init; }

    /// <summary>
    /// Numeric unit for data, data rate, or throughput formats.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numericUnit")]
    public NumericUnit? NumericUnit { get; init; }

    /// <summary>
    /// Custom unit label.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit")]
    public string? Unit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
