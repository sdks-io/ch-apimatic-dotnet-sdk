
# V1 Organizations Udfs Attachments Service Id 400 Error Exception

## Structure

`V1OrganizationsUdfsAttachmentsServiceId400ErrorException`

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
    if (e is V1OrganizationsUdfsAttachmentsServiceId400ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId400ErrorException
        Console.WriteLine(e.Message);
    }
}
```

