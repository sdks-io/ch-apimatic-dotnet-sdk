
# Service Clickhouse Settings List

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingsList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Settings` | [`List<ServiceClickhouseSetting>`](../../doc/models/service-clickhouse-setting.md) | Optional | List of ClickHouse settings with their current values. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceClickhouseSettingsList serviceClickhouseSettingsList = new ServiceClickhouseSettingsList
{
    Settings = new List<ServiceClickhouseSetting>
    {
        new ServiceClickhouseSetting
        {
            Name = "name8",
            MValue = ServiceClickhouseSettingValue.FromString("String1"),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

