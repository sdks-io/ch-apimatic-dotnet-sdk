using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Postgres status, which initiates a process.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Command>))]
public sealed record Command : StringEnum<Command>
{
    private Command(string value) : base(value)
    {
    }

    public static readonly Command Restart = new("restart");

    public static readonly Command Promote = new("promote");

    public static readonly Command Switchover = new("switchover");

    public static Command FromValue(string value) => FromValueCore(value);
}
