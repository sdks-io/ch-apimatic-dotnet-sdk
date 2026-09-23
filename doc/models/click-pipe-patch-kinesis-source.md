
# Click Pipe Patch Kinesis Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchKinesisSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Authentication` | [`Authentication5?`](../../doc/models/authentication-5.md) | Optional | Authentication method to use with the Kinesis stream. |
| `IamRole` | `string` | Optional | IAM role to use for authentication. Required if IAM_ROLE is used. |
| `AccessKey` | [`MskIamUser`](../../doc/models/msk-iam-user.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchKinesisSource clickPipePatchKinesisSource = new ClickPipePatchKinesisSource
{
    Authentication = Authentication5.IamRole,
    IamRole = "arn:aws:iam::123456789012:role/MyRole",
    AccessKey = new MskIamUser
    {
        AccessKeyId = "accessKeyId8",
        SecretKey = "secretKey6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

