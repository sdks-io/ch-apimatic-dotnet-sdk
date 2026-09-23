
# Rbac Role

*This model accepts additional fields of type object.*

## Structure

`RbacRole`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique role identifier |
| `TenantId` | `string` | Optional | Tenant resource ID (e.g., organization/uuid) |
| `OwnerId` | `string` | Optional | Owner resource ID (e.g., organization/uuid) |
| `Name` | `string` | Optional | Name of the role |
| `Type` | [`Type?`](../../doc/models/type.md) | Optional | Whether this is a system role or a custom role |
| `Actors` | `List<string>` | Optional | List of actor resource IDs assigned to this role (e.g., user/uuid, apiKey/uuid) |
| `Policies` | [`List<RbacPolicy>`](../../doc/models/rbac-policy.md) | Optional | List of policies associated with this role |
| `CreatedAt` | `DateTime?` | Optional | Timestamp when the role was created. ISO-8601. |
| `UpdatedAt` | `DateTime?` | Optional | Timestamp when the role was last updated. ISO-8601. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

RbacRole rbacRole = new RbacRole
{
    Id = "id2",
    TenantId = "tenantId8",
    OwnerId = "ownerId4",
    Name = "name2",
    Type = OpenApiSpecForClickHouseCloud.Standard.Models.Type.MSystem,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

