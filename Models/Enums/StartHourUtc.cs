using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<StartHourUtc>))]
public sealed record StartHourUtc : IntEnum<StartHourUtc>
{
    private StartHourUtc(int value) : base(value)
    {
    }

    /// <summary>
    /// Upgrade window starts at 00:00 UTC.
    /// </summary>
    public static readonly StartHourUtc Value0 = new(0);

    /// <summary>
    /// Upgrade window starts at 06:00 UTC.
    /// </summary>
    public static readonly StartHourUtc Value6 = new(6);

    /// <summary>
    /// Upgrade window starts at 12:00 UTC.
    /// </summary>
    public static readonly StartHourUtc Value12 = new(12);

    /// <summary>
    /// Upgrade window starts at 18:00 UTC.
    /// </summary>
    public static readonly StartHourUtc Value18 = new(18);

    public static StartHourUtc FromValue(int value) => FromValueCore(value);
}
