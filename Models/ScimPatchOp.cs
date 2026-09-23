using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimPatchOp
{
    /// <summary>
    /// Must include "urn:ietf:params:scim:api:messages:2.0:PatchOp".
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// List of PATCH operations to apply.
    /// </summary>
    [JsonPropertyName("Operations")]
    public required IReadOnlyList<ScimPatchOperation> Operations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
