
# V1 Organizations Services Clickhouse Settings Schema Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickhouseSettingsSchemaResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceClickhouseSettingsSchema`](../../doc/models/service-clickhouse-settings-schema.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickhouseSettingsSchemaResponse v1OrganizationsServicesClickhouseSettingsSchemaResponse = new V1OrganizationsServicesClickhouseSettingsSchemaResponse
{
    Status = 200,
    RequestId = new Guid("000002c0-0000-0000-0000-000000000000"),
    Result = new ServiceClickhouseSettingsSchema
    {
        Settings = new List<ServiceClickhouseSettingSchemaEntry>
        {
            new ServiceClickhouseSettingSchemaEntry
            {
                Name = "name8",
                Type = "type2",
                Description = "description8",
                MEnum = new List<int>
                {
                    234,
                },
                Warning = "warning6",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ServiceClickhouseSettingSchemaEntry
            {
                Name = "name8",
                Type = "type2",
                Description = "description8",
                MEnum = new List<int>
                {
                    234,
                },
                Warning = "warning6",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

