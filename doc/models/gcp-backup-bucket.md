
# Gcp Backup Bucket

*This model accepts additional fields of type object.*

## Structure

`GcpBackupBucket`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique backup bucket ID |
| `BucketProvider` | [`BucketProvider1?`](../../doc/models/bucket-provider-1.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `AccessKeyId` | `string` | Optional | Access Key ID (HMAC key) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

GcpBackupBucket gcpBackupBucket = new GcpBackupBucket
{
    Id = new Guid("00001c3c-0000-0000-0000-000000000000"),
    BucketProvider = BucketProvider1.Gcp,
    BucketPath = "bucketPath0",
    AccessKeyId = "accessKeyId6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

