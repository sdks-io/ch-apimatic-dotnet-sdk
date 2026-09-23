using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication method of the Kafka source. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. Supported authentication methods: kafka: PLAIN, SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, msk: SCRAM-SHA-512, IAM_ROLE, IAM_USER, MUTUAL_TLS, gcmk: PLAIN, MUTUAL_TLS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY, confluent: PLAIN, MUTUAL_TLS, warpstream: PLAIN, azureeventhub: PLAIN, redpanda: SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, dokafka: SCRAM-SHA-256, MUTUAL_TLS
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication2>))]
public sealed record Authentication2 : StringEnum<Authentication2>
{
    private Authentication2(string value) : base(value)
    {
    }

    public static readonly Authentication2 Plain = new("PLAIN");

    public static readonly Authentication2 ScramSha256 = new("SCRAM-SHA-256");

    public static readonly Authentication2 ScramSha512 = new("SCRAM-SHA-512");

    public static readonly Authentication2 IamRole = new("IAM_ROLE");

    public static readonly Authentication2 IamUser = new("IAM_USER");

    public static readonly Authentication2 MutualTls = new("MUTUAL_TLS");

    public static readonly Authentication2 ServiceAccountWorkloadIdentity = new("SERVICE_ACCOUNT_WORKLOAD_IDENTITY");

    public static Authentication2 FromValue(string value) => FromValueCore(value);
}
