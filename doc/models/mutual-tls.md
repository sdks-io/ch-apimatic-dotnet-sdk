
# Mutual Tls

*This model accepts additional fields of type object.*

## Structure

`MutualTls`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Certificate` | `string` | Optional | PEM encoded client certificate for mTLS authentication. |
| `PrivateKey` | `string` | Optional | PEM encoded client private key for mTLS authentication. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

MutualTls mutualTls = new MutualTls
{
    Certificate = "certificate2",
    PrivateKey = "privateKey2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

