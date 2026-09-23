using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record RbacPolicyCreateRequest
{
    /// <summary>
    /// Whether this policy allows or denies access
    /// </summary>
    [JsonPropertyName("allowDeny")]
    public required AllowDeny AllowDeny { get; init; }

    /// <summary>
    /// List of permissions to grant or deny (e.g., ["control-plane:organization:view"])
    /// </summary>
    [JsonPropertyName("permissions")]
    public required IReadOnlyList<string> Permissions { get; init; }

    /// <summary>
    /// List of resource IDs this policy applies to (e.g., ["instance/uuid", "instance/*"])
    /// </summary>
    [JsonPropertyName("resources")]
    public required IReadOnlyList<string> Resources { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public RbacPolicyTags? Tags { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
