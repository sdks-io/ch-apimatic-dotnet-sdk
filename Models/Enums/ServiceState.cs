using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current state of the service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceState>))]
public sealed record ServiceState : StringEnum<ServiceState>
{
    private ServiceState(string value) : base(value)
    {
    }

    public static readonly ServiceState Starting = new("starting");

    public static readonly ServiceState Stopping = new("stopping");

    public static readonly ServiceState Terminating = new("terminating");

    public static readonly ServiceState Softdeleting = new("softdeleting");

    public static readonly ServiceState Awaking = new("awaking");

    public static readonly ServiceState PartiallyRunning = new("partially_running");

    public static readonly ServiceState Provisioning = new("provisioning");

    public static readonly ServiceState Running = new("running");

    public static readonly ServiceState Stopped = new("stopped");

    public static readonly ServiceState Terminated = new("terminated");

    public static readonly ServiceState Softdeleted = new("softdeleted");

    public static readonly ServiceState Degraded = new("degraded");

    public static readonly ServiceState Failed = new("failed");

    public static readonly ServiceState Idle = new("idle");

    public static ServiceState FromValue(string value) => FromValueCore(value);
}
