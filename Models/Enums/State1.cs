using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// State of the infrastructure
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State1>))]
public sealed record State1 : StringEnum<State1>
{
    private State1(string value) : base(value)
    {
    }

    public static readonly State1 InfraReady = new("infra-ready");

    public static readonly State1 InfraProvisioning = new("infra-provisioning");

    public static readonly State1 InfraTerminated = new("infra-terminated");

    public static State1 FromValue(string value) => FromValueCore(value);
}
