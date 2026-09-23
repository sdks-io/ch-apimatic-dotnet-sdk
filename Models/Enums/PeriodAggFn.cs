using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Optional period aggregation function for Gauge metrics (e.g., compute the delta over the period).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PeriodAggFn>))]
public sealed record PeriodAggFn : StringEnum<PeriodAggFn>
{
    private PeriodAggFn(string value) : base(value)
    {
    }

    public static readonly PeriodAggFn Delta = new("delta");

    public static PeriodAggFn FromValue(string value) => FromValueCore(value);
}
