
# Click Pipe Schema Discovery Response

*This model accepts additional fields of type object.*

## Structure

`ClickPipeSchemaDiscoveryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Fields` | [`List<ClickPipeSchemaDiscoveryField>`](../../doc/models/click-pipe-schema-discovery-field.md) | Optional | Inferred schema fields with their ClickHouse data types. |
| `Meta` | `Dictionary<string, string>` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeSchemaDiscoveryResponse clickPipeSchemaDiscoveryResponse = new ClickPipeSchemaDiscoveryResponse
{
    Fields = new List<ClickPipeSchemaDiscoveryField>
    {
        new ClickPipeSchemaDiscoveryField
        {
            Name = "name8",
            Type = "type2",
            Optional = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeSchemaDiscoveryField
        {
            Name = "name8",
            Type = "type2",
            Optional = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeSchemaDiscoveryField
        {
            Name = "name8",
            Type = "type2",
            Optional = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Meta = new Dictionary<string, string>
    {
        ["key0"] = "meta9",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

