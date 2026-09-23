using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipesGcpWorkloadIdentityContext
{
    /// <summary>
    /// Whether the ClickPipes deployment supports GCP workload identity, which is in Private Preview. The principal field identifies the GCP service account used for source access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supported")]
    public bool? Supported { get; init; }

    /// <summary>
    /// Whether the service tenant identity is ready for workload identity authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ready")]
    public bool? Ready { get; init; }

    /// <summary>
    /// GCP service account used by ClickPipes for workload identity authentication. Grant this service account access to customer source resources.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("principal")]
    public string? Principal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
