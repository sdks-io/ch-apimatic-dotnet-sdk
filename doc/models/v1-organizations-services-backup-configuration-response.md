
# V1 Organizations Services Backup Configuration Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesBackupConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`BackupConfiguration`](../../doc/models/backup-configuration.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesBackupConfigurationResponse v1OrganizationsServicesBackupConfigurationResponse = new V1OrganizationsServicesBackupConfigurationResponse
{
    Status = 200,
    RequestId = new Guid("0000178c-0000-0000-0000-000000000000"),
    Result = new BackupConfiguration
    {
        BackupPeriodInHours = 97.04,
        BackupRetentionPeriodInHours = 142.88,
        BackupStartTime = "backupStartTime0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

