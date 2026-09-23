using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresSlowQueryPattern
{
    /// <summary>
    /// Stable identifier for the query pattern (normalized SQL).
    /// </summary>
    [JsonPropertyName("queryId")]
    public required string QueryId { get; init; }

    /// <summary>
    /// Normalized query text with literals replaced by placeholders.
    /// </summary>
    [JsonPropertyName("queryText")]
    public required string QueryText { get; init; }

    /// <summary>
    /// Database the query ran in.
    /// </summary>
    [JsonPropertyName("dbName")]
    public required string DbName { get; init; }

    /// <summary>
    /// Database user that executed the query.
    /// </summary>
    [JsonPropertyName("dbUser")]
    public required string DbUser { get; init; }

    /// <summary>
    /// Top-level SQL operation type (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY).
    /// </summary>
    [JsonPropertyName("dbOperation")]
    public required string DbOperation { get; init; }

    /// <summary>
    /// Value of the Postgres <c>application_name</c> for executions matching this pattern.
    /// </summary>
    [JsonPropertyName("app")]
    public required string App { get; init; }

    /// <summary>
    /// Number of times the pattern executed in the window.
    /// </summary>
    [JsonPropertyName("callCount")]
    public required int CallCount { get; init; }

    /// <summary>
    /// Number of executions of the pattern that raised an error.
    /// </summary>
    [JsonPropertyName("errorCount")]
    public required int ErrorCount { get; init; }

    /// <summary>
    /// Total execution time across all calls, in microseconds.
    /// </summary>
    [JsonPropertyName("totalDurationUs")]
    public required int TotalDurationUs { get; init; }

    /// <summary>
    /// Average execution time per call, in microseconds.
    /// </summary>
    [JsonPropertyName("avgDurationUs")]
    public required int AvgDurationUs { get; init; }

    /// <summary>
    /// Maximum execution time of any call, in microseconds.
    /// </summary>
    [JsonPropertyName("maxDurationUs")]
    public required int MaxDurationUs { get; init; }

    /// <summary>
    /// 50th percentile execution time, in microseconds.
    /// </summary>
    [JsonPropertyName("p50DurationUs")]
    public required int P50DurationUs { get; init; }

    /// <summary>
    /// 95th percentile execution time, in microseconds.
    /// </summary>
    [JsonPropertyName("p95DurationUs")]
    public required int P95DurationUs { get; init; }

    /// <summary>
    /// 99th percentile execution time, in microseconds.
    /// </summary>
    [JsonPropertyName("p99DurationUs")]
    public required int P99DurationUs { get; init; }

    /// <summary>
    /// Total number of rows returned or affected across all calls.
    /// </summary>
    [JsonPropertyName("totalRows")]
    public required int TotalRows { get; init; }

    /// <summary>
    /// Total shared buffer blocks read from disk (cache misses) across all calls.
    /// </summary>
    [JsonPropertyName("totalSharedBlksRead")]
    public required int TotalSharedBlksRead { get; init; }

    /// <summary>
    /// Total shared buffer blocks hit (cache hits) across all calls.
    /// </summary>
    [JsonPropertyName("totalSharedBlksHit")]
    public required int TotalSharedBlksHit { get; init; }

    /// <summary>
    /// Total CPU time across all calls, in microseconds.
    /// </summary>
    [JsonPropertyName("totalCpuTimeUs")]
    public required int TotalCpuTimeUs { get; init; }

    /// <summary>
    /// Total WAL (write-ahead log) bytes generated across all calls.
    /// </summary>
    [JsonPropertyName("totalWalBytes")]
    public required int TotalWalBytes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
