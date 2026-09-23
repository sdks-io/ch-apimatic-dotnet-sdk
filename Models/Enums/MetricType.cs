using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Metric type; only applicable when the source is a metrics source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MetricType>))]
public sealed record MetricType : StringEnum<MetricType>
{
    private MetricType(string value) : base(value)
    {
    }

    public static readonly MetricType Sum = new("sum");

    public static readonly MetricType Gauge = new("gauge");

    public static readonly MetricType Histogram = new("histogram");

    public static readonly MetricType Summary = new("summary");

    public static readonly MetricType ExponentialHistogram = new("exponential histogram");

    public static MetricType FromValue(string value) => FromValueCore(value);
}
