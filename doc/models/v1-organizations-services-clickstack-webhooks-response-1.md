
# V1 Organizations Services Clickstack Webhooks Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackWebhooksResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackWebhook`](../../doc/models/containers/click-stack-webhook.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

V1OrganizationsServicesClickstackWebhooksResponse1 v1OrganizationsServicesClickstackWebhooksResponse1 = new V1OrganizationsServicesClickstackWebhooksResponse1
{
    Status = 200,
    RequestId = new Guid("000021e2-0000-0000-0000-000000000000"),
    Result = ClickStackWebhook.FromClickStackSlackWebhook(
        new ClickStackSlackWebhook
        {
            Id = "id0",
            Name = "name0",
            Service = "service0",
            UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Url = "url4",
            Description = "description0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

