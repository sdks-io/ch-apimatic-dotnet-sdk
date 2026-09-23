using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the ObjectStorage source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : StringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 S3 = new("s3");

    public static readonly Type5 Gcs = new("gcs");

    public static readonly Type5 Dospaces = new("dospaces");

    public static readonly Type5 Azureblobstorage = new("azureblobstorage");

    public static readonly Type5 Cloudflarer2 = new("cloudflarer2");

    public static readonly Type5 Ovhobjectstorage = new("ovhobjectstorage");

    public static Type5 FromValue(string value) => FromValueCore(value);
}
