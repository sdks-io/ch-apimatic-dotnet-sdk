using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Starting position strategy for consuming the subscription. The seekTimestamp companion is required only when seekType is "timestamp"; setting it for a mismatched seek type is rejected.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SeekType>))]
public sealed record SeekType : StringEnum<SeekType>
{
    private SeekType(string value) : base(value)
    {
    }

    public static readonly SeekType Latest = new("latest");

    public static readonly SeekType Earliest = new("earliest");

    public static readonly SeekType Timestamp = new("timestamp");

    public static SeekType FromValue(string value) => FromValueCore(value);
}
