using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sandbox runtime version.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxVersion4>))]
public sealed record SandboxVersion4 : StringEnum<SandboxVersion4>
{
    private SandboxVersion4(string value) : base(value)
    {
    }

    public static readonly SandboxVersion4 V1 = new("v1");

    public static readonly SandboxVersion4 V2 = new("v2");

    public static readonly SandboxVersion4 V3 = new("v3");

    public static SandboxVersion4 FromValue(string value) => FromValueCore(value);
}
