
# V1 Organizations Members Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsMembersResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`Member`](../../doc/models/member.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

V1OrganizationsMembersResponse1 v1OrganizationsMembersResponse1 = new V1OrganizationsMembersResponse1
{
    Status = 200,
    RequestId = new Guid("000004bc-0000-0000-0000-000000000000"),
    Result = new Member
    {
        UserId = "userId6",
        Name = "name6",
        Email = "email0",
        Role = Role1.Admin,
        JoinedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

