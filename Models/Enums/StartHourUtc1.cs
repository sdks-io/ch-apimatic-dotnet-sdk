using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18. The upgrade window currently lasts 6 hours from this start time.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<StartHourUtc1>))]
public sealed record StartHourUtc1 : IntEnum<StartHourUtc1>
{
    private StartHourUtc1(int value) : base(value)
    {
    }

    /// <summary>
    /// Upgrade window starts at 00:00 UTC.
    /// </summary>
    public static readonly StartHourUtc1 Value0 = new(0);

    /// <summary>
    /// Upgrade window starts at 06:00 UTC.
    /// </summary>
    public static readonly StartHourUtc1 Value6 = new(6);

    /// <summary>
    /// Upgrade window starts at 12:00 UTC.
    /// </summary>
    public static readonly StartHourUtc1 Value12 = new(12);

    /// <summary>
    /// Upgrade window starts at 18:00 UTC.
    /// </summary>
    public static readonly StartHourUtc1 Value18 = new(18);

    public static StartHourUtc1 FromValue(int value) => FromValueCore(value);
}
