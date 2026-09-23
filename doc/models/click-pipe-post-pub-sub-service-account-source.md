
# Click Pipe Post Pub Sub Service Account Source

## Structure

`ClickPipePostPubSubServiceAccountSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Format` | [`Format6`](../../doc/models/format-6.md) | Required | Format of messages in the Pub/Sub topic. GCP Pub/Sub ClickPipes are in limited preview — contact support to enable this feature for your organization. |
| `ProjectId` | `string` | Required | GCP project ID that owns the Pub/Sub topic. |
| `Topic` | `string` | Required | Pub/Sub topic name (not the fully-qualified path). |
| `Authentication` | `string` | Required, Constant | Authenticate with a GCP service account JSON key.<br><br>**Value**: `"SERVICE_ACCOUNT"` |
| `SeekType` | [`SeekType`](../../doc/models/seek-type.md) | Required | Starting position strategy for consuming the subscription. The seekTimestamp companion is required only when seekType is "timestamp"; setting it for a mismatched seek type is rejected. |
| `SeekTimestamp` | `DateTime?` | Optional | RFC 3339 / ISO 8601 timestamp to seek to. Required when seekType is "timestamp"; must be omitted otherwise. |
| `Filter` | `string` | Optional | Optional Pub/Sub subscription filter expression (CEL). Maximum 256 characters.<br><br>**Constraints**: *Maximum Length*: `256` |
| `EnableOrdering` | `bool?` | Optional | Whether to enable ordered delivery of messages (requires messages to be published with ordering keys). |
| `AckDeadline` | `int?` | Optional | Acknowledgement deadline for messages, in seconds. Must be between 10 and 600.<br><br>**Constraints**: `>= 10`, `<= 600` |
| `ServiceAccountKey` | [`ServiceAccount`](../../doc/models/service-account.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ClickPipePostPubSubServiceAccountSource clickPipePostPubSubServiceAccountSource = new ClickPipePostPubSubServiceAccountSource
{
    Format = Format6.JsonEachRow,
    ProjectId = "my-gcp-project",
    Topic = "my-topic",
    Authentication = "SERVICE_ACCOUNT",
    SeekType = SeekType.Earliest,
    ServiceAccountKey = new ServiceAccount
    {
        ServiceAccountFile = "serviceAccountFile8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SeekTimestamp = DateTime.ParseExact("2026-04-10T12:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Filter = "filter4",
    EnableOrdering = false,
    AckDeadline = 206,
};
```

