
# Snapshot Configuration

*This model accepts additional fields of type object.*

## Structure

`SnapshotConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether scheduled snapshots are enabled for the service. |
| `Gap` | `double?` | Optional | Interval between snapshots, in minutes. Set together with timeFrame; only supported preset pairs are accepted. |
| `TimeFrame` | `double?` | Optional | Retention window the snapshots cover, in minutes. Set together with gap; only supported preset pairs are accepted. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

SnapshotConfiguration snapshotConfiguration = new SnapshotConfiguration
{
    Enabled = false,
    Gap = 142.68,
    TimeFrame = 235.14,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

