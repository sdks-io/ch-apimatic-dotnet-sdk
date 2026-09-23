
# Organization

*This model accepts additional fields of type object.*

## Structure

`Organization`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique organization ID. |
| `CreatedAt` | `DateTime?` | Optional | The timestamp the organization was created. ISO-8601. |
| `Name` | `string` | Optional | Name of the organization. |
| `PrivateEndpoints` | [`List<OrganizationPrivateEndpoint>`](../../doc/models/organization-private-endpoint.md) | Optional | List of private endpoints for organization |
| `ByocConfig` | [`List<ByocConfig>`](../../doc/models/byoc-config.md) | Optional | BYOC configuration for the organization |
| `EnableCoreDumps` | `bool?` | Optional | Whether crash reports (core dumps) collection is enabled for services in the organization. When disabled at the organization level, individual services cannot enable crash reports. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

Organization organization = new Organization
{
    Id = new Guid("00001ed8-0000-0000-0000-000000000000"),
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
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

