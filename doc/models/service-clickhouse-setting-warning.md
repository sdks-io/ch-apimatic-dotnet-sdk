
# Service Clickhouse Setting Warning

*This model accepts additional fields of type object.*

## Structure

`ServiceClickhouseSettingWarning`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the setting the warning applies to. |
| `Message` | `string` | Optional | Warning message. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceClickhouseSettingWarning serviceClickhouseSettingWarning = new ServiceClickhouseSettingWarning
{
    Name = "compatibility",
    Message = "Changing the compatibility version without comprehensive testing can cause query failures or instability.",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

