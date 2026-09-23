
# Postgres Log Entry

*This model accepts additional fields of type object.*

## Structure

`PostgresLogEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime` | Required | Time the entry was logged (RFC 3339). |
| `Severity` | `string` | Required | PostgreSQL severity of the entry (for example, LOG, WARNING, ERROR, FATAL, PANIC). |
| `Body` | `string` | Required | Raw log entry body as emitted by PostgreSQL. Structured bodies are returned as a JSON-encoded string. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

PostgresLogEntry postgresLogEntry = new PostgresLogEntry
{
    Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Severity = "severity6",
    Body = "body2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

