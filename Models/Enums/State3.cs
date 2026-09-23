using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current alert state.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State3>))]
public sealed record State3 : StringEnum<State3>
{
    private State3(string value) : base(value)
    {
    }

    public static readonly State3 Alert = new("ALERT");

    public static readonly State3 Ok = new("OK");

    public static readonly State3 InsufficientData = new("INSUFFICIENT_DATA");

    public static readonly State3 Disabled = new("DISABLED");

    public static readonly State3 Pending = new("PENDING");

    public static State3 FromValue(string value) => FromValueCore(value);
}
