using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method to use with the Kinesis stream.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication5>))]
public sealed record Authentication5 : StringEnum<Authentication5>
{
    private Authentication5(string value) : base(value)
    {
    }

    public static readonly Authentication5 IamRole = new("IAM_ROLE");

    public static readonly Authentication5 IamUser = new("IAM_USER");

    public static Authentication5 FromValue(string value) => FromValueCore(value);
}
