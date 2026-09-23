using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// State of the key: 'enabled', 'disabled'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State4>))]
public sealed record State4 : StringEnum<State4>
{
    private State4(string value) : base(value)
    {
    }

    public static readonly State4 Enabled = new("enabled");

    public static readonly State4 Disabled = new("disabled");

    public static State4 FromValue(string value) => FromValueCore(value);
}
