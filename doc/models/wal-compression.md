
# Wal Compression

Compress full-page writes in WAL. Reduces I/O at the cost of CPU. Options vary by PostgreSQL version.

Find out more here: [https://postgresqlco.nf/doc/en/param/wal_compression/](https://postgresqlco.nf/doc/en/param/wal_compression/)

## Enumeration

`WalCompression`

## Fields

| Name |
|  --- |
| `Off` |
| `On` |
| `Lz4` |
| `Zstd` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

WalCompression walCompression = WalCompression.Lz4;
```

