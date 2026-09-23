using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Role3>))]
public sealed record Role3 : StringEnum<Role3>
{
    private Role3(string value) : base(value)
    {
    }

    public static readonly Role3 Admin = new("admin");

    public static readonly Role3 Developer = new("developer");

    public static readonly Role3 QueryEndpoints = new("query_endpoints");

    public static Role3 FromValue(string value) => FromValueCore(value);
}
