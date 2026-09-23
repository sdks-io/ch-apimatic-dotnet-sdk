
# V1 Organizations Services Clickhouse Settings Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickhouseSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceClickhouseSettingsList`](../../doc/models/service-clickhouse-settings-list.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickhouseSettingsResponse v1OrganizationsServicesClickhouseSettingsResponse = new V1OrganizationsServicesClickhouseSettingsResponse
{
    Status = 200,
    RequestId = new Guid("000008c8-0000-0000-0000-000000000000"),
    Result = new ServiceClickhouseSettingsList
    {
        Settings = new List<ServiceClickhouseSetting>
        {
            new ServiceClickhouseSetting
            {
                Name = "name8",
                MValue = ServiceClickhouseSettingValue.FromString("String1"),
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ServiceClickhouseSetting
            {
                Name = "name8",
                MValue = ServiceClickhouseSettingValue.FromString("String1"),
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

