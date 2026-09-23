
# Scim Group Post Request

*This model accepts additional fields of type object.*

## Structure

`ScimGroupPostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. Must include "urn:ietf:params:scim:schemas:core:2.0:Group". |
| `ExternalId` | `string` | Optional | Identifier for the resource as defined by the provisioning client. |
| `DisplayName` | `string` | Required | Human-readable name for the Group. Maps to Role name. |
| `Members` | [`List<ScimGroupMember>`](../../doc/models/scim-group-member.md) | Optional | Members of the Group. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimGroupPostRequest scimGroupPostRequest = new ScimGroupPostRequest
{
    Schemas = new List<string>
    {
        "urn:ietf:params:scim:schemas:core:2.0:Group",
    },
    DisplayName = "displayName2",
    ExternalId = "externalId4",
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

