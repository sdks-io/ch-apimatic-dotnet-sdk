using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of high availability: “none” for no replication, “async” for asynchronous replication to a single standby, and “sync” for synchronous replication to two standbys.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PgHaType>))]
public sealed record PgHaType : StringEnum<PgHaType>
{
    private PgHaType(string value) : base(value)
    {
    }

    public static readonly PgHaType None = new("none");

    public static readonly PgHaType Async = new("async");

    public static readonly PgHaType Sync = new("sync");

    public static PgHaType FromValue(string value) => FromValueCore(value);
}
