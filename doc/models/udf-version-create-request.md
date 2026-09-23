
# Udf Version Create Request

*This model accepts additional fields of type object.*

## Structure

`UdfVersionCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UploadId` | `Guid` | Required | Identifier of the uploaded source archive. |
| `Runtime` | [`Runtime`](../../doc/models/runtime.md) | Required | - |
| `Arguments` | [`List<UdfArgument>`](../../doc/models/udf-argument.md) | Required | - |
| `ReturnType` | `string` | Required | - |
| `ReturnName` | [`UdfVersionCreateRequestReturnName`](../../doc/models/containers/udf-version-create-request-return-name.md) | Optional | This is a container for any-of cases. |
| `CommandReadTimeout` | `int?` | Optional | **Default**: `10000`<br><br>**Constraints**: `>= 1` |
| `CommandWriteTimeout` | `int?` | Optional | **Default**: `10000`<br><br>**Constraints**: `>= 1` |
| `MemoryLimitMib` | [`UdfVersionCreateRequestMemoryLimitMib`](../../doc/models/containers/udf-version-create-request-memory-limit-mib.md) | Optional | This is a container for any-of cases. |
| `SendChunkHeader` | `bool?` | Optional | **Default**: `false` |
| `Deterministic` | `bool?` | Optional | Marks the UDF as deterministic so ClickHouse can reuse cached query results. Only set this when the UDF always returns the same result for the same arguments.<br><br>**Default**: `false` |
| `Format` | `string` | Optional | **Default**: `"TabSeparated"` |
| `SandboxType` | [`SandboxType?`](../../doc/models/sandbox-type.md) | Optional | **Default**: `SandboxType.basic` |
| `SandboxVersion` | [`SandboxVersion?`](../../doc/models/sandbox-version.md) | Optional | **Default**: `SandboxVersion.v2` |
| `Type` | `string` | Required, Constant | **Value**: `"executable"` |
| `PoolSize` | `string` | Optional | Always null — an executable UDF has no command pool. |
| `MaxCommandExecutionTime` | [`UdfVersionCreateRequestMaxCommandExecutionTime`](../../doc/models/containers/udf-version-create-request-max-command-execution-time.md) | Optional | This is a container for any-of cases. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

UdfVersionCreateRequest udfVersionCreateRequest = new UdfVersionCreateRequest
{
    UploadId = new Guid("00000e6c-0000-0000-0000-000000000000"),
    Runtime = Runtime.EnumPython311,
    Arguments = new List<UdfArgument>
    {
        new UdfArgument
        {
            Name = "name8",
            Type = "type2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ReturnType = "returnType6",
    Type = "executable",
    ReturnName = UdfVersionCreateRequestReturnName.FromString("String1"),
    CommandReadTimeout = 10000,
    CommandWriteTimeout = 10000,
    MemoryLimitMib = UdfVersionCreateRequestMemoryLimitMib.FromNumber(232),
    SendChunkHeader = false,
    Deterministic = false,
    Format = "TabSeparated",
    SandboxType = SandboxType.Basic,
    SandboxVersion = SandboxVersion.V2,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

