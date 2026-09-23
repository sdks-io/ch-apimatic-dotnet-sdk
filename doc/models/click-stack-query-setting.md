
# Click Stack Query Setting

*This model accepts additional fields of type object.*

## Structure

`ClickStackQuerySetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Setting` | `string` | Required | ClickHouse setting name |
| `MValue` | `string` | Required | Setting value |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackQuerySetting clickStackQuerySetting = new ClickStackQuerySetting
{
    Setting = "max_threads",
    MValue = "4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

