
# Udf Version List Response

## Structure

`UdfVersionListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<Udf>`](../../doc/models/udf.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;
using System.Globalization;

UdfVersionListResponse udfVersionListResponse = new UdfVersionListResponse
{
    Items = new List<Udf>
    {
        new Udf
        {
            FunctionName = "functionName4",
            Version = 1,
            Status = Status4.Error,
            Runtime = Runtime4.EnumPython311,
            Type = Type22.Executable,
            Arguments = new List<UdfArgumentOutput>
            {
                new UdfArgumentOutput
                {
                    Name = "name8",
                    Type = "type2",
                },
            },
            ReturnType = "returnType4",
            ReturnName = UdfReturnName.FromString("String1"),
            PoolSize = UdfPoolSize.FromNumber(92),
            CommandReadTimeout = 86,
            CommandWriteTimeout = 32,
            MaxCommandExecutionTime = UdfMaxCommandExecutionTime.FromNumber(238),
            MemoryLimitMib = null,
            SendChunkHeader = false,
            Deterministic = false,
            Format = "format6",
            SandboxType = SandboxType4.Basic,
            SandboxVersion = SandboxVersion4.V2,
            Error = UdfError.FromString("String3"),
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
    Pagination = new Pagination
    {
        TotalRecords = 72,
        CurrentCursor = PaginationCurrentCursor.FromString("String5"),
        NextCursor = PaginationNextCursor.FromString("String1"),
        Limit = 80,
    },
};
```

