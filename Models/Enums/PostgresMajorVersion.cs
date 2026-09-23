using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PostgresMajorVersion>))]
public sealed record PostgresMajorVersion : StringEnum<PostgresMajorVersion>
{
    private PostgresMajorVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// Postgres major version 18.
    /// </summary>
    public static readonly PostgresMajorVersion _18 = new("18");

    /// <summary>
    /// Postgres major version 17.
    /// </summary>
    public static readonly PostgresMajorVersion _17 = new("17");

    public static PostgresMajorVersion FromValue(string value) => FromValueCore(value);
}
