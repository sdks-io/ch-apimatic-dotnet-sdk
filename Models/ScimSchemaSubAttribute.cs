using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

/// <summary>
/// A sub-attribute of a complex SCIM schema attribute. Per RFC 7643, sub-attributes cannot themselves have sub-attributes.
/// </summary>
public record ScimSchemaSubAttribute
{
    /// <summary>
    /// The attribute name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The attribute type (e.g., "string", "boolean", "complex").
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Whether the attribute can have multiple values.
    /// </summary>
    [JsonPropertyName("multiValued")]
    public required bool MultiValued { get; init; }

    /// <summary>
    /// A human-readable description of the attribute.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Whether the attribute is required.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// Whether the string attribute is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("caseExact")]
    public bool? CaseExact { get; init; }

    /// <summary>
    /// The circumstances under which the value of the attribute can be (re)defined.
    /// </summary>
    [JsonPropertyName("mutability")]
    public required string Mutability { get; init; }

    /// <summary>
    /// The circumstances under which an attribute and associated values are returned.
    /// </summary>
    [JsonPropertyName("returned")]
    public required string Returned { get; init; }

    /// <summary>
    /// How the service provider enforces uniqueness of attribute values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uniqueness")]
    public string? Uniqueness { get; init; }

    /// <summary>
    /// A multi-valued array of JSON strings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceTypes")]
    public IReadOnlyList<string>? ReferenceTypes { get; init; }

    /// <summary>
    /// A collection of suggested canonical values that MAY be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canonicalValues")]
    public IReadOnlyList<string>? CanonicalValues { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
