using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method for Postgres connection.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication11>))]
public sealed record Authentication11 : StringEnum<Authentication11>
{
    private Authentication11(string value) : base(value)
    {
    }

    public static readonly Authentication11 Basic = new("basic");

    public static readonly Authentication11 IamRole = new("IAM_ROLE");

    public static Authentication11 FromValue(string value) => FromValueCore(value);
}
