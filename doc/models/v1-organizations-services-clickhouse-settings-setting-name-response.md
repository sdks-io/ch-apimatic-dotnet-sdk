
# V1 Organizations Services Clickhouse Settings Setting Name Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickhouseSettingsSettingNameResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceClickhouseSetting`](../../doc/models/service-clickhouse-setting.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickhouseSettingsSettingNameResponse v1OrganizationsServicesClickhouseSettingsSettingNameResponse = new V1OrganizationsServicesClickhouseSettingsSettingNameResponse
{
    Status = 200,
    RequestId = new Guid("00001cd2-0000-0000-0000-000000000000"),
    Result = new ServiceClickhouseSetting
    {
        Name = "name6",
        MValue = ServiceClickhouseSettingValue.FromString("String9"),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

