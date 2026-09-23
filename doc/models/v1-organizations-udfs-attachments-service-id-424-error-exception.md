
# V1 Organizations Udfs Attachments Service Id 424 Error Exception

## Structure

`V1OrganizationsUdfsAttachmentsServiceId424ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | Human-readable error message. |
| `Code` | [`Code`](../../doc/models/code.md) | Required | Reason the attachment could not be started. |
| `ServiceState` | [`ServiceState`](../../doc/models/service-state.md) | Required | Current state of the service. |
| `CanWake` | `bool` | Required | Whether the service can be woken before retrying the attachment. |
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
    if (e is V1OrganizationsUdfsAttachmentsServiceId424ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId424ErrorException
        Console.WriteLine(e.Message);
    }
}
```

