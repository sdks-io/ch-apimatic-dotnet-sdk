
# Scim Patch Operation

*This model accepts additional fields of type object.*

## Structure

`ScimPatchOperation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Op` | [`Op`](../../doc/models/op.md) | Required | The operation to perform. |
| `Path` | `string` | Optional | Target attribute path (e.g. "active", "userName"). |
| `MValue` | `string` | Optional | New value for the attribute. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimPatchOperation scimPatchOperation = new ScimPatchOperation
{
    Op = Op.Replace,
    Path = "path8",
    MValue = "value6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

