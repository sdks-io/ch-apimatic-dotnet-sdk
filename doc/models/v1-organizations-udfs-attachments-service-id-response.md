
# V1 Organizations Udfs Attachments Service Id Response

## Structure

`V1OrganizationsUdfsAttachmentsServiceIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`UdfAttachment`](../../doc/models/udf-attachment.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

V1OrganizationsUdfsAttachmentsServiceIdResponse v1OrganizationsUdfsAttachmentsServiceIdResponse = new V1OrganizationsUdfsAttachmentsServiceIdResponse
{
    Status = 200,
    RequestId = new Guid("00001fb2-0000-0000-0000-000000000000"),
    Result = new UdfAttachment
    {
        FunctionName = "functionName4",
        ServiceId = new Guid("000011f8-0000-0000-0000-000000000000"),
        Status = Status3.Provisioning,
        Version = 1,
    },
};
```

