
# V1 Organizations Services Clickpipes Click Pipe Id Settings Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickPipeSettings`](../../doc/models/click-pipe-settings.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse v1OrganizationsServicesClickpipesClickPipeIdSettingsResponse = new V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse
{
    Status = 200,
    RequestId = new Guid("00001c72-0000-0000-0000-000000000000"),
    Result = new ClickPipeSettings
    {
        StreamingMaxInsertWaitMs = 500,
        ObjectStorageConcurrency = 35,
        ObjectStoragePollingIntervalMs = 100,
        ObjectStorageMaxInsertBytes = 524288000L,
        ObjectStorageMaxFileCount = 90,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

