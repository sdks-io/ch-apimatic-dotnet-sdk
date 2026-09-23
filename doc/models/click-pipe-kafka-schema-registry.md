
# Click Pipe Kafka Schema Registry

*This model accepts additional fields of type object.*

## Structure

`ClickPipeKafkaSchemaRegistry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | Schema URL. HTTPS required. |
| `Authentication` | [`Authentication?`](../../doc/models/authentication.md) | Optional | Authentication type of the schema registry. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificates to validate the schema registry's certificate. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeKafkaSchemaRegistry clickPipeKafkaSchemaRegistry = new ClickPipeKafkaSchemaRegistry
{
    Url = "https://psrc-aa00.us-east-2.aws.confluent.cloud/schemas/ids/100004",
    Authentication = Authentication.Plain,
    CaCertificate = "caCertificate6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

