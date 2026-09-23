
# Postgres Slow Query Pattern

*This model accepts additional fields of type object.*

## Structure

`PostgresSlowQueryPattern`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QueryId` | `string` | Required | Stable identifier for the query pattern (normalized SQL). |
| `QueryText` | `string` | Required | Normalized query text with literals replaced by placeholders. |
| `DbName` | `string` | Required | Database the query ran in. |
| `DbUser` | `string` | Required | Database user that executed the query. |
| `DbOperation` | `string` | Required | Top-level SQL operation type (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY). |
| `App` | `string` | Required | Value of the Postgres `application_name` for executions matching this pattern. |
| `CallCount` | `int` | Required | Number of times the pattern executed in the window. |
| `ErrorCount` | `int` | Required | Number of executions of the pattern that raised an error. |
| `TotalDurationUs` | `int` | Required | Total execution time across all calls, in microseconds. |
| `AvgDurationUs` | `int` | Required | Average execution time per call, in microseconds. |
| `MaxDurationUs` | `int` | Required | Maximum execution time of any call, in microseconds. |
| `P50DurationUs` | `int` | Required | 50th percentile execution time, in microseconds. |
| `P95DurationUs` | `int` | Required | 95th percentile execution time, in microseconds. |
| `P99DurationUs` | `int` | Required | 99th percentile execution time, in microseconds. |
| `TotalRows` | `int` | Required | Total number of rows returned or affected across all calls. |
| `TotalSharedBlksRead` | `int` | Required | Total shared buffer blocks read from disk (cache misses) across all calls. |
| `TotalSharedBlksHit` | `int` | Required | Total shared buffer blocks hit (cache hits) across all calls. |
| `TotalCpuTimeUs` | `int` | Required | Total CPU time across all calls, in microseconds. |
| `TotalWalBytes` | `int` | Required | Total WAL (write-ahead log) bytes generated across all calls. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PostgresSlowQueryPattern postgresSlowQueryPattern = new PostgresSlowQueryPattern
{
    QueryId = "queryId8",
    QueryText = "queryText2",
    DbName = "dbName0",
    DbUser = "dbUser4",
    DbOperation = "dbOperation4",
    App = "app0",
    CallCount = 152,
    ErrorCount = 158,
    TotalDurationUs = 82,
    AvgDurationUs = 0,
    MaxDurationUs = 222,
    P50DurationUs = 206,
    P95DurationUs = 72,
    P99DurationUs = 146,
    TotalRows = 8,
    TotalSharedBlksRead = 98,
    TotalSharedBlksHit = 244,
    TotalCpuTimeUs = 242,
    TotalWalBytes = 0,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

