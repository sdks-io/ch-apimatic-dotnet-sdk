
# Scim Enterprise User

*This model accepts additional fields of type object.*

## Structure

`ScimEnterpriseUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EmployeeNumber` | `string` | Optional | Numeric or alphanumeric identifier assigned to a person, typically based on order of hire or association with an organization. |
| `CostCenter` | `string` | Optional | Identifies the name of a cost center. |
| `Organization` | `string` | Optional | Identifies the name of an organization. |
| `Division` | `string` | Optional | Identifies the name of a division. |
| `Department` | `string` | Optional | Identifies the name of a department. |
| `Manager` | [`ScimEnterpriseManager`](../../doc/models/scim-enterprise-manager.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimEnterpriseUser scimEnterpriseUser = new ScimEnterpriseUser
{
    EmployeeNumber = "employeeNumber6",
    CostCenter = "costCenter8",
    Organization = "organization2",
    Division = "division6",
    Department = "department6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

