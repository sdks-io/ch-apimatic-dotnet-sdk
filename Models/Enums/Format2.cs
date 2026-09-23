using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Format of the Kinesis stream.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Format2>))]
public sealed record Format2 : StringEnum<Format2>
{
    private Format2(string value) : base(value)
    {
    }

    public static readonly Format2 JsonEachRow = new("JSONEachRow");

    public static readonly Format2 Avro = new("Avro");

    public static readonly Format2 AvroConfluent = new("AvroConfluent");

    public static readonly Format2 Protobuf = new("Protobuf");

    public static Format2 FromValue(string value) => FromValueCore(value);
}
