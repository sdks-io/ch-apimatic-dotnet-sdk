
# Click Stack Dashboard Container Tab

*This model accepts additional fields of type object.*

## Structure

`ClickStackDashboardContainerTab`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique identifier for the tab within its container. |
| `Title` | `string` | Required | Display title for the tab. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackDashboardContainerTab clickStackDashboardContainerTab = new ClickStackDashboardContainerTab
{
    Id = "errors",
    Title = "Errors",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

