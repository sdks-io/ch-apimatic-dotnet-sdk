using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Executable UDF type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : StringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 Executable = new("executable");

    public static readonly Type22 ExecutablePool = new("executable_pool");

    public static Type22 FromValue(string value) => FromValueCore(value);
}
