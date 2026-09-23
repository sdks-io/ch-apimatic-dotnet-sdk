using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Equality comparison operator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operator1>))]
public sealed record Operator1 : StringEnum<Operator1>
{
    private Operator1(string value) : base(value)
    {
    }

    public static readonly Operator1 Eq = new("eq");

    public static readonly Operator1 Neq = new("neq");

    public static Operator1 FromValue(string value) => FromValueCore(value);
}
