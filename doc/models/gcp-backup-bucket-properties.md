
# Gcp Backup Bucket Properties

*This model accepts additional fields of type object.*

## Structure

`GcpBackupBucketProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider1?`](../../doc/models/bucket-provider-1.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `AccessKeyId` | `string` | Optional | Access Key ID (HMAC key) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

GcpBackupBucketProperties gcpBackupBucketProperties = new GcpBackupBucketProperties
{
    BucketProvider = BucketProvider1.Gcp,
    BucketPath = "bucketPath0",
    AccessKeyId = "accessKeyId4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

