using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AvailabilityZoneSuffix>))]
public sealed record AvailabilityZoneSuffix : StringEnum<AvailabilityZoneSuffix>
{
    private AvailabilityZoneSuffix(string value) : base(value)
    {
    }

    public static readonly AvailabilityZoneSuffix A = new("a");

    public static readonly AvailabilityZoneSuffix B = new("b");

    public static readonly AvailabilityZoneSuffix C = new("c");

    public static readonly AvailabilityZoneSuffix D = new("d");

    public static readonly AvailabilityZoneSuffix E = new("e");

    public static readonly AvailabilityZoneSuffix F = new("f");

    public static AvailabilityZoneSuffix FromValue(string value) => FromValueCore(value);
}
