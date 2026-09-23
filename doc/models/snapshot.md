
# Snapshot

*This model accepts additional fields of type object.*

## Structure

`Snapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique snapshot ID. |
| `Status` | [`Status2?`](../../doc/models/status-2.md) | Optional | Status of the snapshot: 'done', 'error', 'in_progress', 'throttled'. 'throttled' means snapshot creation was rate-limited and will be retried. |
| `ServiceId` | `string` | Optional | ID of the service the snapshot was created from. |
| `StartedAt` | `DateTime?` | Optional | Snapshot start timestamp. ISO-8601. |
| `FinishedAt` | `DateTime?` | Optional | Snapshot finish timestamp. ISO-8601. Available only for finished snapshots |
| `SizeInBytes` | `double?` | Optional | Size of the snapshot in bytes. |
| `DurationInSeconds` | `double?` | Optional | Time in seconds it took to perform the snapshot. If the status is in_progress or throttled, this is the time in seconds since the snapshot started until now. |
| `Type` | [`Type14?`](../../doc/models/type-14.md) | Optional | Snapshot type. Always "full" — snapshots never chain off a parent. |
| `BackupName` | `string` | Optional | Snapshot name on the external backup bucket. |
| `Bucket` | [`SnapshotBucket`](../../doc/models/containers/snapshot-bucket.md) | Optional | This is a container for one-of cases. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

Snapshot snapshot = new Snapshot
{
    Id = new Guid("00000ed6-0000-0000-0000-000000000000"),
    Status = Status2.InProgress,
    ServiceId = "serviceId2",
    StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    FinishedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

