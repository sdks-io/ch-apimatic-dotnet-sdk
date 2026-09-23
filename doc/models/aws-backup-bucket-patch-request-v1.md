
# Aws Backup Bucket Patch Request V1

*This model accepts additional fields of type object.*

## Structure

`AwsBackupBucketPatchRequestV1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider?`](../../doc/models/bucket-provider.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `IamRoleArn` | `string` | Optional | AWS Role ARN |
| `IamRoleSessionName` | `string` | Optional | AWS IAM Role session name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AwsBackupBucketPatchRequestV1 awsBackupBucketPatchRequestV1 = new AwsBackupBucketPatchRequestV1
{
    BucketProvider = BucketProvider.Aws,
    BucketPath = "bucketPath4",
    IamRoleArn = "iamRoleArn0",
    IamRoleSessionName = "iamRoleSessionName2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

