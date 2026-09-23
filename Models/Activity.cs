using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record Activity
{
    /// <summary>
    /// Unique activity ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Timestamp of the activity. ISO-8601.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Type of the activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type12? Type { get; init; }

    /// <summary>
    /// Type of the actor: 'user', 'support', 'system', 'api'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actorType")]
    public ActorType? ActorType { get; init; }

    /// <summary>
    /// Unique actor ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actorId")]
    public string? ActorId { get; init; }

    /// <summary>
    /// Additional information about the actor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actorDetails")]
    public string? ActorDetails { get; init; }

    /// <summary>
    /// IP address of the actor. Defined for 'user' and 'api' actor types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actorIpAddress")]
    public string? ActorIpAddress { get; init; }

    /// <summary>
    /// Scope of the activity: organization ID this activity is related to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Scope of the activity: service ID this activity is related to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// User agent of the actor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgent")]
    public string? UserAgent { get; init; }

    /// <summary>
    /// For 'openapi_key_update' activities: the ID of the API key that was updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetKeyId")]
    public string? TargetKeyId { get; init; }

    /// <summary>
    /// For 'openapi_key_update' activities: the type of update that was performed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keyUpdateType")]
    public KeyUpdateType? KeyUpdateType { get; init; }

    /// <summary>
    /// For role and actor-role activities: IDs of the affected roles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetRoleIds")]
    public IReadOnlyList<string>? TargetRoleIds { get; init; }

    /// <summary>
    /// For role and actor-role activities: names of the affected roles, when recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetRoleNames")]
    public IReadOnlyList<string>? TargetRoleNames { get; init; }

    /// <summary>
    /// For 'organization_member_update_roles' and 'organization_member_remove_roles' activities: IDs of the affected actors (e.g. 'user/&lt;id&gt;').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetActorIds")]
    public IReadOnlyList<string>? TargetActorIds { get; init; }

    /// <summary>
    /// For 'role_resources_delete' activities: IDs of the deleted resources the roles referenced.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetResourceIds")]
    public IReadOnlyList<string>? TargetResourceIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
