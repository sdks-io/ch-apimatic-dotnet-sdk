
# Aws Backup Bucket

*This model accepts additional fields of type object.*

## Structure

`AwsBackupBucket`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique backup bucket ID |
| `BucketProvider` | [`BucketProvider?`](../../doc/models/bucket-provider.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `IamRoleArn` | `string` | Optional | AWS Role ARN |
| `IamRoleSessionName` | `string` | Optional | AWS  Role session name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AwsBackupBucket awsBackupBucket = new AwsBackupBucket
{
    Id = new Guid("00001b3a-0000-0000-0000-000000000000"),
    BucketProvider = BucketProvider.Aws,
    BucketPath = "bucketPath8",
    IamRoleArn = "iamRoleArn2",
    IamRoleSessionName = "iamRoleSessionName0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

