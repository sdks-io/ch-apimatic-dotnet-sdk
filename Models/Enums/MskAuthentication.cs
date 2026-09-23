using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// MSK cluster authentication type. Required for MSK_MULTI_VPC type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MskAuthentication>))]
public sealed record MskAuthentication : StringEnum<MskAuthentication>
{
    private MskAuthentication(string value) : base(value)
    {
    }

    public static readonly MskAuthentication SaslIam = new("SASL_IAM");

    public static readonly MskAuthentication SaslScram = new("SASL_SCRAM");

    public static MskAuthentication FromValue(string value) => FromValueCore(value);
}
