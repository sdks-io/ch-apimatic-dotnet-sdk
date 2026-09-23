
# Service Clickhouse Setting Schema Entry

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingSchemaEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the setting. |
| `Type` | `string` | Optional | Data type of the setting value. |
| `Description` | `string` | Optional | Description of the setting. |
| `Enum` | `List<int>` | Optional | List of allowed values, if the setting is an enum. |
| `Warning` | `string` | Optional | Warning message about potential disruptive effects of changing this setting. |
| `DeprecationNotice` | `string` | Optional | Deprecation notice, if applicable. |
| `Example` | `string` | Optional | Example value for the setting. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceClickhouseSettingSchemaEntry serviceClickhouseSettingSchemaEntry = new ServiceClickhouseSettingSchemaEntry
{
    Name = "compatibility",
    Type = "string",
    Description = "ClickHouse version compatibility setting.",
    MEnum = new List<int>
    {
        0,
        1,
    },
    Warning = "Changing this setting without comprehensive testing can cause instability.",
    DeprecationNotice = "This setting may become obsolete with Cloud v2 stateless workers.",
    Example = "24.8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

