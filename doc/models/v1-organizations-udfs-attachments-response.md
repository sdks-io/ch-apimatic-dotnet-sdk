
# V1 Organizations Udfs Attachments Response

## Structure

`V1OrganizationsUdfsAttachmentsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`UdfAttachmentListResponse`](../../doc/models/udf-attachment-list-response.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;

V1OrganizationsUdfsAttachmentsResponse v1OrganizationsUdfsAttachmentsResponse = new V1OrganizationsUdfsAttachmentsResponse
{
    Status = 200,
    RequestId = new Guid("00000a12-0000-0000-0000-000000000000"),
    Result = new UdfAttachmentListResponse
    {
        Items = new List<UdfAttachment>
        {
            new UdfAttachment
            {
                FunctionName = "functionName4",
                ServiceId = new Guid("00001362-0000-0000-0000-000000000000"),
                Status = Status3.Deployed,
                Version = 1,
            },
        },
        Pagination = new Pagination
        {
            TotalRecords = 72,
            CurrentCursor = PaginationCurrentCursor.FromString("String5"),
            NextCursor = PaginationNextCursor.FromString("String1"),
            Limit = 80,
        },
    },
};
```

