
# V1 Organizations Quotas Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsQuotasResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`OrganizationQuota`](../../doc/models/organization-quota.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsQuotasResponse1 v1OrganizationsQuotasResponse1 = new V1OrganizationsQuotasResponse1
{
    Status = 200,
    RequestId = new Guid("000008f6-0000-0000-0000-000000000000"),
    Result = new OrganizationQuota
    {
        QuotaCode = QuotaCode.Servicesperorganization,
        Name = "name6",
        Description = "description6",
        Scope = Scope.Organization,
        MValue = 216,
        Adjustable = false,
        Usage = 190,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

