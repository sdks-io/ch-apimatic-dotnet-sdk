
# Click Pipes Service Context

*This model accepts additional fields of type object.*

## Structure

`ClickPipesServiceContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GcpWorkloadIdentity` | [`ClickPipesGcpWorkloadIdentityContext`](../../doc/models/click-pipes-gcp-workload-identity-context.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipesServiceContext clickPipesServiceContext = new ClickPipesServiceContext
{
    GcpWorkloadIdentity = new ClickPipesGcpWorkloadIdentityContext
    {
        Supported = false,
        Ready = false,
        Principal = "principal0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

