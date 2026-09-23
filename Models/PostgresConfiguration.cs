using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

/// <summary>
/// Postgres <see href="https://www.postgresql.org/docs/current/runtime-config.html">runtime configuration</see> configuration.
/// </summary>
public record PostgresConfiguration
{
    /// <summary>
    /// Sets the maximum number of concurrent connections to the database server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_connections")]
    public MaxConnections? MaxConnections { get; init; }

    /// <summary>
    /// Sets the default transaction isolation level for new transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_transaction_isolation")]
    public DefaultTransactionIsolation? DefaultTransactionIsolation { get; init; }

    /// <summary>
    /// Sets the minimum SSL/TLS protocol version allowed for client connections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssl_min_protocol_version")]
    public SslMinProtocolVersion? SslMinProtocolVersion { get; init; }

    /// <summary>
    /// Sets the maximum memory to be used for maintenance operations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maintenance_work_mem")]
    public MaintenanceWorkMem? MaintenanceWorkMem { get; init; }

    /// <summary>
    /// Sets the amount of memory Postgres will use for internal operations like sorting and hashing as part of executing a query.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("work_mem")]
    public WorkMem? WorkMem { get; init; }

    /// <summary>
    /// Sets the planner's assumption about the total size of data caches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effective_cache_size")]
    public EffectiveCacheSize? EffectiveCacheSize { get; init; }

    /// <summary>
    /// Sets the planner's estimate of the cost of a non-sequentially-fetched disk page. Lower values (1.1-1.5) are better for SSDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("random_page_cost")]
    public RandomPageCost? RandomPageCost { get; init; }

    /// <summary>
    /// Number of concurrent disk I/O operations the planner expects. Higher values (100-200) benefit SSDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effective_io_concurrency")]
    public EffectiveIoConcurrency? EffectiveIoConcurrency { get; init; }

    /// <summary>
    /// Maximum number of background processes the system can support. Includes parallel query workers, logical replication, and more.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_worker_processes")]
    public MaxWorkerProcesses? MaxWorkerProcesses { get; init; }

    /// <summary>
    /// Maximum number of workers that can be used for parallel operations. Cannot exceed max_worker_processes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_parallel_workers")]
    public MaxParallelWorkers? MaxParallelWorkers { get; init; }

    /// <summary>
    /// Maximum number of parallel workers per executor node for parallel queries. Use 0 to disable parallel queries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_parallel_workers_per_gather")]
    public MaxParallelWorkersPerGather? MaxParallelWorkersPerGather { get; init; }

    /// <summary>
    /// Maximum number of parallel workers for maintenance operations like CREATE INDEX and VACUUM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_parallel_maintenance_workers")]
    public MaxParallelMaintenanceWorkers? MaxParallelMaintenanceWorkers { get; init; }

    /// <summary>
    /// Abort any statement that runs longer than the specified time. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement_timeout")]
    public StatementTimeout? StatementTimeout { get; init; }

    /// <summary>
    /// Abort any statement that waits longer than the specified time while attempting to acquire a lock. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lock_timeout")]
    public LockTimeout? LockTimeout { get; init; }

    /// <summary>
    /// Terminate any session that has been idle for longer than the specified time. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idle_session_timeout")]
    public IdleSessionTimeout? IdleSessionTimeout { get; init; }

    /// <summary>
    /// Terminate any session that has been idle within an open transaction for longer than the specified time. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idle_in_transaction_session_timeout")]
    public IdleInTransactionSessionTimeout? IdleInTransactionSessionTimeout { get; init; }

    /// <summary>
    /// Terminate any statement that takes more than the specified time, even while active. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_timeout")]
    public TransactionTimeout? TransactionTimeout { get; init; }

    /// <summary>
    /// Terminate replication connections that are inactive for longer than this time. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wal_sender_timeout")]
    public WalSenderTimeout? WalSenderTimeout { get; init; }

    /// <summary>
    /// Minimum size of past WAL files kept in pg_wal for standby servers. Use 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wal_keep_size")]
    public WalKeepSize? WalKeepSize { get; init; }

    /// <summary>
    /// Minimum size to shrink the WAL to. WAL files are recycled rather than removed when below this size.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_wal_size")]
    public MinWalSize? MinWalSize { get; init; }

    /// <summary>
    /// Maximum size WAL can grow between checkpoints. Larger values improve write performance but increase crash recovery time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_wal_size")]
    public MaxWalSize? MaxWalSize { get; init; }

    /// <summary>
    /// Specifies the maximum size of WAL files that replication slots are allowed to retain. Use -1 for unlimited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_slot_wal_keep_size")]
    public MaxSlotWalKeepSize? MaxSlotWalKeepSize { get; init; }

    /// <summary>
    /// Compress full-page writes in WAL. Reduces I/O at the cost of CPU. Options vary by PostgreSQL version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wal_compression")]
    public WalCompression? WalCompression { get; init; }

    /// <summary>
    /// Maximum number of autovacuum worker processes that can run at the same time. Workers share a single cost-limit budget, so raising this alone may not speed up vacuuming.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_max_workers")]
    public AutovacuumMaxWorkers? AutovacuumMaxWorkers { get; init; }

    /// <summary>
    /// Minimum delay between autovacuum runs. Lower values make autovacuum check for work more frequently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_naptime")]
    public AutovacuumNaptime? AutovacuumNaptime { get; init; }

    /// <summary>
    /// Maximum memory each autovacuum worker uses to track dead tuples. Higher values reduce repeated index-vacuum passes on large tables. Use -1 to fall back to maintenance_work_mem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_work_mem")]
    public AutovacuumWorkMem? AutovacuumWorkMem { get; init; }

    /// <summary>
    /// Fraction of a table's rows that must change before autovacuum runs. Lower values vacuum large tables more frequently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_vacuum_scale_factor")]
    public AutovacuumVacuumScaleFactor? AutovacuumVacuumScaleFactor { get; init; }

    /// <summary>
    /// Fraction of a table's rows that must change before autovacuum runs ANALYZE to refresh planner statistics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_analyze_scale_factor")]
    public AutovacuumAnalyzeScaleFactor? AutovacuumAnalyzeScaleFactor { get; init; }

    /// <summary>
    /// Fraction of a table's rows that must be inserted before autovacuum runs. Helps vacuum insert-heavy, rarely-updated tables.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_vacuum_insert_scale_factor")]
    public AutovacuumVacuumInsertScaleFactor? AutovacuumVacuumInsertScaleFactor { get; init; }

    /// <summary>
    /// Cost-accounting limit shared across all autovacuum workers before they pause. Use -1 to inherit vacuum_cost_limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_vacuum_cost_limit")]
    public AutovacuumVacuumCostLimit? AutovacuumVacuumCostLimit { get; init; }

    /// <summary>
    /// Time autovacuum sleeps when the cost limit is reached. Lower values speed up vacuuming at the cost of more I/O.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autovacuum_vacuum_cost_delay")]
    public AutovacuumVacuumCostDelay? AutovacuumVacuumCostDelay { get; init; }
}
