
# Click Pipe Kafka Schema Registry Credentials

*This model accepts additional fields of type object.*

## Structure

`ClickPipeKafkaSchemaRegistryCredentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Optional | Username for the schema registry. |
| `Password` | `string` | Optional | Password for the schema registry. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeKafkaSchemaRegistryCredentials clickPipeKafkaSchemaRegistryCredentials = new ClickPipeKafkaSchemaRegistryCredentials
{
    Username = "username2",
    Password = "password2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

