
# Click Stack Webhook Input

*This model accepts additional fields of type object.*

## Structure

`ClickStackWebhookInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Webhook name. Must be unique per service within the team. |
| `Service` | [`Service1`](../../doc/models/service-1.md) | Required | Webhook service type. |
| `Url` | `string` | Required | Webhook destination URL. |
| `Description` | `string` | Optional | Webhook description, shown in the UI. |
| `Body` | `string` | Optional | Optional request body template. Only for generic/incidentio; rejected for slack. |
| `Headers` | `Dictionary<string, string>` | Optional | - |
| `QueryParams` | `Dictionary<string, string>` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackWebhookInput clickStackWebhookInput = new ClickStackWebhookInput
{
    Name = "Production Alerts",
    Service = Service1.Slack,
    Url = "https://hooks.slack.com/services/EXAMPLE/WEBHOOK/URL",
    Description = "Sends critical alerts to the #incidents channel",
    Body = "{\"alert\": \"{{title}}\", \"severity\": \"{{level}}\"}",
    Headers = new Dictionary<string, string>
    {
        ["key0"] = "headers9",
    },
    QueryParams = new Dictionary<string, string>
    {
        ["key0"] = "queryParams9",
        ["key1"] = "queryParams8",
        ["key2"] = "queryParams7",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

