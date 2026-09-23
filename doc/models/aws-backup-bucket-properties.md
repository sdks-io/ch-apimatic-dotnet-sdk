
# Aws Backup Bucket Properties

*This model accepts additional fields of type object.*

## Structure

`AwsBackupBucketProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider?`](../../doc/models/bucket-provider.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `IamRoleArn` | `string` | Optional | AWS IAM Role |
| `IamRoleSessionName` | `string` | Optional | AWS IAM Role |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AwsBackupBucketProperties awsBackupBucketProperties = new AwsBackupBucketProperties
{
    BucketProvider = BucketProvider.Aws,
    BucketPath = "bucketPath6",
    IamRoleArn = "iamRoleArn8",
    IamRoleSessionName = "iamRoleSessionName4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

