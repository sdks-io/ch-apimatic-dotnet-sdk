
# V1 Organizations Services Clickpipes Click Pipe Id Scaling 400 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException`

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
    if (e is V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException
        Console.WriteLine(e.Message);
    }
}
```

