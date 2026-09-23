
# Click Pipes Gcp Workload Identity Context

*This model accepts additional fields of type object.*

## Structure

`ClickPipesGcpWorkloadIdentityContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Supported` | `bool?` | Optional | Whether the ClickPipes deployment supports GCP workload identity, which is in Private Preview. The principal field identifies the GCP service account used for source access. |
| `Ready` | `bool?` | Optional | Whether the service tenant identity is ready for workload identity authentication. |
| `Principal` | `string` | Optional | GCP service account used by ClickPipes for workload identity authentication. Grant this service account access to customer source resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipesGcpWorkloadIdentityContext clickPipesGcpWorkloadIdentityContext = new ClickPipesGcpWorkloadIdentityContext
{
    Supported = false,
    Ready = false,
    Principal = "ch-deadbeef@clickpipes-development.iam.gserviceaccount.com",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

