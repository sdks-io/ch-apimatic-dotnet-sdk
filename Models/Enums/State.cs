using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current state of the service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State>))]
public sealed record State : StringEnum<State>
{
    private State(string value) : base(value)
    {
    }

    public static readonly State Starting = new("starting");

    public static readonly State Stopping = new("stopping");

    public static readonly State Terminating = new("terminating");

    public static readonly State Softdeleting = new("softdeleting");

    public static readonly State Awaking = new("awaking");

    public static readonly State PartiallyRunning = new("partially_running");

    public static readonly State Provisioning = new("provisioning");

    public static readonly State Running = new("running");

    public static readonly State Stopped = new("stopped");

    public static readonly State Terminated = new("terminated");

    public static readonly State Softdeleted = new("softdeleted");

    public static readonly State Degraded = new("degraded");

    public static readonly State Failed = new("failed");

    public static readonly State Idle = new("idle");

    public static State FromValue(string value) => FromValueCore(value);
}
