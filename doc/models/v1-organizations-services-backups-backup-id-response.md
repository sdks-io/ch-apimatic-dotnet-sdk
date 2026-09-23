
# V1 Organizations Services Backups Backup Id Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesBackupsBackupIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`Backup`](../../doc/models/backup.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

V1OrganizationsServicesBackupsBackupIdResponse v1OrganizationsServicesBackupsBackupIdResponse = new V1OrganizationsServicesBackupsBackupIdResponse
{
    Status = 200,
    RequestId = new Guid("00002570-0000-0000-0000-000000000000"),
    Result = new Backup
    {
        Id = new Guid("000002b8-0000-0000-0000-000000000000"),
        Status = Status1.Done,
        ServiceId = "serviceId0",
        StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        FinishedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

