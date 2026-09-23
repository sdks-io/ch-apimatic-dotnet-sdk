
# V1 Organizations Udfs 403 Error Exception

## Structure

`V1OrganizationsUdfs403ErrorException`

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
    if (e is V1OrganizationsUdfs403ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfs403ErrorException
        Console.WriteLine(e.Message);
    }
}
```

