
# V1 Organizations Services Clickstack Roles Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackRolesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ClickStackRole>`](../../doc/models/click-stack-role.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsServicesClickstackRolesResponse v1OrganizationsServicesClickstackRolesResponse = new V1OrganizationsServicesClickstackRolesResponse
{
    Status = 200,
    RequestId = new Guid("000026be-0000-0000-0000-000000000000"),
    Result = new List<ClickStackRole>
    {
        new ClickStackRole
        {
            Id = "id6",
            Name = "name6",
            Permissions = new List<ClickStackCaslPermission>
            {
                new ClickStackCaslPermission
                {
                    Action = "action4",
                    Subject = "subject2",
                    Inverted = false,
                    Integration = "integration6",
                    Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            IsPredefined = false,
            Description = "description6",
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackRole
        {
            Id = "id6",
            Name = "name6",
            Permissions = new List<ClickStackCaslPermission>
            {
                new ClickStackCaslPermission
                {
                    Action = "action4",
                    Subject = "subject2",
                    Inverted = false,
                    Integration = "integration6",
                    Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            IsPredefined = false,
            Description = "description6",
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackRole
        {
            Id = "id6",
            Name = "name6",
            Permissions = new List<ClickStackCaslPermission>
            {
                new ClickStackCaslPermission
                {
                    Action = "action4",
                    Subject = "subject2",
                    Inverted = false,
                    Integration = "integration6",
                    Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            IsPredefined = false,
            Description = "description6",
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

