using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SandboxVersion>))]
public sealed record SandboxVersion : StringEnum<SandboxVersion>
{
    private SandboxVersion(string value) : base(value)
    {
    }

    public static readonly SandboxVersion V1 = new("v1");

    public static readonly SandboxVersion V2 = new("v2");

    public static readonly SandboxVersion V3 = new("v3");

    public static SandboxVersion FromValue(string value) => FromValueCore(value);
}
