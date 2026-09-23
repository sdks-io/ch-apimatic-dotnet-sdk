using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Reason the attachment could not be started.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code>))]
public sealed record Code : StringEnum<Code>
{
    private Code(string value) : base(value)
    {
    }

    public static readonly Code ServiceIdle = new("SERVICE_IDLE");

    public static readonly Code ServiceNotRunning = new("SERVICE_NOT_RUNNING");

    public static readonly Code ServiceStopped = new("SERVICE_STOPPED");

    public static Code FromValue(string value) => FromValueCore(value);
}
