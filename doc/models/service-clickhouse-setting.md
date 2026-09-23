
# Service Clickhouse Setting

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the setting. |
| `MValue` | [`ServiceClickhouseSettingValue`](../../doc/models/containers/service-clickhouse-setting-value.md) | Optional | Setting value in its native JSON type. Use the settings schema endpoint for per-setting constraints. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceClickhouseSetting serviceClickhouseSetting = new ServiceClickhouseSetting
{
    Name = "compatibility",
    MValue = ServiceClickhouseSettingValue.FromString("String9"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

