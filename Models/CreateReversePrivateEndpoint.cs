using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record CreateReversePrivateEndpoint
{
    /// <summary>
    /// Reverse private endpoint description. Maximum length is 255 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Reverse private endpoint type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type1? Type { get; init; }

    /// <summary>
    /// VPC endpoint service name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vpcEndpointServiceName")]
    public string? VpcEndpointServiceName { get; init; }

    /// <summary>
    /// VPC resource configuration ID. Required for VPC_RESOURCE type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vpcResourceConfigurationId")]
    public string? VpcResourceConfigurationId { get; init; }

    /// <summary>
    /// VPC resource share ARN. Required for VPC_RESOURCE type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vpcResourceShareArn")]
    public string? VpcResourceShareArn { get; init; }

    /// <summary>
    /// MSK cluster ARN. Required for MSK_MULTI_VPC type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; init; }

    /// <summary>
    /// MSK cluster authentication type. Required for MSK_MULTI_VPC type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mskAuthentication")]
    public MskAuthentication? MskAuthentication { get; init; }

    /// <summary>
    /// Private Preview. GCP PSC service attachment URI. Required for GCP_PSC_SERVICE_ATTACHMENT type. Format: projects/{project}/regions/{region}/serviceAttachments/{name}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gcpServiceAttachment")]
    public string? GcpServiceAttachment { get; init; }

    /// <summary>
    /// Optional private DNS names for Reverse Private Endpoint. Can be used as data source destination address. Must be unique across the ClickHouse service.
    /// Generally available for Google Private Service Connect (PSC). For AWS PrivateLink (VPC endpoint service and VPC resource), available in Private Preview; contact ClickHouse support to enable it for your service. Not supported for MSK multi-VPC.
    /// Supports exact names and leading wildcard names such as *.example.com
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customPrivateDnsMappings")]
    public IReadOnlyList<CustomPrivateDnsMapping>? CustomPrivateDnsMappings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
