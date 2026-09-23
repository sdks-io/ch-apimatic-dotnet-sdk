using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Stable identifier of the quota. Use it to request a single quota by code.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<QuotaCode>))]
public sealed record QuotaCode : StringEnum<QuotaCode>
{
    private QuotaCode(string value) : base(value)
    {
    }

    public static readonly QuotaCode ServicesPerOrganization = new("services-per-organization");

    public static readonly QuotaCode PostgresServicesPerOrganization = new("postgres-services-per-organization");

    public static readonly QuotaCode ReplicasPerWarehouse = new("replicas-per-warehouse");

    public static readonly QuotaCode ApiKeysPerOrganization = new("api-keys-per-organization");

    public static QuotaCode FromValue(string value) => FromValueCore(value);
}
