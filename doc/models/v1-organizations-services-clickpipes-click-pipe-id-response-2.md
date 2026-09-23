
# V1 Organizations Services Clickpipes Click Pipe Id Response 2

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesClickPipeIdResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickpipesClickPipeIdResponse2 v1OrganizationsServicesClickpipesClickPipeIdResponse2 = new V1OrganizationsServicesClickpipesClickPipeIdResponse2
{
    Status = 200,
    RequestId = new Guid("00001e7a-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

