using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ApiKeyModel
{
    /// <summary>
    /// Unique API key ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

    /// <summary>
    /// Name of the key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// State of the key: 'enabled', 'disabled'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State4? State { get; init; }

    /// <summary>
    /// DEPRECATED. Use <c>assignedRoles</c> instead. List of roles assigned to the key. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect current role assignments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<Role3>? Roles { get; init; }

    /// <summary>
    /// Custom roles and System roles assigned to this API key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignedRoles")]
    public IReadOnlyList<AssignedRole>? AssignedRoles { get; init; }

    /// <summary>
    /// Last 4 letters of the key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keySuffix")]
    public string? KeySuffix { get; init; }

    /// <summary>
    /// Timestamp the key was created. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Timestamp the key expires. If not present, <c>null</c> or is empty the key never expires. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expireAt")]
    public DateTimeOffset? ExpireAt { get; init; }

    /// <summary>
    /// Timestamp the key was used last time, with one-minute precision. If not present the key was never used. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usedAt")]
    public DateTimeOffset? UsedAt { get; init; }

    /// <summary>
    /// List of IP addresses allowed to access the API using this key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAccessList")]
    public IReadOnlyList<IpAccessListEntry>? IpAccessList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
