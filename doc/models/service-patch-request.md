
# Service Patch Request

*This model accepts additional fields of type object.*

## Structure

`ServicePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `IpAccessList` | [`IpAccessListPatch`](../../doc/models/ip-access-list-patch.md) | Optional | - |
| `PrivateEndpointIds` | [`InstancePrivateEndpointsPatch`](../../doc/models/instance-private-endpoints-patch.md) | Optional | - |
| `ReleaseChannel` | [`ReleaseChannel?`](../../doc/models/release-channel.md) | Optional | Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel. |
| `Endpoints` | [`List<ServiceEndpointChange>`](../../doc/models/service-endpoint-change.md) | Optional | List of service endpoints to change |
| `TransparentDataEncryptionKeyId` | `string` | Optional | The id of the key to rotate |
| `Tags` | [`InstanceTagsPatch`](../../doc/models/instance-tags-patch.md) | Optional | - |
| `EnableCoreDumps` | `bool?` | Optional | If true, the underlying infra is enabled for collecting core dumps. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServicePatchRequest servicePatchRequest = new ServicePatchRequest
{
    Name = "name8",
    IpAccessList = new IpAccessListPatch
    {
        MAdd = new List<IpAccessListEntry>
        {
            new IpAccessListEntry
            {
                Source = "source8",
                Description = "description4",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new IpAccessListEntry
            {
                Source = "source8",
                Description = "description4",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        MRemove = new List<IpAccessListEntry>
        {
            new IpAccessListEntry
            {
                Source = "source6",
                Description = "description0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    PrivateEndpointIds = new InstancePrivateEndpointsPatch
    {
        MAdd = new List<string>
        {
            "add6",
        },
        MRemove = new List<string>
        {
            "remove9",
            "remove0",
            "remove1",
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ReleaseChannel = ReleaseChannel.Fast,
    Endpoints = new List<ServiceEndpointChange>
    {
        new ServiceEndpointChange
        {
            Protocol = Protocol1.Mysql,
            Enabled = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

