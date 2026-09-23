using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current lifecycle state of the ClickPipe. For database pipes: "Provisioning" (initial setup), "Setup" (configuring replication), "Snapshot" (initial data load), "Running" (actively replicating), "Pausing" (transitioning to paused state), "Paused" (temporarily paused), "Modifying" (applying configuration updates), "Resync" (swapping resync tables with original tables), "Failed" (error occurred), "Unknown". For streaming/object storage pipes (Kafka, Kinesis, S3): "Unknown" (initial state), "Provisioning" (setting up resources), "Running" (actively ingesting data), "Stopping" (transitioning to stopped state), "Stopped" (manually stopped, can be restarted), "Completed" (batch ingestion finished for object storage), "Failed" (error occurred, pipe stopped), "InternalError" (internal system error).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State2>))]
public sealed record State2 : StringEnum<State2>
{
    private State2(string value) : base(value)
    {
    }

    public static readonly State2 Unknown = new("Unknown");

    public static readonly State2 Provisioning = new("Provisioning");

    public static readonly State2 Running = new("Running");

    public static readonly State2 Degraded = new("Degraded");

    public static readonly State2 Stopping = new("Stopping");

    public static readonly State2 Stopped = new("Stopped");

    public static readonly State2 Failed = new("Failed");

    public static readonly State2 Completed = new("Completed");

    public static readonly State2 InternalError = new("InternalError");

    public static readonly State2 Setup = new("Setup");

    public static readonly State2 Snapshot = new("Snapshot");

    public static readonly State2 Paused = new("Paused");

    public static readonly State2 Pausing = new("Pausing");

    public static readonly State2 Modifying = new("Modifying");

    public static readonly State2 Resync = new("Resync");

    public static State2 FromValue(string value) => FromValueCore(value);
}
