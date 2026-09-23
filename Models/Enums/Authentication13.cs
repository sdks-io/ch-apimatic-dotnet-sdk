using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method for MySQL connection.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication13>))]
public sealed record Authentication13 : StringEnum<Authentication13>
{
    private Authentication13(string value) : base(value)
    {
    }

    public static readonly Authentication13 Basic = new("basic");

    public static readonly Authentication13 IamRole = new("IAM_ROLE");

    public static Authentication13 FromValue(string value) => FromValueCore(value);
}
