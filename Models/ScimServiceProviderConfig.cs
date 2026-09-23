using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimServiceProviderConfig
{
    /// <summary>
    /// SCIM schema URIs.
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// URI of the service documentation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentationUri")]
    public string? DocumentationUri { get; init; }

    [JsonPropertyName("patch")]
    public required ScimServiceProviderConfigPatch Patch { get; init; }

    [JsonPropertyName("bulk")]
    public required ScimServiceProviderConfigBulk Bulk { get; init; }

    [JsonPropertyName("filter")]
    public required ScimServiceProviderConfigFilter Filter { get; init; }

    [JsonPropertyName("changePassword")]
    public required ScimBooleanFeature ChangePassword { get; init; }

    [JsonPropertyName("sort")]
    public required ScimBooleanFeature Sort { get; init; }

    [JsonPropertyName("etag")]
    public required ScimBooleanFeature Etag { get; init; }

    /// <summary>
    /// Supported authentication schemes.
    /// </summary>
    [JsonPropertyName("authenticationSchemes")]
    public required IReadOnlyList<ScimAuthenticationScheme> AuthenticationSchemes { get; init; }

    [JsonPropertyName("meta")]
    public required ScimServiceProviderConfigMeta Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
