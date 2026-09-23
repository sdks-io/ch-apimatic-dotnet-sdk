
# Instance Private Endpoints Patch

*This model accepts additional fields of type object.*

## Structure

`InstancePrivateEndpointsPatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Add` | `List<string>` | Optional | Elements to add. Executed after "remove" part is processed. |
| `Remove` | `List<string>` | Optional | Elements to remove. Executed before "add" part is processed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

InstancePrivateEndpointsPatch instancePrivateEndpointsPatch = new InstancePrivateEndpointsPatch
{
    MAdd = new List<string>
    {
        "add4",
        "add5",
    },
    MRemove = new List<string>
    {
        "remove9",
        "remove0",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

