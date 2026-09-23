
# V1 Organizations Udfs Attachments 404 Error Exception

## Structure

`V1OrganizationsUdfsAttachments404ErrorException`

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
    if (e is V1OrganizationsUdfsAttachments404ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsAttachments404ErrorException
        Console.WriteLine(e.Message);
    }
}
```

