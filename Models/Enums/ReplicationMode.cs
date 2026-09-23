using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReplicationMode>))]
public sealed record ReplicationMode : StringEnum<ReplicationMode>
{
    private ReplicationMode(string value) : base(value)
    {
    }

    public static readonly ReplicationMode Cdc = new("cdc");

    public static readonly ReplicationMode Snapshot = new("snapshot");

    public static readonly ReplicationMode CdcOnly = new("cdc_only");

    public static ReplicationMode FromValue(string value) => FromValueCore(value);
}
