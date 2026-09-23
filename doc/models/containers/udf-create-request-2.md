
# Udf Create Request 2

## Class Name

`UdfCreateRequest2`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`UdfCreateRequest`](../../../doc/models/udf-create-request.md) | UdfCreateRequest2.FromUdfCreateRequest(UdfCreateRequest udfCreateRequest) |
| [`UdfCreateRequest1`](../../../doc/models/udf-create-request-1.md) | UdfCreateRequest2.FromUdfCreateRequest1(UdfCreateRequest1 udfCreateRequest1) |

## UdfCreateRequest

### Initialization Code

#### Example

```csharp
UdfCreateRequest2 value = UdfCreateRequest2.FromUdfCreateRequest(
    new UdfCreateRequest
    {
        UploadId = new Guid("000017c4-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType2",
        Type = "executable",
        FunctionName = "functionName2",
        CommandReadTimeout = 10000,
        CommandWriteTimeout = 10000,
        SendChunkHeader = false,
        Deterministic = false,
        Format = "TabSeparated",
        SandboxType = SandboxType.Basic,
        SandboxVersion = SandboxVersion.V2,
    }
);
```

## UdfCreateRequest1

### Initialization Code

#### Example

```csharp
UdfCreateRequest2 value = UdfCreateRequest2.FromUdfCreateRequest1(
    new UdfCreateRequest1
    {
        UploadId = new Guid("00000046-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType2",
        Type = "executable_pool",
        FunctionName = "functionName2",
        CommandReadTimeout = 10000,
        CommandWriteTimeout = 10000,
        SendChunkHeader = false,
        Deterministic = false,
        Format = "TabSeparated",
        SandboxType = SandboxType.Basic,
        SandboxVersion = SandboxVersion.V2,
        PoolSize = 3,
        MaxCommandExecutionTime = 10,
    }
);
```

