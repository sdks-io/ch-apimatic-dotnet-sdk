
# Click Pipe Patch Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kafka` | [`ClickPipePatchKafkaSource`](../../doc/models/click-pipe-patch-kafka-source.md) | Optional | - |
| `ObjectStorage` | [`ClickPipePatchObjectStorageSource`](../../doc/models/click-pipe-patch-object-storage-source.md) | Optional | - |
| `Kinesis` | [`ClickPipePatchKinesisSource`](../../doc/models/click-pipe-patch-kinesis-source.md) | Optional | - |
| `Pubsub` | [`ClickPipePatchPubSubSource`](../../doc/models/click-pipe-patch-pub-sub-source.md) | Optional | - |
| `Postgres` | [`ClickPipePatchPostgresSource`](../../doc/models/click-pipe-patch-postgres-source.md) | Optional | - |
| `Mysql` | [`ClickPipePatchMySqlSource`](../../doc/models/click-pipe-patch-my-sql-source.md) | Optional | - |
| `Mongodb` | [`ClickPipePatchMongoDbSource`](../../doc/models/click-pipe-patch-mongo-db-source.md) | Optional | - |
| `ValidateSamples` | `bool?` | Optional | Validate data samples received from data source. It will validate the connection and data availability and correctness. If not enabled, only connection will be validated. This has no effect on Postgres or MySQL pipes, they always only validate the connection and table definitions. This is experimental and can be removed in the future. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePatchSource clickPipePatchSource = new ClickPipePatchSource
{
    Kafka = new ClickPipePatchKafkaSource
    {
        Authentication = Authentication2.Plain,
        IamRole = "iamRole6",
        CaCertificate = "caCertificate2",
        ReversePrivateEndpointIds = new List<string>
        {
            "reversePrivateEndpointIds8",
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
    },
    ObjectStorage = new ClickPipePatchObjectStorageSource
    {
        SkipInitialLoad = false,
        StartAfter = "startAfter6",
        Authentication = Authentication8.IamUser,
        IamRole = "iamRole6",
        ConnectionString = "connectionString6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Kinesis = new ClickPipePatchKinesisSource
    {
        Authentication = Authentication5.IamRole,
        IamRole = "iamRole8",
        AccessKey = new MskIamUser
        {
            AccessKeyId = "accessKeyId8",
            SecretKey = "secretKey6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Pubsub = new ClickPipePatchPubSubSource
    {
        Authentication = Authentication17.ServiceAccount,
        AckDeadline = 104,
        ServiceAccountKey = new ServiceAccount
        {
            ServiceAccountFile = "serviceAccountFile8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Postgres = new ClickPipePatchPostgresSource
    {
        Credentials = new Plain
        {
            Username = "username4",
            Password = "password0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Host = "host2",
        Port = 80,
        Database = "database0",
        TlsHost = "tlsHost4",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

