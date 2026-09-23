
# Instance Tags Patch

*This model accepts additional fields of type object.*

## Structure

`InstanceTagsPatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Add` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Elements to add. Executed after "remove" part is processed.<br><br>**Constraints**: *Maximum Items*: `50` |
| `Remove` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Elements to remove. Executed before "add" part is processed.<br><br>**Constraints**: *Maximum Items*: `50` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

InstanceTagsPatch instanceTagsPatch = new InstanceTagsPatch
{
    MAdd = new List<ResourceTagsV1>
    {
        new ResourceTagsV1
        {
            Key = "key6",
            MValue = "value8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ResourceTagsV1
        {
            Key = "key6",
            MValue = "value8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ResourceTagsV1
        {
            Key = "key6",
            MValue = "value8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    MRemove = new List<ResourceTagsV1>
    {
        new ResourceTagsV1
        {
            Key = "key0",
            MValue = "value2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ResourceTagsV1
        {
            Key = "key0",
            MValue = "value2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

