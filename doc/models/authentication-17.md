
# Authentication 17

Authentication method to use with GCP Pub/Sub. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.

## Enumeration

`Authentication17`

## Fields

| Name |
|  --- |
| `ServiceAccount` |
| `ServiceAccountWorkloadIdentity` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Authentication17 authentication17 = Authentication17.ServiceAccount;
```

