
# Api Key Hash Data

*This model accepts additional fields of type object.*

## Structure

`ApiKeyHashData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `KeyIdHash` | `string` | Optional | Hash of the key ID. |
| `KeyIdSuffix` | `string` | Optional | Last 4 digits of the key ID. Algorithm: echo -n "yourpassword" \| sha256sum \| tr -d '-' \| xxd -r -p \| base64 |
| `KeySecretHash` | `string` | Optional | Hash of the key secret. Algorithm: echo -n "yourpassword" \| sha256sum \| tr -d '-' \| xxd -r -p \| base64 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ApiKeyHashData apiKeyHashData = new ApiKeyHashData
{
    KeyIdHash = "keyIdHash6",
    KeyIdSuffix = "keyIdSuffix8",
    KeySecretHash = "keySecretHash0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

