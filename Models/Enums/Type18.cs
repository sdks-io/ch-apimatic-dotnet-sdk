using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Filter type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type18>))]
public sealed record Type18 : StringEnum<Type18>
{
    private Type18(string value) : base(value)
    {
    }

    public static readonly Type18 Sql = new("sql");

    public static Type18 FromValue(string value) => FromValueCore(value);
}
