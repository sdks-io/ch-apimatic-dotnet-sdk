
# Click Pipe Mutate Kafka Schema Registry

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMutateKafkaSchemaRegistry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | Schema URL. HTTPS required. |
| `Authentication` | [`Authentication?`](../../doc/models/authentication.md) | Optional | Authentication type of the schema registry. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificates to validate the schema registry's certificate. |
| `Credentials` | [`ClickPipeKafkaSchemaRegistryCredentials`](../../doc/models/click-pipe-kafka-schema-registry-credentials.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeMutateKafkaSchemaRegistry clickPipeMutateKafkaSchemaRegistry = new ClickPipeMutateKafkaSchemaRegistry
{
    Url = "https://psrc-aa00.us-east-2.aws.confluent.cloud/schemas/ids/100004",
    Authentication = Authentication.Plain,
    CaCertificate = "caCertificate0",
    Credentials = new ClickPipeKafkaSchemaRegistryCredentials
    {
        Username = "username4",
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

