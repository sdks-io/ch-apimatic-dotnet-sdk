using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sort order for table rows
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SortOrder>))]
public sealed record SortOrder : StringEnum<SortOrder>
{
    private SortOrder(string value) : base(value)
    {
    }

    public static readonly SortOrder Desc = new("desc");

    public static readonly SortOrder Asc = new("asc");

    public static SortOrder FromValue(string value) => FromValueCore(value);
}
