using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Runtime used to execute the UDF command.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Runtime4>))]
public sealed record Runtime4 : StringEnum<Runtime4>
{
    private Runtime4(string value) : base(value)
    {
    }

    public static readonly Runtime4 Python311 = new("python3.11");

    public static readonly Runtime4 Native = new("native");

    public static Runtime4 FromValue(string value) => FromValueCore(value);
}
