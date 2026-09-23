
# V1 Organizations Udfs Response 2

## Structure

`V1OrganizationsUdfsResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

V1OrganizationsUdfsResponse2 v1OrganizationsUdfsResponse2 = new V1OrganizationsUdfsResponse2
{
    Status = 200,
    RequestId = new Guid("00000b0a-0000-0000-0000-000000000000"),
};
```

