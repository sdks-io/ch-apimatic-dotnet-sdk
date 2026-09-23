
# Gcp Backup Bucket Post Request V1

*This model accepts additional fields of type object.*

## Structure

`GcpBackupBucketPostRequestV1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider1?`](../../doc/models/bucket-provider-1.md) | Optional | Bucket provider |
| `BucketPath` | `string` | Optional | Bucket path |
| `AccessKeyId` | `string` | Optional | Access Key ID (HMAC key) |
| `SecretAccessKey` | `string` | Optional | Secret Access Key (HMAC secret key) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

GcpBackupBucketPostRequestV1 gcpBackupBucketPostRequestV1 = new GcpBackupBucketPostRequestV1
{
    BucketProvider = BucketProvider1.Gcp,
    BucketPath = "bucketPath8",
    AccessKeyId = "accessKeyId2",
    SecretAccessKey = "secretAccessKey6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

