
# Pg Ha Type

Type of high availability: “none” for no replication, “async” for asynchronous replication to a single standby, and “sync” for synchronous replication to two standbys.

## Enumeration

`PgHaType`

## Fields

| Name |
|  --- |
| `None` |
| `Async` |
| `Sync` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

PgHaType pgHaType = PgHaType.None;
```

