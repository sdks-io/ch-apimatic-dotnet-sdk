
# V1 Organizations Udfs Response

## Structure

`V1OrganizationsUdfsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `int` | Required | HTTP status code. |
| `RequestId` | `Guid` | Required | Unique id assigned to every request. UUIDv4 |
| `Result` | [`Udf`](../../doc/models/udf.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsUdfsResponse v1OrganizationsUdfsResponse = new V1OrganizationsUdfsResponse
{
    Status = 201,
    RequestId = new Guid("00001130-0000-0000-0000-000000000000"),
    Result = new Udf
    {
        FunctionName = "functionName4",
        Version = 1,
        Status = Status4.Building,
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
        ReturnName = UdfReturnName.FromString("String9"),
        PoolSize = UdfPoolSize.FromNumber(34),
        CommandReadTimeout = 28,
        CommandWriteTimeout = 230,
        MaxCommandExecutionTime = UdfMaxCommandExecutionTime.FromNumber(180),
        MemoryLimitMib = null,
        SendChunkHeader = false,
        Deterministic = false,
        Format = "format2",
        SandboxType = SandboxType4.Basic,
        SandboxVersion = SandboxVersion4.V1,
        Error = UdfError.FromString("String1"),
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

