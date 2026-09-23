
# Udf Version Create Request 1

*This model accepts additional fields of type object.*

## Structure

`UdfVersionCreateRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UploadId` | `Guid` | Required | Identifier of the uploaded source archive. |
| `Runtime` | [`Runtime`](../../doc/models/runtime.md) | Required | - |
| `Arguments` | [`List<UdfArgument>`](../../doc/models/udf-argument.md) | Required | - |
| `ReturnType` | `string` | Required | - |
| `ReturnName` | [`UdfVersionCreateRequest1ReturnName`](../../doc/models/containers/udf-version-create-request-1-return-name.md) | Optional | This is a container for any-of cases. |
| `CommandReadTimeout` | `int?` | Optional | **Default**: `10000`<br><br>**Constraints**: `>= 1` |
| `CommandWriteTimeout` | `int?` | Optional | **Default**: `10000`<br><br>**Constraints**: `>= 1` |
| `MemoryLimitMib` | [`UdfVersionCreateRequest1MemoryLimitMib`](../../doc/models/containers/udf-version-create-request-1-memory-limit-mib.md) | Optional | This is a container for any-of cases. |
| `SendChunkHeader` | `bool?` | Optional | **Default**: `false` |
| `Deterministic` | `bool?` | Optional | Marks the UDF as deterministic so ClickHouse can reuse cached query results. Only set this when the UDF always returns the same result for the same arguments.<br><br>**Default**: `false` |
| `Format` | `string` | Optional | **Default**: `"TabSeparated"` |
| `SandboxType` | [`SandboxType?`](../../doc/models/sandbox-type.md) | Optional | **Default**: `SandboxType.basic` |
| `SandboxVersion` | [`SandboxVersion?`](../../doc/models/sandbox-version.md) | Optional | **Default**: `SandboxVersion.v2` |
| `Type` | `string` | Required, Constant | **Value**: `"executable_pool"` |
| `PoolSize` | `int?` | Optional | **Default**: `3`<br><br>**Constraints**: `>= 1` |
| `MaxCommandExecutionTime` | `int?` | Optional | **Default**: `10`<br><br>**Constraints**: `>= 1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

UdfVersionCreateRequest1 udfVersionCreateRequest1 = new UdfVersionCreateRequest1
{
    UploadId = new Guid("000000ae-0000-0000-0000-000000000000"),
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
    ReturnType = "returnType4",
    Type = "executable_pool",
    ReturnName = UdfVersionCreateRequest1ReturnName.FromString("String9"),
    CommandReadTimeout = 10000,
    CommandWriteTimeout = 10000,
    MemoryLimitMib = UdfVersionCreateRequest1MemoryLimitMib.FromNumber(182),
    SendChunkHeader = false,
    Deterministic = false,
    Format = "TabSeparated",
    SandboxType = SandboxType.Basic,
    SandboxVersion = SandboxVersion.V2,
    PoolSize = 3,
    MaxCommandExecutionTime = 10,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

