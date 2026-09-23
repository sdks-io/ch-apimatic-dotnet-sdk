
# V1 Organizations Udfs Attachments Service Id 500 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsUdfsAttachmentsServiceId500ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | Error message. |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is V1OrganizationsUdfsAttachmentsServiceId500ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId500ErrorException
        Console.WriteLine(e.Message);
    }
}
```

