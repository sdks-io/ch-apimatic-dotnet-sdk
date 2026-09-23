using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use <c>minReplicaMemoryGb</c>, <c>maxReplicaMemoryGb</c>, and <c>numReplicas</c> instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Tier>))]
public sealed record Tier : StringEnum<Tier>
{
    private Tier(string value) : base(value)
    {
    }

    public static readonly Tier Development = new("development");

    public static readonly Tier Production = new("production");

    public static readonly Tier DedicatedHighMem = new("dedicated_high_mem");

    public static readonly Tier DedicatedHighCpu = new("dedicated_high_cpu");

    public static readonly Tier DedicatedStandard = new("dedicated_standard");

    public static readonly Tier DedicatedStandardN2DStandard4 = new("dedicated_standard_n2d_standard_4");

    public static readonly Tier DedicatedStandardN2DStandard8 = new("dedicated_standard_n2d_standard_8");

    public static readonly Tier DedicatedStandardN2DStandard32 = new("dedicated_standard_n2d_standard_32");

    public static readonly Tier DedicatedStandardN2DStandard128 = new("dedicated_standard_n2d_standard_128");

    public static readonly Tier DedicatedStandardN2DStandard3216Ssd = new("dedicated_standard_n2d_standard_32_16SSD");

    public static readonly Tier DedicatedStandardN2DStandard6424Ssd = new("dedicated_standard_n2d_standard_64_24SSD");

    public static Tier FromValue(string value) => FromValueCore(value);
}
