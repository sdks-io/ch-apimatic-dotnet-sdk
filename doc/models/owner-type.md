
# Owner Type

Owner type of the Query API endpoint. Endpoints with a user owned query cannot be updated or deleted through this API.

## Enumeration

`OwnerType`

## Fields

| Name |
|  --- |
| `User` |
| `QueryApiEndpoint` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

OwnerType ownerType = OwnerType.User;
```

