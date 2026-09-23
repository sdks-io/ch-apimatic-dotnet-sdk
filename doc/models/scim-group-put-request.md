
# Scim Group Put Request

*This model accepts additional fields of type object.*

## Structure

`ScimGroupPutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. Must include "urn:ietf:params:scim:schemas:core:2.0:Group". |
| `ExternalId` | `string` | Optional | Identifier for the resource as defined by the provisioning client. |
| `DisplayName` | `string` | Required | Human-readable name for the Group. Maps to Role name. |
| `Members` | [`List<ScimGroupMember>`](../../doc/models/scim-group-member.md) | Optional | Members of the Group. |
| `Id` | `string` | Optional | Server-assigned resource ID echoed back by the IdP. Ignored on write. |
| `Meta` | [`ScimGroupMeta`](../../doc/models/scim-group-meta.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ScimGroupPutRequest scimGroupPutRequest = new ScimGroupPutRequest
{
    Schemas = new List<string>
    {
        "urn:ietf:params:scim:schemas:core:2.0:Group",
    },
    DisplayName = "displayName6",
    ExternalId = "externalId8",
    Members = new List<ScimGroupMember>
    {
        new ScimGroupMember
        {
            MValue = "value0",
            Display = "display0",
            Type = "type2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ScimGroupMember
        {
            MValue = "value0",
            Display = "display0",
            Type = "type2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Id = "id6",
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

