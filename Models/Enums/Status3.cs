using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Current attachment lifecycle state.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status3>))]
public sealed record Status3 : StringEnum<Status3>
{
    private Status3(string value) : base(value)
    {
    }

    public static readonly Status3 Deployed = new("deployed");

    public static readonly Status3 Deprovisioning = new("deprovisioning");

    public static readonly Status3 Error = new("error");

    public static readonly Status3 Provisioning = new("provisioning");

    public static readonly Status3 Standby = new("standby");

    public static Status3 FromValue(string value) => FromValueCore(value);
}
