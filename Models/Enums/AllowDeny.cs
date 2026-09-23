using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Whether this policy allows or denies access
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AllowDeny>))]
public sealed record AllowDeny : StringEnum<AllowDeny>
{
    private AllowDeny(string value) : base(value)
    {
    }

    public static readonly AllowDeny Allow = new("ALLOW");

    public static readonly AllowDeny Deny = new("DENY");

    public static AllowDeny FromValue(string value) => FromValueCore(value);
}
