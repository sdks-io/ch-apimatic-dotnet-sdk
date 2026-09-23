using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Format of the Kafka source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Format>))]
public sealed record Format : StringEnum<Format>
{
    private Format(string value) : base(value)
    {
    }

    public static readonly Format JsonEachRow = new("JSONEachRow");

    public static readonly Format Avro = new("Avro");

    public static readonly Format AvroConfluent = new("AvroConfluent");

    public static readonly Format Protobuf = new("Protobuf");

    public static Format FromValue(string value) => FromValueCore(value);
}
