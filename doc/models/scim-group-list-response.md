
# Scim Group List Response

*This model accepts additional fields of type object.*

## Structure

`ScimGroupListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | Must be ["urn:ietf:params:scim:api:messages:2.0:ListResponse"]. |
| `TotalResults` | `int` | Required | Total number of Groups matching the query. |
| `StartIndex` | `int` | Required | 1-based index of the first result in the current set. |
| `ItemsPerPage` | `int` | Required | Number of resources returned in this response. |
| `Resources` | [`List<ScimGroup>`](../../doc/models/scim-group.md) | Required | Array of SCIM Group resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ScimGroupListResponse scimGroupListResponse = new ScimGroupListResponse
{
    Schemas = new List<string>
    {
        "schemas5",
        "schemas4",
    },
    TotalResults = 32,
    StartIndex = 150,
    ItemsPerPage = 146,
    Resources = new List<ScimGroup>
    {
        new ScimGroup
        {
            Schemas = new List<string>
            {
                "urn:ietf:params:scim:schemas:core:2.0:Group",
            },
            Id = new Guid("00000286-0000-0000-0000-000000000000"),
            DisplayName = "displayName6",
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
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

