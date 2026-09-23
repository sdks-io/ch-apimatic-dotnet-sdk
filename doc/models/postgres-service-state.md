
# Postgres Service State

Current state of the service

## Enumeration

`PostgresServiceState`

## Fields

| Name |
|  --- |
| `Creating` |
| `Restarting` |
| `Running` |
| `ReplayingWal` |
| `RestoringBackup` |
| `FinalizingRestore` |
| `Unavailable` |
| `Stopped` |
| `Deleting` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

PostgresServiceState postgresServiceState = PostgresServiceState.Creating;
```

