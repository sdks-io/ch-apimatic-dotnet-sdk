
# Azure Backup Bucket Properties

*This model accepts additional fields of type object.*

## Structure

`AzureBackupBucketProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BucketProvider` | [`BucketProvider2?`](../../doc/models/bucket-provider-2.md) | Optional | Bucket provider |
| `ContainerName` | `string` | Optional | Container Name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AzureBackupBucketProperties azureBackupBucketProperties = new AzureBackupBucketProperties
{
    BucketProvider = BucketProvider2.Azure,
    ContainerName = "containerName2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

