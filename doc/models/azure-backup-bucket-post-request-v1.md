
# Azure Backup Bucket Post Request V1

*This model accepts additional fields of type object.*

## Structure

`AzureBackupBucketPostRequestV1`

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

AzureBackupBucketPostRequestV1 azureBackupBucketPostRequestV1 = new AzureBackupBucketPostRequestV1
{
    BucketProvider = BucketProvider2.Azure,
    ContainerName = "containerName2",
    ConnectionString = "connectionString0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

