
# V1 Organizations Services Query Api Endpoints 400 Error Exception

## Structure

`V1OrganizationsServicesQueryApiEndpoints400ErrorException`

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
    if (e is V1OrganizationsServicesQueryApiEndpoints400ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesQueryApiEndpoints400ErrorException
        Console.WriteLine(e.Message);
    }
}
```

