
# Backup Configuration Patch Request

*This model accepts additional fields of type object.*

## Structure

`BackupConfigurationPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BackupPeriodInHours` | `double?` | Optional | The interval in hours between each backup. |
| `BackupRetentionPeriodInHours` | `double?` | Optional | The minimum duration in hours for which the backups are available. Must be a whole number of days between 24 (1 day) and 1080 (45 days) — i.e. a multiple of 24. |
| `BackupStartTime` | `string` | Optional | The time in HH:MM format for the backups to be performed (evaluated in UTC timezone). When defined the backup period resets to every 24 hours. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

BackupConfigurationPatchRequest backupConfigurationPatchRequest = new BackupConfigurationPatchRequest
{
    BackupPeriodInHours = 201.02,
    BackupRetentionPeriodInHours = 246.86,
    BackupStartTime = "backupStartTime8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

