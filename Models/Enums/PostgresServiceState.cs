using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current state of the service
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PostgresServiceState>))]
public sealed record PostgresServiceState : StringEnum<PostgresServiceState>
{
    private PostgresServiceState(string value) : base(value)
    {
    }

    public static readonly PostgresServiceState Creating = new("creating");

    public static readonly PostgresServiceState Restarting = new("restarting");

    public static readonly PostgresServiceState Running = new("running");

    public static readonly PostgresServiceState ReplayingWal = new("replaying_wal");

    public static readonly PostgresServiceState RestoringBackup = new("restoring_backup");

    public static readonly PostgresServiceState FinalizingRestore = new("finalizing_restore");

    public static readonly PostgresServiceState Unavailable = new("unavailable");

    public static readonly PostgresServiceState Stopped = new("stopped");

    public static readonly PostgresServiceState Deleting = new("deleting");

    public static PostgresServiceState FromValue(string value) => FromValueCore(value);
}
