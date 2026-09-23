
# Scim Patch Op

*This model accepts additional fields of type object.*

## Structure

`ScimPatchOp`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | Must include "urn:ietf:params:scim:api:messages:2.0:PatchOp". |
| `Operations` | [`List<ScimPatchOperation>`](../../doc/models/scim-patch-operation.md) | Required | List of PATCH operations to apply. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimPatchOp scimPatchOp = new ScimPatchOp
{
    Schemas = new List<string>
    {
        "schemas1",
    },
    Operations = new List<ScimPatchOperation>
    {
        new ScimPatchOperation
        {
            Op = Op.Replace,
            Path = "path0",
            MValue = "value8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

