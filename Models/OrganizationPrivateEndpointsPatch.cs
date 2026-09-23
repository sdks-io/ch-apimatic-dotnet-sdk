using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record OrganizationPrivateEndpointsPatch
{
    /// <summary>
    /// DEPRECATED. Elements to add. Executed after "remove" part is processed. Please use the <c>Update Service Basic Details</c> endpoint with the <c>privateEndpointIds</c> field instead to modify the private endpoints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    public IReadOnlyList<OrganizationPatchPrivateEndpoint>? Add { get; init; }

    /// <summary>
    /// Elements to remove. Executed before "add" part is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remove")]
    public IReadOnlyList<OrganizationPatchPrivateEndpoint>? Remove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
