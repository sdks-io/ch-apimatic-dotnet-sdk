using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Percentile level; only valid when aggFn is "quantile".
/// </summary>
[JsonConverter(typeof(IntEnumConverter<Level>))]
public sealed record Level : IntEnum<Level>
{
    private Level(int value) : base(value)
    {
    }

    /// <summary>
    /// 50th percentile.
    /// </summary>
    public static readonly Level Value0 = new(0);

    /// <summary>
    /// 90th percentile.
    /// </summary>
    public static readonly Level Value1 = new(1);

    /// <summary>
    /// 95th percentile.
    /// </summary>
    public static readonly Level Value2 = new(2);

    /// <summary>
    /// 99th percentile.
    /// </summary>
    public static readonly Level Value3 = new(3);

    public static Level FromValue(int value) => FromValueCore(value);
}
