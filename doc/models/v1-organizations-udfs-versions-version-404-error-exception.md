
# V1 Organizations Udfs Versions Version 404 Error Exception

## Structure

`V1OrganizationsUdfsVersionsVersion404ErrorException`

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
    if (e is V1OrganizationsUdfsVersionsVersion404ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsVersionsVersion404ErrorException
        Console.WriteLine(e.Message);
    }
}
```

