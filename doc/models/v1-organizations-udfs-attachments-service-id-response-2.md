
# V1 Organizations Udfs Attachments Service Id Response 2

## Structure

`V1OrganizationsUdfsAttachmentsServiceIdResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

V1OrganizationsUdfsAttachmentsServiceIdResponse2 v1OrganizationsUdfsAttachmentsServiceIdResponse2 = new V1OrganizationsUdfsAttachmentsServiceIdResponse2
{
    Status = 200,
    RequestId = new Guid("00001ddc-0000-0000-0000-000000000000"),
};
```

