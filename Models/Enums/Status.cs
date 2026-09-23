using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Reverse private endpoint status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Unknown = new("Unknown");

    public static readonly Status Provisioning = new("Provisioning");

    public static readonly Status Deleting = new("Deleting");

    public static readonly Status Ready = new("Ready");

    public static readonly Status Failed = new("Failed");

    public static readonly Status PendingAcceptance = new("PendingAcceptance");

    public static readonly Status Rejected = new("Rejected");

    public static readonly Status Expired = new("Expired");

    public static Status FromValue(string value) => FromValueCore(value);
}
