
# V1 Organizations Services Clickpipes Context Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesContextResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickPipesServiceContext`](../../doc/models/click-pipes-service-context.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickpipesContextResponse v1OrganizationsServicesClickpipesContextResponse = new V1OrganizationsServicesClickpipesContextResponse
{
    Status = 200,
    RequestId = new Guid("00000c6e-0000-0000-0000-000000000000"),
    Result = new ClickPipesServiceContext
    {
        GcpWorkloadIdentity = new ClickPipesGcpWorkloadIdentityContext
        {
            Supported = false,
            Ready = false,
            Principal = "principal0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

