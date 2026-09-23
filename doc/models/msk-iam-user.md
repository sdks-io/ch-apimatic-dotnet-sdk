
# Msk Iam User

*This model accepts additional fields of type object.*

## Structure

`MskIamUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyId` | `string` | Optional | IAM access key ID. |
| `SecretKey` | `string` | Optional | IAM secret key. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

MskIamUser mskIamUser = new MskIamUser
{
    AccessKeyId = "accessKeyId2",
    SecretKey = "secretKey0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

