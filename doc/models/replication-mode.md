
# Replication Mode

Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot).

## Enumeration

`ReplicationMode`

## Fields

| Name |
|  --- |
| `Cdc` |
| `Snapshot` |
| `CdcOnly` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

ReplicationMode replicationMode = ReplicationMode.Snapshot;
```

