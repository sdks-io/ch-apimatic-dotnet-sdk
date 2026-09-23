using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Compression algorithm used for the files.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Compression>))]
public sealed record Compression : StringEnum<Compression>
{
    private Compression(string value) : base(value)
    {
    }

    public static readonly Compression None = new("none");

    public static readonly Compression Gzip = new("gzip");

    public static readonly Compression Gz = new("gz");

    public static readonly Compression Brotli = new("brotli");

    public static readonly Compression Br = new("br");

    public static readonly Compression Xz = new("xz");

    public static readonly Compression Lzma = new("LZMA");

    public static readonly Compression Zstd = new("zstd");

    public static readonly Compression Auto = new("auto");

    public static Compression FromValue(string value) => FromValueCore(value);
}
