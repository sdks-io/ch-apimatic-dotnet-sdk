using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Backup type ("full" or "incremental").
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : StringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Full = new("full");

    public static readonly Type13 Incremental = new("incremental");

    public static Type13 FromValue(string value) => FromValueCore(value);
}
