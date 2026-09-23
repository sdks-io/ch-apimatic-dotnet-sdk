using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method. IAM_USER is for S3, GCS, and DigitalOcean Spaces. IAM_ROLE is for S3 only. SERVICE_ACCOUNT is for GCS only. For GCS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. CONNECTION_STRING is for Azure Blob Storage. PUBLIC uses no authentication.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication8>))]
public sealed record Authentication8 : StringEnum<Authentication8>
{
    private Authentication8(string value) : base(value)
    {
    }

    public static readonly Authentication8 IamRole = new("IAM_ROLE");

    public static readonly Authentication8 IamUser = new("IAM_USER");

    public static readonly Authentication8 ConnectionString = new("CONNECTION_STRING");

    public static readonly Authentication8 ServiceAccount = new("SERVICE_ACCOUNT");

    public static readonly Authentication8 ServiceAccountWorkloadIdentity = new("SERVICE_ACCOUNT_WORKLOAD_IDENTITY");

    public static Authentication8 FromValue(string value) => FromValueCore(value);
}
