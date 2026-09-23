
# V1 Organizations Services Query Api Endpoints Endpoint Id Response

## Structure

`V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse v1OrganizationsServicesQueryApiEndpointsEndpointIdResponse = new V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse
{
    Status = 200,
    RequestId = new Guid("000022c0-0000-0000-0000-000000000000"),
};
```

