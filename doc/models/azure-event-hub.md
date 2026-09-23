
# Azure Event Hub

*This model accepts additional fields of type object.*

## Structure

`AzureEventHub`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConnectionString` | `string` | Optional | Connection string for Azure EventHub source. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AzureEventHub azureEventHub = new AzureEventHub
{
    ConnectionString = "connectionString0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

