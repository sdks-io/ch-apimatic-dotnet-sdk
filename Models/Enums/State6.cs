using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Initial state of the key: 'enabled', 'disabled'. If not provided the new key will be 'enabled'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State6>))]
public sealed record State6 : StringEnum<State6>
{
    private State6(string value) : base(value)
    {
    }

    public static readonly State6 Enabled = new("enabled");

    public static readonly State6 Disabled = new("disabled");

    public static State6 FromValue(string value) => FromValueCore(value);
}
