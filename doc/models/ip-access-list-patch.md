
# Ip Access List Patch

*This model accepts additional fields of type object.*

## Structure

`IpAccessListPatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Add` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | Elements to add. Executed after "remove" part is processed. |
| `Remove` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | Elements to remove. Executed before "add" part is processed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

IpAccessListPatch ipAccessListPatch = new IpAccessListPatch
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
};
```

