
# Service State Patch Request

*This model accepts additional fields of type object.*

## Structure

`ServiceStatePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | [`Command1?`](../../doc/models/command-1.md) | Optional | Command to change the state: 'start', 'stop', 'awake'. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceStatePatchRequest serviceStatePatchRequest = new ServiceStatePatchRequest
{
    Command = Command1.Start,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

