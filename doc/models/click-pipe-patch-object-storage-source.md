
# Click Pipe Patch Object Storage Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchObjectStorageSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SkipInitialLoad` | `bool?` | Optional | If set to true, skips the initial load and only ingests files delivered by queue notifications. Only applicable when queueUrl is provided. |
| `StartAfter` | `string` | Optional | Skip all files up to and including this object key during the initial load. Cannot be provided when skipInitialLoad is true. |
| `Authentication` | [`Authentication8?`](../../doc/models/authentication-8.md) | Optional | Authentication method. IAM_USER is for S3, GCS, and DigitalOcean Spaces. IAM_ROLE is for S3 only. SERVICE_ACCOUNT is for GCS only. For GCS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. CONNECTION_STRING is for Azure Blob Storage. PUBLIC uses no authentication. |
| `IamRole` | `string` | Optional | IAM role to be used with IAM role authentication. Read more in ClickPipes documentation: https://clickhouse.com/docs/en/integrations/clickpipes/object-storage#authentication |
| `ConnectionString` | `string` | Optional | Connection string for Azure Blob Storage authentication. Required when authentication is CONNECTION_STRING. |
| `Path` | `string` | Optional | Path to the file(s) within the Azure container. Used for Azure Blob Storage sources. You can specify multiple files using bash-like wildcards. For more information, see the documentation on using wildcards in path: https://clickhouse.com/docs/en/integrations/clickpipes/object-storage#limitations |
| `AzureContainerName` | `string` | Optional | Container name for Azure Blob Storage. Required when type is azureblobstorage. |
| `AccessKey` | [`MskIamUser`](../../doc/models/msk-iam-user.md) | Optional | - |
| `ServiceAccountKey` | `string` | Optional | Base64-encoded GCP service account JSON key. Required when authentication is SERVICE_ACCOUNT. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchObjectStorageSource clickPipePatchObjectStorageSource = new ClickPipePatchObjectStorageSource
{
    SkipInitialLoad = false,
    StartAfter = "events/2026-06-01/",
    Authentication = Authentication8.ServiceAccount,
    IamRole = "arn:aws:iam::123456789012:role/MyRole",
    ConnectionString = "DefaultEndpointsProtocol=https;AccountName=myaccount;AccountKey=mykey;EndpointSuffix=core.windows.net",
    Path = "data/logs/*.json",
    AzureContainerName = "mycontainer",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

