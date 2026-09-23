
# Udf Version Create Request 2

## Class Name

`UdfVersionCreateRequest2`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`UdfVersionCreateRequest`](../../../doc/models/udf-version-create-request.md) | UdfVersionCreateRequest2.FromUdfVersionCreateRequest(UdfVersionCreateRequest udfVersionCreateRequest) |
| [`UdfVersionCreateRequest1`](../../../doc/models/udf-version-create-request-1.md) | UdfVersionCreateRequest2.FromUdfVersionCreateRequest1(UdfVersionCreateRequest1 udfVersionCreateRequest1) |

## UdfVersionCreateRequest

### Initialization Code

#### Example

```csharp
UdfVersionCreateRequest2 value = UdfVersionCreateRequest2.FromUdfVersionCreateRequest(
    new UdfVersionCreateRequest
    {
        UploadId = new Guid("0000139a-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType6",
        Type = "executable",
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

## UdfVersionCreateRequest1

### Initialization Code

#### Example

```csharp
UdfVersionCreateRequest2 value = UdfVersionCreateRequest2.FromUdfVersionCreateRequest1(
    new UdfVersionCreateRequest1
    {
        UploadId = new Guid("000001be-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType8",
        Type = "executable_pool",
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

