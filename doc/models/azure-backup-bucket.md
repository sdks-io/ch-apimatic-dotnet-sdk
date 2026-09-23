
# Azure Backup Bucket

*This model accepts additional fields of type object.*

## Structure

`AzureBackupBucket`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique backup bucket ID. |
| `BucketProvider` | [`BucketProvider2?`](../../doc/models/bucket-provider-2.md) | Optional | Bucket provider |
| `ContainerName` | `string` | Optional | Container Name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AzureBackupBucket azureBackupBucket = new AzureBackupBucket
{
    Id = new Guid("00000204-0000-0000-0000-000000000000"),
    BucketProvider = BucketProvider2.Azure,
    ContainerName = "containerName0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

