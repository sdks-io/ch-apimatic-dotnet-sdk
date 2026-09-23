
# Postgres Configuration Lock Timeout

## Class Name

`PostgresConfigurationLockTimeout`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationLockTimeout.FromString(string mString) |
| `int` | PostgresConfigurationLockTimeout.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationLockTimeout value = PostgresConfigurationLockTimeout.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationLockTimeout value = PostgresConfigurationLockTimeout.FromNumber(0);
```

