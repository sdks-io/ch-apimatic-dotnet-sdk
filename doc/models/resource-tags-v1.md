
# Resource Tags V1

*This model accepts additional fields of type object.*

## Structure

`ResourceTagsV1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Required | Tag key. Must be alphanumeric with dashes, underscores and dots.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^[a-zA-Z0-9._-]+$` |
| `MValue` | `string` | Optional | Tag value. Must be alphanumeric with dashes, underscores and dots.<br><br>**Constraints**: *Maximum Length*: `256`, *Pattern*: `^[a-zA-Z0-9._-]+$` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

ResourceTagsV1 resourceTagsV1 = new ResourceTagsV1
{
    Key = "Environment",
    MValue = "staging",
};
```

