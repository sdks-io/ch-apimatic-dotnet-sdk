using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the actor: 'user', 'support', 'system', 'api'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActorType>))]
public sealed record ActorType : StringEnum<ActorType>
{
    private ActorType(string value) : base(value)
    {
    }

    public static readonly ActorType User = new("user");

    public static readonly ActorType Support = new("support");

    public static readonly ActorType System = new("system");

    public static readonly ActorType Api = new("api");

    public static ActorType FromValue(string value) => FromValueCore(value);
}
