using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Snapshot type. Always "full" — snapshots never chain off a parent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type14>))]
public sealed record Type14 : StringEnum<Type14>
{
    private Type14(string value) : base(value)
    {
    }

    public static readonly Type14 Full = new("full");

    public static Type14 FromValue(string value) => FromValueCore(value);
}
