
# Postgres Configuration Max Connections

## Class Name

`PostgresConfigurationMaxConnections`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationMaxConnections.FromString(string mString) |
| `int` | PostgresConfigurationMaxConnections.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationMaxConnections value = PostgresConfigurationMaxConnections.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationMaxConnections value = PostgresConfigurationMaxConnections.FromNumber(1);
```

