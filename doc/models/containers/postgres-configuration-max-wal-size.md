
# Postgres Configuration Max Wal Size

## Class Name

`PostgresConfigurationMaxWalSize`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationMaxWalSize.FromString(string mString) |
| `int` | PostgresConfigurationMaxWalSize.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationMaxWalSize value = PostgresConfigurationMaxWalSize.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationMaxWalSize value = PostgresConfigurationMaxWalSize.FromNumber(32768);
```

