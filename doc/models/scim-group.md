
# Scim Group

*This model accepts additional fields of type object.*

## Structure

`ScimGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. Must include "urn:ietf:params:scim:schemas:core:2.0:Group". |
| `Id` | `Guid` | Required | Unique identifier for this Group (corresponds to Role ID). |
| `ExternalId` | `string` | Optional | Identifier for the resource as defined by the provisioning client. |
| `DisplayName` | `string` | Required | Human-readable name for the Group. Maps to Role name. |
| `Members` | [`List<ScimGroupMember>`](../../doc/models/scim-group-member.md) | Optional | Members of the Group. |
| `Meta` | [`ScimGroupMeta`](../../doc/models/scim-group-meta.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ScimGroup scimGroup = new ScimGroup
{
    Schemas = new List<string>
    {
        "urn:ietf:params:scim:schemas:core:2.0:Group",
    },
    Id = new Guid("00001b38-0000-0000-0000-000000000000"),
    DisplayName = "displayName4",
    Meta = new ScimGroupMeta
    {
        ResourceType = "resourceType6",
        Created = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        LastModified = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Location = "location6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ExternalId = "externalId6",
    Members = new List<ScimGroupMember>
    {
        new ScimGroupMember
        {
            MValue = "value0",
            Display = "display0",
            Type = "type2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

