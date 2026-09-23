
# Udf Argument Output

## Structure

`UdfArgumentOutput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the argument. Required for Native and JSONEachRow formats.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `Type` | `string` | Required | ClickHouse data type of the argument. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

UdfArgumentOutput udfArgumentOutput = new UdfArgumentOutput
{
    Name = "name8",
    Type = "type2",
};
```

