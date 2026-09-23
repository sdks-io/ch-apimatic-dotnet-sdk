
# Click Pipe Kinesis Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeKinesisSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Format` | [`Format2?`](../../doc/models/format-2.md) | Optional | Format of the Kinesis stream. |
| `StreamName` | `string` | Optional | Name of the Kinesis stream. |
| `Region` | `string` | Optional | AWS region of the Kinesis stream. |
| `UseEnhancedFanOut` | `bool?` | Optional | Use enhanced fan-out for the Kinesis stream. |
| `IteratorType` | [`IteratorType?`](../../doc/models/iterator-type.md) | Optional | Type of iterator to use when reading from the Kinesis stream. If AT_TIMESTAMP is used, the timestamp field must be provided. |
| `Timestamp` | `int?` | Optional | UNIX timestamp to start reading from the Kinesis stream. Required if iteratorType is AT_TIMESTAMP. |
| `Authentication` | [`Authentication5?`](../../doc/models/authentication-5.md) | Optional | Authentication method to use with the Kinesis stream. |
| `IamRole` | `string` | Optional | IAM role to use for authentication. Required if IAM_ROLE is used. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeKinesisSource clickPipeKinesisSource = new ClickPipeKinesisSource
{
    Format = Format2.AvroConfluent,
    StreamName = "my-stream",
    Region = "us-east-1",
    UseEnhancedFanOut = false,
    IteratorType = IteratorType.AtTimestamp,
    Timestamp = 1615766400,
    IamRole = "arn:aws:iam::123456789012:role/MyRole",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

