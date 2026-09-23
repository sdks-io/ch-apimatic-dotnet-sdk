using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipesCdcScaling
{
    /// <summary>
    /// CPU in millicores for DB ClickPipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaCpuMillicores")]
    [Minimum(1000)]
    [Maximum(32000)]
    [MultipleOf(1000)]
    public int? ReplicaCpuMillicores { get; init; }

    /// <summary>
    /// Memory in GiB for DB ClickPipes. Must be 4× the CPU core count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaMemoryGb")]
    [Minimum(4.0)]
    [Maximum(128.0)]
    [MultipleOf(4)]
    public double? ReplicaMemoryGb { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
