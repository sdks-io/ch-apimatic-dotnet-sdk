using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method to use with GCP Pub/Sub. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication17>))]
public sealed record Authentication17 : StringEnum<Authentication17>
{
    private Authentication17(string value) : base(value)
    {
    }

    public static readonly Authentication17 ServiceAccount = new("SERVICE_ACCOUNT");

    public static readonly Authentication17 ServiceAccountWorkloadIdentity = new("SERVICE_ACCOUNT_WORKLOAD_IDENTITY");

    public static Authentication17 FromValue(string value) => FromValueCore(value);
}
