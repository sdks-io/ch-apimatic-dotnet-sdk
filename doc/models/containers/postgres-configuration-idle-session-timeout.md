
# Postgres Configuration Idle Session Timeout

## Class Name

`PostgresConfigurationIdleSessionTimeout`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationIdleSessionTimeout.FromString(string mString) |
| `int` | PostgresConfigurationIdleSessionTimeout.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationIdleSessionTimeout value = PostgresConfigurationIdleSessionTimeout.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationIdleSessionTimeout value = PostgresConfigurationIdleSessionTimeout.FromNumber(0);
```

