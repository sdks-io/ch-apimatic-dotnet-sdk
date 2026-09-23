
# V1 Organizations Services Query Api Endpoints Endpoint Id 500 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException`

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
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException
        Console.WriteLine(e.Message);
    }
}
```

