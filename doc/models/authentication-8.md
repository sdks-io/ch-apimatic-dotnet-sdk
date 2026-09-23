
# Authentication 8

Authentication method. IAM_USER is for S3, GCS, and DigitalOcean Spaces. IAM_ROLE is for S3 only. SERVICE_ACCOUNT is for GCS only. For GCS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. CONNECTION_STRING is for Azure Blob Storage. PUBLIC uses no authentication.

## Enumeration

`Authentication8`

## Fields

| Name |
|  --- |
| `IamRole` |
| `IamUser` |
| `ConnectionString` |
| `ServiceAccount` |
| `ServiceAccountWorkloadIdentity` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Authentication8 authentication8 = Authentication8.ConnectionString;
```

