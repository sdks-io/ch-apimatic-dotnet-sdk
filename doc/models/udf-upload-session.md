
# Udf Upload Session

## Structure

`UdfUploadSession`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UploadId` | `Guid` | Required | Identifier of the uploaded source archive. |
| `UploadUrl` | `string` | Required | Presigned URL for uploading the source archive. |
| `ExpiresAt` | `DateTime` | Required | Presigned-URL expiry timestamp. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using System.Globalization;

UdfUploadSession udfUploadSession = new UdfUploadSession
{
    UploadId = new Guid("00000412-0000-0000-0000-000000000000"),
    UploadUrl = "uploadUrl8",
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

