using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimUser
{
    /// <summary>
    /// SCIM schemas URIs. Should include "urn:ietf:params:scim:schemas:core:2.0:User".
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// Unique identifier for the SCIM resource. Returned by the server.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A String that is an identifier for the resource as defined by the provisioning client.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// Unique identifier for the User, typically used by the user to directly authenticate to the service provider.
    /// </summary>
    [JsonPropertyName("userName")]
    public required string UserName { get; init; }

    [JsonPropertyName("name")]
    public required ScimUserName Name { get; init; }

    /// <summary>
    /// The name of the User, suitable for display to end-users.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The casual way to address the user in real life.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nickName")]
    public string? NickName { get; init; }

    /// <summary>
    /// A fully qualified URL pointing to a page representing the User's online profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; init; }

    /// <summary>
    /// The User's title, such as "Vice President".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// Identifies the relationship between the organization and the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userType")]
    public string? UserType { get; init; }

    /// <summary>
    /// Indicates the User's preferred written or spoken language (e.g., "en-US").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; init; }

    /// <summary>
    /// Used to indicate the User's default location for localizing items such as currency, date time format, or numerical representations (e.g., "en-US").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The User's time zone in the "Olson" time zone database format (e.g., "America/Los_Angeles").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// A Boolean value indicating the User's administrative status.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// Email addresses for the user.
    /// </summary>
    [JsonPropertyName("emails")]
    public required IReadOnlyList<ScimUserEmail> Emails { get; init; }

    /// <summary>
    /// Phone numbers for the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumbers")]
    public IReadOnlyList<ScimUserPhoneNumber>? PhoneNumbers { get; init; }

    /// <summary>
    /// Instant messaging addresses for the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ims")]
    public IReadOnlyList<ScimUserIm>? Ims { get; init; }

    /// <summary>
    /// URLs of photos of the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("photos")]
    public IReadOnlyList<ScimUserPhoto>? Photos { get; init; }

    /// <summary>
    /// Physical mailing addresses for the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addresses")]
    public IReadOnlyList<ScimUserAddress>? Addresses { get; init; }

    /// <summary>
    /// A list of groups to which the user belongs, either through direct membership, through nested groups, or dynamically calculated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groups")]
    public IReadOnlyList<ScimUserGroup>? Groups { get; init; }

    /// <summary>
    /// A list of entitlements for the user that represent a thing the user has.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entitlements")]
    public IReadOnlyList<ScimUserEntitlement>? Entitlements { get; init; }

    /// <summary>
    /// A list of roles for the user that collectively represent who the user is, e.g. "Student", "Faculty". No vocabulary or syntax is specified; role value is a string or label representing a collection of entitlements. RFC 7643.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<ScimUserRole>? Roles { get; init; }

    /// <summary>
    /// A list of certificates issued to the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("x509Certificates")]
    public IReadOnlyList<ScimX509Certificate>? X509Certificates { get; init; }

    [JsonPropertyName("meta")]
    public required ScimUserMeta Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
