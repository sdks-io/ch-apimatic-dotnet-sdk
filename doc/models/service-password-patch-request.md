
# Service Password Patch Request

*This model accepts additional fields of type object.*

## Structure

`ServicePasswordPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NewPasswordHash` | `string` | Optional | Optional password hash. Used to avoid password transmission over network. If not provided a new password is generated and is provided in the response. Otherwise this hash is used. Algorithm: echo -n "yourpassword" \| sha256sum \| tr -d '-' \| xxd -r -p \| base64 |
| `NewDoubleSha1Hash` | `string` | Optional | Optional double SHA1 password hash for MySQL protocol. If newPasswordHash is not provided this key will be ignored and the generated password will be used. Algorithm: echo -n "yourpassword" \| sha1sum \| tr -d '-' \| xxd -r -p \| sha1sum \| tr -d '-' |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServicePasswordPatchRequest servicePasswordPatchRequest = new ServicePasswordPatchRequest
{
    NewPasswordHash = "newPasswordHash8",
    NewDoubleSha1Hash = "newDoubleSha1Hash2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

