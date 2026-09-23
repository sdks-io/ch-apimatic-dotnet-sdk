
# Postgres Query Execution

*This model accepts additional fields of type object.*

## Structure

`PostgresQueryExecution`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime` | Required | Execution timestamp (RFC 3339). |
| `QueryId` | `string` | Required | Stable identifier for the query pattern. |
| `DbName` | `string` | Required | Database the query ran in. |
| `DbUser` | `string` | Required | Database user that executed the query. |
| `DbOperation` | `string` | Required | Top-level SQL operation type. |
| `App` | `string` | Required | Value of the Postgres `application_name` for this execution. |
| `QueryText` | `string` | Required | Normalized query text for this execution. |
| `Pid` | `string` | Required | Postgres backend process ID that executed the query. |
| `DurationUs` | `int` | Required | Execution duration in microseconds. |
| `Rows` | `int` | Required | Rows returned or affected. |
| `SharedBlksHit` | `int` | Required | Shared buffer blocks hit. |
| `SharedBlksRead` | `int` | Required | Shared buffer blocks read from disk. |
| `SharedBlksWritten` | `int` | Required | Shared buffer blocks written. |
| `SharedBlksDirtied` | `int` | Required | Shared buffer blocks dirtied. |
| `SharedBlkReadTimeUs` | `int` | Required | Time spent reading shared blocks, in microseconds. |
| `SharedBlkWriteTimeUs` | `int` | Required | Time spent writing shared blocks, in microseconds. |
| `LocalBlksHit` | `int` | Required | Local buffer blocks hit (temp tables). |
| `LocalBlksRead` | `int` | Required | Local buffer blocks read (temp tables). |
| `LocalBlksWritten` | `int` | Required | Local buffer blocks written (temp tables). |
| `LocalBlksDirtied` | `int` | Required | Local buffer blocks dirtied (temp tables). |
| `TempBlksRead` | `int` | Required | Temp blocks read (spills to disk). |
| `TempBlksWritten` | `int` | Required | Temp blocks written (spills to disk). |
| `TempBlkReadTimeUs` | `int` | Required | Time spent reading temp blocks, in microseconds. |
| `TempBlkWriteTimeUs` | `int` | Required | Time spent writing temp blocks, in microseconds. |
| `WalRecords` | `int` | Required | Number of WAL records produced. |
| `WalBytes` | `int` | Required | Number of WAL bytes produced. |
| `WalFpi` | `int` | Required | Number of WAL full-page images produced. |
| `CpuUserTimeUs` | `int` | Required | CPU time spent in user mode, in microseconds. |
| `CpuSysTimeUs` | `int` | Required | CPU time spent in kernel mode, in microseconds. |
| `JitFunctions` | `int` | Required | Number of JIT-compiled functions. |
| `JitGenerationTimeUs` | `int` | Required | JIT generation time, in microseconds. |
| `JitInliningTimeUs` | `int` | Required | JIT inlining time, in microseconds. |
| `JitOptimizationTimeUs` | `int` | Required | JIT optimization time, in microseconds. |
| `JitEmissionTimeUs` | `int` | Required | JIT emission time, in microseconds. |
| `JitDeformTimeUs` | `int` | Required | JIT deform time, in microseconds. |
| `ParallelWorkersPlanned` | `int` | Required | Parallel workers planned for this execution. |
| `ParallelWorkersLaunched` | `int` | Required | Parallel workers actually launched for this execution. |
| `ErrMessage` | `string` | Optional | Error message if the execution raised an error. |
| `ErrSqlstate` | `string` | Optional | Postgres SQLSTATE code if the execution raised an error. |
| `ErrElevel` | `int?` | Optional | Postgres error severity level if the execution raised an error. |
| `ServerRole` | `string` | Required | Role of the server that executed the query (for example, primary or standby). |
| `TraceId` | `string` | Optional | OpenTelemetry trace ID associated with the execution. |
| `SpanId` | `string` | Optional | OpenTelemetry span ID associated with the execution. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

PostgresQueryExecution postgresQueryExecution = new PostgresQueryExecution
{
    Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    QueryId = "queryId0",
    DbName = "dbName2",
    DbUser = "dbUser6",
    DbOperation = "dbOperation6",
    App = "app2",
    QueryText = "queryText4",
    Pid = "pid6",
    DurationUs = 234,
    Rows = 4,
    SharedBlksHit = 212,
    SharedBlksRead = 194,
    SharedBlksWritten = 210,
    SharedBlksDirtied = 142,
    SharedBlkReadTimeUs = 166,
    SharedBlkWriteTimeUs = 130,
    LocalBlksHit = 192,
    LocalBlksRead = 102,
    LocalBlksWritten = 232,
    LocalBlksDirtied = 168,
    TempBlksRead = 108,
    TempBlksWritten = 166,
    TempBlkReadTimeUs = 226,
    TempBlkWriteTimeUs = 104,
    WalRecords = 24,
    WalBytes = 246,
    WalFpi = 164,
    CpuUserTimeUs = 114,
    CpuSysTimeUs = 144,
    JitFunctions = 150,
    JitGenerationTimeUs = 102,
    JitInliningTimeUs = 60,
    JitOptimizationTimeUs = 106,
    JitEmissionTimeUs = 174,
    JitDeformTimeUs = 240,
    ParallelWorkersPlanned = 32,
    ParallelWorkersLaunched = 144,
    ServerRole = "serverRole6",
    ErrMessage = "errMessage0",
    ErrSqlstate = "errSqlstate6",
    ErrElevel = 48,
    TraceId = "traceId6",
    SpanId = "spanId8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

