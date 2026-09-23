using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Command to change the state: 'start', 'stop', 'resync'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Command2>))]
public sealed record Command2 : StringEnum<Command2>
{
    private Command2(string value) : base(value)
    {
    }

    public static readonly Command2 Start = new("start");

    public static readonly Command2 Stop = new("stop");

    public static readonly Command2 Resync = new("resync");

    public static Command2 FromValue(string value) => FromValueCore(value);
}
