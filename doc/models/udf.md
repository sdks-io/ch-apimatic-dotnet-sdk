
# Udf

## Structure

`Udf`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FunctionName` | `string` | Required | Name of the UDF. Unique within the organization. |
| `Version` | `int` | Required | Version number of the UDF.<br><br>**Constraints**: `>= 1` |
| `Status` | [`Status4`](../../doc/models/status-4.md) | Required | Build state of this UDF version. |
| `Runtime` | [`Runtime4`](../../doc/models/runtime-4.md) | Required | Runtime used to execute the UDF command. |
| `Type` | [`Type22`](../../doc/models/type-22.md) | Required | Executable UDF type. |
| `Arguments` | [`List<UdfArgumentOutput>`](../../doc/models/udf-argument-output.md) | Required | Arguments passed to the UDF command. |
| `ReturnType` | `string` | Required | ClickHouse data type of the returned value. |
| `ReturnName` | [`UdfReturnName`](../../doc/models/containers/udf-return-name.md) | Required | This is a container for any-of cases. |
| `PoolSize` | [`UdfPoolSize`](../../doc/models/containers/udf-pool-size.md) | Required | This is a container for any-of cases. |
| `CommandReadTimeout` | `int` | Required | Command stdout read timeout in milliseconds.<br><br>**Constraints**: `>= 1` |
| `CommandWriteTimeout` | `int` | Required | Command stdin write timeout in milliseconds.<br><br>**Constraints**: `>= 1` |
| `MaxCommandExecutionTime` | [`UdfMaxCommandExecutionTime`](../../doc/models/containers/udf-max-command-execution-time.md) | Required | This is a container for any-of cases. |
| `MemoryLimitMib` | [`UdfMemoryLimitMib`](../../doc/models/containers/udf-memory-limit-mib.md) | Required | This is a container for any-of cases. |
| `SendChunkHeader` | `bool` | Required | Whether ClickHouse sends a row-count chunk header. |
| `Deterministic` | `bool` | Required | Whether ClickHouse may reuse cached query results for this UDF. |
| `Format` | `string` | Required | Input and output format used by the UDF command. |
| `SandboxType` | [`SandboxType4`](../../doc/models/sandbox-type-4.md) | Required | Sandbox isolation level. |
| `SandboxVersion` | [`SandboxVersion4`](../../doc/models/sandbox-version-4.md) | Required | Sandbox runtime version. |
| `Error` | [`UdfError`](../../doc/models/containers/udf-error.md) | Required | This is a container for any-of cases. |
| `CreatedAt` | `DateTime` | Required | Creation timestamp. |
| `UpdatedAt` | `DateTime` | Required | Last-update timestamp. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using System.Collections.Generic;
using System.Globalization;

Udf udf = new Udf
{
    FunctionName = "functionName2",
    Version = 1,
    Status = Status4.Ready,
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
    ReturnType = "returnType2",
    ReturnName = UdfReturnName.FromString("String7"),
    PoolSize = UdfPoolSize.FromNumber(222),
    CommandReadTimeout = 216,
    CommandWriteTimeout = 162,
    MaxCommandExecutionTime = UdfMaxCommandExecutionTime.FromNumber(112),
    MemoryLimitMib = null,
    SendChunkHeader = false,
    Deterministic = false,
    Format = "format0",
    SandboxType = SandboxType4.Basic,
    SandboxVersion = SandboxVersion4.V3,
    Error = UdfError.FromString("String9"),
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

