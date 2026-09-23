using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Output format applied to the number.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Output>))]
public sealed record Output : StringEnum<Output>
{
    private Output(string value) : base(value)
    {
    }

    public static readonly Output Currency = new("currency");

    public static readonly Output Percent = new("percent");

    public static readonly Output Byte = new("byte");

    public static readonly Output Time = new("time");

    public static readonly Output Number = new("number");

    public static readonly Output DataRate = new("data_rate");

    public static readonly Output Throughput = new("throughput");

    public static readonly Output Duration = new("duration");

    public static Output FromValue(string value) => FromValueCore(value);
}
