
# V1 Organizations Services Clickhouse Settings Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickhouseSettingsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceClickhouseSettingsPatchResponse`](../../doc/models/service-clickhouse-settings-patch-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickhouseSettingsResponse1 v1OrganizationsServicesClickhouseSettingsResponse1 = new V1OrganizationsServicesClickhouseSettingsResponse1
{
    Status = 200,
    RequestId = new Guid("00000fd4-0000-0000-0000-000000000000"),
    Result = new ServiceClickhouseSettingsPatchResponse
    {
        Settings = new Dictionary<string, ServiceClickhouseSettingValue>
        {
            ["key0"] = ServiceClickhouseSettingValue.FromString("String9"),
            ["key1"] = ServiceClickhouseSettingValue.FromString("String0"),
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
            new ServiceClickhouseSettingWarning
            {
                Name = "name4",
                Message = "message4",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

