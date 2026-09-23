
# Upgrade Window

*This model accepts additional fields of type object.*

## Structure

`UpgradeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Weekday` | `int` | Required | Day of the week the upgrade window starts. 0 = Sunday, 1 = Monday, …, 6 = Saturday.<br><br>**Constraints**: `>= 0`, `<= 6` |
| `StartHourUtc` | [`StartHourUtc`](../../doc/models/start-hour-utc.md) | Required | UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18. |
| `Duration` | `int` | Required, Constant | Length of the upgrade window in hours. Currently only a 6-hour window is supported.<br><br>**Value**: `6` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

UpgradeWindow upgradeWindow = new UpgradeWindow
{
    Weekday = 3,
    StartHourUtc = StartHourUtc.Hour12,
    Duration = 6,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

