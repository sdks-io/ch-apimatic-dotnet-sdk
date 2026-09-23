using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresServicePatchRequest
{
    /// <summary>
    /// Name of the Postgres service. Alphanumerical string with whitespaces up to 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(50, MinimumLength = 1)]
    public string? Name { get; init; }

    /// <summary>
    /// The VM size for a Postgres service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public VmSize? Size { get; init; }

    /// <summary>
    /// Type of high availability: “none” for no replication, “async” for asynchronous replication to a single standby, and “sync” for synchronous replication to two standbys.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("haType")]
    public PgHaType? HaType { get; init; }

    /// <summary>
    /// Tags associated with the Postgres service. Tag keys starting with “chc_” are reserved for internal use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    [MaxLength(50)]
    public IReadOnlyList<ResourceTagsV1>? Tags { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
