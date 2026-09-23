
# Click Stack Role

*This model accepts additional fields of type object.*

## Structure

`ClickStackRole`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Role ID. |
| `Name` | `string` | Required | Role name. |
| `Description` | `string` | Optional | Human-readable role description. |
| `Permissions` | [`List<ClickStackCaslPermission>`](../../doc/models/click-stack-casl-permission.md) | Required | The CASL permissions granted by this role. |
| `IsPredefined` | `bool` | Required | Whether this is an immutable predefined/system role. |
| `CreatedAt` | `DateTime?` | Optional | Creation timestamp. |
| `UpdatedAt` | `DateTime?` | Optional | Last update timestamp. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ClickStackRole clickStackRole = new ClickStackRole
{
    Id = "507f1f77bcf86cd799439011",
    Name = "Read Only",
    Permissions = new List<ClickStackCaslPermission>
    {
        new ClickStackCaslPermission
        {
            Action = "read",
            Subject = "dashboard",
            Inverted = false,
            Integration = "mongodb",
            Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    IsPredefined = false,
    Description = "Read-only access to all resources",
    CreatedAt = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("2025-06-15T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

