using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Compress full-page writes in WAL. Reduces I/O at the cost of CPU. Options vary by PostgreSQL version.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalCompression>))]
public sealed record WalCompression : StringEnum<WalCompression>
{
    private WalCompression(string value) : base(value)
    {
    }

    public static readonly WalCompression Off = new("off");

    public static readonly WalCompression On = new("on");

    public static readonly WalCompression Lz4 = new("lz4");

    public static readonly WalCompression Zstd = new("zstd");

    public static WalCompression FromValue(string value) => FromValueCore(value);
}
