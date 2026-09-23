
# V1 Organizations Udf Uploads Url 500 Error Exception

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsUdfUploadsUrl500ErrorException`

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
    if (e is V1OrganizationsUdfUploadsUrl500ErrorException)
    {
        // TODO: Handle V1OrganizationsUdfUploadsUrl500ErrorException
        Console.WriteLine(e.Message);
    }
}
```

