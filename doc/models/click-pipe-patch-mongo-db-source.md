
# Click Pipe Patch Mongo Db Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchMongoDbSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Plain`](../../doc/models/plain.md) | Optional | - |
| `Uri` | `string` | Required | MongoDB connection URI (mongodb:// or mongodb+srv://). Credentials are redacted in responses; a masked value is never saved as a credential, so a real credential equal to [REDACTED] cannot be set. To change the connection, send the full URI with real credentials; omit this field or resend the redacted value to leave it unchanged. |
| `ReadPreference` | [`ReadPreference?`](../../doc/models/read-preference.md) | Required | MongoDB read preference for replica set reads. |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the MongoDB connection. Defaults to false (TLS enabled). |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the MongoDB connection. Use with caution in production environments. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the MongoDB server certificate. |
| `Settings` | [`ClickPipePatchMongoDbPipeSettings`](../../doc/models/click-pipe-patch-mongo-db-pipe-settings.md) | Optional | - |
| `TableMappingsToAdd` | [`List<ClickPipeMongoDbPipeTableMapping>`](../../doc/models/click-pipe-mongo-db-pipe-table-mapping.md) | Optional | Collection mappings to add to the pipe. Can be an empty array if no collections are being added.<br><br>**Constraints**: *Minimum Items*: `0` |
| `TableMappingsToRemove` | [`List<ClickPipePatchMongoDbPipeRemoveTableMapping>`](../../doc/models/click-pipe-patch-mongo-db-pipe-remove-table-mapping.md) | Optional | Collection mappings to remove from the pipe. Only sourceDatabaseName, sourceCollection, and targetTable are required for removal.<br><br>**Constraints**: *Minimum Items*: `0` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchMongoDbSource clickPipePatchMongoDbSource = new ClickPipePatchMongoDbSource
{
    Uri = "mongodb+srv://cluster0.example.mongodb.net/mydb",
    ReadPreference = ReadPreference.SecondaryPreferred,
    Credentials = new Plain
    {
        Username = "username4",
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TlsHost = "cluster0.example.mongodb.net",
    DisableTls = false,
    SkipCertVerification = false,
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

