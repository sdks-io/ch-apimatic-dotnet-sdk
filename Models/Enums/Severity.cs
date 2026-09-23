using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Severity label used by PagerDuty API webhooks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Severity>))]
public sealed record Severity : StringEnum<Severity>
{
    private Severity(string value) : base(value)
    {
    }

    public static readonly Severity Critical = new("critical");

    public static readonly Severity Error = new("error");

    public static readonly Severity Warning = new("warning");

    public static readonly Severity Info = new("info");

    public static Severity FromValue(string value) => FromValueCore(value);
}
