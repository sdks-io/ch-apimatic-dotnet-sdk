using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PrivateEndpointConfig
{
    /// <summary>
    /// Unique identifier of the interface endpoint you created in your VPC with the AWS(Service Name), GCP(Target Service) or AZURE (Private Link Service) resource
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpointServiceId")]
    public string? EndpointServiceId { get; init; }

    /// <summary>
    /// Private DNS Hostname of the VPC you created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privateDnsHostname")]
    public string? PrivateDnsHostname { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
