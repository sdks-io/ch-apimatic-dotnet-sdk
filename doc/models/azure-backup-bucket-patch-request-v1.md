
# Azure Backup Bucket Patch Request V1

*This model accepts additional fields of type object.*

## Structure

`AzureBackupBucketPatchRequestV1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider2?`](../../doc/models/bucket-provider-2.md) | Optional | Bucket provider |
| `ContainerName` | `string` | Optional | Container Name |
| `ConnectionString` | `string` | Optional | Connection String |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AzureBackupBucketPatchRequestV1 azureBackupBucketPatchRequestV1 = new AzureBackupBucketPatchRequestV1
{
    BucketProvider = BucketProvider2.Azure,
    ContainerName = "containerName6",
    ConnectionString = "connectionString6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

