
# V1 Organizations Udfs Attachments Service Id 422 Error Exception

## Structure

`V1OrganizationsUdfsAttachmentsServiceId422ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | Human-readable error message. |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is V1OrganizationsUdfsAttachmentsServiceId422ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId422ErrorException
        Console.WriteLine(e.Message);
    }
}
```

