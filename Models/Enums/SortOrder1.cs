using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SortOrder1>))]
public sealed record SortOrder1 : StringEnum<SortOrder1>
{
    private SortOrder1(string value) : base(value)
    {
    }

    public static readonly SortOrder1 Asc = new("asc");

    public static readonly SortOrder1 Desc = new("desc");

    public static SortOrder1 FromValue(string value) => FromValueCore(value);
}
