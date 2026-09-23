using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimUserName
{
    /// <summary>
    /// The full name, including all middle names, titles, and suffixes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formatted")]
    public string? Formatted { get; init; }

    /// <summary>
    /// The family name of the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// The given name of the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("givenName")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The middle name(s) of the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; init; }

    /// <summary>
    /// The honorific prefix(es) of the User, or title in some cultures.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; init; }

    /// <summary>
    /// The honorific suffix(es) of the User.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
