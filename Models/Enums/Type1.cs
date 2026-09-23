using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Reverse private endpoint type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 VpcEndpointService = new("VPC_ENDPOINT_SERVICE");

    public static readonly Type1 VpcResource = new("VPC_RESOURCE");

    public static readonly Type1 MskMultiVpc = new("MSK_MULTI_VPC");

    public static readonly Type1 GcpPscServiceAttachment = new("GCP_PSC_SERVICE_ATTACHMENT");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
