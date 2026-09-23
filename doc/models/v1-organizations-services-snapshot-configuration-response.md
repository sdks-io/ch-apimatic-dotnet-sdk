
# V1 Organizations Services Snapshot Configuration Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesSnapshotConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`SnapshotConfiguration`](../../doc/models/snapshot-configuration.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesSnapshotConfigurationResponse v1OrganizationsServicesSnapshotConfigurationResponse = new V1OrganizationsServicesSnapshotConfigurationResponse
{
    Status = 200,
    RequestId = new Guid("00001310-0000-0000-0000-000000000000"),
    Result = new SnapshotConfiguration
    {
        Enabled = false,
        Gap = 65.7,
        TimeFrame = 56.12,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

