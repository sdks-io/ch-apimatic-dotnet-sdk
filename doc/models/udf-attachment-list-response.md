
# Udf Attachment List Response

## Structure

`UdfAttachmentListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<UdfAttachment>`](../../doc/models/udf-attachment.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;

UdfAttachmentListResponse udfAttachmentListResponse = new UdfAttachmentListResponse
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
};
```

