
# Service Clickhouse Settings Schema

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingsSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Settings` | [`List<ServiceClickhouseSettingSchemaEntry>`](../../doc/models/service-clickhouse-setting-schema-entry.md) | Optional | List of all configurable ClickHouse settings with their types, descriptions, and constraints. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceClickhouseSettingsSchema serviceClickhouseSettingsSchema = new ServiceClickhouseSettingsSchema
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
};
```

