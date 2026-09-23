using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SortBy>))]
public sealed record SortBy : StringEnum<SortBy>
{
    private SortBy(string value) : base(value)
    {
    }

    public static readonly SortBy TotalDuration = new("total_duration");

    public static readonly SortBy AvgDuration = new("avg_duration");

    public static readonly SortBy CallCount = new("call_count");

    public static readonly SortBy TotalBlksRead = new("total_blks_read");

    public static readonly SortBy TotalCpuTime = new("total_cpu_time");

    public static readonly SortBy ErrorCount = new("error_count");

    public static readonly SortBy MaxDuration = new("max_duration");

    public static readonly SortBy P50Duration = new("p50_duration");

    public static readonly SortBy P95Duration = new("p95_duration");

    public static readonly SortBy P99Duration = new("p99_duration");

    public static readonly SortBy TotalRows = new("total_rows");

    public static readonly SortBy TotalSharedBlksHit = new("total_shared_blks_hit");

    public static readonly SortBy TotalWalBytes = new("total_wal_bytes");

    public static SortBy FromValue(string value) => FromValueCore(value);
}
