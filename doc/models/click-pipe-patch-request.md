
# Click Pipe Patch Request

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the ClickPipe. |
| `Source` | [`ClickPipePatchSource`](../../doc/models/click-pipe-patch-source.md) | Optional | - |
| `Destination` | [`ClickPipePatchDestination`](../../doc/models/click-pipe-patch-destination.md) | Optional | - |
| `FieldMappings` | [`List<ClickPipeFieldMapping>`](../../doc/models/click-pipe-field-mapping.md) | Optional | Field mappings of the ClickPipe. This will not update the table schema, only the ClickPipe configuration. |
| `Settings` | [`ClickPipeSettings`](../../doc/models/click-pipe-settings.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePatchRequest clickPipePatchRequest = new ClickPipePatchRequest
{
    Name = "name6",
    Source = new ClickPipePatchSource
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
    },
    Destination = new ClickPipePatchDestination
    {
        Columns = new List<ClickPipeDestinationColumn>
        {
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ClickPipeDestinationColumn
            {
                Name = "name0",
                Type = "type0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    FieldMappings = new List<ClickPipeFieldMapping>
    {
        new ClickPipeFieldMapping
        {
            SourceField = "sourceField4",
            DestinationField = "destinationField6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeFieldMapping
        {
            SourceField = "sourceField4",
            DestinationField = "destinationField6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeFieldMapping
        {
            SourceField = "sourceField4",
            DestinationField = "destinationField6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Settings = new ClickPipeSettings
    {
        StreamingMaxInsertWaitMs = 500,
        ObjectStorageConcurrency = 35,
        ObjectStoragePollingIntervalMs = 100,
        ObjectStorageMaxInsertBytes = 524288000L,
        ObjectStorageMaxFileCount = 30,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

