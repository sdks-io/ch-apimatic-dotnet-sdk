
# Service Clickhouse Settings Patch Response

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingsPatchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Settings` | [`Dictionary<string, ServiceClickhouseSettingValue>`](../../doc/models/containers/service-clickhouse-setting-value.md) | Optional | Setting value in its native JSON type. Use the settings schema endpoint for per-setting constraints. |
| `Warnings` | [`List<ServiceClickhouseSettingWarning>`](../../doc/models/service-clickhouse-setting-warning.md) | Optional | Warnings for settings that may have disruptive effects. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceClickhouseSettingsPatchResponse serviceClickhouseSettingsPatchResponse = new ServiceClickhouseSettingsPatchResponse
{
    Settings = new Dictionary<string, ServiceClickhouseSettingValue>
    {
        ["compatibility"] = ServiceClickhouseSettingValue.FromString("26.2"),
        ["max_query_size"] = ServiceClickhouseSettingValue.FromNumber(262144),
    },
    Warnings = new List<ServiceClickhouseSettingWarning>
    {
        new ServiceClickhouseSettingWarning
        {
            Name = "name4",
            Message = "message4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ServiceClickhouseSettingWarning
        {
            Name = "name4",
            Message = "message4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

