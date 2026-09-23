
# Click Stack Alert Response

*This model accepts additional fields of type object.*

## Structure

`ClickStackAlertResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DashboardId` | `string` | Optional | Dashboard ID for tile-based alerts. |
| `TileId` | `string` | Optional | Tile ID for tile-based alerts. Must be a line, stacked bar, or number type tile. |
| `SavedSearchId` | `string` | Optional | Saved search ID for saved_search alerts. |
| `GroupBy` | `string` | Optional | Group-by key for saved search alerts. |
| `Threshold` | `double?` | Optional | Threshold value for triggering the alert. For between and not_between threshold types, this is the lower bound. |
| `ThresholdMax` | `double?` | Optional | Upper bound for between and not_between threshold types. Required when thresholdType is between or not_between, must be >= threshold. |
| `Interval` | [`Interval?`](../../doc/models/interval.md) | Optional | Evaluation interval for the alert. `30s` requires the 30s alert interval feature to be enabled for your team. |
| `ScheduleOffsetMinutes` | `int?` | Optional | Offset from the interval boundary in minutes. For example, 2 with a 5m interval evaluates windows at :02, :07, :12, etc. (UTC). |
| `ScheduleStartAt` | `DateTime?` | Optional | Absolute UTC start time anchor. Alert windows start from this timestamp and repeat every interval. |
| `Source` | [`Source?`](../../doc/models/source.md) | Optional | Alert source type (tile-based or saved search). |
| `ThresholdType` | [`ThresholdType?`](../../doc/models/threshold-type.md) | Optional | Threshold comparison direction. |
| `Channel` | [`ClickStackAlertChannel`](../../doc/models/containers/click-stack-alert-channel.md) | Optional | - |
| `Channels` | [`List<ClickStackAlertChannel>`](../../doc/models/containers/click-stack-alert-channel.md) | Optional | Notification channels to trigger when the alert fires or resolves. Between 1 and 10 channels; duplicates are rejected.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `Name` | `string` | Optional | Human-friendly alert name. |
| `Message` | `string` | Optional | Alert message template. |
| `Note` | `string` | Optional | Freeform note for the alert. Supports markdown formatting. |
| `NumConsecutiveWindows` | `int?` | Optional | Fire the alert only after its condition has been met for this many consecutive evaluation windows. While the condition is met but fewer than this many consecutive windows have violated, the alert is in the PENDING state. |
| `Id` | `string` | Optional | Unique alert identifier. |
| `State` | [`State3?`](../../doc/models/state-3.md) | Optional | Current alert state. |
| `TeamId` | `string` | Optional | Team identifier. |
| `Silenced` | [`ClickStackAlertSilenced`](../../doc/models/click-stack-alert-silenced.md) | Optional | - |
| `ExecutionErrors` | [`List<ClickStackAlertExecutionError>`](../../doc/models/click-stack-alert-execution-error.md) | Optional | Errors recorded during the most recent alert execution, if any. |
| `CreatedAt` | `DateTime?` | Optional | Creation timestamp. |
| `UpdatedAt` | `DateTime?` | Optional | Last update timestamp. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickStackAlertResponse clickStackAlertResponse = new ClickStackAlertResponse
{
    DashboardId = "65f5e4a3b9e77c001a567890",
    TileId = "65f5e4a3b9e77c001a901234",
    SavedSearchId = "65f5e4a3b9e77c001a345678",
    GroupBy = "ServiceName",
    Threshold = 100,
    ThresholdMax = 500,
    Interval = Interval.Enum1H,
    ScheduleOffsetMinutes = 2,
    ScheduleStartAt = DateTime.ParseExact("2026-02-08T10:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Source = Source.Tile,
    ThresholdType = ThresholdType.Above,
    Name = "Test Alert",
    Message = "Test Alert Message",
    Note = "Threshold raised from 50 to 100 on 2026-01-15. See [runbook](https://wiki.example.com/runbook).",
    NumConsecutiveWindows = 3,
    Id = "65f5e4a3b9e77c001a123456",
    State = State3.Alert,
    TeamId = "65f5e4a3b9e77c001a345678",
    CreatedAt = DateTime.ParseExact("2023-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("2023-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

