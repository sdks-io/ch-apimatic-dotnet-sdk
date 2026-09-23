using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of iterator to use when reading from the Kinesis stream. If AT_TIMESTAMP is used, the timestamp field must be provided.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IteratorType>))]
public sealed record IteratorType : StringEnum<IteratorType>
{
    private IteratorType(string value) : base(value)
    {
    }

    public static readonly IteratorType TrimHorizon = new("TRIM_HORIZON");

    public static readonly IteratorType Latest = new("LATEST");

    public static readonly IteratorType AtTimestamp = new("AT_TIMESTAMP");

    public static IteratorType FromValue(string value) => FromValueCore(value);
}
