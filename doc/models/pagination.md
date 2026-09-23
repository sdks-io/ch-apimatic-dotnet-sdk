
# Pagination

## Structure

`Pagination`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalRecords` | `int` | Required | Total number of records available. |
| `CurrentCursor` | [`PaginationCurrentCursor`](../../doc/models/containers/pagination-current-cursor.md) | Required | This is a container for any-of cases. |
| `NextCursor` | [`PaginationNextCursor`](../../doc/models/containers/pagination-next-cursor.md) | Required | This is a container for any-of cases. |
| `Limit` | `int` | Required | Maximum number of records returned per page. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;

Pagination pagination = new Pagination
{
    TotalRecords = 72,
    CurrentCursor = PaginationCurrentCursor.FromString("String5"),
    NextCursor = PaginationNextCursor.FromString("String1"),
    Limit = 80,
};
```

