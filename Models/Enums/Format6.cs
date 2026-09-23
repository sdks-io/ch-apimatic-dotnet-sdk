using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Format of messages in the Pub/Sub topic. GCP Pub/Sub ClickPipes are in limited preview — contact support to enable this feature for your organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Format6>))]
public sealed record Format6 : StringEnum<Format6>
{
    private Format6(string value) : base(value)
    {
    }

    public static readonly Format6 JsonEachRow = new("JSONEachRow");

    public static readonly Format6 Avro = new("Avro");

    public static readonly Format6 Protobuf = new("Protobuf");

    public static Format6 FromValue(string value) => FromValueCore(value);
}
