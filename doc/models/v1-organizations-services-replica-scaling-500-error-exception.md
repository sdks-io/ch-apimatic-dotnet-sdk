
# V1 Organizations Services Replica Scaling 500 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesReplicaScaling500ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int?` | Optional | HTTP status code. |
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
    if (e is V1OrganizationsServicesReplicaScaling500ErrorException)
    {
        // TODO: Handle V1OrganizationsServicesReplicaScaling500ErrorException
        Console.WriteLine(e.Message);
    }
}
```

