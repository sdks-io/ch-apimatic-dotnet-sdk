using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the balance.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : StringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 Prepaid = new("prepaid");

    public static readonly Type21 Trial = new("trial");

    public static Type21 FromValue(string value) => FromValueCore(value);
}
