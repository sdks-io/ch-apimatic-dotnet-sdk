
# Click Stack Dashboard Container

*This model accepts additional fields of type object.*

## Structure

`ClickStackDashboardContainer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique identifier for the container within the dashboard. |
| `Title` | `string` | Required | Display title for the container. |
| `Collapsed` | `bool` | Required | Persisted default collapse state. Per-viewer state lives in the URL. |
| `Collapsible` | `bool?` | Optional | Whether the user can collapse the group. |
| `Bordered` | `bool?` | Optional | Whether to show a visual border around the group. |
| `Tabs` | [`List<ClickStackDashboardContainerTab>`](../../doc/models/click-stack-dashboard-container-tab.md) | Optional | Optional tabs. 2+ entries renders a tab bar; 0-1 entries renders a plain group header. Tiles join a tab via tabId. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackDashboardContainer clickStackDashboardContainer = new ClickStackDashboardContainer
{
    Id = "service-health",
    Title = "Service Health",
    Collapsed = false,
    Collapsible = true,
    Bordered = true,
    Tabs = new List<ClickStackDashboardContainerTab>
    {
        new ClickStackDashboardContainerTab
        {
            Id = "id8",
            Title = "title4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackDashboardContainerTab
        {
            Id = "id8",
            Title = "title4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

