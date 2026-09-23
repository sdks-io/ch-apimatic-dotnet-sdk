
# V1 Organizations Udfs Versions Version Response

## Structure

`V1OrganizationsUdfsVersionsVersionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

V1OrganizationsUdfsVersionsVersionResponse v1OrganizationsUdfsVersionsVersionResponse = new V1OrganizationsUdfsVersionsVersionResponse
{
    Status = 200,
    RequestId = new Guid("00001e10-0000-0000-0000-000000000000"),
};
```

