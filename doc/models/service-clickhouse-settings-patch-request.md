
# Service Clickhouse Settings Patch Request

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingsPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Settings` | [`Dictionary<string, ServiceClickhouseSettingValue>`](../../doc/models/containers/service-clickhouse-setting-value.md) | Required | Setting value in its native JSON type. Use the settings schema endpoint for per-setting constraints. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceClickhouseSettingsPatchRequest serviceClickhouseSettingsPatchRequest = new ServiceClickhouseSettingsPatchRequest
{
    Settings = new Dictionary<string, ServiceClickhouseSettingValue>
    {
        ["compatibility"] = ServiceClickhouseSettingValue.FromString("26.2"),
        ["max_query_size"] = ServiceClickhouseSettingValue.FromNumber(262144),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

