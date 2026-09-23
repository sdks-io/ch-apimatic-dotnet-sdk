
# V1 Organizations Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<Organization>`](../../doc/models/organization.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsResponse v1OrganizationsResponse = new V1OrganizationsResponse
{
    Status = 200,
    RequestId = new Guid("00001d18-0000-0000-0000-000000000000"),
    Result = new List<Organization>
    {
        new Organization
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Name = "name6",
            PrivateEndpoints = new List<OrganizationPrivateEndpoint>
            {
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ByocConfig = new List<ByocConfig>
            {
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new Organization
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Name = "name6",
            PrivateEndpoints = new List<OrganizationPrivateEndpoint>
            {
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ByocConfig = new List<ByocConfig>
            {
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new Organization
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Name = "name6",
            PrivateEndpoints = new List<OrganizationPrivateEndpoint>
            {
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new OrganizationPrivateEndpoint
                {
                    Id = "id0",
                    Description = "description0",
                    CloudProvider = CloudProvider1.Aws,
                    Region = Region1.Uscentral1,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ByocConfig = new List<ByocConfig>
            {
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ByocConfig
                {
                    Id = "id0",
                    State = State1.Infraprovisioning,
                    AccountName = "accountName4",
                    RegionId = RegionId.Apsoutheast2,
                    CloudProvider = CloudProvider2.Azure,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

