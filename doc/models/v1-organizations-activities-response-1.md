
# V1 Organizations Activities Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsActivitiesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`Activity`](../../doc/models/activity.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

V1OrganizationsActivitiesResponse1 v1OrganizationsActivitiesResponse1 = new V1OrganizationsActivitiesResponse1
{
    Status = 200,
    RequestId = new Guid("0000142a-0000-0000-0000-000000000000"),
    Result = new Activity
    {
        Id = "id6",
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Type = Type12.ServiceRunning,
        ActorType = ActorType.User,
        ActorId = "actorId6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

