
# V1 Organizations Udfs Versions 410 Error Exception

## Structure

`V1OrganizationsUdfsVersions410ErrorException`

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
    if (e is V1OrganizationsUdfsVersions410ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsVersions410ErrorException
        Console.WriteLine(e.Message);
    }
}
```

