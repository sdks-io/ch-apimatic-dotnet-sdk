
# Udf Attachment

## Structure

`UdfAttachment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FunctionName` | `string` | Required | Name of the UDF. |
| `ServiceId` | `Guid` | Required | ID of the attached service. |
| `Status` | [`Status3`](../../doc/models/status-3.md) | Required | Current attachment lifecycle state. |
| `Version` | `int` | Required | Attached UDF version.<br><br>**Constraints**: `>= 1` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

UdfAttachment udfAttachment = new UdfAttachment
{
    FunctionName = "functionName8",
    ServiceId = new Guid("000016ec-0000-0000-0000-000000000000"),
    Status = Status3.Standby,
    Version = 1,
};
```

