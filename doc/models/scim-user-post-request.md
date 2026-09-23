
# Scim User Post Request

*This model accepts additional fields of type object.*

## Structure

`ScimUserPostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schemas URIs. Should include "urn:ietf:params:scim:schemas:core:2.0:User". |
| `UserName` | `string` | Required | Unique identifier for the User, typically used by the user to directly authenticate to the service provider. |
| `ExternalId` | `string` | Optional | A String that is an identifier for the resource as defined by the provisioning client. |
| `Name` | [`ScimUserName`](../../doc/models/scim-user-name.md) | Optional | - |
| `DisplayName` | `string` | Optional | The name of the User, suitable for display to end-users. |
| `NickName` | `string` | Optional | The casual way to address the user in real life. |
| `ProfileUrl` | `string` | Optional | A fully qualified URL pointing to a page representing the User's online profile. |
| `Title` | `string` | Optional | The User's title, such as "Vice President". |
| `UserType` | `string` | Optional | Identifies the relationship between the organization and the user. |
| `PreferredLanguage` | `string` | Optional | Indicates the User's preferred written or spoken language (e.g., "en-US"). |
| `Locale` | `string` | Optional | Used to indicate the User's default location for localizing items such as currency, date time format, or numerical representations (e.g., "en-US"). |
| `Timezone` | `string` | Optional | The User's time zone in the "Olson" time zone database format (e.g., "America/Los_Angeles"). |
| `Active` | `bool?` | Optional | A Boolean value indicating the User's administrative status. Defaults to true if not specified. |
| `Password` | `string` | Optional | The User's cleartext password. Write-only; never returned in responses. |
| `Emails` | [`List<ScimUserEmail>`](../../doc/models/scim-user-email.md) | Required | Email addresses for the user. |
| `PhoneNumbers` | [`List<ScimUserPhoneNumber>`](../../doc/models/scim-user-phone-number.md) | Optional | Phone numbers for the User. |
| `Ims` | [`List<ScimUserIm>`](../../doc/models/scim-user-im.md) | Optional | Instant messaging addresses for the User. |
| `Photos` | [`List<ScimUserPhoto>`](../../doc/models/scim-user-photo.md) | Optional | URLs of photos of the User. |
| `Addresses` | [`List<ScimUserAddress>`](../../doc/models/scim-user-address.md) | Optional | Physical mailing addresses for the User. |
| `Groups` | [`List<ScimUserGroup>`](../../doc/models/scim-user-group.md) | Optional | A list of groups to which the user belongs. Role may be derived from group display or value. |
| `Entitlements` | [`List<ScimUserEntitlement>`](../../doc/models/scim-user-entitlement.md) | Optional | A list of entitlements for the user that represent a thing the user has. |
| `Roles` | [`List<ScimUserRole>`](../../doc/models/scim-user-role.md) | Optional | A list of roles for the user. |
| `X509Certificates` | [`List<ScimX509Certificate>`](../../doc/models/scim-x509-certificate.md) | Optional | A list of certificates issued to the User. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimUserPostRequest scimUserPostRequest = new ScimUserPostRequest
{
    Schemas = new List<string>
    {
        "urn:ietf:params:scim:schemas:core:2.0:User",
    },
    UserName = "user@example.com",
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
    ExternalId = "ext-user-001",
    Name = new ScimUserName
    {
        Formatted = "formatted2",
        FamilyName = "familyName8",
        GivenName = "givenName4",
        MiddleName = "middleName8",
        HonorificPrefix = "honorificPrefix4",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    DisplayName = "displayName8",
    NickName = "nickName6",
    ProfileUrl = "profileUrl4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

