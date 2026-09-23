
# V1 Organizations Byoc Infrastructure Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsByocInfrastructureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ByocConfig`](../../doc/models/byoc-config.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsByocInfrastructureResponse v1OrganizationsByocInfrastructureResponse = new V1OrganizationsByocInfrastructureResponse
{
    Status = 200,
    RequestId = new Guid("0000004a-0000-0000-0000-000000000000"),
    Result = new ByocConfig
    {
        Id = "id6",
        State = State1.Infraready,
        AccountName = "accountName0",
        RegionId = RegionId.Uswest2,
        CloudProvider = CloudProvider2.Azure,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

