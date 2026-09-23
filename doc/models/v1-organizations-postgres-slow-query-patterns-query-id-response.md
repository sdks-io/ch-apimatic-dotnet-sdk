
# V1 Organizations Postgres Slow Query Patterns Query Id Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`PostgresSlowQueryPatternDetail`](../../doc/models/postgres-slow-query-pattern-detail.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse v1OrganizationsPostgresSlowQueryPatternsQueryIdResponse = new V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse
{
    Status = 200,
    RequestId = new Guid("00000890-0000-0000-0000-000000000000"),
    Result = new PostgresSlowQueryPatternDetail
    {
        RecentExecutions = new List<PostgresQueryExecution>
        {
            new PostgresQueryExecution
            {
                Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                    provider: CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind),
                QueryId = "queryId0",
                DbName = "dbName2",
                DbUser = "dbUser6",
                DbOperation = "dbOperation6",
                App = "app8",
                QueryText = "queryText4",
                Pid = "pid6",
                DurationUs = 80,
                Rows = 106,
                SharedBlksHit = 58,
                SharedBlksRead = 40,
                SharedBlksWritten = 56,
                SharedBlksDirtied = 244,
                SharedBlkReadTimeUs = 64,
                SharedBlkWriteTimeUs = 24,
                LocalBlksHit = 38,
                LocalBlksRead = 204,
                LocalBlksWritten = 130,
                LocalBlksDirtied = 14,
                TempBlksRead = 210,
                TempBlksWritten = 12,
                TempBlkReadTimeUs = 72,
                TempBlkWriteTimeUs = 206,
                WalRecords = 126,
                WalBytes = 92,
                WalFpi = 10,
                CpuUserTimeUs = 216,
                CpuSysTimeUs = 42,
                JitFunctions = 252,
                JitGenerationTimeUs = 204,
                JitInliningTimeUs = 162,
                JitOptimizationTimeUs = 4,
                JitEmissionTimeUs = 20,
                JitDeformTimeUs = 138,
                ParallelWorkersPlanned = 186,
                ParallelWorkersLaunched = 10,
                ServerRole = "serverRole6",
                ErrMessage = "errMessage0",
                ErrSqlstate = "errSqlstate6",
                ErrElevel = 202,
                TraceId = "traceId6",
                SpanId = "spanId8",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new PostgresQueryExecution
            {
                Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                    provider: CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind),
                QueryId = "queryId0",
                DbName = "dbName2",
                DbUser = "dbUser6",
                DbOperation = "dbOperation6",
                App = "app8",
                QueryText = "queryText4",
                Pid = "pid6",
                DurationUs = 80,
                Rows = 106,
                SharedBlksHit = 58,
                SharedBlksRead = 40,
                SharedBlksWritten = 56,
                SharedBlksDirtied = 244,
                SharedBlkReadTimeUs = 64,
                SharedBlkWriteTimeUs = 24,
                LocalBlksHit = 38,
                LocalBlksRead = 204,
                LocalBlksWritten = 130,
                LocalBlksDirtied = 14,
                TempBlksRead = 210,
                TempBlksWritten = 12,
                TempBlkReadTimeUs = 72,
                TempBlkWriteTimeUs = 206,
                WalRecords = 126,
                WalBytes = 92,
                WalFpi = 10,
                CpuUserTimeUs = 216,
                CpuSysTimeUs = 42,
                JitFunctions = 252,
                JitGenerationTimeUs = 204,
                JitInliningTimeUs = 162,
                JitOptimizationTimeUs = 4,
                JitEmissionTimeUs = 20,
                JitDeformTimeUs = 138,
                ParallelWorkersPlanned = 186,
                ParallelWorkersLaunched = 10,
                ServerRole = "serverRole6",
                ErrMessage = "errMessage0",
                ErrSqlstate = "errSqlstate6",
                ErrElevel = 202,
                TraceId = "traceId6",
                SpanId = "spanId8",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        Aggregate = new PostgresSlowQueryPattern
        {
            QueryId = "queryId8",
            QueryText = "queryText2",
            DbName = "dbName0",
            DbUser = "dbUser4",
            DbOperation = "dbOperation4",
            App = "app0",
            CallCount = 40,
            ErrorCount = 46,
            TotalDurationUs = 226,
            AvgDurationUs = 144,
            MaxDurationUs = 146,
            P50DurationUs = 94,
            P95DurationUs = 216,
            P99DurationUs = 34,
            TotalRows = 152,
            TotalSharedBlksRead = 14,
            TotalSharedBlksHit = 132,
            TotalCpuTimeUs = 130,
            TotalWalBytes = 144,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

