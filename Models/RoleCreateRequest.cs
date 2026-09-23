using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record RoleCreateRequest
{
    /// <summary>
    /// Name of the role
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// List of actor resource IDs to assign to this role (e.g., ["user/uuid", "apiKey/uuid"])
    /// </summary>
    [JsonPropertyName("actors")]
    public required IReadOnlyList<string> Actors { get; init; }

    /// <summary>
    /// List of policies to create for this role
    /// </summary>
    [JsonPropertyName("policies")]
    public required IReadOnlyList<RbacPolicyCreateRequest> Policies { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
