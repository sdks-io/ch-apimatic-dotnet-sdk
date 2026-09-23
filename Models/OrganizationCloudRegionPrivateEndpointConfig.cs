using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record OrganizationCloudRegionPrivateEndpointConfig
{
    /// <summary>
    /// Unique identifier of the interface endpoint you created in your VPC with the AWS(Service Name) or GCP(Target Service) resource
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpointServiceId")]
    public string? EndpointServiceId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
