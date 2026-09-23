using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Metric data type, only for metrics data sources.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MetricDataType>))]
public sealed record MetricDataType : StringEnum<MetricDataType>
{
    private MetricDataType(string value) : base(value)
    {
    }

    public static readonly MetricDataType Sum = new("sum");

    public static readonly MetricDataType Gauge = new("gauge");

    public static readonly MetricDataType Histogram = new("histogram");

    public static readonly MetricDataType Summary = new("summary");

    public static readonly MetricDataType ExponentialHistogram = new("exponential histogram");

    public static MetricDataType FromValue(string value) => FromValueCore(value);
}
