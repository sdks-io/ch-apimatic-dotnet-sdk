
# V1 Organizations Services Query Api Endpoints Endpoint Id 400 Error 3 Exception

## Structure

`V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception`

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
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception)
    {
        // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception
        Console.WriteLine(e.Message);
    }
}
```

