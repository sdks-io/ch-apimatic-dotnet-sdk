
# V1 Organizations Services Query Api Endpoints Endpoint Id 404 Error Exception

## Structure

`V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException`

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
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException
        Console.WriteLine(e.Message);
    }
}
```

