
# Upgrade Window Put Request

*This model accepts additional fields of type object.*

## Structure

`UpgradeWindowPutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Weekday` | `int` | Required | Day of the week the upgrade window starts. 0 = Sunday, 1 = Monday, …, 6 = Saturday.<br><br>**Constraints**: `>= 0`, `<= 6` |
| `StartHourUtc` | [`StartHourUtc1`](../../doc/models/start-hour-utc-1.md) | Required | UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18. The upgrade window currently lasts 6 hours from this start time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

UpgradeWindowPutRequest upgradeWindowPutRequest = new UpgradeWindowPutRequest
{
    Weekday = 3,
    StartHourUtc = StartHourUtc1.Hour12,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

