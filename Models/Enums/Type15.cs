using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Category of the error.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type15>))]
public sealed record Type15 : StringEnum<Type15>
{
    private Type15(string value) : base(value)
    {
    }

    public static readonly Type15 QueryError = new("QUERY_ERROR");

    public static readonly Type15 QueryTimeout = new("QUERY_TIMEOUT");

    public static readonly Type15 WebhookError = new("WEBHOOK_ERROR");

    public static readonly Type15 InvalidAlert = new("INVALID_ALERT");

    public static readonly Type15 Unknown = new("UNKNOWN");

    public static Type15 FromValue(string value) => FromValueCore(value);
}
