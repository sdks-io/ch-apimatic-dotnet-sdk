
# Issue

## Structure

`Issue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Path` | [`List<IssuePath>`](../../doc/models/containers/issue-path.md) | Required | This is List of a container for any-of cases. |
| `Code` | `string` | Required | Validation issue code. |
| `Message` | `string` | Required | Human-readable description of the issue. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;

Issue issue = new Issue
{
    Path = new List<IssuePath>
    {
        IssuePath.FromString("String1"),
        IssuePath.FromString("String2"),
    },
    Code = "code2",
    Message = "message4",
};
```

