
# V1 Organizations Udfs Versions 403 Error Exception

## Structure

`V1OrganizationsUdfsVersions403ErrorException`

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
    if (e is V1OrganizationsUdfsVersions403ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsVersions403ErrorException
        Console.WriteLine(e.Message);
    }
}
```

