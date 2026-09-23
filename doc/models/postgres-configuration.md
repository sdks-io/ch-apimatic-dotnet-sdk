
# Postgres Configuration

Postgres [runtime configuration](https://www.postgresql.org/docs/current/runtime-config.html) configuration.

## Structure

`PostgresConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxConnections` | [`PostgresConfigurationMaxConnections`](../../doc/models/containers/postgres-configuration-max-connections.md) | Optional | This is a container for one-of cases. |
| `DefaultTransactionIsolation` | [`DefaultTransactionIsolation?`](../../doc/models/default-transaction-isolation.md) | Optional | Sets the default transaction isolation level for new transactions.<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/default_transaction_isolation/](https://postgresqlco.nf/doc/en/param/default_transaction_isolation/)<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/default_transaction_isolation/](https://postgresqlco.nf/doc/en/param/default_transaction_isolation/) |
| `SslMinProtocolVersion` | [`SslMinProtocolVersion?`](../../doc/models/ssl-min-protocol-version.md) | Optional | Sets the minimum SSL/TLS protocol version allowed for client connections.<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/](https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/)<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/](https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/) |
| `MaintenanceWorkMem` | [`PostgresConfigurationMaintenanceWorkMem`](../../doc/models/containers/postgres-configuration-maintenance-work-mem.md) | Optional | This is a container for one-of cases. |
| `WorkMem` | [`PostgresConfigurationWorkMem`](../../doc/models/containers/postgres-configuration-work-mem.md) | Optional | This is a container for one-of cases. |
| `EffectiveCacheSize` | [`PostgresConfigurationEffectiveCacheSize`](../../doc/models/containers/postgres-configuration-effective-cache-size.md) | Optional | This is a container for one-of cases. |
| `RandomPageCost` | [`PostgresConfigurationRandomPageCost`](../../doc/models/containers/postgres-configuration-random-page-cost.md) | Optional | This is a container for one-of cases. |
| `EffectiveIoConcurrency` | [`PostgresConfigurationEffectiveIoConcurrency`](../../doc/models/containers/postgres-configuration-effective-io-concurrency.md) | Optional | This is a container for one-of cases. |
| `MaxWorkerProcesses` | [`PostgresConfigurationMaxWorkerProcesses`](../../doc/models/containers/postgres-configuration-max-worker-processes.md) | Optional | This is a container for one-of cases. |
| `MaxParallelWorkers` | [`PostgresConfigurationMaxParallelWorkers`](../../doc/models/containers/postgres-configuration-max-parallel-workers.md) | Optional | This is a container for one-of cases. |
| `MaxParallelWorkersPerGather` | [`PostgresConfigurationMaxParallelWorkersPerGather`](../../doc/models/containers/postgres-configuration-max-parallel-workers-per-gather.md) | Optional | This is a container for one-of cases. |
| `MaxParallelMaintenanceWorkers` | [`PostgresConfigurationMaxParallelMaintenanceWorkers`](../../doc/models/containers/postgres-configuration-max-parallel-maintenance-workers.md) | Optional | This is a container for one-of cases. |
| `StatementTimeout` | [`PostgresConfigurationStatementTimeout`](../../doc/models/containers/postgres-configuration-statement-timeout.md) | Optional | This is a container for one-of cases. |
| `LockTimeout` | [`PostgresConfigurationLockTimeout`](../../doc/models/containers/postgres-configuration-lock-timeout.md) | Optional | This is a container for one-of cases. |
| `IdleSessionTimeout` | [`PostgresConfigurationIdleSessionTimeout`](../../doc/models/containers/postgres-configuration-idle-session-timeout.md) | Optional | This is a container for one-of cases. |
| `IdleInTransactionSessionTimeout` | [`PostgresConfigurationIdleInTransactionSessionTimeout`](../../doc/models/containers/postgres-configuration-idle-in-transaction-session-timeout.md) | Optional | This is a container for one-of cases. |
| `TransactionTimeout` | [`PostgresConfigurationTransactionTimeout`](../../doc/models/containers/postgres-configuration-transaction-timeout.md) | Optional | This is a container for one-of cases. |
| `WalSenderTimeout` | [`PostgresConfigurationWalSenderTimeout`](../../doc/models/containers/postgres-configuration-wal-sender-timeout.md) | Optional | This is a container for one-of cases. |
| `WalKeepSize` | [`PostgresConfigurationWalKeepSize`](../../doc/models/containers/postgres-configuration-wal-keep-size.md) | Optional | This is a container for one-of cases. |
| `MinWalSize` | [`PostgresConfigurationMinWalSize`](../../doc/models/containers/postgres-configuration-min-wal-size.md) | Optional | This is a container for one-of cases. |
| `MaxWalSize` | [`PostgresConfigurationMaxWalSize`](../../doc/models/containers/postgres-configuration-max-wal-size.md) | Optional | This is a container for one-of cases. |
| `MaxSlotWalKeepSize` | [`PostgresConfigurationMaxSlotWalKeepSize`](../../doc/models/containers/postgres-configuration-max-slot-wal-keep-size.md) | Optional | This is a container for one-of cases. |
| `WalCompression` | [`WalCompression?`](../../doc/models/wal-compression.md) | Optional | Compress full-page writes in WAL. Reduces I/O at the cost of CPU. Options vary by PostgreSQL version.<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/wal_compression/](https://postgresqlco.nf/doc/en/param/wal_compression/)<br><br>Find out more here: [https://postgresqlco.nf/doc/en/param/wal_compression/](https://postgresqlco.nf/doc/en/param/wal_compression/) |
| `AutovacuumMaxWorkers` | [`PostgresConfigurationAutovacuumMaxWorkers`](../../doc/models/containers/postgres-configuration-autovacuum-max-workers.md) | Optional | This is a container for one-of cases. |
| `AutovacuumNaptime` | [`PostgresConfigurationAutovacuumNaptime`](../../doc/models/containers/postgres-configuration-autovacuum-naptime.md) | Optional | This is a container for one-of cases. |
| `AutovacuumWorkMem` | [`PostgresConfigurationAutovacuumWorkMem`](../../doc/models/containers/postgres-configuration-autovacuum-work-mem.md) | Optional | This is a container for one-of cases. |
| `AutovacuumVacuumScaleFactor` | [`PostgresConfigurationAutovacuumVacuumScaleFactor`](../../doc/models/containers/postgres-configuration-autovacuum-vacuum-scale-factor.md) | Optional | This is a container for one-of cases. |
| `AutovacuumAnalyzeScaleFactor` | [`PostgresConfigurationAutovacuumAnalyzeScaleFactor`](../../doc/models/containers/postgres-configuration-autovacuum-analyze-scale-factor.md) | Optional | This is a container for one-of cases. |
| `AutovacuumVacuumInsertScaleFactor` | [`PostgresConfigurationAutovacuumVacuumInsertScaleFactor`](../../doc/models/containers/postgres-configuration-autovacuum-vacuum-insert-scale-factor.md) | Optional | This is a container for one-of cases. |
| `AutovacuumVacuumCostLimit` | [`PostgresConfigurationAutovacuumVacuumCostLimit`](../../doc/models/containers/postgres-configuration-autovacuum-vacuum-cost-limit.md) | Optional | This is a container for one-of cases. |
| `AutovacuumVacuumCostDelay` | [`PostgresConfigurationAutovacuumVacuumCostDelay`](../../doc/models/containers/postgres-configuration-autovacuum-vacuum-cost-delay.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;

PostgresConfiguration postgresConfiguration = new PostgresConfiguration
{
    MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
};
```

