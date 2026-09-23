
# Scim List Response

*This model accepts additional fields of type object.*

## Structure

`ScimListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | Must be ["urn:ietf:params:scim:api:messages:2.0:ListResponse"]. |
| `TotalResults` | `int` | Required | Total number of results matching the query. |
| `StartIndex` | `int` | Required | 1-based index of the first result in the current set. |
| `ItemsPerPage` | `int` | Required | Number of resources returned in this response. |
| `Resources` | [`List<ScimUser>`](../../doc/models/scim-user.md) | Required | Array of SCIM User resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ScimListResponse scimListResponse = new ScimListResponse
{
    Schemas = new List<string>
    {
        "schemas7",
    },
    TotalResults = 208,
    StartIndex = 70,
    ItemsPerPage = 66,
    Resources = new List<ScimUser>
    {
        new ScimUser
        {
            Schemas = new List<string>
            {
                "urn:ietf:params:scim:schemas:core:2.0:User",
            },
            Id = "samlp|b7a3c2d1-4e5f-6a7b-8c9d-0e1f2a3b4c5d|user@example.com",
            UserName = "user@example.com",
            Name = new ScimUserName
            {
                Formatted = "formatted2",
                FamilyName = "familyName8",
                GivenName = "givenName4",
                MiddleName = "middleName8",
                HonorificPrefix = "honorificPrefix4",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            Active = false,
            Emails = new List<ScimUserEmail>
            {
                new ScimUserEmail
                {
                    MValue = "value8",
                    Type = "type6",
                    Primary = false,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            Meta = new ScimUserMeta
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
            ExternalId = "ext-user-001",
            DisplayName = "displayName6",
            NickName = "nickName8",
            ProfileUrl = "profileUrl0",
            Title = "title2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

