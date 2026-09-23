
# Click Stack Session Source

*This model accepts additional fields of type object.*

## Structure

`ClickStackSessionSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique source ID. Server-generated; ignored if sent in create/update requests. |
| `Name` | `string` | Required | Display name for the source. |
| `Section` | `string` | Optional | Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together. |
| `Disabled` | `bool?` | Optional | When true, the source is hidden from source selectors in the UI. Defaults to false. |
| `Kind` | `string` | Required, Constant | Source kind discriminator. Must be "session" for session sources.<br><br>**Value**: `"session"` |
| `Connection` | `string` | Required | ID of the ClickHouse connection used by this source. |
| `From` | [`ClickStackSourceFrom`](../../doc/models/click-stack-source-from.md) | Required | - |
| `QuerySettings` | [`List<ClickStackQuerySetting>`](../../doc/models/click-stack-query-setting.md) | Optional | Optional ClickHouse query settings applied when querying this source. |
| `TimestampValueExpression` | `string` | Optional | DateTime column or expression that is part of your table's primary key. |
| `TraceSourceId` | `string` | Required | HyperDX Source for traces associated with sessions. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackSessionSource clickStackSessionSource = new ClickStackSessionSource
{
    Name = "Sessions",
    Kind = "session",
    Connection = "507f1f77bcf86cd799439012",
    From = new ClickStackSourceFrom
    {
        DatabaseName = "otel",
        TableName = "otel_logs",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TraceSourceId = "507f1f77bcf86cd799439021",
    Id = "507f1f77bcf86cd799439031",
    Section = "Billing",
    Disabled = false,
    QuerySettings = new List<ClickStackQuerySetting>
    {
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    TimestampValueExpression = "TimestampTime",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

