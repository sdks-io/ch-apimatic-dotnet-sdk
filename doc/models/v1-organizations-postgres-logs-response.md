
# V1 Organizations Postgres Logs Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPostgresLogsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<PostgresLogEntry>`](../../doc/models/postgres-log-entry.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsPostgresLogsResponse v1OrganizationsPostgresLogsResponse = new V1OrganizationsPostgresLogsResponse
{
    Status = 200,
    RequestId = new Guid("000001ee-0000-0000-0000-000000000000"),
    Result = new List<PostgresLogEntry>
    {
        new PostgresLogEntry
        {
            Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Severity = "severity6",
            Body = "body2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new PostgresLogEntry
        {
            Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Severity = "severity6",
            Body = "body2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new PostgresLogEntry
        {
            Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Severity = "severity6",
            Body = "body2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

