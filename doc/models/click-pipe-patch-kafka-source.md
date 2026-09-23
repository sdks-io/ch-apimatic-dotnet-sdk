
# Click Pipe Patch Kafka Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchKafkaSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Authentication` | [`Authentication2?`](../../doc/models/authentication-2.md) | Optional | Authentication method of the Kafka source. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources. Supported authentication methods: kafka: PLAIN, SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, msk: SCRAM-SHA-512, IAM_ROLE, IAM_USER, MUTUAL_TLS, gcmk: PLAIN, MUTUAL_TLS, SERVICE_ACCOUNT_WORKLOAD_IDENTITY, confluent: PLAIN, MUTUAL_TLS, warpstream: PLAIN, azureeventhub: PLAIN, redpanda: SCRAM-SHA-256, SCRAM-SHA-512, MUTUAL_TLS, dokafka: SCRAM-SHA-256, MUTUAL_TLS |
| `IamRole` | `string` | Optional | IAM role for the Kafka source. Use with IAM role authentication. Read more in ClickPipes documentation: https://clickhouse.com/docs/en/integrations/clickpipes/kafka#iam |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificates to validate the broker's certificate. |
| `ReversePrivateEndpointIds` | `List<string>` | Optional | Reverse private endpoint UUIDs used for a secure private connection to the Kafka source. |
| `Credentials` | [`ClickPipePatchKafkaSourceCredentials`](../../doc/models/containers/click-pipe-patch-kafka-source-credentials.md) | Optional | This is a container for one-of cases. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePatchKafkaSource clickPipePatchKafkaSource = new ClickPipePatchKafkaSource
{
    Authentication = Authentication2.Scramsha256,
    IamRole = "arn:aws:iam::123456789012:role/MyRole",
    CaCertificate = "caCertificate2",
    ReversePrivateEndpointIds = new List<string>
    {
        "reversePrivateEndpointIds2",
        "reversePrivateEndpointIds1",
        "reversePrivateEndpointIds0",
    },
    Credentials = ClickPipePatchKafkaSourceCredentials.FromPLAIN(
        new Plain
        {
            Username = "username6",
            Password = "password8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

