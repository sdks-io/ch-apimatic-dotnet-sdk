
# V1 Organizations Udfs Versions 400 Error Exception

## Structure

`V1OrganizationsUdfsVersions400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | Error message. |
| `Issues` | [`List<Issue>`](../../doc/models/issue.md) | Optional | Validation issues that caused the request to be rejected. |
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
    if (e is V1OrganizationsUdfsVersions400ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfsVersions400ErrorException
        Console.WriteLine(e.Message);
    }
}
```

