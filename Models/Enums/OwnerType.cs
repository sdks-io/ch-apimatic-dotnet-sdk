using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Owner type of the Query API endpoint. Endpoints with a user owned query cannot be updated or deleted through this API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OwnerType>))]
public sealed record OwnerType : StringEnum<OwnerType>
{
    private OwnerType(string value) : base(value)
    {
    }

    public static readonly OwnerType User = new("user");

    public static readonly OwnerType QueryApiEndpoint = new("queryApiEndpoint");

    public static OwnerType FromValue(string value) => FromValueCore(value);
}
