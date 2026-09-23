
# V1 Organizations Postgres Slow Query Patterns Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresSlowQueryPatternsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<PostgresSlowQueryPattern>`](../../doc/models/postgres-slow-query-pattern.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsPostgresSlowQueryPatternsResponse v1OrganizationsPostgresSlowQueryPatternsResponse = new V1OrganizationsPostgresSlowQueryPatternsResponse
{
    Status = 200,
    RequestId = new Guid("00000604-0000-0000-0000-000000000000"),
    Result = new List<PostgresSlowQueryPattern>
    {
        new PostgresSlowQueryPattern
        {
            QueryId = "queryId2",
            QueryText = "queryText6",
            DbName = "dbName4",
            DbUser = "dbUser8",
            DbOperation = "dbOperation8",
            App = "app6",
            CallCount = 50,
            ErrorCount = 56,
            TotalDurationUs = 236,
            AvgDurationUs = 154,
            MaxDurationUs = 120,
            P50DurationUs = 104,
            P95DurationUs = 226,
            P99DurationUs = 44,
            TotalRows = 162,
            TotalSharedBlksRead = 4,
            TotalSharedBlksHit = 142,
            TotalCpuTimeUs = 140,
            TotalWalBytes = 154,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new PostgresSlowQueryPattern
        {
            QueryId = "queryId2",
            QueryText = "queryText6",
            DbName = "dbName4",
            DbUser = "dbUser8",
            DbOperation = "dbOperation8",
            App = "app6",
            CallCount = 50,
            ErrorCount = 56,
            TotalDurationUs = 236,
            AvgDurationUs = 154,
            MaxDurationUs = 120,
            P50DurationUs = 104,
            P95DurationUs = 226,
            P99DurationUs = 44,
            TotalRows = 162,
            TotalSharedBlksRead = 4,
            TotalSharedBlksHit = 142,
            TotalCpuTimeUs = 140,
            TotalWalBytes = 154,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new PostgresSlowQueryPattern
        {
            QueryId = "queryId2",
            QueryText = "queryText6",
            DbName = "dbName4",
            DbUser = "dbUser8",
            DbOperation = "dbOperation8",
            App = "app6",
            CallCount = 50,
            ErrorCount = 56,
            TotalDurationUs = 236,
            AvgDurationUs = 154,
            MaxDurationUs = 120,
            P50DurationUs = 104,
            P95DurationUs = 226,
            P99DurationUs = 44,
            TotalRows = 162,
            TotalSharedBlksRead = 4,
            TotalSharedBlksHit = 142,
            TotalCpuTimeUs = 140,
            TotalWalBytes = 154,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

