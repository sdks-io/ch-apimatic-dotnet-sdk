using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// MySQL replication mechanism: "GTID" (Global Transaction Identifier) or "FILE_POS" (binary log file and position). Defaults to "GTID" if not specified. MariaDB supports "GTID" only. For "FILE_POS" on MySQL, contact support.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReplicationMechanism>))]
public sealed record ReplicationMechanism : StringEnum<ReplicationMechanism>
{
    private ReplicationMechanism(string value) : base(value)
    {
    }

    public static readonly ReplicationMechanism Gtid = new("GTID");

    public static readonly ReplicationMechanism FilePos = new("FILE_POS");

    public static ReplicationMechanism FromValue(string value) => FromValueCore(value);
}
