
# V1 Organizations Udf Uploads Url Response

## Structure

`V1OrganizationsUdfUploadsUrlResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`UdfUploadSession`](../../doc/models/udf-upload-session.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using System.Globalization;

V1OrganizationsUdfUploadsUrlResponse v1OrganizationsUdfUploadsUrlResponse = new V1OrganizationsUdfUploadsUrlResponse
{
    Status = 201,
    RequestId = new Guid("00000494-0000-0000-0000-000000000000"),
    Result = new UdfUploadSession
    {
        UploadId = new Guid("0000252c-0000-0000-0000-000000000000"),
        UploadUrl = "uploadUrl2",
        ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

