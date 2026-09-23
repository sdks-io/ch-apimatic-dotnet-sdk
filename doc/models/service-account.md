
# Service Account

*This model accepts additional fields of type object.*

## Structure

`ServiceAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceAccountFile` | `string` | Required | Google Cloud service account JSON key file content, base64 encoded. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceAccount serviceAccount = new ServiceAccount
{
    ServiceAccountFile = "serviceAccountFile0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

