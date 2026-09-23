using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Aggregation function to apply. "count" does not require a valueExpression; "quantile" requires a level field indicating the desired percentile (e.g., 0.95).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggFn3>))]
public sealed record AggFn3 : StringEnum<AggFn3>
{
    private AggFn3(string value) : base(value)
    {
    }

    public static readonly AggFn3 Avg = new("avg");

    public static readonly AggFn3 Count = new("count");

    public static readonly AggFn3 CountDistinct = new("count_distinct");

    public static readonly AggFn3 LastValue = new("last_value");

    public static readonly AggFn3 Max = new("max");

    public static readonly AggFn3 Min = new("min");

    public static readonly AggFn3 Quantile = new("quantile");

    public static readonly AggFn3 Sum = new("sum");

    public static readonly AggFn3 Any = new("any");

    public static readonly AggFn3 None = new("none");

    public static AggFn3 FromValue(string value) => FromValueCore(value);
}
