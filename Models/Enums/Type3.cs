using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the Kafka source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Kafka = new("kafka");

    public static readonly Type3 Redpanda = new("redpanda");

    public static readonly Type3 Msk = new("msk");

    public static readonly Type3 Gcmk = new("gcmk");

    public static readonly Type3 Confluent = new("confluent");

    public static readonly Type3 Warpstream = new("warpstream");

    public static readonly Type3 Azureeventhub = new("azureeventhub");

    public static readonly Type3 Dokafka = new("dokafka");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
