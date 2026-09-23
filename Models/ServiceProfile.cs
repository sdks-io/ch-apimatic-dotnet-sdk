using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceProfile
{
    /// <summary>
    /// Profile name to pass as <c>profile</c> when creating a service (e.g. 'v1-standard-byoc-4').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    /// <summary>
    /// Number of vCPUs per replica.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cpuCores")]
    public double? CpuCores { get; init; }

    /// <summary>
    /// Memory per replica in GiB. When creating a BYOC service with this profile, minReplicaMemoryGb and maxReplicaMemoryGb must both equal this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memoryGi")]
    public double? MemoryGi { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
