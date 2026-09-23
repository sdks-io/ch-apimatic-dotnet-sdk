
# Click Pipe State Patch Request

*This model accepts additional fields of type object.*

## Structure

`ClickPipeStatePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | [`Command2?`](../../doc/models/command-2.md) | Optional | Command to change the state: 'start', 'stop', 'resync'. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeStatePatchRequest clickPipeStatePatchRequest = new ClickPipeStatePatchRequest
{
    Command = Command2.Stop,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

