using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Webhook service type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Service1>))]
public sealed record Service1 : StringEnum<Service1>
{
    private Service1(string value) : base(value)
    {
    }

    public static readonly Service1 Slack = new("slack");

    public static readonly Service1 Incidentio = new("incidentio");

    public static readonly Service1 Generic = new("generic");

    public static Service1 FromValue(string value) => FromValueCore(value);
}
