using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Numeric unit for data, data rate, or throughput formats.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NumericUnit>))]
public sealed record NumericUnit : StringEnum<NumericUnit>
{
    private NumericUnit(string value) : base(value)
    {
    }

    public static readonly NumericUnit BytesIec = new("bytes_iec");

    public static readonly NumericUnit BytesSi = new("bytes_si");

    public static readonly NumericUnit BitsIec = new("bits_iec");

    public static readonly NumericUnit BitsSi = new("bits_si");

    public static readonly NumericUnit Kibibytes = new("kibibytes");

    public static readonly NumericUnit Kilobytes = new("kilobytes");

    public static readonly NumericUnit Mebibytes = new("mebibytes");

    public static readonly NumericUnit Megabytes = new("megabytes");

    public static readonly NumericUnit Gibibytes = new("gibibytes");

    public static readonly NumericUnit Gigabytes = new("gigabytes");

    public static readonly NumericUnit Tebibytes = new("tebibytes");

    public static readonly NumericUnit Terabytes = new("terabytes");

    public static readonly NumericUnit Pebibytes = new("pebibytes");

    public static readonly NumericUnit Petabytes = new("petabytes");

    public static readonly NumericUnit PacketsSec = new("packets_sec");

    public static readonly NumericUnit BytesSecIec = new("bytes_sec_iec");

    public static readonly NumericUnit BytesSecSi = new("bytes_sec_si");

    public static readonly NumericUnit BitsSecIec = new("bits_sec_iec");

    public static readonly NumericUnit BitsSecSi = new("bits_sec_si");

    public static readonly NumericUnit KibibytesSec = new("kibibytes_sec");

    public static readonly NumericUnit KibibitsSec = new("kibibits_sec");

    public static readonly NumericUnit KilobytesSec = new("kilobytes_sec");

    public static readonly NumericUnit KilobitsSec = new("kilobits_sec");

    public static readonly NumericUnit MebibytesSec = new("mebibytes_sec");

    public static readonly NumericUnit MebibitsSec = new("mebibits_sec");

    public static readonly NumericUnit MegabytesSec = new("megabytes_sec");

    public static readonly NumericUnit MegabitsSec = new("megabits_sec");

    public static readonly NumericUnit GibibytesSec = new("gibibytes_sec");

    public static readonly NumericUnit GibibitsSec = new("gibibits_sec");

    public static readonly NumericUnit GigabytesSec = new("gigabytes_sec");

    public static readonly NumericUnit GigabitsSec = new("gigabits_sec");

    public static readonly NumericUnit TebibytesSec = new("tebibytes_sec");

    public static readonly NumericUnit TebibitsSec = new("tebibits_sec");

    public static readonly NumericUnit TerabytesSec = new("terabytes_sec");

    public static readonly NumericUnit TerabitsSec = new("terabits_sec");

    public static readonly NumericUnit PebibytesSec = new("pebibytes_sec");

    public static readonly NumericUnit PebibitsSec = new("pebibits_sec");

    public static readonly NumericUnit PetabytesSec = new("petabytes_sec");

    public static readonly NumericUnit PetabitsSec = new("petabits_sec");

    public static readonly NumericUnit Cps = new("cps");

    public static readonly NumericUnit Ops = new("ops");

    public static readonly NumericUnit Rps = new("rps");

    public static readonly NumericUnit ReadsSec = new("reads_sec");

    public static readonly NumericUnit Wps = new("wps");

    public static readonly NumericUnit Iops = new("iops");

    public static readonly NumericUnit Cpm = new("cpm");

    public static readonly NumericUnit Opm = new("opm");

    public static readonly NumericUnit RpmReads = new("rpm_reads");

    public static readonly NumericUnit Wpm = new("wpm");

    public static NumericUnit FromValue(string value) => FromValueCore(value);
}
