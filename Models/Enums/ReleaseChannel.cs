using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReleaseChannel>))]
public sealed record ReleaseChannel : StringEnum<ReleaseChannel>
{
    private ReleaseChannel(string value) : base(value)
    {
    }

    public static readonly ReleaseChannel Slow = new("slow");

    public static readonly ReleaseChannel Default = new("default");

    public static readonly ReleaseChannel Fast = new("fast");

    public static ReleaseChannel FromValue(string value) => FromValueCore(value);
}
