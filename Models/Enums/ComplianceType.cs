using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of regulatory compliance for service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ComplianceType>))]
public sealed record ComplianceType : StringEnum<ComplianceType>
{
    private ComplianceType(string value) : base(value)
    {
    }

    public static readonly ComplianceType Hipaa = new("hipaa");

    public static readonly ComplianceType Pci = new("pci");

    public static ComplianceType FromValue(string value) => FromValueCore(value);
}
