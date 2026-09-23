
# V1 Organizations Services Backup Bucket Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesBackupBucketResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`BackupBucket2`](../../doc/models/containers/backup-bucket-2.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesBackupBucketResponse v1OrganizationsServicesBackupBucketResponse = new V1OrganizationsServicesBackupBucketResponse
{
    Status = 200,
    RequestId = new Guid("00001a9e-0000-0000-0000-000000000000"),
    Result = BackupBucket2.FromAwsBackupBucket(
        new AwsBackupBucket
        {
            Id = new Guid("00001a3e-0000-0000-0000-000000000000"),
            BucketProvider = BucketProvider.Aws,
            BucketPath = "bucketPath0",
            IamRoleArn = "iamRoleArn6",
            IamRoleSessionName = "iamRoleSessionName8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

