using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresQueryExecution
{
    /// <summary>
    /// Execution timestamp (RFC 3339).
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Stable identifier for the query pattern.
    /// </summary>
    [JsonPropertyName("queryId")]
    public required string QueryId { get; init; }

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
    /// Top-level SQL operation type.
    /// </summary>
    [JsonPropertyName("dbOperation")]
    public required string DbOperation { get; init; }

    /// <summary>
    /// Value of the Postgres <c>application_name</c> for this execution.
    /// </summary>
    [JsonPropertyName("app")]
    public required string App { get; init; }

    /// <summary>
    /// Normalized query text for this execution.
    /// </summary>
    [JsonPropertyName("queryText")]
    public required string QueryText { get; init; }

    /// <summary>
    /// Postgres backend process ID that executed the query.
    /// </summary>
    [JsonPropertyName("pid")]
    public required string Pid { get; init; }

    /// <summary>
    /// Execution duration in microseconds.
    /// </summary>
    [JsonPropertyName("durationUs")]
    public required int DurationUs { get; init; }

    /// <summary>
    /// Rows returned or affected.
    /// </summary>
    [JsonPropertyName("rows")]
    public required int Rows { get; init; }

    /// <summary>
    /// Shared buffer blocks hit.
    /// </summary>
    [JsonPropertyName("sharedBlksHit")]
    public required int SharedBlksHit { get; init; }

    /// <summary>
    /// Shared buffer blocks read from disk.
    /// </summary>
    [JsonPropertyName("sharedBlksRead")]
    public required int SharedBlksRead { get; init; }

    /// <summary>
    /// Shared buffer blocks written.
    /// </summary>
    [JsonPropertyName("sharedBlksWritten")]
    public required int SharedBlksWritten { get; init; }

    /// <summary>
    /// Shared buffer blocks dirtied.
    /// </summary>
    [JsonPropertyName("sharedBlksDirtied")]
    public required int SharedBlksDirtied { get; init; }

    /// <summary>
    /// Time spent reading shared blocks, in microseconds.
    /// </summary>
    [JsonPropertyName("sharedBlkReadTimeUs")]
    public required int SharedBlkReadTimeUs { get; init; }

    /// <summary>
    /// Time spent writing shared blocks, in microseconds.
    /// </summary>
    [JsonPropertyName("sharedBlkWriteTimeUs")]
    public required int SharedBlkWriteTimeUs { get; init; }

    /// <summary>
    /// Local buffer blocks hit (temp tables).
    /// </summary>
    [JsonPropertyName("localBlksHit")]
    public required int LocalBlksHit { get; init; }

    /// <summary>
    /// Local buffer blocks read (temp tables).
    /// </summary>
    [JsonPropertyName("localBlksRead")]
    public required int LocalBlksRead { get; init; }

    /// <summary>
    /// Local buffer blocks written (temp tables).
    /// </summary>
    [JsonPropertyName("localBlksWritten")]
    public required int LocalBlksWritten { get; init; }

    /// <summary>
    /// Local buffer blocks dirtied (temp tables).
    /// </summary>
    [JsonPropertyName("localBlksDirtied")]
    public required int LocalBlksDirtied { get; init; }

    /// <summary>
    /// Temp blocks read (spills to disk).
    /// </summary>
    [JsonPropertyName("tempBlksRead")]
    public required int TempBlksRead { get; init; }

    /// <summary>
    /// Temp blocks written (spills to disk).
    /// </summary>
    [JsonPropertyName("tempBlksWritten")]
    public required int TempBlksWritten { get; init; }

    /// <summary>
    /// Time spent reading temp blocks, in microseconds.
    /// </summary>
    [JsonPropertyName("tempBlkReadTimeUs")]
    public required int TempBlkReadTimeUs { get; init; }

    /// <summary>
    /// Time spent writing temp blocks, in microseconds.
    /// </summary>
    [JsonPropertyName("tempBlkWriteTimeUs")]
    public required int TempBlkWriteTimeUs { get; init; }

    /// <summary>
    /// Number of WAL records produced.
    /// </summary>
    [JsonPropertyName("walRecords")]
    public required int WalRecords { get; init; }

    /// <summary>
    /// Number of WAL bytes produced.
    /// </summary>
    [JsonPropertyName("walBytes")]
    public required int WalBytes { get; init; }

    /// <summary>
    /// Number of WAL full-page images produced.
    /// </summary>
    [JsonPropertyName("walFpi")]
    public required int WalFpi { get; init; }

    /// <summary>
    /// CPU time spent in user mode, in microseconds.
    /// </summary>
    [JsonPropertyName("cpuUserTimeUs")]
    public required int CpuUserTimeUs { get; init; }

    /// <summary>
    /// CPU time spent in kernel mode, in microseconds.
    /// </summary>
    [JsonPropertyName("cpuSysTimeUs")]
    public required int CpuSysTimeUs { get; init; }

    /// <summary>
    /// Number of JIT-compiled functions.
    /// </summary>
    [JsonPropertyName("jitFunctions")]
    public required int JitFunctions { get; init; }

    /// <summary>
    /// JIT generation time, in microseconds.
    /// </summary>
    [JsonPropertyName("jitGenerationTimeUs")]
    public required int JitGenerationTimeUs { get; init; }

    /// <summary>
    /// JIT inlining time, in microseconds.
    /// </summary>
    [JsonPropertyName("jitInliningTimeUs")]
    public required int JitInliningTimeUs { get; init; }

    /// <summary>
    /// JIT optimization time, in microseconds.
    /// </summary>
    [JsonPropertyName("jitOptimizationTimeUs")]
    public required int JitOptimizationTimeUs { get; init; }

    /// <summary>
    /// JIT emission time, in microseconds.
    /// </summary>
    [JsonPropertyName("jitEmissionTimeUs")]
    public required int JitEmissionTimeUs { get; init; }

    /// <summary>
    /// JIT deform time, in microseconds.
    /// </summary>
    [JsonPropertyName("jitDeformTimeUs")]
    public required int JitDeformTimeUs { get; init; }

    /// <summary>
    /// Parallel workers planned for this execution.
    /// </summary>
    [JsonPropertyName("parallelWorkersPlanned")]
    public required int ParallelWorkersPlanned { get; init; }

    /// <summary>
    /// Parallel workers actually launched for this execution.
    /// </summary>
    [JsonPropertyName("parallelWorkersLaunched")]
    public required int ParallelWorkersLaunched { get; init; }

    /// <summary>
    /// Error message if the execution raised an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errMessage")]
    public string? ErrMessage { get; init; }

    /// <summary>
    /// Postgres SQLSTATE code if the execution raised an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errSqlstate")]
    public string? ErrSqlstate { get; init; }

    /// <summary>
    /// Postgres error severity level if the execution raised an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errElevel")]
    public int? ErrElevel { get; init; }

    /// <summary>
    /// Role of the server that executed the query (for example, primary or standby).
    /// </summary>
    [JsonPropertyName("serverRole")]
    public required string ServerRole { get; init; }

    /// <summary>
    /// OpenTelemetry trace ID associated with the execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traceId")]
    public string? TraceId { get; init; }

    /// <summary>
    /// OpenTelemetry span ID associated with the execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spanId")]
    public string? SpanId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
