using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sparkline shape.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type19>))]
public sealed record Type19 : StringEnum<Type19>
{
    private Type19(string value) : base(value)
    {
    }

    public static readonly Type19 Line = new("line");

    public static readonly Type19 Area = new("area");

    public static Type19 FromValue(string value) => FromValueCore(value);
}
