using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// The operation to perform.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Op>))]
public sealed record Op : StringEnum<Op>
{
    private Op(string value) : base(value)
    {
    }

    public static readonly Op Add = new("add");

    public static readonly Op Replace = new("replace");

    public static readonly Op Remove = new("remove");

    public static Op FromValue(string value) => FromValueCore(value);
}
