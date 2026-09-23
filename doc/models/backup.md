
# Backup

*This model accepts additional fields of type object.*

## Structure

`Backup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique backup ID. |
| `Status` | [`Status1?`](../../doc/models/status-1.md) | Optional | Status of the backup: 'done', 'error', 'in_progress'. |
| `ServiceId` | `string` | Optional | Name |
| `StartedAt` | `DateTime?` | Optional | Backup start timestamp. ISO-8601. |
| `FinishedAt` | `DateTime?` | Optional | Backup finish timestamp. ISO-8601. Available only for finished backups |
| `SizeInBytes` | `double?` | Optional | Size of the backup in bytes. |
| `DurationInSeconds` | `double?` | Optional | Time in seconds it took to perform the backup. If the status still in_progress, this is the time in seconds since the backup started until now. |
| `Type` | [`Type13?`](../../doc/models/type-13.md) | Optional | Backup type ("full" or "incremental"). |
| `BackupName` | `string` | Optional | Backup name on the external backup bucket. |
| `Bucket` | [`BackupBucket`](../../doc/models/containers/backup-bucket.md) | Optional | This is a container for one-of cases. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

Backup backup = new Backup
{
    Id = new Guid("000009d0-0000-0000-0000-000000000000"),
    Status = Status1.InProgress,
    ServiceId = "serviceId6",
    StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    FinishedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

