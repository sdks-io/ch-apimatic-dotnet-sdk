
# Aws Backup Bucket Post Request V1

*This model accepts additional fields of type object.*

## Structure

`AwsBackupBucketPostRequestV1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider?`](../../doc/models/bucket-provider.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `IamRoleArn` | `string` | Optional | AWS Role ARN |
| `IamRoleSessionName` | `string` | Optional | AWS Role session name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AwsBackupBucketPostRequestV1 awsBackupBucketPostRequestV1 = new AwsBackupBucketPostRequestV1
{
    BucketProvider = BucketProvider.Aws,
    BucketPath = "bucketPath2",
    IamRoleArn = "iamRoleArn8",
    IamRoleSessionName = "iamRoleSessionName0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

