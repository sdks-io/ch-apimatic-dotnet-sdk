using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sandbox isolation level.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SandboxType4>))]
public sealed record SandboxType4 : StringEnum<SandboxType4>
{
    private SandboxType4(string value) : base(value)
    {
    }

    public static readonly SandboxType4 Basic = new("basic");

    public static readonly SandboxType4 Netenable = new("netenable");

    public static SandboxType4 FromValue(string value) => FromValueCore(value);
}
