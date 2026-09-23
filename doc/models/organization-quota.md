
# Organization Quota

*This model accepts additional fields of type object.*

## Structure

`OrganizationQuota`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QuotaCode` | [`QuotaCode`](../../doc/models/quota-code.md) | Required | Stable identifier of the quota. Use it to request a single quota by code. |
| `Name` | `string` | Required | Human-readable name of the quota. |
| `Description` | `string` | Required | Explanation of the resource the quota limits and how the limit is applied. |
| `Scope` | [`Scope`](../../doc/models/scope.md) | Required | Granularity at which the limit is applied. For example, `replicas-per-warehouse` is an organization-wide setting that limits each warehouse individually. |
| `MValue` | `int` | Required | Limit currently applied to the organization, including any adjustments made for the organization. The value can change when the billing status of the organization changes.<br><br>**Constraints**: `>= 0` |
| `Usage` | `int?` | Optional | Current consumption of the quota. Omitted for quotas that do not report usage. Usage can exceed `value` when a limit was lowered after resources were created; existing resources are not affected.<br><br>**Constraints**: `>= 0` |
| `Adjustable` | `bool` | Required | Whether the limit can be raised for the organization by contacting ClickHouse support. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

OrganizationQuota organizationQuota = new OrganizationQuota
{
    QuotaCode = QuotaCode.Servicesperorganization,
    Name = "Services per organization",
    Description = "description0",
    Scope = Scope.Organization,
    MValue = 20,
    Adjustable = false,
    Usage = 3,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

