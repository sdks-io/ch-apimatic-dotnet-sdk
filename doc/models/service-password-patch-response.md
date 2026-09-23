
# Service Password Patch Response

*This model accepts additional fields of type object.*

## Structure

`ServicePasswordPatchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Password` | `string` | Optional | New service password. Provided only if there was no 'newPasswordHash' in the request |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServicePasswordPatchResponse servicePasswordPatchResponse = new ServicePasswordPatchResponse
{
    Password = "password2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

