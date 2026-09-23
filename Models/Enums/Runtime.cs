using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Runtime>))]
public sealed record Runtime : StringEnum<Runtime>
{
    private Runtime(string value) : base(value)
    {
    }

    public static readonly Runtime Python311 = new("python3.11");

    public static readonly Runtime Native = new("native");

    public static Runtime FromValue(string value) => FromValueCore(value);
}
