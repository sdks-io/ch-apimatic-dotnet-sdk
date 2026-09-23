using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Metric type when source is metrics
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SourceMetricType>))]
public sealed record SourceMetricType : StringEnum<SourceMetricType>
{
    private SourceMetricType(string value) : base(value)
    {
    }

    public static readonly SourceMetricType Sum = new("sum");

    public static readonly SourceMetricType Gauge = new("gauge");

    public static readonly SourceMetricType Histogram = new("histogram");

    public static readonly SourceMetricType Summary = new("summary");

    public static readonly SourceMetricType ExponentialHistogram = new("exponential histogram");

    public static SourceMetricType FromValue(string value) => FromValueCore(value);
}
