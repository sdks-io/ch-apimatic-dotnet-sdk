using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Numeric comparison operator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operator>))]
public sealed record Operator : StringEnum<Operator>
{
    private Operator(string value) : base(value)
    {
    }

    public static readonly Operator Gt = new("gt");

    public static readonly Operator Gte = new("gte");

    public static readonly Operator Lt = new("lt");

    public static readonly Operator Lte = new("lte");

    public static Operator FromValue(string value) => FromValueCore(value);
}
