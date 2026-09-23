
# Click Pipe Patch Pub Sub Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchPubSubSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Authentication` | [`Authentication17?`](../../doc/models/authentication-17.md) | Required | Authentication method to use with GCP Pub/Sub. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. |
| `AckDeadline` | `int?` | Optional | Acknowledgement deadline for messages, in seconds. Must be between 10 and 600.<br><br>**Constraints**: `>= 10`, `<= 600` |
| `ServiceAccountKey` | [`ServiceAccount`](../../doc/models/service-account.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchPubSubSource clickPipePatchPubSubSource = new ClickPipePatchPubSubSource
{
    Authentication = Authentication17.ServiceAccount,
    AckDeadline = 56,
    ServiceAccountKey = new ServiceAccount
    {
        ServiceAccountFile = "serviceAccountFile8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

