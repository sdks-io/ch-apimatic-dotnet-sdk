
# V1 Organizations Quotas Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsQuotasResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<OrganizationQuota>`](../../doc/models/organization-quota.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsQuotasResponse v1OrganizationsQuotasResponse = new V1OrganizationsQuotasResponse
{
    Status = 200,
    RequestId = new Guid("0000032e-0000-0000-0000-000000000000"),
    Result = new List<OrganizationQuota>
    {
        new OrganizationQuota
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
        new OrganizationQuota
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
        new OrganizationQuota
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
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

