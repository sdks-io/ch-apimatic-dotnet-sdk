
# Postgres Configuration Work Mem

## Class Name

`PostgresConfigurationWorkMem`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationWorkMem.FromString(string mString) |
| `int` | PostgresConfigurationWorkMem.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationWorkMem value = PostgresConfigurationWorkMem.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationWorkMem value = PostgresConfigurationWorkMem.FromNumber(64);
```

