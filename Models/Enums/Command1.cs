using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Command to change the state: 'start', 'stop', 'awake'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Command1>))]
public sealed record Command1 : StringEnum<Command1>
{
    private Command1(string value) : base(value)
    {
    }

    public static readonly Command1 Start = new("start");

    public static readonly Command1 Stop = new("stop");

    public static readonly Command1 Awake = new("awake");

    public static Command1 FromValue(string value) => FromValueCore(value);
}
