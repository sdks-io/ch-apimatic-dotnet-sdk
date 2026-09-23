using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresServiceSetPassword
{
    /// <summary>
    /// Optional password. If not provided a new password is generated and provided in the response. Must contain:
    /// <list type="bullet">
    ///   <item><description>At least one lowercase letter</description></item>
    ///   <item><description>At least one uppercase letter</description></item>
    ///   <item><description>At least one digit</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    [RegularExpression("[a-z]")]
    public string? Password { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
