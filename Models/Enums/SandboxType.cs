using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SandboxType>))]
public sealed record SandboxType : StringEnum<SandboxType>
{
    private SandboxType(string value) : base(value)
    {
    }

    public static readonly SandboxType Basic = new("basic");

    public static readonly SandboxType Netenable = new("netenable");

    public static SandboxType FromValue(string value) => FromValueCore(value);
}
