using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sets the default transaction isolation level for new transactions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DefaultTransactionIsolation>))]
public sealed record DefaultTransactionIsolation : StringEnum<DefaultTransactionIsolation>
{
    private DefaultTransactionIsolation(string value) : base(value)
    {
    }

    public static readonly DefaultTransactionIsolation ReadCommitted = new("read committed");

    public static readonly DefaultTransactionIsolation RepeatableRead = new("repeatable read");

    public static readonly DefaultTransactionIsolation Serializable = new("serializable");

    public static DefaultTransactionIsolation FromValue(string value) => FromValueCore(value);
}
