using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Aggregation function to apply to the field or metric value
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggFn>))]
public sealed record AggFn : StringEnum<AggFn>
{
    private AggFn(string value) : base(value)
    {
    }

    public static readonly AggFn Avg = new("avg");

    public static readonly AggFn Count = new("count");

    public static readonly AggFn CountDistinct = new("count_distinct");

    public static readonly AggFn LastValue = new("last_value");

    public static readonly AggFn Max = new("max");

    public static readonly AggFn Min = new("min");

    public static readonly AggFn Quantile = new("quantile");

    public static readonly AggFn Sum = new("sum");

    public static readonly AggFn Any = new("any");

    public static readonly AggFn None = new("none");

    public static AggFn FromValue(string value) => FromValueCore(value);
}
