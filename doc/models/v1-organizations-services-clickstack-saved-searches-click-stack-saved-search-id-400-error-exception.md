
# V1 Organizations Services Clickstack Saved Searches Click Stack Saved Search Id 400 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `Error` | `string` | Optional | Detailed error description. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException
        Console.WriteLine(e.Message);
    }
}
```

