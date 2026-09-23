using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ApiKeyPatchRequest
{
    /// <summary>
    /// Name of the key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// DEPRECATED. Use <c>assignedRoleIds</c> instead. List of roles assigned to the key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<Role3>? Roles { get; init; }

    /// <summary>
    /// Array of role UUIDs to assign to the API key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignedRoleIds")]
    public IReadOnlyList<Guid>? AssignedRoleIds { get; init; }

    /// <summary>
    /// Timestamp the key expires. If <c>null</c> or is empty the key never expires. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expireAt")]
    public DateTimeOffset? ExpireAt { get; init; }

    /// <summary>
    /// State of the key: 'enabled', 'disabled'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State4? State { get; init; }

    /// <summary>
    /// List of IP addresses allowed to access the API using this key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAccessList")]
    public IReadOnlyList<IpAccessListEntry>? IpAccessList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
