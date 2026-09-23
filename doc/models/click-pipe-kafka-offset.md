
# Click Pipe Kafka Offset

*This model accepts additional fields of type object.*

## Structure

`ClickPipeKafkaOffset`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Strategy` | [`Strategy?`](../../doc/models/strategy.md) | Optional | Offset strategy. |
| `Timestamp` | `string` | Optional | A minute precision UTC timestamp to start from. Required for "from_timestamp" strategy. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeKafkaOffset clickPipeKafkaOffset = new ClickPipeKafkaOffset
{
    Strategy = Strategy.FromLatest,
    Timestamp = "2021-01-01T00:00",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

